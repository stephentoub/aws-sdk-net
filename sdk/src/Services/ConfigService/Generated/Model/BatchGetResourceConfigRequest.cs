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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetResourceConfig operation.
    /// Returns the <c>BaseConfigurationItem</c> for one or more requested resources. The
    /// operation also returns a list of resources that are not processed in the current request.
    /// If there are no unprocessed resources, the operation returns an empty unprocessedResourceKeys
    /// list. 
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// The API does not return results for deleted resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The API does not return any tags for the requested resources. This information is
    /// filtered out of the supplementaryConfiguration section of the API response.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class BatchGetResourceConfigRequest : AmazonConfigServiceRequest
    {
        private List<ResourceKey> _resourceKeys = AWSConfigs.InitializeCollections ? new List<ResourceKey>() : null;

        /// <summary>
        /// Gets and sets the property ResourceKeys. 
        /// <para>
        /// A list of resource keys to be processed with the current request. Each element in
        /// the list consists of the resource type and resource ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<ResourceKey> ResourceKeys
        {
            get { return this._resourceKeys; }
            set { this._resourceKeys = value; }
        }

        // Check to see if ResourceKeys property is set
        internal bool IsSetResourceKeys()
        {
            return this._resourceKeys != null && (this._resourceKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}