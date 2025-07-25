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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
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
namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// This is the response object from the GetBandwidthRateLimitSchedule operation.
    /// </summary>
    public partial class GetBandwidthRateLimitScheduleResponse : AmazonWebServiceResponse
    {
        private List<BandwidthRateLimitInterval> _bandwidthRateLimitIntervals = AWSConfigs.InitializeCollections ? new List<BandwidthRateLimitInterval>() : null;
        private string _gatewayArn;

        /// <summary>
        /// Gets and sets the property BandwidthRateLimitIntervals. 
        /// <para>
        /// An array containing bandwidth rate limit schedule intervals for a gateway. When no
        /// bandwidth rate limit intervals have been scheduled, the array is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<BandwidthRateLimitInterval> BandwidthRateLimitIntervals
        {
            get { return this._bandwidthRateLimitIntervals; }
            set { this._bandwidthRateLimitIntervals = value; }
        }

        // Check to see if BandwidthRateLimitIntervals property is set
        internal bool IsSetBandwidthRateLimitIntervals()
        {
            return this._bandwidthRateLimitIntervals != null && (this._bandwidthRateLimitIntervals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_BGW_ListGateways.html">
        /// <c>ListGateways</c> </a> operation to return a list of gateways for your account and
        /// Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

    }
}