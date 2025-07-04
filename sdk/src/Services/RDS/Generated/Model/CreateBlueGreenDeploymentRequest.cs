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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBlueGreenDeployment operation.
    /// Creates a blue/green deployment.
    /// 
    ///  
    /// <para>
    /// A blue/green deployment creates a staging environment that copies the production environment.
    /// In a blue/green deployment, the blue environment is the current production environment.
    /// The green environment is the staging environment, and it stays in sync with the current
    /// production environment.
    /// </para>
    ///  
    /// <para>
    /// You can make changes to the databases in the green environment without affecting production
    /// workloads. For example, you can upgrade the major or minor DB engine version, change
    /// database parameters, or make schema changes in the staging environment. You can thoroughly
    /// test changes in the green environment. When ready, you can switch over the environments
    /// to promote the green environment to be the new production environment. The switchover
    /// typically takes under a minute.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
    /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
    /// Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateBlueGreenDeploymentRequest : AmazonRDSRequest
    {
        private string _blueGreenDeploymentName;
        private string _source;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _targetAllocatedStorage;
        private string _targetDBClusterParameterGroupName;
        private string _targetDBInstanceClass;
        private string _targetDBParameterGroupName;
        private string _targetEngineVersion;
        private int? _targetIops;
        private int? _targetStorageThroughput;
        private string _targetStorageType;
        private bool? _upgradeTargetStorageConfig;

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentName. 
        /// <para>
        /// The name of the blue/green deployment.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be the same as an existing blue/green deployment name in the same account and
        /// Amazon Web Services Region.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string BlueGreenDeploymentName
        {
            get { return this._blueGreenDeploymentName; }
            set { this._blueGreenDeploymentName = value; }
        }

        // Check to see if BlueGreenDeploymentName property is set
        internal bool IsSetBlueGreenDeploymentName()
        {
            return this._blueGreenDeploymentName != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source production database.
        /// </para>
        ///  
        /// <para>
        /// Specify the database that you want to clone. The blue/green deployment creates this
        /// database in the green environment. You can make updates to the database in the green
        /// environment, such as an engine version upgrade. When you are ready, you can switch
        /// the database in the green environment to be the production database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the blue/green deployment.
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
        /// Gets and sets the property TargetAllocatedStorage. 
        /// <para>
        /// The amount of storage in gibibytes (GiB) to allocate for the green DB instance. You
        /// can choose to increase or decrease the allocated storage on the green DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public int? TargetAllocatedStorage
        {
            get { return this._targetAllocatedStorage; }
            set { this._targetAllocatedStorage = value; }
        }

        // Check to see if TargetAllocatedStorage property is set
        internal bool IsSetTargetAllocatedStorage()
        {
            return this._targetAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetDBClusterParameterGroupName. 
        /// <para>
        /// The DB cluster parameter group associated with the Aurora DB cluster in the green
        /// environment.
        /// </para>
        ///  
        /// <para>
        /// To test parameter changes, specify a DB cluster parameter group that is different
        /// from the one associated with the source DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TargetDBClusterParameterGroupName
        {
            get { return this._targetDBClusterParameterGroupName; }
            set { this._targetDBClusterParameterGroupName = value; }
        }

        // Check to see if TargetDBClusterParameterGroupName property is set
        internal bool IsSetTargetDBClusterParameterGroupName()
        {
            return this._targetDBClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDBInstanceClass. 
        /// <para>
        /// Specify the DB instance class for the databases in the green environment.
        /// </para>
        ///  
        /// <para>
        /// This parameter only applies to RDS DB instances, because DB instances within an Aurora
        /// DB cluster can have multiple different instance classes. If you're creating a blue/green
        /// deployment from an Aurora DB cluster, don't specify this parameter. After the green
        /// environment is created, you can individually modify the instance classes of the DB
        /// instances within the green DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=20)]
        public string TargetDBInstanceClass
        {
            get { return this._targetDBInstanceClass; }
            set { this._targetDBInstanceClass = value; }
        }

        // Check to see if TargetDBInstanceClass property is set
        internal bool IsSetTargetDBInstanceClass()
        {
            return this._targetDBInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDBParameterGroupName. 
        /// <para>
        /// The DB parameter group associated with the DB instance in the green environment.
        /// </para>
        ///  
        /// <para>
        /// To test parameter changes, specify a DB parameter group that is different from the
        /// one associated with the source DB instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TargetDBParameterGroupName
        {
            get { return this._targetDBParameterGroupName; }
            set { this._targetDBParameterGroupName = value; }
        }

        // Check to see if TargetDBParameterGroupName property is set
        internal bool IsSetTargetDBParameterGroupName()
        {
            return this._targetDBParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetEngineVersion. 
        /// <para>
        /// The engine version of the database in the green environment.
        /// </para>
        ///  
        /// <para>
        /// Specify the engine version to upgrade to in the green environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TargetEngineVersion
        {
            get { return this._targetEngineVersion; }
            set { this._targetEngineVersion = value; }
        }

        // Check to see if TargetEngineVersion property is set
        internal bool IsSetTargetEngineVersion()
        {
            return this._targetEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TargetIops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to allocate for
        /// the green DB instance. For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html">Amazon
        /// RDS DB instance storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public int? TargetIops
        {
            get { return this._targetIops; }
            set { this._targetIops = value; }
        }

        // Check to see if TargetIops property is set
        internal bool IsSetTargetIops()
        {
            return this._targetIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetStorageThroughput. 
        /// <para>
        /// The storage throughput value for the green DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to the <c>gp3</c> storage type.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public int? TargetStorageThroughput
        {
            get { return this._targetStorageThroughput; }
            set { this._targetStorageThroughput = value; }
        }

        // Check to see if TargetStorageThroughput property is set
        internal bool IsSetTargetStorageThroughput()
        {
            return this._targetStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetStorageType. 
        /// <para>
        /// The storage type to associate with the green DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>gp2 | gp3 | io1 | io2</c> 
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public string TargetStorageType
        {
            get { return this._targetStorageType; }
            set { this._targetStorageType = value; }
        }

        // Check to see if TargetStorageType property is set
        internal bool IsSetTargetStorageType()
        {
            return this._targetStorageType != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeTargetStorageConfig. 
        /// <para>
        /// Whether to upgrade the storage file system configuration on the green database. This
        /// option migrates the green DB instance from the older 32-bit file system to the preferred
        /// configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIOPS.StorageTypes.html#USER_PIOPS.UpgradeFileSystem">Upgrading
        /// the storage file system for a DB instance</a>.
        /// </para>
        /// </summary>
        public bool? UpgradeTargetStorageConfig
        {
            get { return this._upgradeTargetStorageConfig; }
            set { this._upgradeTargetStorageConfig = value; }
        }

        // Check to see if UpgradeTargetStorageConfig property is set
        internal bool IsSetUpgradeTargetStorageConfig()
        {
            return this._upgradeTargetStorageConfig.HasValue; 
        }

    }
}