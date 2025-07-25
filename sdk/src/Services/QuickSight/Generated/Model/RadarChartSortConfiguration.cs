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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The sort configuration of a <c>RadarChartVisual</c>.
    /// </summary>
    public partial class RadarChartSortConfiguration
    {
        private ItemsLimitConfiguration _categoryItemsLimit;
        private List<FieldSortOptions> _categorySort = AWSConfigs.InitializeCollections ? new List<FieldSortOptions>() : null;
        private ItemsLimitConfiguration _colorItemsLimit;
        private List<FieldSortOptions> _colorSort = AWSConfigs.InitializeCollections ? new List<FieldSortOptions>() : null;

        /// <summary>
        /// Gets and sets the property CategoryItemsLimit. 
        /// <para>
        /// The category items limit for a radar chart.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration CategoryItemsLimit
        {
            get { return this._categoryItemsLimit; }
            set { this._categoryItemsLimit = value; }
        }

        // Check to see if CategoryItemsLimit property is set
        internal bool IsSetCategoryItemsLimit()
        {
            return this._categoryItemsLimit != null;
        }

        /// <summary>
        /// Gets and sets the property CategorySort. 
        /// <para>
        /// The category sort options of a radar chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> CategorySort
        {
            get { return this._categorySort; }
            set { this._categorySort = value; }
        }

        // Check to see if CategorySort property is set
        internal bool IsSetCategorySort()
        {
            return this._categorySort != null && (this._categorySort.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ColorItemsLimit. 
        /// <para>
        /// The color items limit of a radar chart.
        /// </para>
        /// </summary>
        public ItemsLimitConfiguration ColorItemsLimit
        {
            get { return this._colorItemsLimit; }
            set { this._colorItemsLimit = value; }
        }

        // Check to see if ColorItemsLimit property is set
        internal bool IsSetColorItemsLimit()
        {
            return this._colorItemsLimit != null;
        }

        /// <summary>
        /// Gets and sets the property ColorSort. 
        /// <para>
        /// The color sort configuration of a radar chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldSortOptions> ColorSort
        {
            get { return this._colorSort; }
            set { this._colorSort = value; }
        }

        // Check to see if ColorSort property is set
        internal bool IsSetColorSort()
        {
            return this._colorSort != null && (this._colorSort.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}