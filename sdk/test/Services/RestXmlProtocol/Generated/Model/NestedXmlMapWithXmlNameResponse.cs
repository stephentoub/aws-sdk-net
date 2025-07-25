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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestXmlProtocol.Model
{
    /// <summary>
    /// This is the response object from the NestedXmlMapWithXmlName operation.
    /// </summary>
    public partial class NestedXmlMapWithXmlNameResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, Dictionary<string, string>> _nestedXmlMapWithXmlNameMap = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Gets and sets the property NestedXmlMapWithXmlNameMap.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> NestedXmlMapWithXmlNameMap
        {
            get { return this._nestedXmlMapWithXmlNameMap; }
            set { this._nestedXmlMapWithXmlNameMap = value; }
        }

        // Check to see if NestedXmlMapWithXmlNameMap property is set
        internal bool IsSetNestedXmlMapWithXmlNameMap()
        {
            return this._nestedXmlMapWithXmlNameMap != null && (this._nestedXmlMapWithXmlNameMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}