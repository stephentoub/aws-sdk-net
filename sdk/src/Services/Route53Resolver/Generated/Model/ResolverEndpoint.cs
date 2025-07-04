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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In the response to a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverEndpoint.html">DeleteResolverEndpoint</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>,
    /// Updates the name, or ResolverEndpointType for an endpoint, or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverEndpoint.html">UpdateResolverEndpoint</a>
    /// request, a complex type that contains settings for an existing inbound or outbound
    /// Resolver endpoint.
    /// </summary>
    public partial class ResolverEndpoint
    {
        private string _arn;
        private string _creationTime;
        private string _creatorRequestId;
        private ResolverEndpointDirection _direction;
        private string _hostVPCId;
        private string _id;
        private int? _ipAddressCount;
        private string _modificationTime;
        private string _name;
        private string _outpostArn;
        private string _preferredInstanceType;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResolverEndpointType _resolverEndpointType;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResolverEndpointStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Resolver endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the endpoint was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request that created the Resolver endpoint. The
        /// <c>CreatorRequestId</c> allows failed requests to be retried without the risk of running
        /// the operation twice.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// Indicates whether the Resolver endpoint allows inbound or outbound DNS queries:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INBOUND</c>: allows DNS queries to your VPC from your network
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTBOUND</c>: allows DNS queries from your VPC to your network
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INBOUND_DELEGATION</c>: Resolver delegates queries to Route 53 private hosted
        /// zones from your network.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverEndpointDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property HostVPCId. 
        /// <para>
        /// The ID of the VPC that you want to create the Resolver endpoint in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string HostVPCId
        {
            get { return this._hostVPCId; }
            set { this._hostVPCId = value; }
        }

        // Check to see if HostVPCId property is set
        internal bool IsSetHostVPCId()
        {
            return this._hostVPCId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Resolver endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property IpAddressCount. 
        /// <para>
        /// The number of IP addresses that the Resolver endpoint can use for DNS queries.
        /// </para>
        /// </summary>
        public int? IpAddressCount
        {
            get { return this._ipAddressCount; }
            set { this._ipAddressCount = value; }
        }

        // Check to see if IpAddressCount property is set
        internal bool IsSetIpAddressCount()
        {
            return this._ipAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the endpoint was last modified, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string ModificationTime
        {
            get { return this._modificationTime; }
            set { this._modificationTime = value; }
        }

        // Check to see if ModificationTime property is set
        internal bool IsSetModificationTime()
        {
            return this._modificationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you assigned to the Resolver endpoint when you submitted a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredInstanceType. 
        /// <para>
        ///  The Amazon EC2 instance type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PreferredInstanceType
        {
            get { return this._preferredInstanceType; }
            set { this._preferredInstanceType = value; }
        }

        // Check to see if PreferredInstanceType property is set
        internal bool IsSetPreferredInstanceType()
        {
            return this._preferredInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        ///  Protocols used for the endpoint. DoH-FIPS is applicable for a default inbound endpoints
        /// only. 
        /// </para>
        ///  
        /// <para>
        /// For an inbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 and DoH-FIPS in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH-FIPS alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a delegation inbound endpoint you can use Do53 only.
        /// </para>
        ///  
        /// <para>
        /// For an outbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResolverEndpointType. 
        /// <para>
        ///  The Resolver endpoint IP address type. 
        /// </para>
        /// </summary>
        public ResolverEndpointType ResolverEndpointType
        {
            get { return this._resolverEndpointType; }
            set { this._resolverEndpointType = value; }
        }

        // Check to see if ResolverEndpointType property is set
        internal bool IsSetResolverEndpointType()
        {
            return this._resolverEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The ID of one or more security groups that control access to this VPC. The security
        /// group must include one or more inbound rules (for inbound endpoints) or outbound rules
        /// (for outbound endpoints). Inbound and outbound rules must allow TCP and UDP access.
        /// For inbound access, open port 53. For outbound access, open the port that you're using
        /// for DNS queries on your network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A code that specifies the current status of the Resolver endpoint. Valid values include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: Resolver is creating and configuring one or more Amazon VPC network
        /// interfaces for this endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPERATIONAL</c>: The Amazon VPC network interfaces for this endpoint are correctly
        /// configured and able to pass inbound or outbound DNS queries between your network and
        /// Resolver.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c>: Resolver is associating or disassociating one or more network interfaces
        /// with this endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO_RECOVERING</c>: Resolver is trying to recover one or more of the network
        /// interfaces that are associated with this endpoint. During the recovery process, the
        /// endpoint functions with limited capacity because of the limit on the number of DNS
        /// queries per IP address (per network interface). For the current limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-resolver">Limits
        /// on Route 53 Resolver</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTION_NEEDED</c>: This endpoint is unhealthy, and Resolver can't automatically
        /// recover it. To resolve the problem, we recommend that you check each IP address that
        /// you associated with the endpoint. For each IP address that isn't available, add another
        /// IP address and then delete the IP address that isn't available. (An endpoint must
        /// always include at least two IP addresses.) A status of <c>ACTION_NEEDED</c> can have
        /// a variety of causes. Here are two common causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more of the network interfaces that are associated with the endpoint were deleted
        /// using Amazon VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The network interface couldn't be created for some reason that's outside the control
        /// of Resolver.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Resolver is deleting this endpoint and the associated network interfaces.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverEndpointStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the status of the Resolver endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}