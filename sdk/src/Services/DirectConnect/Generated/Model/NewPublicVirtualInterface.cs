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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about a public virtual interface.
    /// </summary>
    public partial class NewPublicVirtualInterface
    {
        private AddressFamily _addressFamily;
        private string _amazonAddress;
        private int? _asn;
        private string _authKey;
        private string _customerAddress;
        private List<RouteFilterPrefix> _routeFilterPrefixes = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _virtualInterfaceName;
        private int? _vlan;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family for the BGP peer.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonAddress. 
        /// <para>
        /// The IP address assigned to the Amazon interface.
        /// </para>
        /// </summary>
        public string AmazonAddress
        {
            get { return this._amazonAddress; }
            set { this._amazonAddress = value; }
        }

        // Check to see if AmazonAddress property is set
        internal bool IsSetAmazonAddress()
        {
            return this._amazonAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.
        /// </para>
        ///  
        /// <para>
        /// The valid values are 1-2147483647.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Asn
        {
            get { return this._asn; }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthKey. 
        /// <para>
        /// The authentication key for BGP configuration. This string has a minimum length of
        /// 6 characters and and a maximun lenth of 80 characters.
        /// </para>
        /// </summary>
        public string AuthKey
        {
            get { return this._authKey; }
            set { this._authKey = value; }
        }

        // Check to see if AuthKey property is set
        internal bool IsSetAuthKey()
        {
            return this._authKey != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerAddress. 
        /// <para>
        /// The IP address assigned to the customer interface.
        /// </para>
        /// </summary>
        public string CustomerAddress
        {
            get { return this._customerAddress; }
            set { this._customerAddress = value; }
        }

        // Check to see if CustomerAddress property is set
        internal bool IsSetCustomerAddress()
        {
            return this._customerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RouteFilterPrefixes. 
        /// <para>
        /// The routes to be advertised to the Amazon Web Services network in this Region. Applies
        /// to public virtual interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> RouteFilterPrefixes
        {
            get { return this._routeFilterPrefixes; }
            set { this._routeFilterPrefixes = value; }
        }

        // Check to see if RouteFilterPrefixes property is set
        internal bool IsSetRouteFilterPrefixes()
        {
            return this._routeFilterPrefixes != null && (this._routeFilterPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the public virtual interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property VirtualInterfaceName. 
        /// <para>
        /// The name of the virtual interface assigned by the customer network. The name has a
        /// maximum of 100 characters. The following are valid characters: a-z, 0-9 and a hyphen
        /// (-).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VirtualInterfaceName
        {
            get { return this._virtualInterfaceName; }
            set { this._virtualInterfaceName = value; }
        }

        // Check to see if VirtualInterfaceName property is set
        internal bool IsSetVirtualInterfaceName()
        {
            return this._virtualInterfaceName != null;
        }

        /// <summary>
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The ID of the VLAN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Vlan
        {
            get { return this._vlan; }
            set { this._vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this._vlan.HasValue; 
        }

    }
}