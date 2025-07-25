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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// If your output group type is HLS, DASH, or Microsoft Smooth, use these settings when
    /// doing DRM encryption with a SPEKE-compliant key provider. If your output group type
    /// is CMAF, use the SpekeKeyProviderCmaf settings instead.
    /// </summary>
    public partial class SpekeKeyProvider
    {
        private string _certificateArn;
        private EncryptionContractConfiguration _encryptionContractConfiguration;
        private string _resourceId;
        private List<string> _systemIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _url;

        /// <summary>
        /// Gets and sets the property CertificateArn. If you want your key provider to encrypt
        /// the content keys that it provides to MediaConvert, set up a certificate with a master
        /// key using AWS Certificate Manager. Specify the certificate's Amazon Resource Name
        /// (ARN) here.
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionContractConfiguration. Specify the SPEKE version,
        /// either v1.0 or v2.0, that MediaConvert uses when encrypting your output. For more
        /// information, see: https://docs.aws.amazon.com/speke/latest/documentation/speke-api-specification.html
        /// To use SPEKE v1.0: Leave blank. To use SPEKE v2.0: Specify a SPEKE v2.0 video preset
        /// and a SPEKE v2.0 audio preset.
        /// </summary>
        public EncryptionContractConfiguration EncryptionContractConfiguration
        {
            get { return this._encryptionContractConfiguration; }
            set { this._encryptionContractConfiguration = value; }
        }

        // Check to see if EncryptionContractConfiguration property is set
        internal bool IsSetEncryptionContractConfiguration()
        {
            return this._encryptionContractConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. Specify the resource ID that your SPEKE-compliant
        /// key provider uses to identify this content.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SystemIds. Relates to SPEKE implementation. DRM system
        /// identifiers. DASH output groups support a max of two system ids. HLS output groups
        /// support a max of 3 system ids. Other group types support one system id. See https://dashif.org/identifiers/content_protection/
        /// for more details.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SystemIds
        {
            get { return this._systemIds; }
            set { this._systemIds = value; }
        }

        // Check to see if SystemIds property is set
        internal bool IsSetSystemIds()
        {
            return this._systemIds != null && (this._systemIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Url. Specify the URL to the key server that your SPEKE-compliant
        /// DRM key provider uses to provide keys for encrypting your content.
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}