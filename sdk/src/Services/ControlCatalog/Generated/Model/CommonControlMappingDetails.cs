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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A structure that contains details about a common control mapping. In particular, it
    /// returns the Amazon Resource Name (ARN) of the common control.
    /// </summary>
    public partial class CommonControlMappingDetails
    {
        private string _commonControlArn;

        /// <summary>
        /// Gets and sets the property CommonControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the common control in the mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=41, Max=2048)]
        public string CommonControlArn
        {
            get { return this._commonControlArn; }
            set { this._commonControlArn = value; }
        }

        // Check to see if CommonControlArn property is set
        internal bool IsSetCommonControlArn()
        {
            return this._commonControlArn != null;
        }

    }
}