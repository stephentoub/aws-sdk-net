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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComponentType operation.
    /// Creates a component type.
    /// </summary>
    public partial class CreateComponentTypeRequest : AmazonIoTTwinMakerRequest
    {
        private string _componentTypeId;
        private string _componentTypeName;
        private Dictionary<string, CompositeComponentTypeRequest> _compositeComponentTypes = AWSConfigs.InitializeCollections ? new Dictionary<string, CompositeComponentTypeRequest>() : null;
        private string _description;
        private List<string> _extendsFrom = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, FunctionRequest> _functions = AWSConfigs.InitializeCollections ? new Dictionary<string, FunctionRequest>() : null;
        private bool? _isSingleton;
        private Dictionary<string, PropertyDefinitionRequest> _propertyDefinitions = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyDefinitionRequest>() : null;
        private Dictionary<string, PropertyGroupRequest> _propertyGroups = AWSConfigs.InitializeCollections ? new Dictionary<string, PropertyGroupRequest>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ComponentTypeId. 
        /// <para>
        /// The ID of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ComponentTypeId
        {
            get { return this._componentTypeId; }
            set { this._componentTypeId = value; }
        }

        // Check to see if ComponentTypeId property is set
        internal bool IsSetComponentTypeId()
        {
            return this._componentTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentTypeName. 
        /// <para>
        /// A friendly name for the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ComponentTypeName
        {
            get { return this._componentTypeName; }
            set { this._componentTypeName = value; }
        }

        // Check to see if ComponentTypeName property is set
        internal bool IsSetComponentTypeName()
        {
            return this._componentTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property CompositeComponentTypes. 
        /// <para>
        /// This is an object that maps strings to <c>compositeComponentTypes</c> of the <c>componentType</c>.
        /// <c>CompositeComponentType</c> is referenced by <c>componentTypeId</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CompositeComponentTypeRequest> CompositeComponentTypes
        {
            get { return this._compositeComponentTypes; }
            set { this._compositeComponentTypes = value; }
        }

        // Check to see if CompositeComponentTypes property is set
        internal bool IsSetCompositeComponentTypes()
        {
            return this._compositeComponentTypes != null && (this._compositeComponentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendsFrom. 
        /// <para>
        /// Specifies the parent component type to extend.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExtendsFrom
        {
            get { return this._extendsFrom; }
            set { this._extendsFrom = value; }
        }

        // Check to see if ExtendsFrom property is set
        internal bool IsSetExtendsFrom()
        {
            return this._extendsFrom != null && (this._extendsFrom.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Functions. 
        /// <para>
        /// An object that maps strings to the functions in the component type. Each string in
        /// the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FunctionRequest> Functions
        {
            get { return this._functions; }
            set { this._functions = value; }
        }

        // Check to see if Functions property is set
        internal bool IsSetFunctions()
        {
            return this._functions != null && (this._functions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsSingleton. 
        /// <para>
        /// A Boolean value that specifies whether an entity can have more than one component
        /// of this type.
        /// </para>
        /// </summary>
        public bool? IsSingleton
        {
            get { return this._isSingleton; }
            set { this._isSingleton = value; }
        }

        // Check to see if IsSingleton property is set
        internal bool IsSetIsSingleton()
        {
            return this._isSingleton.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PropertyDefinitions. 
        /// <para>
        /// An object that maps strings to the property definitions in the component type. Each
        /// string in the mapping must be unique to this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyDefinitionRequest> PropertyDefinitions
        {
            get { return this._propertyDefinitions; }
            set { this._propertyDefinitions = value; }
        }

        // Check to see if PropertyDefinitions property is set
        internal bool IsSetPropertyDefinitions()
        {
            return this._propertyDefinitions != null && (this._propertyDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PropertyGroups.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PropertyGroupRequest> PropertyGroups
        {
            get { return this._propertyGroups; }
            set { this._propertyGroups = value; }
        }

        // Check to see if PropertyGroups property is set
        internal bool IsSetPropertyGroups()
        {
            return this._propertyGroups != null && (this._propertyGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that you can use to manage the component type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace that contains the component type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}