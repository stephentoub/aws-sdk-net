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
    /// The metadata of the Lightweight Directory Access Protocol (LDAP) server used to authenticate
    /// and authorize connections to the broker. This is an optional failover server.
    /// </summary>
    public partial class AwsAmazonMqBrokerLdapServerMetadataDetails
    {
        private List<string> _hosts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleBase;
        private string _roleName;
        private string _roleSearchMatching;
        private bool? _roleSearchSubtree;
        private string _serviceAccountUsername;
        private string _userBase;
        private string _userRoleName;
        private string _userSearchMatching;
        private bool? _userSearchSubtree;

        /// <summary>
        /// Gets and sets the property Hosts. 
        /// <para>
        ///  Specifies the location of the LDAP server, such as Amazon Web Services Directory
        /// Service for Microsoft Active Directory. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Hosts
        {
            get { return this._hosts; }
            set { this._hosts = value; }
        }

        // Check to see if Hosts property is set
        internal bool IsSetHosts()
        {
            return this._hosts != null && (this._hosts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleBase. 
        /// <para>
        ///  The distinguished name of the node in the directory information tree (DIT) to search
        /// for roles or groups. 
        /// </para>
        /// </summary>
        public string RoleBase
        {
            get { return this._roleBase; }
            set { this._roleBase = value; }
        }

        // Check to see if RoleBase property is set
        internal bool IsSetRoleBase()
        {
            return this._roleBase != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        ///  The group name attribute in a role entry whose value is the name of that role. 
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleSearchMatching. 
        /// <para>
        ///  The LDAP search filter used to find roles within the <c>roleBase</c>. 
        /// </para>
        /// </summary>
        public string RoleSearchMatching
        {
            get { return this._roleSearchMatching; }
            set { this._roleSearchMatching = value; }
        }

        // Check to see if RoleSearchMatching property is set
        internal bool IsSetRoleSearchMatching()
        {
            return this._roleSearchMatching != null;
        }

        /// <summary>
        /// Gets and sets the property RoleSearchSubtree. 
        /// <para>
        ///  The directory search scope for the role. If set to <c>true</c>, the scope is to search
        /// the entire subtree. 
        /// </para>
        /// </summary>
        public bool? RoleSearchSubtree
        {
            get { return this._roleSearchSubtree; }
            set { this._roleSearchSubtree = value; }
        }

        // Check to see if RoleSearchSubtree property is set
        internal bool IsSetRoleSearchSubtree()
        {
            return this._roleSearchSubtree.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountUsername. 
        /// <para>
        ///  A username for the service account, which is an account in your LDAP server that
        /// has access to initiate a connection. 
        /// </para>
        /// </summary>
        public string ServiceAccountUsername
        {
            get { return this._serviceAccountUsername; }
            set { this._serviceAccountUsername = value; }
        }

        // Check to see if ServiceAccountUsername property is set
        internal bool IsSetServiceAccountUsername()
        {
            return this._serviceAccountUsername != null;
        }

        /// <summary>
        /// Gets and sets the property UserBase. 
        /// <para>
        ///  Selects a particular subtree of the directory information tree (DIT) to search for
        /// user entries. 
        /// </para>
        /// </summary>
        public string UserBase
        {
            get { return this._userBase; }
            set { this._userBase = value; }
        }

        // Check to see if UserBase property is set
        internal bool IsSetUserBase()
        {
            return this._userBase != null;
        }

        /// <summary>
        /// Gets and sets the property UserRoleName. 
        /// <para>
        ///  The name of the LDAP attribute in the user's directory entry for the user's group
        /// membership. 
        /// </para>
        /// </summary>
        public string UserRoleName
        {
            get { return this._userRoleName; }
            set { this._userRoleName = value; }
        }

        // Check to see if UserRoleName property is set
        internal bool IsSetUserRoleName()
        {
            return this._userRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property UserSearchMatching. 
        /// <para>
        ///  The LDAP search filter used to find users within the <c>userBase</c>. 
        /// </para>
        /// </summary>
        public string UserSearchMatching
        {
            get { return this._userSearchMatching; }
            set { this._userSearchMatching = value; }
        }

        // Check to see if UserSearchMatching property is set
        internal bool IsSetUserSearchMatching()
        {
            return this._userSearchMatching != null;
        }

        /// <summary>
        /// Gets and sets the property UserSearchSubtree. 
        /// <para>
        ///  The directory search scope for the user. If set to true, the scope is to search the
        /// entire subtree. 
        /// </para>
        /// </summary>
        public bool? UserSearchSubtree
        {
            get { return this._userSearchSubtree; }
            set { this._userSearchSubtree = value; }
        }

        // Check to see if UserSearchSubtree property is set
        internal bool IsSetUserSearchSubtree()
        {
            return this._userSearchSubtree.HasValue; 
        }

    }
}