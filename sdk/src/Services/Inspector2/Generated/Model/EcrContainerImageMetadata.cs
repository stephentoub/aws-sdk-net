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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Information on the Amazon ECR image metadata associated with a finding.
    /// </summary>
    public partial class EcrContainerImageMetadata
    {
        private DateTime? _imagePulledAt;
        private List<string> _tags = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ImagePulledAt. 
        /// <para>
        /// The date an image was last pulled at.
        /// </para>
        /// </summary>
        public DateTime? ImagePulledAt
        {
            get { return this._imagePulledAt; }
            set { this._imagePulledAt = value; }
        }

        // Check to see if ImagePulledAt property is set
        internal bool IsSetImagePulledAt()
        {
            return this._imagePulledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the Amazon ECR image metadata.
        /// </para>
        /// </summary>
        public List<string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}