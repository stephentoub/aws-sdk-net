﻿/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using Amazon.Util.Internal;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// A wrapper stream that calculates a hash of the base stream as it
    /// is being read.
    /// The calculated hash is only available after the stream is closed or
    /// CalculateHash is called. After calling CalculateHash, any further reads
    /// on the streams will not change the CalculatedHash.
    /// If an ExpectedHash is specified and is not equal to the calculated hash,
    /// Close or CalculateHash methods will throw an AmazonClientException.
    /// If CalculatedHash is calculated for only the portion of the stream that
    /// is read.
    /// </summary>
    /// <exception cref="Amazon.Runtime.AmazonClientException">
    /// Exception thrown during Close() or CalculateHash(), if ExpectedHash is set and
    /// is different from CalculateHash that the stream calculates, provided that
    /// CalculatedHash is not a zero-length byte array.
    /// </exception>
    public abstract class HashStream : WrapperStream
    {
        #region Properties

        /// <summary>
        /// Algorithm to use to calculate hash.
        /// </summary>
        protected IHashingWrapper Algorithm { get; set; }

        /// <summary>
        /// True if hashing is finished and no more hashing should be done;
        /// otherwise false.
        /// </summary>
        protected bool FinishedHashing { get { return CalculatedHash != null; } }

        /// <summary>
        /// Current position in the stream.
        /// </summary>
        protected long CurrentPosition { get; private set; }

        /// <summary>
        /// Calculated hash for the stream.
        /// This value is set only after the stream is closed.
        /// </summary>
        public byte[] CalculatedHash { get; protected set; }

        /// <summary>
        /// Expected hash value. Compared against CalculatedHash upon Close().
        /// If the hashes are different, an AmazonClientException is thrown.
        /// </summary>
        public byte[] ExpectedHash { get; private set; }

        /// <summary>
        /// Expected length of stream.
        /// </summary>
        public long ExpectedLength { get; protected set; }

        #endregion

        #region Constructors

        ///// <summary>
        ///// Initializes an HashStream with a hash algorithm and a base stream.
        ///// </summary>
        ///// <param name="baseStream">Stream to calculate hash for.</param>
        //protected HashStream(Stream baseStream)
        //    : this(baseStream, null) { }

        /// <summary>
        /// Initializes an HashStream with a hash algorithm and a base stream.
        /// </summary>
        /// <param name="baseStream">Stream to calculate hash for.</param>
        /// <param name="expectedHash">
        /// Expected hash. Will be compared against calculated hash on stream close.
        /// Pass in null to disable check.
        /// </param>
        /// <param name="expectedLength">
        /// Expected length of the stream. If the reading stops before reaching this
        /// position, CalculatedHash will be set to empty array.
        /// </param>
        protected HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
            : base(baseStream)
        {
            ExpectedHash = expectedHash;
            ExpectedLength = expectedLength;
            ValidateBaseStream();
            Reset();
        }

        #endregion

        #region Stream overrides

        /// <summary>
        /// Reads a sequence of bytes from the current stream and advances the position
        /// within the stream by the number of bytes read.
        /// </summary>
        /// <param name="buffer">
        /// An array of bytes. When this method returns, the buffer contains the specified
        /// byte array with the values between offset and (offset + count - 1) replaced
        /// by the bytes read from the current source.
        /// </param>
        /// <param name="offset">
        /// The zero-based byte offset in buffer at which to begin storing the data read
        /// from the current stream.
        /// </param>
        /// <param name="count">
        /// The maximum number of bytes to be read from the current stream.
        /// </param>
        /// <returns>
        /// The total number of bytes read into the buffer. This can be less than the
        /// number of bytes requested if that many bytes are not currently available,
        /// or zero (0) if the end of the stream has been reached.
        /// </returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            int result = base.Read(buffer, offset, count);

            CurrentPosition += result;
            if (!FinishedHashing)
            {
                Algorithm.AppendBlock(buffer, offset, result);
            }

            // Calculate the hash if this was the final read
            if (result == 0)
            {
                CalculateHash();
            }
            return result;
        }

        /// <summary>
        /// Asynchronously reads a sequence of bytes from the current stream, advances
        /// the position within the stream by the number of bytes read, and monitors
        /// cancellation requests.
        /// </summary>
        /// <param name="buffer">
        /// An array of bytes. When this method returns, the buffer contains the specified
        /// byte array with the values between offset and (offset + count - 1) replaced
        /// by the bytes read from the current source.
        /// </param>
        /// <param name="offset">
        /// The zero-based byte offset in buffer at which to begin storing the data read
        /// from the current stream.
        /// </param>
        /// <param name="count">
        /// The maximum number of bytes to be read from the current stream.
        /// </param>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests. The default value is
        /// System.Threading.CancellationToken.None.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous read operation. The value of the TResult
        /// parameter contains the total number of bytes read into the buffer. This can be
        /// less than the number of bytes requested if that many bytes are not currently
        /// available, or zero (0) if the end of the stream has been reached.
        /// </returns>
        public async override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            int result = await base.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);

            CurrentPosition += result;
            if (!FinishedHashing)
            {
                Algorithm.AppendBlock(buffer, offset, result);
            }

            // Calculate the hash if this was the final read
            if (result == 0)
            {
                CalculateHash();
            }
            return result;
        }

#if !NETSTANDARD
        /// <summary>
        /// Closes the underlying stream and finishes calculating the hash.
        /// If an ExpectedHash is specified and is not equal to the calculated hash,
        /// this method will throw an AmazonClientException.
        /// </summary>
        /// <exception cref="Amazon.Runtime.AmazonClientException">
        /// If ExpectedHash is set and is different from CalculateHash that the stream calculates.
        /// </exception>
        public override void Close()
        {
            CalculateHash();
            base.Close();
        }
#endif

        protected override void Dispose(bool disposing)
        {
            try
            {
                CalculateHash();

                if (disposing && Algorithm != null)
                {
                    Algorithm.Dispose();
                    Algorithm = null;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// HashStream does not support seeking, this will always be false.
        /// </summary>
        public override bool CanSeek
        {
            get
            {
                // Restrict random access, as this will break hashing.
                return false;
            }
        }

        /// <summary>
        /// Gets or sets the position within the current stream.
        /// HashStream does not support seeking, attempting to set Position
        /// will throw NotSupportedException.
        /// </summary>
        public override long Position
        {
            get
            {
                throw new NotSupportedException("HashStream does not support seeking");
            }
            set
            {
                // Restrict random access, as this will break hashing.
                throw new NotSupportedException("HashStream does not support seeking");
            }
        }

        /// <summary>
        /// Sets the position within the current stream.
        /// HashStream does not support seeking, attempting to call Seek
        /// will throw NotSupportedException.
        /// </summary>
        /// <param name="offset">A byte offset relative to the origin parameter.</param>
        /// <param name="origin">
        /// A value of type System.IO.SeekOrigin indicating the reference point used
        /// to obtain the new position.</param>
        /// <returns>The new position within the current stream.</returns>
        public override long Seek(long offset, SeekOrigin origin)
        {
            // Restrict random access, as this will break hashing.
            throw new NotSupportedException("HashStream does not support seeking");
        }

        /// <summary>
        /// Gets the overridden length used to construct the HashStream
        /// </summary>
        public override long Length
        {
            get
            {
                return this.ExpectedLength;
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Calculates the hash for the stream so far and disables any further
        /// hashing.
        /// </summary>
        public virtual void CalculateHash()
        {
            if (!FinishedHashing)
            {
                if (ExpectedLength < 0 || CurrentPosition == ExpectedLength)
                {
                    CalculatedHash = Algorithm.AppendLastBlock(ArrayEx.Empty<byte>());
                }
                else
                    CalculatedHash = ArrayEx.Empty<byte>();

                if (CalculatedHash.Length > 0 && ExpectedHash != null && ExpectedHash.Length > 0)
                {
                    if (!CompareHashes(ExpectedHash, CalculatedHash))
                        throw new AmazonClientException("Expected hash not equal to calculated hash");
                }
            }
        }

        /// <summary>
        /// Resets the hash stream to starting state.
        /// Use this if the underlying stream has been modified and needs
        /// to be rehashed without reconstructing the hierarchy.
        /// </summary>
        public void Reset()
        {
            CurrentPosition = 0;
            CalculatedHash = null;
            if (Algorithm != null)
                Algorithm.Clear();
            var baseHashStream = BaseStream as HashStream;
            if (baseHashStream != null)
            {
                baseHashStream.Reset();
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Validates the underlying stream.
        /// </summary>
        private void ValidateBaseStream()
        {
            // Fast-fail on unusable streams
            if (!BaseStream.CanRead && !BaseStream.CanWrite)
                throw new InvalidDataException("HashStream does not support base streams that are not capable of reading or writing");
        }

        /// <summary>
        /// Compares two hashes (arrays of bytes).
        /// </summary>
        /// <param name="expected">Expected hash.</param>
        /// <param name="actual">Actual hash.</param>
        /// <returns>
        /// True if the hashes are identical; otherwise false.
        /// </returns>
        protected static bool CompareHashes(byte[] expected, byte[] actual)
        {
            if (ReferenceEquals(expected, actual))
                return true;

            if (expected == null || actual == null)
                return (expected == actual);

            if (expected.Length != actual.Length)
                return false;

            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                    return false;
            }

            return true;
        }

        #endregion
    }


    /// <summary>
    /// A wrapper stream that calculates a hash of the base stream as it
    /// is being read or written.
    /// The calculated hash is only available after the stream is closed or
    /// CalculateHash is called. After calling CalculateHash, any further reads
    /// on the streams will not change the CalculatedHash.
    /// If an ExpectedHash is specified and is not equal to the calculated hash,
    /// Close or CalculateHash methods will throw an AmazonClientException.
    /// If base stream's position is not 0 or HashOnReads is true and the entire stream is
    /// not read, the CalculatedHash will be set to an empty byte array and
    /// comparison to ExpectedHash will not be made.
    /// </summary>
    /// <exception cref="Amazon.Runtime.AmazonClientException">
    /// Exception thrown during Close() or CalculateHash(), if ExpectedHash is set and
    /// is different from CalculateHash that the stream calculates, provided that
    /// CalculatedHash is not a zero-length byte array.
    /// </exception>
    public class HashStream<T> : HashStream
        where T : IHashingWrapper, new()
    {
        #region Constructors

        /// <summary>
        /// Initializes an HashStream with a hash algorithm and a base stream.
        /// </summary>
        /// <param name="baseStream">Stream to calculate hash for.</param>
        /// <param name="expectedHash">
        /// Expected hash. Will be compared against calculated hash on stream close.
        /// Pass in null to disable check.
        /// </param>
        /// <param name="expectedLength">
        /// Expected length of the stream. If the reading stops before reaching this
        /// position, CalculatedHash will be set to empty array.
        /// </param>
        public HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
            : base(baseStream, expectedHash, expectedLength)
        {
            Algorithm = new T();
        }

        #endregion
    }

    /// <summary>
    /// A wrapper stream that calculates an MD5 hash of the base stream as it
    /// is being read or written.
    /// The calculated hash is only available after the stream is closed or
    /// CalculateHash is called. After calling CalculateHash, any further reads
    /// on the streams will not change the CalculatedHash.
    /// If an ExpectedHash is specified and is not equal to the calculated hash,
    /// Close or CalculateHash methods will throw an AmazonClientException.
    /// If base stream's position is not 0 or HashOnReads is true and the entire stream is
    /// not read, the CalculatedHash will be set to an empty byte array and
    /// comparison to ExpectedHash will not be made.
    /// </summary>
    /// <exception cref="Amazon.Runtime.AmazonClientException">
    /// Exception thrown during Close() or CalculateHash(), if ExpectedHash is set and
    /// is different from CalculateHash that the stream calculates, provided that
    /// CalculatedHash is not a zero-length byte array.
    /// </exception>
    public class MD5Stream : HashStream<HashingWrapperMD5>
    {
        private Logger _logger;

        #region Constructors

        /// <summary>
        /// Initializes an MD5Stream with a base stream.
        /// </summary>
        /// <param name="baseStream">Stream to calculate hash for.</param>
        /// <param name="expectedHash">
        /// Expected hash. Will be compared against calculated hash on stream close.
        /// Pass in null to disable check.
        /// </param>
        /// <param name="expectedLength">
        /// Expected length of the stream. If the reading stops before reaching this
        /// position, CalculatedHash will be set to empty array.
        /// </param>
        public MD5Stream(Stream baseStream, byte[] expectedHash, long expectedLength)
            : base(baseStream, expectedHash, expectedLength)
        {
            _logger = Logger.GetLogger(this.GetType());
        }
#endregion

    }
}
