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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the ListConfiguredModelAlgorithms operation.
    /// </summary>
    public partial class ListConfiguredModelAlgorithmsResponse : AmazonWebServiceResponse
    {
        private List<ConfiguredModelAlgorithmSummary> _configuredModelAlgorithms = AWSConfigs.InitializeCollections ? new List<ConfiguredModelAlgorithmSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithms. 
        /// <para>
        /// The list of configured model algorithms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConfiguredModelAlgorithmSummary> ConfiguredModelAlgorithms
        {
            get { return this._configuredModelAlgorithms; }
            set { this._configuredModelAlgorithms = value; }
        }

        // Check to see if ConfiguredModelAlgorithms property is set
        internal bool IsSetConfiguredModelAlgorithms()
        {
            return this._configuredModelAlgorithms != null && (this._configuredModelAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token value used to access the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}