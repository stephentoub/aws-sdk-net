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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the ListQueries operation.
    /// </summary>
    public partial class ListQueriesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Query> _queries = AWSConfigs.InitializeCollections ? new List<Query>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
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

        /// <summary>
        /// Gets and sets the property Queries. 
        /// <para>
        /// Lists matching query results, and shows query ID, status, and creation time of each
        /// query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Query> Queries
        {
            get { return this._queries; }
            set { this._queries = value; }
        }

        // Check to see if Queries property is set
        internal bool IsSetQueries()
        {
            return this._queries != null && (this._queries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}