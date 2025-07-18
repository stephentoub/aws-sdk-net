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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The information about job driver for Spark submit.
    /// </summary>
    public partial class SparkSubmitJobDriver
    {
        private string _entryPoint;
        private List<string> _entryPointArguments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sparkSubmitParameters;

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The entry point of job application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this._entryPoint != null;
        }

        /// <summary>
        /// Gets and sets the property EntryPointArguments. 
        /// <para>
        /// The arguments for job application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntryPointArguments
        {
            get { return this._entryPointArguments; }
            set { this._entryPointArguments = value; }
        }

        // Check to see if EntryPointArguments property is set
        internal bool IsSetEntryPointArguments()
        {
            return this._entryPointArguments != null && (this._entryPointArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparkSubmitParameters. 
        /// <para>
        /// The Spark submit parameters that are used for job runs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=102400)]
        public string SparkSubmitParameters
        {
            get { return this._sparkSubmitParameters; }
            set { this._sparkSubmitParameters = value; }
        }

        // Check to see if SparkSubmitParameters property is set
        internal bool IsSetSparkSubmitParameters()
        {
            return this._sparkSubmitParameters != null;
        }

    }
}