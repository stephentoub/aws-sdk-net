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
    /// Logical grouping of servers.
    /// </summary>
    public partial class ServerGroup
    {
        private string _name;
        private string _serverGroupId;
        private List<Server> _serverList = AWSConfigs.InitializeCollections ? new List<Server>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a server group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ServerGroupId. 
        /// <para>
        /// The ID of a server group.
        /// </para>
        /// </summary>
        public string ServerGroupId
        {
            get { return this._serverGroupId; }
            set { this._serverGroupId = value; }
        }

        // Check to see if ServerGroupId property is set
        internal bool IsSetServerGroupId()
        {
            return this._serverGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerList. 
        /// <para>
        /// The servers that belong to a server group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Server> ServerList
        {
            get { return this._serverList; }
            set { this._serverList = value; }
        }

        // Check to see if ServerList property is set
        internal bool IsSetServerList()
        {
            return this._serverList != null && (this._serverList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}