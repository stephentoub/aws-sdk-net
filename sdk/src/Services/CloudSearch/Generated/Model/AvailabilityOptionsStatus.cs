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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The status and configuration of the domain's availability options.
    /// </summary>
    public partial class AvailabilityOptionsStatus
    {
        private bool? _options;
        private OptionStatus _status;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The availability options configured for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required=true)]
        public OptionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}