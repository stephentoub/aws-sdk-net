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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLayer operation.
    /// Updates a specified layer.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLayerRequest : AmazonOpsWorksRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _autoAssignElasticIps;
        private bool? _autoAssignPublicIps;
        private CloudWatchLogsConfiguration _cloudWatchLogsConfiguration;
        private string _customInstanceProfileArn;
        private string _customJson;
        private Recipes _customRecipes;
        private List<string> _customSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enableAutoHealing;
        private bool? _installUpdatesOnBoot;
        private string _layerId;
        private LifecycleEventConfiguration _lifecycleEventConfiguration;
        private string _name;
        private List<string> _packages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _shortname;
        private bool? _useEbsOptimizedInstances;
        private List<VolumeConfiguration> _volumeConfigurations = AWSConfigs.InitializeCollections ? new List<VolumeConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more user-defined key/value pairs to be added to the stack attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoAssignElasticIps. 
        /// <para>
        /// Whether to automatically assign an <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP address</a> to the layer's instances. For more information, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How
        /// to Edit a Layer</a>.
        /// </para>
        /// </summary>
        public bool? AutoAssignElasticIps
        {
            get { return this._autoAssignElasticIps; }
            set { this._autoAssignElasticIps = value; }
        }

        // Check to see if AutoAssignElasticIps property is set
        internal bool IsSetAutoAssignElasticIps()
        {
            return this._autoAssignElasticIps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoAssignPublicIps. 
        /// <para>
        /// For stacks that are running in a VPC, whether to automatically assign a public IP
        /// address to the layer's instances. For more information, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workinglayers-basics-edit.html">How
        /// to Edit a Layer</a>.
        /// </para>
        /// </summary>
        public bool? AutoAssignPublicIps
        {
            get { return this._autoAssignPublicIps; }
            set { this._autoAssignPublicIps = value; }
        }

        // Check to see if AutoAssignPublicIps property is set
        internal bool IsSetAutoAssignPublicIps()
        {
            return this._autoAssignPublicIps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLogsConfiguration. 
        /// <para>
        /// Specifies CloudWatch Logs configuration options for the layer. For more information,
        /// see <a>CloudWatchLogsLogStream</a>.
        /// </para>
        /// </summary>
        public CloudWatchLogsConfiguration CloudWatchLogsConfiguration
        {
            get { return this._cloudWatchLogsConfiguration; }
            set { this._cloudWatchLogsConfiguration = value; }
        }

        // Check to see if CloudWatchLogsConfiguration property is set
        internal bool IsSetCloudWatchLogsConfiguration()
        {
            return this._cloudWatchLogsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CustomInstanceProfileArn. 
        /// <para>
        /// The ARN of an IAM profile to be used for all of the layer's EC2 instances. For more
        /// information about IAM ARNs, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string CustomInstanceProfileArn
        {
            get { return this._customInstanceProfileArn; }
            set { this._customInstanceProfileArn = value; }
        }

        // Check to see if CustomInstanceProfileArn property is set
        internal bool IsSetCustomInstanceProfileArn()
        {
            return this._customInstanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomJson. 
        /// <para>
        /// A JSON-formatted string containing custom stack configuration and deployment attributes
        /// to be installed on the layer's instances. For more information, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook-json-override.html">
        /// Using Custom JSON</a>. 
        /// </para>
        /// </summary>
        public string CustomJson
        {
            get { return this._customJson; }
            set { this._customJson = value; }
        }

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this._customJson != null;
        }

        /// <summary>
        /// Gets and sets the property CustomRecipes. 
        /// <para>
        /// A <c>LayerCustomRecipes</c> object that specifies the layer's custom recipes.
        /// </para>
        /// </summary>
        public Recipes CustomRecipes
        {
            get { return this._customRecipes; }
            set { this._customRecipes = value; }
        }

        // Check to see if CustomRecipes property is set
        internal bool IsSetCustomRecipes()
        {
            return this._customRecipes != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSecurityGroupIds. 
        /// <para>
        /// An array containing the layer's custom security group IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomSecurityGroupIds
        {
            get { return this._customSecurityGroupIds; }
            set { this._customSecurityGroupIds = value; }
        }

        // Check to see if CustomSecurityGroupIds property is set
        internal bool IsSetCustomSecurityGroupIds()
        {
            return this._customSecurityGroupIds != null && (this._customSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableAutoHealing. 
        /// <para>
        /// Whether to disable auto healing for the layer.
        /// </para>
        /// </summary>
        public bool? EnableAutoHealing
        {
            get { return this._enableAutoHealing; }
            set { this._enableAutoHealing = value; }
        }

        // Check to see if EnableAutoHealing property is set
        internal bool IsSetEnableAutoHealing()
        {
            return this._enableAutoHealing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstallUpdatesOnBoot. 
        /// <para>
        /// Whether to install operating system and package updates when the instance boots. The
        /// default value is <c>true</c>. To control when updates are installed, set this value
        /// to <c>false</c>. You must then update your instances manually by using <a>CreateDeployment</a>
        /// to run the <c>update_dependencies</c> stack command or manually running <c>yum</c>
        /// (Amazon Linux) or <c>apt-get</c> (Ubuntu) on the instances. 
        /// </para>
        ///  <note> 
        /// <para>
        /// We strongly recommend using the default value of <c>true</c>, to ensure that your
        /// instances have the latest security updates.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? InstallUpdatesOnBoot
        {
            get { return this._installUpdatesOnBoot; }
            set { this._installUpdatesOnBoot = value; }
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this._installUpdatesOnBoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// The layer ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LayerId
        {
            get { return this._layerId; }
            set { this._layerId = value; }
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleEventConfiguration.
        /// </summary>
        public LifecycleEventConfiguration LifecycleEventConfiguration
        {
            get { return this._lifecycleEventConfiguration; }
            set { this._lifecycleEventConfiguration = value; }
        }

        // Check to see if LifecycleEventConfiguration property is set
        internal bool IsSetLifecycleEventConfiguration()
        {
            return this._lifecycleEventConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The layer name, which is used by the console. Layer names can be a maximum of 32 characters.
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
        /// Gets and sets the property Packages. 
        /// <para>
        /// An array of <c>Package</c> objects that describe the layer's packages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Packages
        {
            get { return this._packages; }
            set { this._packages = value; }
        }

        // Check to see if Packages property is set
        internal bool IsSetPackages()
        {
            return this._packages != null && (this._packages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Shortname. 
        /// <para>
        /// For custom layers only, use this parameter to specify the layer's short name, which
        /// is used internally by OpsWorks Stacks and by Chef. The short name is also used as
        /// the name for the directory where your app files are installed. It can have a maximum
        /// of 32 characters and must be in the following format: /\A[a-z0-9\-\_\.]+\Z/.
        /// </para>
        ///  
        /// <para>
        /// Built-in layer short names are defined by OpsWorks Stacks. For more information, see
        /// the <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/layers.html">Layer
        /// reference</a> in the OpsWorks User Guide. 
        /// </para>
        /// </summary>
        public string Shortname
        {
            get { return this._shortname; }
            set { this._shortname = value; }
        }

        // Check to see if Shortname property is set
        internal bool IsSetShortname()
        {
            return this._shortname != null;
        }

        /// <summary>
        /// Gets and sets the property UseEbsOptimizedInstances. 
        /// <para>
        /// Whether to use Amazon EBS-optimized instances.
        /// </para>
        /// </summary>
        public bool? UseEbsOptimizedInstances
        {
            get { return this._useEbsOptimizedInstances; }
            set { this._useEbsOptimizedInstances = value; }
        }

        // Check to see if UseEbsOptimizedInstances property is set
        internal bool IsSetUseEbsOptimizedInstances()
        {
            return this._useEbsOptimizedInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeConfigurations. 
        /// <para>
        /// A <c>VolumeConfigurations</c> object that describes the layer's Amazon EBS volumes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeConfiguration> VolumeConfigurations
        {
            get { return this._volumeConfigurations; }
            set { this._volumeConfigurations = value; }
        }

        // Check to see if VolumeConfigurations property is set
        internal bool IsSetVolumeConfigurations()
        {
            return this._volumeConfigurations != null && (this._volumeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}