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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The third-party provider detail for a service configuration.
    /// </summary>
    public partial class ProviderDetail
    {
        private JiraCloudDetail _jiraCloud;
        private ServiceNowDetail _serviceNow;

        /// <summary>
        /// Gets and sets the property JiraCloud. 
        /// <para>
        /// Details about a Jira Cloud integration.
        /// </para>
        /// </summary>
        public JiraCloudDetail JiraCloud
        {
            get { return this._jiraCloud; }
            set { this._jiraCloud = value; }
        }

        // Check to see if JiraCloud property is set
        internal bool IsSetJiraCloud()
        {
            return this._jiraCloud != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        /// Details about a ServiceNow ITSM integration.
        /// </para>
        /// </summary>
        public ServiceNowDetail ServiceNow
        {
            get { return this._serviceNow; }
            set { this._serviceNow = value; }
        }

        // Check to see if ServiceNow property is set
        internal bool IsSetServiceNow()
        {
            return this._serviceNow != null;
        }

    }
}