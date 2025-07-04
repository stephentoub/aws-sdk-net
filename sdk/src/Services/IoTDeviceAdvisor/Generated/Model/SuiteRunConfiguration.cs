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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
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
namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Gets suite run configuration.
    /// </summary>
    public partial class SuiteRunConfiguration
    {
        private bool? _parallelRun;
        private DeviceUnderTest _primaryDevice;
        private List<string> _selectedTestList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ParallelRun. 
        /// <para>
        /// TRUE if multiple test suites run in parallel.
        /// </para>
        /// </summary>
        public bool? ParallelRun
        {
            get { return this._parallelRun; }
            set { this._parallelRun = value; }
        }

        // Check to see if ParallelRun property is set
        internal bool IsSetParallelRun()
        {
            return this._parallelRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrimaryDevice. 
        /// <para>
        /// Sets the primary device for the test suite run. This requires a thing ARN or a certificate
        /// ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceUnderTest PrimaryDevice
        {
            get { return this._primaryDevice; }
            set { this._primaryDevice = value; }
        }

        // Check to see if PrimaryDevice property is set
        internal bool IsSetPrimaryDevice()
        {
            return this._primaryDevice != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedTestList. 
        /// <para>
        /// Sets test case list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SelectedTestList
        {
            get { return this._selectedTestList; }
            set { this._selectedTestList = value; }
        }

        // Check to see if SelectedTestList property is set
        internal bool IsSetSelectedTestList()
        {
            return this._selectedTestList != null && (this._selectedTestList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}