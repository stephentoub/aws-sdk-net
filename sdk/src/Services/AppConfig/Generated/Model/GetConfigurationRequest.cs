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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the GetConfiguration operation.
    /// (Deprecated) Retrieves the latest deployed configuration.
    /// 
    ///  <important> 
    /// <para>
    /// Note the following important information.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// This API action is deprecated. Calls to receive configuration data should use the
    /// <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_StartConfigurationSession.html">StartConfigurationSession</a>
    /// and <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
    /// APIs instead. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetConfiguration</a> is a priced call. For more information, see <a href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class GetConfigurationRequest : AmazonAppConfigRequest
    {
        private string _application;
        private string _clientConfigurationVersion;
        private string _clientId;
        private string _configuration;
        private string _environment;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The application to get. Specify either the application name or the application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property ClientConfigurationVersion. 
        /// <para>
        /// The configuration version returned in the most recent <a>GetConfiguration</a> response.
        /// </para>
        ///  <important> 
        /// <para>
        /// AppConfig uses the value of the <c>ClientConfigurationVersion</c> parameter to identify
        /// the configuration version on your clients. If you don’t send <c>ClientConfigurationVersion</c>
        /// with each call to <a>GetConfiguration</a>, your clients receive the current configuration.
        /// You are charged each time your clients receive a configuration.
        /// </para>
        ///  
        /// <para>
        /// To avoid excess charges, we recommend you use the <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/StartConfigurationSession.html">StartConfigurationSession</a>
        /// and <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/GetLatestConfiguration.html">GetLatestConfiguration</a>
        /// APIs, which track the client configuration version on your behalf. If you choose to
        /// continue using <a>GetConfiguration</a>, we recommend that you include the <c>ClientConfigurationVersion</c>
        /// value with every call to <a>GetConfiguration</a>. The value to use for <c>ClientConfigurationVersion</c>
        /// comes from the <c>ConfigurationVersion</c> attribute returned by <a>GetConfiguration</a>
        /// when there is new or updated data, and should be saved for subsequent calls to <a>GetConfiguration</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about working with configurations, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/retrieving-feature-flags.html">Retrieving
        /// feature flags and configuration data in AppConfig</a> in the <i>AppConfig User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ClientConfigurationVersion
        {
            get { return this._clientConfigurationVersion; }
            set { this._clientConfigurationVersion = value; }
        }

        // Check to see if ClientConfigurationVersion property is set
        internal bool IsSetClientConfigurationVersion()
        {
            return this._clientConfigurationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The clientId parameter in the following command is a unique, user-specified ID to
        /// identify the client for the configuration. This ID enables AppConfig to deploy the
        /// configuration in intervals, as defined in the deployment strategy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration to get. Specify either the configuration name or the configuration
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment to get. Specify either the environment name or the environment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

    }
}