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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// List of <c>Food</c> types offered by this result.
    /// </summary>
    public partial class FoodType
    {
        private string _id;
        private string _localizedName;
        private bool? _primary;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The Food Type Id.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LocalizedName. 
        /// <para>
        /// Localized name of the food type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
        public string LocalizedName
        {
            get { return this._localizedName; }
            set { this._localizedName = value; }
        }

        // Check to see if LocalizedName property is set
        internal bool IsSetLocalizedName()
        {
            return this._localizedName != null;
        }

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// Boolean which indicates if this food type is the primary offered by the place. For
        /// example, if a location serves fast food, but also dessert, he primary would likely
        /// be fast food.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary.HasValue; 
        }

    }
}