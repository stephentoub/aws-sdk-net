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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines the parameters and conditions used to evaluate and filter security findings.
    /// </summary>
    public partial class Criteria
    {
        private OcsfFindingFilters _ocsfFindingCriteria;

        /// <summary>
        /// Gets and sets the property OcsfFindingCriteria. 
        /// <para>
        /// The filtering conditions that align with OCSF standards.
        /// </para>
        /// </summary>
        public OcsfFindingFilters OcsfFindingCriteria
        {
            get { return this._ocsfFindingCriteria; }
            set { this._ocsfFindingCriteria = value; }
        }

        // Check to see if OcsfFindingCriteria property is set
        internal bool IsSetOcsfFindingCriteria()
        {
            return this._ocsfFindingCriteria != null;
        }

    }
}