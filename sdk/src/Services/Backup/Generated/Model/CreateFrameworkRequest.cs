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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFramework operation.
    /// Creates a framework with one or more controls. A framework is a collection of controls
    /// that you can use to evaluate your backup practices. By using pre-built customizable
    /// controls to define your policies, you can evaluate whether your backup practices comply
    /// with your policies and which resources are not yet in compliance.
    /// </summary>
    public partial class CreateFrameworkRequest : AmazonBackupRequest
    {
        private List<FrameworkControl> _frameworkControls = AWSConfigs.InitializeCollections ? new List<FrameworkControl>() : null;
        private string _frameworkDescription;
        private string _frameworkName;
        private Dictionary<string, string> _frameworkTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _idempotencyToken;

        /// <summary>
        /// Gets and sets the property FrameworkControls. 
        /// <para>
        /// The controls that make up the framework. Each control in the list has a name, input
        /// parameters, and scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FrameworkControl> FrameworkControls
        {
            get { return this._frameworkControls; }
            set { this._frameworkControls = value; }
        }

        // Check to see if FrameworkControls property is set
        internal bool IsSetFrameworkControls()
        {
            return this._frameworkControls != null && (this._frameworkControls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// An optional description of the framework with a maximum of 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FrameworkDescription
        {
            get { return this._frameworkDescription; }
            set { this._frameworkDescription = value; }
        }

        // Check to see if FrameworkDescription property is set
        internal bool IsSetFrameworkDescription()
        {
            return this._frameworkDescription != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        /// The unique name of the framework. The name must be between 1 and 256 characters, starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FrameworkName
        {
            get { return this._frameworkName; }
            set { this._frameworkName = value; }
        }

        // Check to see if FrameworkName property is set
        internal bool IsSetFrameworkName()
        {
            return this._frameworkName != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkTags. 
        /// <para>
        /// The tags to assign to the framework.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> FrameworkTags
        {
            get { return this._frameworkTags; }
            set { this._frameworkTags = value; }
        }

        // Check to see if FrameworkTags property is set
        internal bool IsSetFrameworkTags()
        {
            return this._frameworkTags != null && (this._frameworkTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>CreateFrameworkInput</c>. Retrying a successful request with the same
        /// idempotency token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

    }
}