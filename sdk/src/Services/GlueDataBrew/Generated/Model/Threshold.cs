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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// The threshold used with a non-aggregate check expression. The non-aggregate check
    /// expression will be applied to each row in a specific column. Then the threshold will
    /// be used to determine whether the validation succeeds.
    /// </summary>
    public partial class Threshold
    {
        private ThresholdType _type;
        private ThresholdUnit _unit;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of a threshold. Used for comparison of an actual count of rows that satisfy
        /// the rule to the threshold value.
        /// </para>
        /// </summary>
        public ThresholdType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Unit of threshold value. Can be either a COUNT or PERCENTAGE of the full sample size
        /// used for validation.
        /// </para>
        /// </summary>
        public ThresholdUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of a threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}