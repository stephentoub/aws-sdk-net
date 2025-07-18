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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
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
namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDevEnvironment operation.
    /// Changes one or more values for a Dev Environment. Updating certain values of the Dev
    /// Environment will cause a restart.
    /// </summary>
    public partial class UpdateDevEnvironmentRequest : AmazonCodeCatalystRequest
    {
        private string _alias;
        private string _clientToken;
        private string _id;
        private List<IdeConfiguration> _ides = AWSConfigs.InitializeCollections ? new List<IdeConfiguration>() : null;
        private int? _inactivityTimeoutMinutes;
        private InstanceType _instanceType;
        private string _projectName;
        private string _spaceName;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The user-specified alias for the Dev Environment. Changing this value will not cause
        /// a restart.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A user-specified idempotency token. Idempotency ensures that an API request completes
        /// only once. With an idempotent request, if the original request completes successfully,
        /// the subsequent retries return the result from the original successful request and
        /// have no additional effect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated unique ID of the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Ides. 
        /// <para>
        /// Information about the integrated development environment (IDE) configured for a Dev
        /// Environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<IdeConfiguration> Ides
        {
            get { return this._ides; }
            set { this._ides = value; }
        }

        // Check to see if Ides property is set
        internal bool IsSetIdes()
        {
            return this._ides != null && (this._ides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InactivityTimeoutMinutes. 
        /// <para>
        /// The amount of time the Dev Environment will run without any activity detected before
        /// stopping, in minutes. Only whole integers are allowed. Dev Environments consume compute
        /// minutes when running.
        /// </para>
        ///  <note> 
        /// <para>
        /// Changing this value will cause a restart of the Dev Environment if it is running.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1200)]
        public int? InactivityTimeoutMinutes
        {
            get { return this._inactivityTimeoutMinutes; }
            set { this._inactivityTimeoutMinutes = value; }
        }

        // Check to see if InactivityTimeoutMinutes property is set
        internal bool IsSetInactivityTimeoutMinutes()
        {
            return this._inactivityTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instace type to use for the Dev Environment. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Changing this value will cause a restart of the Dev Environment if it is running.
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

    }
}