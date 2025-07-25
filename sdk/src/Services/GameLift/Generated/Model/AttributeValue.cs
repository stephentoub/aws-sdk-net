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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Values for use in player attribute key-value pairs. This object lets you specify an
    /// attribute value using any of the valid data types: string, number, string array, or
    /// data map. Each <c>AttributeValue</c> object can use only one of the available properties.
    /// </summary>
    public partial class AttributeValue
    {
        private double? _n;
        private string _s;
        private Dictionary<string, double> _sdm = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private List<string> _sl = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property N. 
        /// <para>
        /// For number values, expressed as double.
        /// </para>
        /// </summary>
        public double? N
        {
            get { return this._n; }
            set { this._n = value; }
        }

        // Check to see if N property is set
        internal bool IsSetN()
        {
            return this._n.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S. 
        /// <para>
        /// For single string values. Maximum string length is 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string S
        {
            get { return this._s; }
            set { this._s = value; }
        }

        // Check to see if S property is set
        internal bool IsSetS()
        {
            return this._s != null;
        }

        /// <summary>
        /// Gets and sets the property SDM. 
        /// <para>
        /// For a map of up to 10 data type:value pairs. Maximum length for each string value
        /// is 100 characters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> SDM
        {
            get { return this._sdm; }
            set { this._sdm = value; }
        }

        // Check to see if SDM property is set
        internal bool IsSetSDM()
        {
            return this._sdm != null && (this._sdm.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SL. 
        /// <para>
        /// For a list of up to 100 strings. Maximum length for each string is 100 characters.
        /// Duplicate values are not recognized; all occurrences of the repeated value after the
        /// first of a repeated value are ignored.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SL
        {
            get { return this._sl; }
            set { this._sl = value; }
        }

        // Check to see if SL property is set
        internal bool IsSetSL()
        {
            return this._sl != null && (this._sl.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}