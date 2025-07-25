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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
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
namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the PutAppValidationConfiguration operation.
    /// Creates or updates a validation configuration for the specified application.
    /// </summary>
    public partial class PutAppValidationConfigurationRequest : AmazonServerMigrationServiceRequest
    {
        private string _appId;
        private List<AppValidationConfiguration> _appValidationConfigurations = AWSConfigs.InitializeCollections ? new List<AppValidationConfiguration>() : null;
        private List<ServerGroupValidationConfiguration> _serverGroupValidationConfigurations = AWSConfigs.InitializeCollections ? new List<ServerGroupValidationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AppValidationConfigurations. 
        /// <para>
        /// The configuration for application validation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AppValidationConfiguration> AppValidationConfigurations
        {
            get { return this._appValidationConfigurations; }
            set { this._appValidationConfigurations = value; }
        }

        // Check to see if AppValidationConfigurations property is set
        internal bool IsSetAppValidationConfigurations()
        {
            return this._appValidationConfigurations != null && (this._appValidationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerGroupValidationConfigurations. 
        /// <para>
        /// The configuration for instance validation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerGroupValidationConfiguration> ServerGroupValidationConfigurations
        {
            get { return this._serverGroupValidationConfigurations; }
            set { this._serverGroupValidationConfigurations = value; }
        }

        // Check to see if ServerGroupValidationConfigurations property is set
        internal bool IsSetServerGroupValidationConfigurations()
        {
            return this._serverGroupValidationConfigurations != null && (this._serverGroupValidationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}