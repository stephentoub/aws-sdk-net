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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIPSet operation.
    /// Updates the specified <a>IPSet</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// This operation completely replaces the mutable specifications that you already have
    /// for the IP set with the ones that you provide to this call. 
    /// </para>
    ///  
    /// <para>
    /// To modify an IP set, do the following: 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Retrieve it by calling <a>GetIPSet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update its settings as needed
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the complete IP set specification to this call
    /// </para>
    ///  </li> </ol> </note> 
    /// <para>
    ///  <b>Temporary inconsistencies during updates</b> 
    /// </para>
    ///  
    /// <para>
    /// When you create or change a web ACL or other WAF resources, the changes take a small
    /// amount of time to propagate to all areas where the resources are stored. The propagation
    /// time can be from a few seconds to a number of minutes. 
    /// </para>
    ///  
    /// <para>
    /// The following are examples of the temporary inconsistencies that you might notice
    /// during change propagation: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// After you create a web ACL, if you try to associate it with a resource, you might
    /// get an exception indicating that the web ACL is unavailable. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you add a rule group to a web ACL, the new rule group rules might be in effect
    /// in one area where the web ACL is used and not in another.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you change a rule action setting, you might see the old action in some places
    /// and the new action in others. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you add an IP address to an IP set that is in use in a blocking rule, the new
    /// address might be blocked in one area while still allowed in another.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateIPSetRequest : AmazonWAFV2Request
    {
        private List<string> _addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _id;
        private string _lockToken;
        private string _name;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// Contains an array of strings that specifies zero or more IP addresses or blocks of
        /// IP addresses that you want WAF to inspect for in incoming requests. All addresses
        /// must be specified using Classless Inter-Domain Routing (CIDR) notation. WAF supports
        /// all IPv4 and IPv6 CIDR ranges except for <c>/0</c>. 
        /// </para>
        ///  
        /// <para>
        /// Example address strings: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For requests that originated from the IP address 192.0.2.44, specify <c>192.0.2.44/32</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For requests that originated from IP addresses from 192.0.2.0 to 192.0.2.255, specify
        /// <c>192.0.2.0/24</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For requests that originated from the IP address 1111:0000:0000:0000:0000:0000:0000:0111,
        /// specify <c>1111:0000:0000:0000:0000:0000:0000:0111/128</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For requests that originated from IP addresses 1111:0000:0000:0000:0000:0000:0000:0000
        /// to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify <c>1111:0000:0000:0000:0000:0000:0000:0000/64</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// Example JSON <c>Addresses</c> specifications: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Empty array: <c>"Addresses": []</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Array with one address: <c>"Addresses": ["192.0.2.44/32"]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Array with three addresses: <c>"Addresses": ["192.0.2.44/32", "192.0.2.0/24", "192.0.0.0/16"]</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID specification: <c>"Addresses": [""]</c> INVALID 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Addresses
        {
            get { return this._addresses; }
            set { this._addresses = value; }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="Addresses"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="Addresses"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsAddressesSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._addresses);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._addresses);
            }
        }

        // Check to see if Addresses property is set
        internal bool IsSetAddresses()
        {
            return this.IsAddressesSet; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the IP set that helps with identification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the set. This ID is returned in the responses to create and
        /// list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
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
        /// Gets and sets the property LockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string LockToken
        {
            get { return this._lockToken; }
            set { this._lockToken = value; }
        }

        // Check to see if LockToken property is set
        internal bool IsSetLockToken()
        {
            return this._lockToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the IP set. You cannot change the name of an <c>IPSet</c> after you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
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