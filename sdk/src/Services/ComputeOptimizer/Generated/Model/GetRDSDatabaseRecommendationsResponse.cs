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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the GetRDSDatabaseRecommendations operation.
    /// </summary>
    public partial class GetRDSDatabaseRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<GetRecommendationError> _errors = AWSConfigs.InitializeCollections ? new List<GetRecommendationError>() : null;
        private string _nextToken;
        private List<RDSDBRecommendation> _rdsdbRecommendations = AWSConfigs.InitializeCollections ? new List<RDSDBRecommendation>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        ///  An array of objects that describe errors of the request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GetRecommendationError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token to advance to the next page of Amazon Aurora and RDS database recommendations.
        /// 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RdsDBRecommendations. 
        /// <para>
        ///  An array of objects that describe the Amazon Aurora and RDS database recommendations.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RDSDBRecommendation> RdsDBRecommendations
        {
            get { return this._rdsdbRecommendations; }
            set { this._rdsdbRecommendations = value; }
        }

        // Check to see if RdsDBRecommendations property is set
        internal bool IsSetRdsDBRecommendations()
        {
            return this._rdsdbRecommendations != null && (this._rdsdbRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}