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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// The identifer of the input routed from AWS IoT SiteWise.
    /// </summary>
    public partial class IotSiteWiseInputIdentifier
    {
        private IotSiteWiseAssetModelPropertyIdentifier _iotSiteWiseAssetModelPropertyIdentifier;

        /// <summary>
        /// Gets and sets the property IotSiteWiseAssetModelPropertyIdentifier. 
        /// <para>
        ///  The identifier of the AWS IoT SiteWise asset model property. 
        /// </para>
        /// </summary>
        public IotSiteWiseAssetModelPropertyIdentifier IotSiteWiseAssetModelPropertyIdentifier
        {
            get { return this._iotSiteWiseAssetModelPropertyIdentifier; }
            set { this._iotSiteWiseAssetModelPropertyIdentifier = value; }
        }

        // Check to see if IotSiteWiseAssetModelPropertyIdentifier property is set
        internal bool IsSetIotSiteWiseAssetModelPropertyIdentifier()
        {
            return this._iotSiteWiseAssetModelPropertyIdentifier != null;
        }

    }
}