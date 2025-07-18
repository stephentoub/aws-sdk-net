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

/*
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStream operation.
    /// Creates a Kinesis data stream. A stream captures and transports data records that
    /// are continuously emitted from different data sources or <i>producers</i>. Scale-out
    /// within a stream is explicitly supported by means of shards, which are uniquely identified
    /// groups of data records in a stream.
    /// 
    ///  
    /// <para>
    /// You can create your data stream using either on-demand or provisioned capacity mode.
    /// Data streams with an on-demand mode require no capacity planning and automatically
    /// scale to handle gigabytes of write and read throughput per minute. With the on-demand
    /// mode, Kinesis Data Streams automatically manages the shards in order to provide the
    /// necessary throughput. For the data streams with a provisioned mode, you must specify
    /// the number of shards for the data stream. Each shard can support reads up to five
    /// transactions per second, up to a maximum data read total of 2 MiB per second. Each
    /// shard can support writes up to 1,000 records per second, up to a maximum data write
    /// total of 1 MiB per second. If the amount of data input increases or decreases, you
    /// can add or remove shards.
    /// </para>
    ///  
    /// <para>
    /// The stream name identifies the stream. The name is scoped to the Amazon Web Services
    /// account used by the application. It is also scoped by Amazon Web Services Region.
    /// That is, two streams in two different accounts can have the same name, and two streams
    /// in the same account, but in two different Regions, can have the same name.
    /// </para>
    ///  
    /// <para>
    ///  <c>CreateStream</c> is an asynchronous operation. Upon receiving a <c>CreateStream</c>
    /// request, Kinesis Data Streams immediately returns and sets the stream status to <c>CREATING</c>.
    /// After the stream is created, Kinesis Data Streams sets the stream status to <c>ACTIVE</c>.
    /// You should perform read and write operations only on an <c>ACTIVE</c> stream. 
    /// </para>
    ///  
    /// <para>
    /// You receive a <c>LimitExceededException</c> when making a <c>CreateStream</c> request
    /// when you try to do one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Have more than five streams in the <c>CREATING</c> state at any point in time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create more shards than are authorized for your account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the default shard limit for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
    /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
    /// Amazon Web Services Support</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use <a>DescribeStreamSummary</a> to check the stream status, which is returned
    /// in <c>StreamStatus</c>.
    /// </para>
    ///  
    /// <para>
    ///  <a>CreateStream</a> has a limit of five transactions per second per account.
    /// </para>
    ///  
    /// <para>
    /// You can add tags to the stream when making a <c>CreateStream</c> request by setting
    /// the <c>Tags</c> parameter. If you pass the <c>Tags</c> parameter, in addition to having
    /// the <c>kinesis:CreateStream</c> permission, you must also have the <c>kinesis:AddTagsToStream</c>
    /// permission for the stream that will be created. The <c>kinesis:TagResource</c> permission
    /// won’t work to tag streams on creation. Tags will take effect from the <c>CREATING</c>
    /// status of the stream, but you can't make any updates to the tags until the stream
    /// is in <c>ACTIVE</c> state.
    /// </para>
    /// </summary>
    public partial class CreateStreamRequest : AmazonKinesisRequest
    {
        private int? _shardCount;
        private StreamModeDetails _streamModeDetails;
        private string _streamName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ShardCount. 
        /// <para>
        /// The number of shards that the stream will use. The throughput of the stream is a function
        /// of the number of shards; more shards are required for greater provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ShardCount
        {
            get { return this._shardCount; }
            set { this._shardCount = value; }
        }

        // Check to see if ShardCount property is set
        internal bool IsSetShardCount()
        {
            return this._shardCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamModeDetails. 
        /// <para>
        ///  Indicates the capacity mode of the data stream. Currently, in Kinesis Data Streams,
        /// you can choose between an <b>on-demand</b> capacity mode and a <b>provisioned</b>
        /// capacity mode for your data streams.
        /// </para>
        /// </summary>
        public StreamModeDetails StreamModeDetails
        {
            get { return this._streamModeDetails; }
            set { this._streamModeDetails = value; }
        }

        // Check to see if StreamModeDetails property is set
        internal bool IsSetStreamModeDetails()
        {
            return this._streamModeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// A name to identify the stream. The stream name is scoped to the Amazon Web Services
        /// account used by the application that creates the stream. It is also scoped by Amazon
        /// Web Services Region. That is, two streams in two different Amazon Web Services accounts
        /// can have the same name. Two streams in the same Amazon Web Services account but in
        /// two different Regions can also have the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of up to 50 key-value pairs to use to create the tags. A tag consists of a required
        /// key and an optional value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}