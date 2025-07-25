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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the ListTapePools operation.
    /// </summary>
    public partial class ListTapePoolsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<PoolInfo> _poolInfos = AWSConfigs.InitializeCollections ? new List<PoolInfo>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A string that indicates the position at which to begin the returned list of tape pools.
        /// Use the marker in your next request to continue pagination of tape pools. If there
        /// are no more tape pools to list, this element does not appear in the response body.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PoolInfos. 
        /// <para>
        /// An array of <c>PoolInfo</c> objects, where each object describes a single custom tape
        /// pool. If there are no custom tape pools, the <c>PoolInfos</c> is an empty array. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PoolInfo> PoolInfos
        {
            get { return this._poolInfos; }
            set { this._poolInfos = value; }
        }

        // Check to see if PoolInfos property is set
        internal bool IsSetPoolInfos()
        {
            return this._poolInfos != null && (this._poolInfos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}