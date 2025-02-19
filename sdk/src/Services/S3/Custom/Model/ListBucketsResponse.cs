/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  ListBuckets response and response metadata.
    /// </summary>
    public class ListBucketsResponse : AmazonWebServiceResponse
    {
        private List<S3Bucket> buckets = AWSConfigs.InitializeCollections ? new List<S3Bucket>() : null;
        private Owner owner;
        private string continuationToken;
        private string _prefix;

        /// <summary>
        /// List of buckets.
        /// </summary>
        public List<S3Bucket> Buckets
        {
            get { return this.buckets; }
            set { this.buckets = value; }
        }

        // Check to see if Buckets property is set
        internal bool IsSetBuckets()
        {
            return this.buckets != null && (this.buckets.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Owner of the buckets.
        /// </summary>
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// <c>ContinuationToken</c> is included in the response when there are more buckets that can be listed with pagination. 
        /// The next <c>ListBuckets</c> request to Amazon S3 can be continued with this <c>ContinuationToken</c>. 
        /// <c>ContinuationToken</c> is obfuscated and is not a real bucket.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this.continuationToken; }
            set { this.continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this.continuationToken != null;
        }

        /// <summary>
        /// <para>If <c>Prefix</c> was sent with the request, it is included in the response.</para> <para>All bucket names in the response begin with the specified bucket name prefix.</para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }
    }
}
    
