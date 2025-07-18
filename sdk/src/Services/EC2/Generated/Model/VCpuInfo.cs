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
    /// Describes the vCPU configurations for the instance type.
    /// </summary>
    public partial class VCpuInfo
    {
        private int? _defaultCores;
        private int? _defaultThreadsPerCore;
        private int? _defaultVCpus;
        private List<int> _validCores = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<int> _validThreadsPerCore = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property DefaultCores. 
        /// <para>
        /// The default number of cores for the instance type.
        /// </para>
        /// </summary>
        public int? DefaultCores
        {
            get { return this._defaultCores; }
            set { this._defaultCores = value; }
        }

        // Check to see if DefaultCores property is set
        internal bool IsSetDefaultCores()
        {
            return this._defaultCores.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultThreadsPerCore. 
        /// <para>
        /// The default number of threads per core for the instance type.
        /// </para>
        /// </summary>
        public int? DefaultThreadsPerCore
        {
            get { return this._defaultThreadsPerCore; }
            set { this._defaultThreadsPerCore = value; }
        }

        // Check to see if DefaultThreadsPerCore property is set
        internal bool IsSetDefaultThreadsPerCore()
        {
            return this._defaultThreadsPerCore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultVCpus. 
        /// <para>
        /// The default number of vCPUs for the instance type.
        /// </para>
        /// </summary>
        public int? DefaultVCpus
        {
            get { return this._defaultVCpus; }
            set { this._defaultVCpus = value; }
        }

        // Check to see if DefaultVCpus property is set
        internal bool IsSetDefaultVCpus()
        {
            return this._defaultVCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidCores. 
        /// <para>
        /// The valid number of cores that can be configured for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> ValidCores
        {
            get { return this._validCores; }
            set { this._validCores = value; }
        }

        // Check to see if ValidCores property is set
        internal bool IsSetValidCores()
        {
            return this._validCores != null && (this._validCores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidThreadsPerCore. 
        /// <para>
        /// The valid number of threads per core that can be configured for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> ValidThreadsPerCore
        {
            get { return this._validThreadsPerCore; }
            set { this._validThreadsPerCore = value; }
        }

        // Check to see if ValidThreadsPerCore property is set
        internal bool IsSetValidThreadsPerCore()
        {
            return this._validThreadsPerCore != null && (this._validThreadsPerCore.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}