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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// The severity of a value of a dimension that contributed to an anomaly.
    /// </summary>
    public partial class DimensionValueContribution
    {
        private double? _contributionScore;
        private string _dimensionValue;

        /// <summary>
        /// Gets and sets the property ContributionScore. 
        /// <para>
        /// The severity score of the value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? ContributionScore
        {
            get { return this._contributionScore; }
            set { this._contributionScore = value; }
        }

        // Check to see if ContributionScore property is set
        internal bool IsSetContributionScore()
        {
            return this._contributionScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DimensionValue. 
        /// <para>
        /// The value of the dimension.
        /// </para>
        /// </summary>
        public string DimensionValue
        {
            get { return this._dimensionValue; }
            set { this._dimensionValue = value; }
        }

        // Check to see if DimensionValue property is set
        internal bool IsSetDimensionValue()
        {
            return this._dimensionValue != null;
        }

    }
}