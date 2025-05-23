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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex data type that includes the profile configurations and other options specified
    /// for field-level encryption.
    /// </summary>
    public partial class FieldLevelEncryption
    {
        private FieldLevelEncryptionConfig _fieldLevelEncryptionConfig;
        private string _id;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionConfig. 
        /// <para>
        /// A complex data type that includes the profile configurations specified for field-level
        /// encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldLevelEncryptionConfig FieldLevelEncryptionConfig
        {
            get { return this._fieldLevelEncryptionConfig; }
            set { this._fieldLevelEncryptionConfig = value; }
        }

        // Check to see if FieldLevelEncryptionConfig property is set
        internal bool IsSetFieldLevelEncryptionConfig()
        {
            return this._fieldLevelEncryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The configuration ID for a field-level encryption configuration which includes a set
        /// of profiles that specify certain selected data fields to be encrypted by specific
        /// public keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the field-level encryption configuration was changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}