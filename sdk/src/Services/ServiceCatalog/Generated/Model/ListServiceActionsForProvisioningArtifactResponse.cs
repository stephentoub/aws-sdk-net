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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the ListServiceActionsForProvisioningArtifact operation.
    /// </summary>
    public partial class ListServiceActionsForProvisioningArtifactResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private List<ServiceActionSummary> _serviceActionSummaries = AWSConfigs.InitializeCollections ? new List<ServiceActionSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The page token to use to retrieve the next set of results. If there are no additional
        /// results, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2024)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceActionSummaries. 
        /// <para>
        /// An object containing information about the self-service actions associated with the
        /// provisioning artifact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceActionSummary> ServiceActionSummaries
        {
            get { return this._serviceActionSummaries; }
            set { this._serviceActionSummaries = value; }
        }

        // Check to see if ServiceActionSummaries property is set
        internal bool IsSetServiceActionSummaries()
        {
            return this._serviceActionSummaries != null && (this._serviceActionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}