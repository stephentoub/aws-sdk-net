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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the PutApplicationAccessScope operation.
    /// Adds or updates the list of authorized targets for an IAM Identity Center access scope
    /// for an application.
    /// </summary>
    public partial class PutApplicationAccessScopeRequest : AmazonSSOAdminRequest
    {
        private string _applicationArn;
        private List<string> _authorizedTargets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scope;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Specifies the ARN of the application with the access scope with the targets to add
        /// or update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizedTargets. 
        /// <para>
        /// Specifies an array list of ARNs that represent the authorized targets for this access
        /// scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AuthorizedTargets
        {
            get { return this._authorizedTargets; }
            set { this._authorizedTargets = value; }
        }

        // Check to see if AuthorizedTargets property is set
        internal bool IsSetAuthorizedTargets()
        {
            return this._authorizedTargets != null && (this._authorizedTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies the name of the access scope to be associated with the specified targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}