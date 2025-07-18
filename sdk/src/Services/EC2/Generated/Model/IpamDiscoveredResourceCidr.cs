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
    /// An IPAM discovered resource CIDR. A discovered resource is a resource CIDR monitored
    /// under a resource discovery. The following resources can be discovered: VPCs, Public
    /// IPv4 pools, VPC subnets, and Elastic IP addresses. The discovered resource CIDR is
    /// the IP address range in CIDR notation that is associated with the resource.
    /// </summary>
    public partial class IpamDiscoveredResourceCidr
    {
        private string _availabilityZoneId;
        private string _ipamResourceDiscoveryId;
        private IpamResourceCidrIpSource _ipSource;
        private double? _ipUsage;
        private IpamNetworkInterfaceAttachmentStatus _networkInterfaceAttachmentStatus;
        private string _resourceCidr;
        private string _resourceId;
        private string _resourceOwnerId;
        private string _resourceRegion;
        private List<IpamResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<IpamResourceTag>() : null;
        private IpamResourceType _resourceType;
        private DateTime? _sampleTime;
        private string _subnetId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// The resource discovery ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryId
        {
            get { return this._ipamResourceDiscoveryId; }
            set { this._ipamResourceDiscoveryId = value; }
        }

        // Check to see if IpamResourceDiscoveryId property is set
        internal bool IsSetIpamResourceDiscoveryId()
        {
            return this._ipamResourceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property IpSource. 
        /// <para>
        /// The source that allocated the IP address space. <c>byoip</c> or <c>amazon</c> indicates
        /// public IP address space allocated by Amazon or space that you have allocated with
        /// Bring your own IP (BYOIP). <c>none</c> indicates private space.
        /// </para>
        /// </summary>
        public IpamResourceCidrIpSource IpSource
        {
            get { return this._ipSource; }
            set { this._ipSource = value; }
        }

        // Check to see if IpSource property is set
        internal bool IsSetIpSource()
        {
            return this._ipSource != null;
        }

        /// <summary>
        /// Gets and sets the property IpUsage. 
        /// <para>
        /// The percentage of IP address space in use. To convert the decimal to a percentage,
        /// multiply the decimal by 100. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For resources that are VPCs, this is the percentage of IP address space in the VPC
        /// that's taken up by subnet CIDRs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resources that are subnets, if the subnet has an IPv4 CIDR provisioned to it,
        /// this is the percentage of IPv4 address space in the subnet that's in use. If the subnet
        /// has an IPv6 CIDR provisioned to it, the percentage of IPv6 address space in use is
        /// not represented. The percentage of IPv6 address space in use cannot currently be calculated.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resources that are public IPv4 pools, this is the percentage of IP address space
        /// in the pool that's been allocated to Elastic IP addresses (EIPs). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public double? IpUsage
        {
            get { return this._ipUsage; }
            set { this._ipUsage = value; }
        }

        // Check to see if IpUsage property is set
        internal bool IsSetIpUsage()
        {
            return this._ipUsage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceAttachmentStatus. 
        /// <para>
        /// For elastic network interfaces, this is the status of whether or not the elastic network
        /// interface is attached.
        /// </para>
        /// </summary>
        public IpamNetworkInterfaceAttachmentStatus NetworkInterfaceAttachmentStatus
        {
            get { return this._networkInterfaceAttachmentStatus; }
            set { this._networkInterfaceAttachmentStatus = value; }
        }

        // Check to see if NetworkInterfaceAttachmentStatus property is set
        internal bool IsSetNetworkInterfaceAttachmentStatus()
        {
            return this._networkInterfaceAttachmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCidr. 
        /// <para>
        /// The resource CIDR.
        /// </para>
        /// </summary>
        public string ResourceCidr
        {
            get { return this._resourceCidr; }
            set { this._resourceCidr = value; }
        }

        // Check to see if ResourceCidr property is set
        internal bool IsSetResourceCidr()
        {
            return this._resourceCidr != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// The resource owner ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerId
        {
            get { return this._resourceOwnerId; }
            set { this._resourceOwnerId = value; }
        }

        // Check to see if ResourceOwnerId property is set
        internal bool IsSetResourceOwnerId()
        {
            return this._resourceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The resource Region.
        /// </para>
        /// </summary>
        public string ResourceRegion
        {
            get { return this._resourceRegion; }
            set { this._resourceRegion = value; }
        }

        // Check to see if ResourceRegion property is set
        internal bool IsSetResourceRegion()
        {
            return this._resourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The resource tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        public IpamResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The last successful resource discovery time.
        /// </para>
        /// </summary>
        public DateTime? SampleTime
        {
            get { return this._sampleTime; }
            set { this._sampleTime = value; }
        }

        // Check to see if SampleTime property is set
        internal bool IsSetSampleTime()
        {
            return this._sampleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}