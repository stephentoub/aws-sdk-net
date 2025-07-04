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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTaskTemplate operation.
    /// Updates details about a specific task template in the specified Amazon Connect instance.
    /// This operation does not support partial updates. Instead it does a full update of
    /// template content.
    /// </summary>
    public partial class UpdateTaskTemplateRequest : AmazonConnectRequest
    {
        private TaskTemplateConstraints _constraints;
        private string _contactFlowId;
        private TaskTemplateDefaults _defaults;
        private string _description;
        private List<TaskTemplateField> _fields = AWSConfigs.InitializeCollections ? new List<TaskTemplateField>() : null;
        private string _instanceId;
        private string _name;
        private string _selfAssignFlowId;
        private TaskTemplateStatus _status;
        private string _taskTemplateId;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Constraints that are applicable to the fields listed.
        /// </para>
        /// </summary>
        public TaskTemplateConstraints Constraints
        {
            get { return this._constraints; }
            set { this._constraints = value; }
        }

        // Check to see if Constraints property is set
        internal bool IsSetConstraints()
        {
            return this._constraints != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow that runs by default when a task is created by referencing
        /// this template.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ContactFlowId
        {
            get { return this._contactFlowId; }
            set { this._contactFlowId = value; }
        }

        // Check to see if ContactFlowId property is set
        internal bool IsSetContactFlowId()
        {
            return this._contactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property Defaults. 
        /// <para>
        /// The default values for fields when a task is created by referencing this template.
        /// </para>
        /// </summary>
        public TaskTemplateDefaults Defaults
        {
            get { return this._defaults; }
            set { this._defaults = value; }
        }

        // Check to see if Defaults property is set
        internal bool IsSetDefaults()
        {
            return this._defaults != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the task template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Fields. 
        /// <para>
        /// Fields that are part of the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskTemplateField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the task template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SelfAssignFlowId. 
        /// <para>
        /// The ContactFlowId for the flow that will be run if this template is used to create
        /// a self-assigned task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string SelfAssignFlowId
        {
            get { return this._selfAssignFlowId; }
            set { this._selfAssignFlowId = value; }
        }

        // Check to see if SelfAssignFlowId property is set
        internal bool IsSetSelfAssignFlowId()
        {
            return this._selfAssignFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Marks a template as <c>ACTIVE</c> or <c>INACTIVE</c> for a task to refer to it. Tasks
        /// can only be created from <c>ACTIVE</c> templates. If a template is marked as <c>INACTIVE</c>,
        /// then a task that refers to this template cannot be created.
        /// </para>
        /// </summary>
        public TaskTemplateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskTemplateId. 
        /// <para>
        /// A unique identifier for the task template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string TaskTemplateId
        {
            get { return this._taskTemplateId; }
            set { this._taskTemplateId = value; }
        }

        // Check to see if TaskTemplateId property is set
        internal bool IsSetTaskTemplateId()
        {
            return this._taskTemplateId != null;
        }

    }
}