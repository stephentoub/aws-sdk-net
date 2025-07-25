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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Thing group indexing configuration.
    /// </summary>
    public partial class ThingGroupIndexingConfiguration
    {
        private List<Field> _customFields = AWSConfigs.InitializeCollections ? new List<Field>() : null;
        private List<Field> _managedFields = AWSConfigs.InitializeCollections ? new List<Field>() : null;
        private ThingGroupIndexingMode _thingGroupIndexingMode;

        /// <summary>
        /// Gets and sets the property CustomFields. 
        /// <para>
        /// A list of thing group fields to index. This list cannot contain any managed fields.
        /// Use the GetIndexingConfiguration API to get a list of managed fields.
        /// </para>
        ///  
        /// <para>
        /// Contains custom field names and their data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Field> CustomFields
        {
            get { return this._customFields; }
            set { this._customFields = value; }
        }

        // Check to see if CustomFields property is set
        internal bool IsSetCustomFields()
        {
            return this._customFields != null && (this._customFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedFields. 
        /// <para>
        /// Contains fields that are indexed and whose types are already known by the Fleet Indexing
        /// service. This is an optional field. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/managing-fleet-index.html#managed-field">Managed
        /// fields</a> in the <i>Amazon Web Services IoT Core Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't modify managed fields by updating fleet indexing configuration.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Field> ManagedFields
        {
            get { return this._managedFields; }
            set { this._managedFields = value; }
        }

        // Check to see if ManagedFields property is set
        internal bool IsSetManagedFields()
        {
            return this._managedFields != null && (this._managedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThingGroupIndexingMode. 
        /// <para>
        /// Thing group indexing mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ThingGroupIndexingMode ThingGroupIndexingMode
        {
            get { return this._thingGroupIndexingMode; }
            set { this._thingGroupIndexingMode = value; }
        }

        // Check to see if ThingGroupIndexingMode property is set
        internal bool IsSetThingGroupIndexingMode()
        {
            return this._thingGroupIndexingMode != null;
        }

    }
}