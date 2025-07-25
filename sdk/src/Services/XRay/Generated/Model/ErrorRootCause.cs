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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// The root cause of a trace summary error.
    /// </summary>
    public partial class ErrorRootCause
    {
        private bool? _clientImpacting;
        private List<ErrorRootCauseService> _services = AWSConfigs.InitializeCollections ? new List<ErrorRootCauseService>() : null;

        /// <summary>
        /// Gets and sets the property ClientImpacting. 
        /// <para>
        /// A flag that denotes that the root cause impacts the trace client.
        /// </para>
        /// </summary>
        public bool? ClientImpacting
        {
            get { return this._clientImpacting; }
            set { this._clientImpacting = value; }
        }

        // Check to see if ClientImpacting property is set
        internal bool IsSetClientImpacting()
        {
            return this._clientImpacting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// A list of services corresponding to an error. A service identifies a segment and it
        /// contains a name, account ID, type, and inferred flag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorRootCauseService> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && (this._services.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}