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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The connection group for your distribution tenants. When you first create a distribution
    /// tenant and you don't specify a connection group, CloudFront will automatically create
    /// a default connection group for you. When you create a new distribution tenant and
    /// don't specify a connection group, the default one will be associated with your distribution
    /// tenant.
    /// </summary>
    public partial class ConnectionGroup
    {
        private string _anycastIpListId;
        private string _arn;
        private DateTime? _createdTime;
        private bool? _enabled;
        private string _id;
        private bool? _ipv6Enabled;
        private bool? _isDefault;
        private DateTime? _lastModifiedTime;
        private string _name;
        private string _routingEndpoint;
        private string _status;
        private Tags _tags;

        /// <summary>
        /// Gets and sets the property AnycastIpListId. 
        /// <para>
        /// The ID of the Anycast static IP list.
        /// </para>
        /// </summary>
        public string AnycastIpListId
        {
            get { return this._anycastIpListId; }
            set { this._anycastIpListId = value; }
        }

        // Check to see if AnycastIpListId property is set
        internal bool IsSetAnycastIpListId()
        {
            return this._anycastIpListId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection group.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time when the connection group was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the connection group is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the connection group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Ipv6Enabled. 
        /// <para>
        /// IPv6 is enabled for the connection group.
        /// </para>
        /// </summary>
        public bool? Ipv6Enabled
        {
            get { return this._ipv6Enabled; }
            set { this._ipv6Enabled = value; }
        }

        // Check to see if Ipv6Enabled property is set
        internal bool IsSetIpv6Enabled()
        {
            return this._ipv6Enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Whether the connection group is the default connection group for the distribution
        /// tenants.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when the connection group was updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection group.
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
        /// Gets and sets the property RoutingEndpoint. 
        /// <para>
        /// The routing endpoint (also known as the DNS name) that is assigned to the connection
        /// group, such as d111111abcdef8.cloudfront.net.
        /// </para>
        /// </summary>
        public string RoutingEndpoint
        {
            get { return this._routingEndpoint; }
            set { this._routingEndpoint = value; }
        }

        // Check to see if RoutingEndpoint property is set
        internal bool IsSetRoutingEndpoint()
        {
            return this._routingEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the connection group.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}