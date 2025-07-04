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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a security group rule.
    /// </summary>
    public partial class SecurityGroupRule
    {
        private string _cidrIpv4;
        private string _cidrIpv6;
        private string _description;
        private int? _fromPort;
        private string _groupId;
        private string _groupOwnerId;
        private string _ipProtocol;
        private bool? _isEgress;
        private string _prefixListId;
        private ReferencedSecurityGroup _referencedGroupInfo;
        private string _securityGroupRuleArn;
        private string _securityGroupRuleId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property CidrIpv4. 
        /// <para>
        /// The IPv4 CIDR range.
        /// </para>
        /// </summary>
        public string CidrIpv4
        {
            get { return this._cidrIpv4; }
            set { this._cidrIpv4 = value; }
        }

        // Check to see if CidrIpv4 property is set
        internal bool IsSetCidrIpv4()
        {
            return this._cidrIpv4 != null;
        }

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// The IPv6 CIDR range.
        /// </para>
        /// </summary>
        public string CidrIpv6
        {
            get { return this._cidrIpv6; }
            set { this._cidrIpv6 = value; }
        }

        // Check to see if CidrIpv6 property is set
        internal bool IsSetCidrIpv6()
        {
            return this._cidrIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The security group rule description.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FromPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the start of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP type or -1 (all ICMP types).
        /// </para>
        /// </summary>
        public int? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the security group. 
        /// </para>
        /// </summary>
        public string GroupOwnerId
        {
            get { return this._groupOwnerId; }
            set { this._groupOwnerId = value; }
        }

        // Check to see if GroupOwnerId property is set
        internal bool IsSetGroupOwnerId()
        {
            return this._groupOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The IP protocol name (<c>tcp</c>, <c>udp</c>, <c>icmp</c>, <c>icmpv6</c>) or number
        /// (see <a href="http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers</a>). 
        /// </para>
        ///  
        /// <para>
        /// Use <c>-1</c> to specify all protocols.
        /// </para>
        /// </summary>
        public string IpProtocol
        {
            get { return this._ipProtocol; }
            set { this._ipProtocol = value; }
        }

        // Check to see if IpProtocol property is set
        internal bool IsSetIpProtocol()
        {
            return this._ipProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property IsEgress. 
        /// <para>
        /// Indicates whether the security group rule is an outbound rule.
        /// </para>
        /// </summary>
        public bool? IsEgress
        {
            get { return this._isEgress; }
            set { this._isEgress = value; }
        }

        // Check to see if IsEgress property is set
        internal bool IsSetIsEgress()
        {
            return this._isEgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferencedGroupInfo. 
        /// <para>
        /// Describes the security group that is referenced in the rule.
        /// </para>
        /// </summary>
        public ReferencedSecurityGroup ReferencedGroupInfo
        {
            get { return this._referencedGroupInfo; }
            set { this._referencedGroupInfo = value; }
        }

        // Check to see if ReferencedGroupInfo property is set
        internal bool IsSetReferencedGroupInfo()
        {
            return this._referencedGroupInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleArn. 
        /// <para>
        /// The ARN of the security group rule.
        /// </para>
        /// </summary>
        public string SecurityGroupRuleArn
        {
            get { return this._securityGroupRuleArn; }
            set { this._securityGroupRuleArn = value; }
        }

        // Check to see if SecurityGroupRuleArn property is set
        internal bool IsSetSecurityGroupRuleArn()
        {
            return this._securityGroupRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleId. 
        /// <para>
        /// The ID of the security group rule.
        /// </para>
        /// </summary>
        public string SecurityGroupRuleId
        {
            get { return this._securityGroupRuleId; }
            set { this._securityGroupRuleId = value; }
        }

        // Check to see if SecurityGroupRuleId property is set
        internal bool IsSetSecurityGroupRuleId()
        {
            return this._securityGroupRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the security group rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property ToPort. 
        /// <para>
        /// If the protocol is TCP or UDP, this is the end of the port range. If the protocol
        /// is ICMP or ICMPv6, this is the ICMP code or -1 (all ICMP codes). If the start port
        /// is -1 (all ICMP types), then the end port must be -1 (all ICMP codes).
        /// </para>
        /// </summary>
        public int? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}