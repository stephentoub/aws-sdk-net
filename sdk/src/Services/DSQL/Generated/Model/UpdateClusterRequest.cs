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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
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
namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCluster operation.
    /// Updates a cluster.
    /// 
    ///  
    /// <para>
    ///  <b>Example IAM Policy for Multi-Region Operations</b> 
    /// </para>
    ///  
    /// <para>
    /// The following IAM policy grants permissions for multi-Region operations.
    /// </para>
    ///  
    /// <para>
    /// The <c>dsql:RemovePeerCluster</c> permission uses a wildcard ARN pattern to simplify
    /// permission management during updates.
    /// </para>
    ///  <important> 
    /// <para>
    ///  <b>Important Notes for Multi-Region Operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The witness region specified in <c>multiRegionProperties.witnessRegion</c> cannot
    /// be the same as the cluster's Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When updating clusters with peer relationships, permissions are checked for both adding
    /// and removing peers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>dsql:RemovePeerCluster</c> permission uses a wildcard ARN pattern to simplify
    /// permission management during updates.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class UpdateClusterRequest : AmazonDSQLRequest
    {
        private string _clientToken;
        private bool? _deletionProtectionEnabled;
        private string _identifier;
        private MultiRegionProperties _multiRegionProperties;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully. The subsequent
        /// retries with the same client token return the result from the original successful
        /// request and they have no additional effect.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a client token, the Amazon Web Services SDK automatically generates
        /// one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Specifies whether to enable deletion protection in your cluster.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the cluster you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionProperties. 
        /// <para>
        /// The new multi-Region cluster configuration settings to be applied during an update
        /// operation.
        /// </para>
        /// </summary>
        public MultiRegionProperties MultiRegionProperties
        {
            get { return this._multiRegionProperties; }
            set { this._multiRegionProperties = value; }
        }

        // Check to see if MultiRegionProperties property is set
        internal bool IsSetMultiRegionProperties()
        {
            return this._multiRegionProperties != null;
        }

    }
}