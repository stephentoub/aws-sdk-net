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
    /// Container for the parameters to the CreateHub operation.
    /// Create a hub.
    /// </summary>
    public partial class CreateHubRequest : AmazonSageMakerRequest
    {
        private string _hubDescription;
        private string _hubDisplayName;
        private string _hubName;
        private List<string> _hubSearchKeywords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private HubS3StorageConfig _s3StorageConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property HubDescription. 
        /// <para>
        /// A description of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1023)]
        public string HubDescription
        {
            get { return this._hubDescription; }
            set { this._hubDescription = value; }
        }

        // Check to see if HubDescription property is set
        internal bool IsSetHubDescription()
        {
            return this._hubDescription != null;
        }

        /// <summary>
        /// Gets and sets the property HubDisplayName. 
        /// <para>
        /// The display name of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string HubDisplayName
        {
            get { return this._hubDisplayName; }
            set { this._hubDisplayName = value; }
        }

        // Check to see if HubDisplayName property is set
        internal bool IsSetHubDisplayName()
        {
            return this._hubDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string HubName
        {
            get { return this._hubName; }
            set { this._hubName = value; }
        }

        // Check to see if HubName property is set
        internal bool IsSetHubName()
        {
            return this._hubName != null;
        }

        /// <summary>
        /// Gets and sets the property HubSearchKeywords. 
        /// <para>
        /// The searchable keywords for the hub.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> HubSearchKeywords
        {
            get { return this._hubSearchKeywords; }
            set { this._hubSearchKeywords = value; }
        }

        // Check to see if HubSearchKeywords property is set
        internal bool IsSetHubSearchKeywords()
        {
            return this._hubSearchKeywords != null && (this._hubSearchKeywords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3StorageConfig. 
        /// <para>
        /// The Amazon S3 storage configuration for the hub.
        /// </para>
        /// </summary>
        public HubS3StorageConfig S3StorageConfig
        {
            get { return this._s3StorageConfig; }
            set { this._s3StorageConfig = value; }
        }

        // Check to see if S3StorageConfig property is set
        internal bool IsSetS3StorageConfig()
        {
            return this._s3StorageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags to associate with the hub.
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

    }
}