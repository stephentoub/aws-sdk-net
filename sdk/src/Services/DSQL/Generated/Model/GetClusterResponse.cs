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
    /// The output of a cluster.
    /// </summary>
    public partial class GetClusterResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private bool? _deletionProtectionEnabled;
        private string _identifier;
        private List<string> _linkedClusterArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MultiRegionProperties _multiRegionProperties;
        private ClusterStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _witnessRegion;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the retrieved cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The time of when the cluster was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Whether deletion protection is enabled in this cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the retrieved cluster.
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
        /// Gets and sets the property LinkedClusterArns. 
        /// <para>
        /// The ARNs of the clusters linked to the retrieved cluster.
        /// </para>
        /// </summary>
        [Obsolete("The linkedClusterArns field is deprecated. To see the peered cluster Arns, use multiRegionProperties.cluster instead.")]
        public List<string> LinkedClusterArns
        {
            get { return this._linkedClusterArns; }
            set { this._linkedClusterArns = value; }
        }

        // Check to see if LinkedClusterArns property is set
        internal bool IsSetLinkedClusterArns()
        {
            return this._linkedClusterArns != null && (this._linkedClusterArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MultiRegionProperties. 
        /// <para>
        /// Returns the current multi-Region cluster configuration, including witness region and
        /// linked cluster information.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the retrieved cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterStatus Status
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
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property WitnessRegion. 
        /// <para>
        /// The witness Region of the cluster. Applicable only for multi-Region clusters.
        /// </para>
        /// </summary>
        [Obsolete("The witnessRegion field is deprecated. To see the witnessRegion, use multiRegionProperties.witnessRegion instead.")]
        [AWSProperty(Min=0, Max=50)]
        public string WitnessRegion
        {
            get { return this._witnessRegion; }
            set { this._witnessRegion = value; }
        }

        // Check to see if WitnessRegion property is set
        internal bool IsSetWitnessRegion()
        {
            return this._witnessRegion != null;
        }

    }
}