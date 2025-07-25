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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the PutAttributeMapping operation.
    /// Put an entry in the attribute mapping rules that will be enforced by a given profile.
    /// A mapping specifies a certificate field and one or more specifiers that have contextual
    /// meanings.
    /// </summary>
    public partial class PutAttributeMappingRequest : AmazonIAMRolesAnywhereRequest
    {
        private CertificateField _certificateField;
        private List<MappingRule> _mappingRules = AWSConfigs.InitializeCollections ? new List<MappingRule>() : null;
        private string _profileId;

        /// <summary>
        /// Gets and sets the property CertificateField. 
        /// <para>
        /// Fields (x509Subject, x509Issuer and x509SAN) within X.509 certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateField CertificateField
        {
            get { return this._certificateField; }
            set { this._certificateField = value; }
        }

        // Check to see if CertificateField property is set
        internal bool IsSetCertificateField()
        {
            return this._certificateField != null;
        }

        /// <summary>
        /// Gets and sets the property MappingRules. 
        /// <para>
        /// A list of mapping entries for every supported specifier or sub-field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MappingRule> MappingRules
        {
            get { return this._mappingRules; }
            set { this._mappingRules = value; }
        }

        // Check to see if MappingRules property is set
        internal bool IsSetMappingRules()
        {
            return this._mappingRules != null && (this._mappingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

    }
}