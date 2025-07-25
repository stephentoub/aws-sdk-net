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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the DescribeAssessmentTargets operation.
    /// </summary>
    public partial class DescribeAssessmentTargetsResponse : AmazonWebServiceResponse
    {
        private List<AssessmentTarget> _assessmentTargets = AWSConfigs.InitializeCollections ? new List<AssessmentTarget>() : null;
        private Dictionary<string, FailedItemDetails> _failedItems = AWSConfigs.InitializeCollections ? new Dictionary<string, FailedItemDetails>() : null;

        /// <summary>
        /// Gets and sets the property AssessmentTargets. 
        /// <para>
        /// Information about the assessment targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<AssessmentTarget> AssessmentTargets
        {
            get { return this._assessmentTargets; }
            set { this._assessmentTargets = value; }
        }

        // Check to see if AssessmentTargets property is set
        internal bool IsSetAssessmentTargets()
        {
            return this._assessmentTargets != null && (this._assessmentTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedItems. 
        /// <para>
        /// Assessment target details that cannot be described. An error code is provided for
        /// each failed item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, FailedItemDetails> FailedItems
        {
            get { return this._failedItems; }
            set { this._failedItems = value; }
        }

        // Check to see if FailedItems property is set
        internal bool IsSetFailedItems()
        {
            return this._failedItems != null && (this._failedItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}