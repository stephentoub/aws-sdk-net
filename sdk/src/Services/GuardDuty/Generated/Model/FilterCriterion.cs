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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Represents a condition that when matched will be added to the response of the operation.
    /// Irrespective of using any filter criteria, an administrator account can view the scan
    /// entries for all of its member accounts. However, each member account can view the
    /// scan entries only for their own account.
    /// </summary>
    public partial class FilterCriterion
    {
        private CriterionKey _criterionKey;
        private FilterCondition _filterCondition;

        /// <summary>
        /// Gets and sets the property CriterionKey. 
        /// <para>
        /// An enum value representing possible scan properties to match with given scan entries.
        /// </para>
        /// </summary>
        public CriterionKey CriterionKey
        {
            get { return this._criterionKey; }
            set { this._criterionKey = value; }
        }

        // Check to see if CriterionKey property is set
        internal bool IsSetCriterionKey()
        {
            return this._criterionKey != null;
        }

        /// <summary>
        /// Gets and sets the property FilterCondition. 
        /// <para>
        /// Contains information about the condition.
        /// </para>
        /// </summary>
        public FilterCondition FilterCondition
        {
            get { return this._filterCondition; }
            set { this._filterCondition = value; }
        }

        // Check to see if FilterCondition property is set
        internal bool IsSetFilterCondition()
        {
            return this._filterCondition != null;
        }

    }
}