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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteNetworkInsightsAnalysis operation.
    /// Deletes the specified network insights analysis.
    /// </summary>
    public partial class DeleteNetworkInsightsAnalysisRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _networkInsightsAnalysisId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAnalysisId. 
        /// <para>
        /// The ID of the network insights analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInsightsAnalysisId
        {
            get { return this._networkInsightsAnalysisId; }
            set { this._networkInsightsAnalysisId = value; }
        }

        // Check to see if NetworkInsightsAnalysisId property is set
        internal bool IsSetNetworkInsightsAnalysisId()
        {
            return this._networkInsightsAnalysisId != null;
        }

    }
}