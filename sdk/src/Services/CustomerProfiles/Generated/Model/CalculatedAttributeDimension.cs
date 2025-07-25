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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Object that segments on Customer Profile's Calculated Attributes.
    /// </summary>
    public partial class CalculatedAttributeDimension
    {
        private ConditionOverrides _conditionOverrides;
        private AttributeDimensionType _dimensionType;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConditionOverrides. 
        /// <para>
        /// Applies the given condition over the initial Calculated Attribute's definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ConditionOverrides ConditionOverrides
        {
            get { return this._conditionOverrides; }
            set { this._conditionOverrides = value; }
        }

        // Check to see if ConditionOverrides property is set
        internal bool IsSetConditionOverrides()
        {
            return this._conditionOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionType. 
        /// <para>
        /// The action to segment with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttributeDimensionType DimensionType
        {
            get { return this._dimensionType; }
            set { this._dimensionType = value; }
        }

        // Check to see if DimensionType property is set
        internal bool IsSetDimensionType()
        {
            return this._dimensionType != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values to apply the DimensionType with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}