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
    /// The tunnel options for a single VPN tunnel.
    /// </summary>
    public partial class VpnTunnelOptionsSpecification
    {
        private string _dpdTimeoutAction;
        private int? _dpdTimeoutSeconds;
        private bool? _enableTunnelLifecycleControl;
        private List<IKEVersionsRequestListValue> _ikeVersions = AWSConfigs.InitializeCollections ? new List<IKEVersionsRequestListValue>() : null;
        private VpnTunnelLogOptionsSpecification _logOptions;
        private List<Phase1DHGroupNumbersRequestListValue> _phase1DHGroupNumbers = AWSConfigs.InitializeCollections ? new List<Phase1DHGroupNumbersRequestListValue>() : null;
        private List<Phase1EncryptionAlgorithmsRequestListValue> _phase1EncryptionAlgorithms = AWSConfigs.InitializeCollections ? new List<Phase1EncryptionAlgorithmsRequestListValue>() : null;
        private List<Phase1IntegrityAlgorithmsRequestListValue> _phase1IntegrityAlgorithms = AWSConfigs.InitializeCollections ? new List<Phase1IntegrityAlgorithmsRequestListValue>() : null;
        private int? _phase1LifetimeSeconds;
        private List<Phase2DHGroupNumbersRequestListValue> _phase2DHGroupNumbers = AWSConfigs.InitializeCollections ? new List<Phase2DHGroupNumbersRequestListValue>() : null;
        private List<Phase2EncryptionAlgorithmsRequestListValue> _phase2EncryptionAlgorithms = AWSConfigs.InitializeCollections ? new List<Phase2EncryptionAlgorithmsRequestListValue>() : null;
        private List<Phase2IntegrityAlgorithmsRequestListValue> _phase2IntegrityAlgorithms = AWSConfigs.InitializeCollections ? new List<Phase2IntegrityAlgorithmsRequestListValue>() : null;
        private int? _phase2LifetimeSeconds;
        private string _preSharedKey;
        private int? _rekeyFuzzPercentage;
        private int? _rekeyMarginTimeSeconds;
        private int? _replayWindowSize;
        private string _startupAction;
        private string _tunnelInsideCidr;
        private string _tunnelInsideIpv6Cidr;

        /// <summary>
        /// Gets and sets the property DPDTimeoutAction. 
        /// <para>
        /// The action to take after DPD timeout occurs. Specify <c>restart</c> to restart the
        /// IKE initiation. Specify <c>clear</c> to end the IKE session.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>clear</c> | <c>none</c> | <c>restart</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>clear</c> 
        /// </para>
        /// </summary>
        public string DPDTimeoutAction
        {
            get { return this._dpdTimeoutAction; }
            set { this._dpdTimeoutAction = value; }
        }

        // Check to see if DPDTimeoutAction property is set
        internal bool IsSetDPDTimeoutAction()
        {
            return this._dpdTimeoutAction != null;
        }

        /// <summary>
        /// Gets and sets the property DPDTimeoutSeconds. 
        /// <para>
        /// The number of seconds after which a DPD timeout occurs.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value greater than or equal to 30.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>30</c> 
        /// </para>
        /// </summary>
        public int? DPDTimeoutSeconds
        {
            get { return this._dpdTimeoutSeconds; }
            set { this._dpdTimeoutSeconds = value; }
        }

        // Check to see if DPDTimeoutSeconds property is set
        internal bool IsSetDPDTimeoutSeconds()
        {
            return this._dpdTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableTunnelLifecycleControl. 
        /// <para>
        /// Turn on or off tunnel endpoint lifecycle control feature.
        /// </para>
        /// </summary>
        public bool? EnableTunnelLifecycleControl
        {
            get { return this._enableTunnelLifecycleControl; }
            set { this._enableTunnelLifecycleControl = value; }
        }

        // Check to see if EnableTunnelLifecycleControl property is set
        internal bool IsSetEnableTunnelLifecycleControl()
        {
            return this._enableTunnelLifecycleControl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IKEVersions. 
        /// <para>
        /// The IKE versions that are permitted for the VPN tunnel.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ikev1</c> | <c>ikev2</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IKEVersionsRequestListValue> IKEVersions
        {
            get { return this._ikeVersions; }
            set { this._ikeVersions = value; }
        }

        // Check to see if IKEVersions property is set
        internal bool IsSetIKEVersions()
        {
            return this._ikeVersions != null && (this._ikeVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogOptions. 
        /// <para>
        /// Options for logging VPN tunnel activity.
        /// </para>
        /// </summary>
        public VpnTunnelLogOptionsSpecification LogOptions
        {
            get { return this._logOptions; }
            set { this._logOptions = value; }
        }

        // Check to see if LogOptions property is set
        internal bool IsSetLogOptions()
        {
            return this._logOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Phase1DHGroupNumbers. 
        /// <para>
        /// One or more Diffie-Hellman group numbers that are permitted for the VPN tunnel for
        /// phase 1 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2</c> | <c>14</c> | <c>15</c> | <c>16</c> | <c>17</c> | <c>18</c>
        /// | <c>19</c> | <c>20</c> | <c>21</c> | <c>22</c> | <c>23</c> | <c>24</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1DHGroupNumbersRequestListValue> Phase1DHGroupNumbers
        {
            get { return this._phase1DHGroupNumbers; }
            set { this._phase1DHGroupNumbers = value; }
        }

        // Check to see if Phase1DHGroupNumbers property is set
        internal bool IsSetPhase1DHGroupNumbers()
        {
            return this._phase1DHGroupNumbers != null && (this._phase1DHGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase1EncryptionAlgorithms. 
        /// <para>
        /// One or more encryption algorithms that are permitted for the VPN tunnel for phase
        /// 1 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>AES128</c> | <c>AES256</c> | <c>AES128-GCM-16</c> | <c>AES256-GCM-16</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1EncryptionAlgorithmsRequestListValue> Phase1EncryptionAlgorithms
        {
            get { return this._phase1EncryptionAlgorithms; }
            set { this._phase1EncryptionAlgorithms = value; }
        }

        // Check to see if Phase1EncryptionAlgorithms property is set
        internal bool IsSetPhase1EncryptionAlgorithms()
        {
            return this._phase1EncryptionAlgorithms != null && (this._phase1EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase1IntegrityAlgorithms. 
        /// <para>
        /// One or more integrity algorithms that are permitted for the VPN tunnel for phase 1
        /// IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>SHA1</c> | <c>SHA2-256</c> | <c>SHA2-384</c> | <c>SHA2-512</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase1IntegrityAlgorithmsRequestListValue> Phase1IntegrityAlgorithms
        {
            get { return this._phase1IntegrityAlgorithms; }
            set { this._phase1IntegrityAlgorithms = value; }
        }

        // Check to see if Phase1IntegrityAlgorithms property is set
        internal bool IsSetPhase1IntegrityAlgorithms()
        {
            return this._phase1IntegrityAlgorithms != null && (this._phase1IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase1LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 1 of the IKE negotiation, in seconds.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 900 and 28,800.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>28800</c> 
        /// </para>
        /// </summary>
        public int? Phase1LifetimeSeconds
        {
            get { return this._phase1LifetimeSeconds; }
            set { this._phase1LifetimeSeconds = value; }
        }

        // Check to see if Phase1LifetimeSeconds property is set
        internal bool IsSetPhase1LifetimeSeconds()
        {
            return this._phase1LifetimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Phase2DHGroupNumbers. 
        /// <para>
        /// One or more Diffie-Hellman group numbers that are permitted for the VPN tunnel for
        /// phase 2 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2</c> | <c>5</c> | <c>14</c> | <c>15</c> | <c>16</c> | <c>17</c>
        /// | <c>18</c> | <c>19</c> | <c>20</c> | <c>21</c> | <c>22</c> | <c>23</c> | <c>24</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2DHGroupNumbersRequestListValue> Phase2DHGroupNumbers
        {
            get { return this._phase2DHGroupNumbers; }
            set { this._phase2DHGroupNumbers = value; }
        }

        // Check to see if Phase2DHGroupNumbers property is set
        internal bool IsSetPhase2DHGroupNumbers()
        {
            return this._phase2DHGroupNumbers != null && (this._phase2DHGroupNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase2EncryptionAlgorithms. 
        /// <para>
        /// One or more encryption algorithms that are permitted for the VPN tunnel for phase
        /// 2 IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>AES128</c> | <c>AES256</c> | <c>AES128-GCM-16</c> | <c>AES256-GCM-16</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2EncryptionAlgorithmsRequestListValue> Phase2EncryptionAlgorithms
        {
            get { return this._phase2EncryptionAlgorithms; }
            set { this._phase2EncryptionAlgorithms = value; }
        }

        // Check to see if Phase2EncryptionAlgorithms property is set
        internal bool IsSetPhase2EncryptionAlgorithms()
        {
            return this._phase2EncryptionAlgorithms != null && (this._phase2EncryptionAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase2IntegrityAlgorithms. 
        /// <para>
        /// One or more integrity algorithms that are permitted for the VPN tunnel for phase 2
        /// IKE negotiations.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>SHA1</c> | <c>SHA2-256</c> | <c>SHA2-384</c> | <c>SHA2-512</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Phase2IntegrityAlgorithmsRequestListValue> Phase2IntegrityAlgorithms
        {
            get { return this._phase2IntegrityAlgorithms; }
            set { this._phase2IntegrityAlgorithms = value; }
        }

        // Check to see if Phase2IntegrityAlgorithms property is set
        internal bool IsSetPhase2IntegrityAlgorithms()
        {
            return this._phase2IntegrityAlgorithms != null && (this._phase2IntegrityAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phase2LifetimeSeconds. 
        /// <para>
        /// The lifetime for phase 2 of the IKE negotiation, in seconds.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 900 and 3,600. The value must be less than the value
        /// for <c>Phase1LifetimeSeconds</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>3600</c> 
        /// </para>
        /// </summary>
        public int? Phase2LifetimeSeconds
        {
            get { return this._phase2LifetimeSeconds; }
            set { this._phase2LifetimeSeconds = value; }
        }

        // Check to see if Phase2LifetimeSeconds property is set
        internal bool IsSetPhase2LifetimeSeconds()
        {
            return this._phase2LifetimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreSharedKey. 
        /// <para>
        /// The pre-shared key (PSK) to establish initial authentication between the virtual private
        /// gateway and customer gateway.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Allowed characters are alphanumeric characters, periods (.), and underscores
        /// (_). Must be between 8 and 64 characters in length and cannot start with zero (0).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PreSharedKey
        {
            get { return this._preSharedKey; }
            set { this._preSharedKey = value; }
        }

        // Check to see if PreSharedKey property is set
        internal bool IsSetPreSharedKey()
        {
            return this._preSharedKey != null;
        }

        /// <summary>
        /// Gets and sets the property RekeyFuzzPercentage. 
        /// <para>
        /// The percentage of the rekey window (determined by <c>RekeyMarginTimeSeconds</c>) during
        /// which the rekey time is randomly selected.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 0 and 100.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>100</c> 
        /// </para>
        /// </summary>
        public int? RekeyFuzzPercentage
        {
            get { return this._rekeyFuzzPercentage; }
            set { this._rekeyFuzzPercentage = value; }
        }

        // Check to see if RekeyFuzzPercentage property is set
        internal bool IsSetRekeyFuzzPercentage()
        {
            return this._rekeyFuzzPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RekeyMarginTimeSeconds. 
        /// <para>
        /// The margin time, in seconds, before the phase 2 lifetime expires, during which the
        /// Amazon Web Services side of the VPN connection performs an IKE rekey. The exact time
        /// of the rekey is randomly selected based on the value for <c>RekeyFuzzPercentage</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 60 and half of <c>Phase2LifetimeSeconds</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>270</c> 
        /// </para>
        /// </summary>
        public int? RekeyMarginTimeSeconds
        {
            get { return this._rekeyMarginTimeSeconds; }
            set { this._rekeyMarginTimeSeconds = value; }
        }

        // Check to see if RekeyMarginTimeSeconds property is set
        internal bool IsSetRekeyMarginTimeSeconds()
        {
            return this._rekeyMarginTimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplayWindowSize. 
        /// <para>
        /// The number of packets in an IKE replay window.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value between 64 and 2048.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1024</c> 
        /// </para>
        /// </summary>
        public int? ReplayWindowSize
        {
            get { return this._replayWindowSize; }
            set { this._replayWindowSize = value; }
        }

        // Check to see if ReplayWindowSize property is set
        internal bool IsSetReplayWindowSize()
        {
            return this._replayWindowSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartupAction. 
        /// <para>
        /// The action to take when the establishing the tunnel for the VPN connection. By default,
        /// your customer gateway device must initiate the IKE negotiation and bring up the tunnel.
        /// Specify <c>start</c> for Amazon Web Services to initiate the IKE negotiation.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>add</c> | <c>start</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>add</c> 
        /// </para>
        /// </summary>
        public string StartupAction
        {
            get { return this._startupAction; }
            set { this._startupAction = value; }
        }

        // Check to see if StartupAction property is set
        internal bool IsSetStartupAction()
        {
            return this._startupAction != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelInsideCidr. 
        /// <para>
        /// The range of inside IPv4 addresses for the tunnel. Any specified CIDR blocks must
        /// be unique across all VPN connections that use the same virtual private gateway. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: A size /30 CIDR block from the <c>169.254.0.0/16</c> range. The following
        /// CIDR blocks are reserved and cannot be used:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>169.254.0.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.1.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.2.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.3.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.4.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.5.0/30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>169.254.169.252/30</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TunnelInsideCidr
        {
            get { return this._tunnelInsideCidr; }
            set { this._tunnelInsideCidr = value; }
        }

        // Check to see if TunnelInsideCidr property is set
        internal bool IsSetTunnelInsideCidr()
        {
            return this._tunnelInsideCidr != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelInsideIpv6Cidr. 
        /// <para>
        /// The range of inside IPv6 addresses for the tunnel. Any specified CIDR blocks must
        /// be unique across all VPN connections that use the same transit gateway.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A size /126 CIDR block from the local <c>fd00::/8</c> range.
        /// </para>
        /// </summary>
        public string TunnelInsideIpv6Cidr
        {
            get { return this._tunnelInsideIpv6Cidr; }
            set { this._tunnelInsideIpv6Cidr = value; }
        }

        // Check to see if TunnelInsideIpv6Cidr property is set
        internal bool IsSetTunnelInsideIpv6Cidr()
        {
            return this._tunnelInsideIpv6Cidr != null;
        }

    }
}