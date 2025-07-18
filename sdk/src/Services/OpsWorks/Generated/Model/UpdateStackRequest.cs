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
    /// Container for the parameters to the UpdateStack operation.
    /// Updates a specified stack.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateStackRequest : AmazonOpsWorksRequest
    {
        private string _agentVersion;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ChefConfiguration _chefConfiguration;
        private StackConfigurationManager _configurationManager;
        private Source _customCookbooksSource;
        private string _customJson;
        private string _defaultAvailabilityZone;
        private string _defaultInstanceProfileArn;
        private string _defaultOs;
        private RootDeviceType _defaultRootDeviceType;
        private string _defaultSshKeyName;
        private string _defaultSubnetId;
        private string _hostnameTheme;
        private string _name;
        private string _serviceRoleArn;
        private string _stackId;
        private bool? _useCustomCookbooks;
        private bool? _useOpsworksSecurityGroups;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The default OpsWorks Stacks agent version. You have the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto-update - Set this parameter to <c>LATEST</c>. OpsWorks Stacks automatically installs
        /// new agent versions on the stack's instances as soon as they are available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Fixed version - Set this parameter to your preferred agent version. To update the
        /// agent version, you must edit the stack configuration and specify a new version. OpsWorks
        /// Stacks installs that version on the stack's instances.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default setting is <c>LATEST</c>. To specify an agent version, you must use the
        /// complete version number, not the abbreviated number shown on the console. For a list
        /// of available agent version numbers, call <a>DescribeAgentVersions</a>. AgentVersion
        /// cannot be set to Chef 12.2.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can also specify an agent version when you create or update an instance, which
        /// overrides the stack's default setting.
        /// </para>
        ///  </note>
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more user-defined key-value pairs to be added to the stack attributes.
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
        /// Gets and sets the property ChefConfiguration. 
        /// <para>
        /// A <c>ChefConfiguration</c> object that specifies whether to enable Berkshelf and the
        /// Berkshelf version on Chef 11.10 stacks. For more information, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-creating.html">Create
        /// a New Stack</a>.
        /// </para>
        /// </summary>
        public ChefConfiguration ChefConfiguration
        {
            get { return this._chefConfiguration; }
            set { this._chefConfiguration = value; }
        }

        // Check to see if ChefConfiguration property is set
        internal bool IsSetChefConfiguration()
        {
            return this._chefConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationManager. 
        /// <para>
        /// The configuration manager. When you update a stack, we recommend that you use the
        /// configuration manager to specify the Chef version: 12, 11.10, or 11.4 for Linux stacks,
        /// or 12.2 for Windows stacks. The default value for Linux stacks is currently 12.
        /// </para>
        /// </summary>
        public StackConfigurationManager ConfigurationManager
        {
            get { return this._configurationManager; }
            set { this._configurationManager = value; }
        }

        // Check to see if ConfigurationManager property is set
        internal bool IsSetConfigurationManager()
        {
            return this._configurationManager != null;
        }

        /// <summary>
        /// Gets and sets the property CustomCookbooksSource. 
        /// <para>
        /// Contains the information required to retrieve an app or cookbook from a repository.
        /// For more information, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-creating.html">Adding
        /// Apps</a> or <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workingcookbook.html">Cookbooks
        /// and Recipes</a>.
        /// </para>
        /// </summary>
        public Source CustomCookbooksSource
        {
            get { return this._customCookbooksSource; }
            set { this._customCookbooksSource = value; }
        }

        // Check to see if CustomCookbooksSource property is set
        internal bool IsSetCustomCookbooksSource()
        {
            return this._customCookbooksSource != null;
        }

        /// <summary>
        /// Gets and sets the property CustomJson. 
        /// <para>
        /// A string that contains user-defined, custom JSON. It can be used to override the corresponding
        /// default stack configuration JSON values or to pass data to recipes. The string should
        /// be in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information about custom JSON, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html">Use
        /// Custom JSON to Modify the Stack Configuration Attributes</a>.
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
        /// Gets and sets the property DefaultAvailabilityZone. 
        /// <para>
        /// The stack's default Availability Zone, which must be in the stack's region. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>. If you also specify a value for <c>DefaultSubnetId</c>, the subnet
        /// must be in the same zone. For more information, see <a>CreateStack</a>. 
        /// </para>
        /// </summary>
        public string DefaultAvailabilityZone
        {
            get { return this._defaultAvailabilityZone; }
            set { this._defaultAvailabilityZone = value; }
        }

        // Check to see if DefaultAvailabilityZone property is set
        internal bool IsSetDefaultAvailabilityZone()
        {
            return this._defaultAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultInstanceProfileArn. 
        /// <para>
        /// The ARN of an IAM profile that is the default profile for all of the stack's EC2 instances.
        /// For more information about IAM ARNs, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string DefaultInstanceProfileArn
        {
            get { return this._defaultInstanceProfileArn; }
            set { this._defaultInstanceProfileArn = value; }
        }

        // Check to see if DefaultInstanceProfileArn property is set
        internal bool IsSetDefaultInstanceProfileArn()
        {
            return this._defaultInstanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultOs. 
        /// <para>
        /// The stack's operating system, which must be set to one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A supported Linux operating system: An Amazon Linux version, such as <c>Amazon Linux
        /// 2</c>, <c>Amazon Linux 2018.03</c>, <c>Amazon Linux 2017.09</c>, <c>Amazon Linux 2017.03</c>,
        /// <c>Amazon Linux 2016.09</c>, <c>Amazon Linux 2016.03</c>, <c>Amazon Linux 2015.09</c>,
        /// or <c>Amazon Linux 2015.03</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A supported Ubuntu operating system, such as <c>Ubuntu 18.04 LTS</c>, <c>Ubuntu 16.04
        /// LTS</c>, <c>Ubuntu 14.04 LTS</c>, or <c>Ubuntu 12.04 LTS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CentOS Linux 7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Red Hat Enterprise Linux 7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A supported Windows operating system, such as <c>Microsoft Windows Server 2012 R2
        /// Base</c>, <c>Microsoft Windows Server 2012 R2 with SQL Server Express</c>, <c>Microsoft
        /// Windows Server 2012 R2 with SQL Server Standard</c>, or <c>Microsoft Windows Server
        /// 2012 R2 with SQL Server Web</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A custom AMI: <c>Custom</c>. You specify the custom AMI you want to use when you create
        /// instances. For more information about how to use custom AMIs with OpsWorks, see <a
        /// href="https://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">Using
        /// Custom AMIs</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default option is the stack's current operating system. Not all operating systems
        /// are supported with all versions of Chef. For more information about supported operating
        /// systems, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">OpsWorks
        /// Stacks Operating Systems</a>.
        /// </para>
        /// </summary>
        public string DefaultOs
        {
            get { return this._defaultOs; }
            set { this._defaultOs = value; }
        }

        // Check to see if DefaultOs property is set
        internal bool IsSetDefaultOs()
        {
            return this._defaultOs != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRootDeviceType. 
        /// <para>
        /// The default root device type. This value is used by default for all instances in the
        /// stack, but you can override it when you create an instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage
        /// for the Root Device</a>.
        /// </para>
        /// </summary>
        public RootDeviceType DefaultRootDeviceType
        {
            get { return this._defaultRootDeviceType; }
            set { this._defaultRootDeviceType = value; }
        }

        // Check to see if DefaultRootDeviceType property is set
        internal bool IsSetDefaultRootDeviceType()
        {
            return this._defaultRootDeviceType != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSshKeyName. 
        /// <para>
        /// A default Amazon EC2 key-pair name. The default value is <c>none</c>. If you specify
        /// a key-pair name, OpsWorks Stacks installs the public key on the instance and you can
        /// use the private key with an SSH client to log in to the instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-ssh.html">
        /// Using SSH to Communicate with an Instance</a> and <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/security-ssh-access.html">
        /// Managing SSH Access</a>. You can override this setting by specifying a different key
        /// pair, or no key pair, when you <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html">
        /// create an instance</a>. 
        /// </para>
        /// </summary>
        public string DefaultSshKeyName
        {
            get { return this._defaultSshKeyName; }
            set { this._defaultSshKeyName = value; }
        }

        // Check to see if DefaultSshKeyName property is set
        internal bool IsSetDefaultSshKeyName()
        {
            return this._defaultSshKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSubnetId. 
        /// <para>
        /// The stack's default VPC subnet ID. This parameter is required if you specify a value
        /// for the <c>VpcId</c> parameter. All instances are launched into this subnet unless
        /// you specify otherwise when you create the instance. If you also specify a value for
        /// <c>DefaultAvailabilityZone</c>, the subnet must be in that zone. For information on
        /// default values and when this parameter is required, see the <c>VpcId</c> parameter
        /// description. 
        /// </para>
        /// </summary>
        public string DefaultSubnetId
        {
            get { return this._defaultSubnetId; }
            set { this._defaultSubnetId = value; }
        }

        // Check to see if DefaultSubnetId property is set
        internal bool IsSetDefaultSubnetId()
        {
            return this._defaultSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property HostnameTheme. 
        /// <para>
        /// The stack's new host name theme, with spaces replaced by underscores. The theme is
        /// used to generate host names for the stack's instances. By default, <c>HostnameTheme</c>
        /// is set to <c>Layer_Dependent</c>, which creates host names by appending integers to
        /// the layer's short name. The other themes are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Baked_Goods</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Clouds</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Europe_Cities</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fruits</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Greek_Deities_and_Titans</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Legendary_creatures_from_Japan</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Planets_and_Moons</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Roman_Deities</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Scottish_Islands</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>US_Cities</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Wild_Cats</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To obtain a generated host name, call <c>GetHostNameSuggestion</c>, which returns
        /// a host name based on the current theme.
        /// </para>
        /// </summary>
        public string HostnameTheme
        {
            get { return this._hostnameTheme; }
            set { this._hostnameTheme = value; }
        }

        // Check to see if HostnameTheme property is set
        internal bool IsSetHostnameTheme()
        {
            return this._hostnameTheme != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The stack's new name. Stack names can be a maximum of 64 characters.
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
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// Do not use this parameter. You cannot update a stack's service role.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property UseCustomCookbooks. 
        /// <para>
        /// Whether the stack uses custom cookbooks.
        /// </para>
        /// </summary>
        public bool? UseCustomCookbooks
        {
            get { return this._useCustomCookbooks; }
            set { this._useCustomCookbooks = value; }
        }

        // Check to see if UseCustomCookbooks property is set
        internal bool IsSetUseCustomCookbooks()
        {
            return this._useCustomCookbooks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseOpsworksSecurityGroups. 
        /// <para>
        /// Whether to associate the OpsWorks Stacks built-in security groups with the stack's
        /// layers.
        /// </para>
        ///  
        /// <para>
        /// OpsWorks Stacks provides a standard set of built-in security groups, one for each
        /// layer, which are associated with layers by default. <c>UseOpsworksSecurityGroups</c>
        /// allows you to provide your own custom security groups instead of using the built-in
        /// groups. <c>UseOpsworksSecurityGroups</c> has the following settings: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// True - OpsWorks Stacks automatically associates the appropriate built-in security
        /// group with each layer (default setting). You can associate additional security groups
        /// with a layer after you create it, but you cannot delete the built-in security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// False - OpsWorks Stacks does not associate built-in security groups with layers. You
        /// must create appropriate EC2 security groups and associate a security group with each
        /// layer that you create. However, you can still manually associate a built-in security
        /// group with a layer on. Custom security groups are required only for those layers that
        /// need custom settings.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-creating.html">Create
        /// a New Stack</a>.
        /// </para>
        /// </summary>
        public bool? UseOpsworksSecurityGroups
        {
            get { return this._useOpsworksSecurityGroups; }
            set { this._useOpsworksSecurityGroups = value; }
        }

        // Check to see if UseOpsworksSecurityGroups property is set
        internal bool IsSetUseOpsworksSecurityGroups()
        {
            return this._useOpsworksSecurityGroups.HasValue; 
        }

    }
}