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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFeatureGroup operation.
    /// Create a new <c>FeatureGroup</c>. A <c>FeatureGroup</c> is a group of <c>Features</c>
    /// defined in the <c>FeatureStore</c> to describe a <c>Record</c>. 
    /// 
    ///  
    /// <para>
    /// The <c>FeatureGroup</c> defines the schema and features contained in the <c>FeatureGroup</c>.
    /// A <c>FeatureGroup</c> definition is composed of a list of <c>Features</c>, a <c>RecordIdentifierFeatureName</c>,
    /// an <c>EventTimeFeatureName</c> and configurations for its <c>OnlineStore</c> and <c>OfflineStore</c>.
    /// Check <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
    /// Web Services service quotas</a> to see the <c>FeatureGroup</c>s quota for your Amazon
    /// Web Services account.
    /// </para>
    ///  
    /// <para>
    /// Note that it can take approximately 10-15 minutes to provision an <c>OnlineStore</c>
    /// <c>FeatureGroup</c> with the <c>InMemory</c> <c>StorageType</c>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must include at least one of <c>OnlineStoreConfig</c> and <c>OfflineStoreConfig</c>
    /// to create a <c>FeatureGroup</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateFeatureGroupRequest : AmazonSageMakerRequest
    {
        private string _description;
        private string _eventTimeFeatureName;
        private List<FeatureDefinition> _featureDefinitions = AWSConfigs.InitializeCollections ? new List<FeatureDefinition>() : null;
        private string _featureGroupName;
        private OfflineStoreConfig _offlineStoreConfig;
        private OnlineStoreConfig _onlineStoreConfig;
        private string _recordIdentifierFeatureName;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ThroughputConfig _throughputConfig;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A free-form description of a <c>FeatureGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventTimeFeatureName. 
        /// <para>
        /// The name of the feature that stores the <c>EventTime</c> of a <c>Record</c> in a <c>FeatureGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// An <c>EventTime</c> is a point in time when a new event occurs that corresponds to
        /// the creation or update of a <c>Record</c> in a <c>FeatureGroup</c>. All <c>Records</c>
        /// in the <c>FeatureGroup</c> must have a corresponding <c>EventTime</c>.
        /// </para>
        ///  
        /// <para>
        /// An <c>EventTime</c> can be a <c>String</c> or <c>Fractional</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Fractional</c>: <c>EventTime</c> feature values must be a Unix timestamp in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>String</c>: <c>EventTime</c> feature values must be an ISO-8601 string in the
        /// format. The following formats are supported <c>yyyy-MM-dd'T'HH:mm:ssZ</c> and <c>yyyy-MM-dd'T'HH:mm:ss.SSSZ</c>
        /// where <c>yyyy</c>, <c>MM</c>, and <c>dd</c> represent the year, month, and day respectively
        /// and <c>HH</c>, <c>mm</c>, <c>ss</c>, and if applicable, <c>SSS</c> represent the hour,
        /// month, second and milliseconds respsectively. <c>'T'</c> and <c>Z</c> are constants.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventTimeFeatureName
        {
            get { return this._eventTimeFeatureName; }
            set { this._eventTimeFeatureName = value; }
        }

        // Check to see if EventTimeFeatureName property is set
        internal bool IsSetEventTimeFeatureName()
        {
            return this._eventTimeFeatureName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureDefinitions. 
        /// <para>
        /// A list of <c>Feature</c> names and types. <c>Name</c> and <c>Type</c> is compulsory
        /// per <c>Feature</c>. 
        /// </para>
        ///  
        /// <para>
        /// Valid feature <c>FeatureType</c>s are <c>Integral</c>, <c>Fractional</c> and <c>String</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>FeatureName</c>s cannot be any of the following: <c>is_deleted</c>, <c>write_time</c>,
        /// <c>api_invocation_time</c> 
        /// </para>
        ///  
        /// <para>
        /// You can create up to 2,500 <c>FeatureDefinition</c>s per <c>FeatureGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2500)]
        public List<FeatureDefinition> FeatureDefinitions
        {
            get { return this._featureDefinitions; }
            set { this._featureDefinitions = value; }
        }

        // Check to see if FeatureDefinitions property is set
        internal bool IsSetFeatureDefinitions()
        {
            return this._featureDefinitions != null && (this._featureDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the <c>FeatureGroup</c>. The name must be unique within an Amazon Web
        /// Services Region in an Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// The name:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start with an alphanumeric character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can only include alphanumeric characters, underscores, and hyphens. Spaces are not
        /// allowed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property OfflineStoreConfig. 
        /// <para>
        /// Use this to configure an <c>OfflineFeatureStore</c>. This parameter allows you to
        /// specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) location of an <c>OfflineStore</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A configuration for an Amazon Web Services Glue or Amazon Web Services Hive data catalog.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An KMS encryption key to encrypt the Amazon S3 location used for <c>OfflineStore</c>.
        /// If KMS encryption key is not specified, by default we encrypt all data at rest using
        /// Amazon Web Services KMS key. By defining your <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucket-key.html">bucket-level
        /// key</a> for SSE, you can reduce Amazon Web Services KMS requests costs by up to 99
        /// percent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Format for the offline store table. Supported formats are Glue (Default) and <a href="https://iceberg.apache.org/">Apache
        /// Iceberg</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn more about this parameter, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OfflineStoreConfig.html">OfflineStoreConfig</a>.
        /// </para>
        /// </summary>
        public OfflineStoreConfig OfflineStoreConfig
        {
            get { return this._offlineStoreConfig; }
            set { this._offlineStoreConfig = value; }
        }

        // Check to see if OfflineStoreConfig property is set
        internal bool IsSetOfflineStoreConfig()
        {
            return this._offlineStoreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineStoreConfig. 
        /// <para>
        /// You can turn the <c>OnlineStore</c> on or off by specifying <c>True</c> for the <c>EnableOnlineStore</c>
        /// flag in <c>OnlineStoreConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// You can also include an Amazon Web Services KMS key ID (<c>KMSKeyId</c>) for at-rest
        /// encryption of the <c>OnlineStore</c>.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>False</c>.
        /// </para>
        /// </summary>
        public OnlineStoreConfig OnlineStoreConfig
        {
            get { return this._onlineStoreConfig; }
            set { this._onlineStoreConfig = value; }
        }

        // Check to see if OnlineStoreConfig property is set
        internal bool IsSetOnlineStoreConfig()
        {
            return this._onlineStoreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RecordIdentifierFeatureName. 
        /// <para>
        /// The name of the <c>Feature</c> whose value uniquely identifies a <c>Record</c> defined
        /// in the <c>FeatureStore</c>. Only the latest record per identifier value will be stored
        /// in the <c>OnlineStore</c>. <c>RecordIdentifierFeatureName</c> must be one of feature
        /// definitions' names.
        /// </para>
        ///  
        /// <para>
        /// You use the <c>RecordIdentifierFeatureName</c> to access data in a <c>FeatureStore</c>.
        /// </para>
        ///  
        /// <para>
        /// This name:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start with an alphanumeric character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can only contains alphanumeric characters, hyphens, underscores. Spaces are not allowed.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RecordIdentifierFeatureName
        {
            get { return this._recordIdentifierFeatureName; }
            set { this._recordIdentifierFeatureName = value; }
        }

        // Check to see if RecordIdentifierFeatureName property is set
        internal bool IsSetRecordIdentifierFeatureName()
        {
            return this._recordIdentifierFeatureName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role used to persist data into
        /// the <c>OfflineStore</c> if an <c>OfflineStoreConfig</c> is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags used to identify <c>Features</c> in each <c>FeatureGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThroughputConfig.
        /// </summary>
        public ThroughputConfig ThroughputConfig
        {
            get { return this._throughputConfig; }
            set { this._throughputConfig = value; }
        }

        // Check to see if ThroughputConfig property is set
        internal bool IsSetThroughputConfig()
        {
            return this._throughputConfig != null;
        }

    }
}