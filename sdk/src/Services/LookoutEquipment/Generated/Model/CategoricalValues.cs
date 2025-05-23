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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Entity that comprises information on categorical values in data.
    /// </summary>
    public partial class CategoricalValues
    {
        private int? _numberOfCategory;
        private StatisticalIssueStatus _status;

        /// <summary>
        /// Gets and sets the property NumberOfCategory. 
        /// <para>
        ///  Indicates the number of categories in the data. 
        /// </para>
        /// </summary>
        public int? NumberOfCategory
        {
            get { return this._numberOfCategory; }
            set { this._numberOfCategory = value; }
        }

        // Check to see if NumberOfCategory property is set
        internal bool IsSetNumberOfCategory()
        {
            return this._numberOfCategory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Indicates whether there is a potential data issue related to categorical values.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatisticalIssueStatus Status
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