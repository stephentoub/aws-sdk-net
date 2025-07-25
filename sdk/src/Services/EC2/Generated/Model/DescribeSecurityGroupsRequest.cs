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
    /// Container for the parameters to the DescribeSecurityGroups operation.
    /// Describes the specified security groups or all of your security groups.
    /// </summary>
    public partial class DescribeSecurityGroupsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _groupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _groupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters. If using multiple filters for rules, the results include security groups
        /// for which any combination of rules - not necessarily a single rule - match all filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>description</c> - The description of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.cidr</c> - An IPv4 CIDR block for an outbound security group
        /// rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.from-port</c> - For an outbound rule, the start of port range
        /// for the TCP and UDP protocols, or an ICMP type number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.group-id</c> - The ID of a security group that has been referenced
        /// in an outbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.group-name</c> - The name of a security group that is referenced
        /// in an outbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.ipv6-cidr</c> - An IPv6 CIDR block for an outbound security
        /// group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.prefix-list-id</c> - The ID of a prefix list to which a security
        /// group rule allows outbound access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.protocol</c> - The IP protocol for an outbound security group
        /// rule (<c>tcp</c> | <c>udp</c> | <c>icmp</c>, a protocol number, or -1 for all protocols).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.to-port</c> - For an outbound rule, the end of port range
        /// for the TCP and UDP protocols, or an ICMP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>egress.ip-permission.user-id</c> - The ID of an Amazon Web Services account that
        /// has been referenced in an outbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>group-id</c> - The ID of the security group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>group-name</c> - The name of the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.cidr</c> - An IPv4 CIDR block for an inbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.from-port</c> - For an inbound rule, the start of port range for
        /// the TCP and UDP protocols, or an ICMP type number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.group-id</c> - The ID of a security group that has been referenced
        /// in an inbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.group-name</c> - The name of a security group that is referenced
        /// in an inbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.ipv6-cidr</c> - An IPv6 CIDR block for an inbound security group
        /// rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.prefix-list-id</c> - The ID of a prefix list from which a security
        /// group rule allows inbound access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.protocol</c> - The IP protocol for an inbound security group rule
        /// (<c>tcp</c> | <c>udp</c> | <c>icmp</c>, a protocol number, or -1 for all protocols).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.to-port</c> - For an inbound rule, the end of port range for the
        /// TCP and UDP protocols, or an ICMP code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ip-permission.user-id</c> - The ID of an Amazon Web Services account that has
        /// been referenced in an inbound security group rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The Amazon Web Services account ID of the owner of the security
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c>:&lt;key&gt; - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-id</c> - The ID of the VPC specified when the security group was created.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupIds. 
        /// <para>
        /// The IDs of the security groups. Required for security groups in a nondefault VPC.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all of your security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupIds
        {
            get { return this._groupIds; }
            set { this._groupIds = value; }
        }

        // Check to see if GroupIds property is set
        internal bool IsSetGroupIds()
        {
            return this._groupIds != null && (this._groupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupNames. 
        /// <para>
        /// [Default VPC] The names of the security groups. You can specify either the security
        /// group name or the security group ID.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all of your security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupNames
        {
            get { return this._groupNames; }
            set { this._groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this._groupNames != null && (this._groupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. This value can be between
        /// 5 and 1000. If this parameter is not specified, then all items are returned. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}