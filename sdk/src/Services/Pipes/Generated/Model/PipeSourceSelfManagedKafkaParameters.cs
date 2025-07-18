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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a self-managed Apache Kafka stream as a source.
    /// 
    ///  
    /// <para>
    /// A <i>self managed</i> cluster refers to any Apache Kafka cluster not hosted by Amazon
    /// Web Services. This includes both clusters you manage yourself, as well as those hosted
    /// by a third-party provider, such as <a href="https://www.confluent.io/">Confluent Cloud</a>,
    /// <a href="https://www.cloudkarafka.com/">CloudKarafka</a>, or <a href="https://redpanda.com/">Redpanda</a>.
    /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-kafka.html">Apache
    /// Kafka streams as a source</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PipeSourceSelfManagedKafkaParameters
    {
        private List<string> _additionalBootstrapServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _batchSize;
        private string _consumerGroupID;
        private SelfManagedKafkaAccessConfigurationCredentials _credentials;
        private int? _maximumBatchingWindowInSeconds;
        private string _serverRootCaCertificate;
        private SelfManagedKafkaStartPosition _startingPosition;
        private string _topicName;
        private SelfManagedKafkaAccessConfigurationVpc _vpc;

        /// <summary>
        /// Gets and sets the property AdditionalBootstrapServers. 
        /// <para>
        /// An array of server URLs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> AdditionalBootstrapServers
        {
            get { return this._additionalBootstrapServers; }
            set { this._additionalBootstrapServers = value; }
        }

        // Check to see if AdditionalBootstrapServers property is set
        internal bool IsSetAdditionalBootstrapServers()
        {
            return this._additionalBootstrapServers != null && (this._additionalBootstrapServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of records to include in each batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? BatchSize
        {
            get { return this._batchSize; }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumerGroupID. 
        /// <para>
        /// The name of the destination queue to consume.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string ConsumerGroupID
        {
            get { return this._consumerGroupID; }
            set { this._consumerGroupID = value; }
        }

        // Check to see if ConsumerGroupID property is set
        internal bool IsSetConsumerGroupID()
        {
            return this._consumerGroupID != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials needed to access the resource.
        /// </para>
        /// </summary>
        public SelfManagedKafkaAccessConfigurationCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// The maximum length of a time to wait for events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int? MaximumBatchingWindowInSeconds
        {
            get { return this._maximumBatchingWindowInSeconds; }
            set { this._maximumBatchingWindowInSeconds = value; }
        }

        // Check to see if MaximumBatchingWindowInSeconds property is set
        internal bool IsSetMaximumBatchingWindowInSeconds()
        {
            return this._maximumBatchingWindowInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerRootCaCertificate. 
        /// <para>
        /// The ARN of the Secrets Manager secret used for certification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ServerRootCaCertificate
        {
            get { return this._serverRootCaCertificate; }
            set { this._serverRootCaCertificate = value; }
        }

        // Check to see if ServerRootCaCertificate property is set
        internal bool IsSetServerRootCaCertificate()
        {
            return this._serverRootCaCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The position in a stream from which to start reading.
        /// </para>
        /// </summary>
        public SelfManagedKafkaStartPosition StartingPosition
        {
            get { return this._startingPosition; }
            set { this._startingPosition = value; }
        }

        // Check to see if StartingPosition property is set
        internal bool IsSetStartingPosition()
        {
            return this._startingPosition != null;
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of the topic that the pipe will read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=249)]
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// This structure specifies the VPC subnets and security groups for the stream, and whether
        /// a public IP address is to be used.
        /// </para>
        /// </summary>
        public SelfManagedKafkaAccessConfigurationVpc Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}