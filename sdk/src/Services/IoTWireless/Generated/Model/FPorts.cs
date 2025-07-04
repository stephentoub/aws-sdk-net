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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// List of FPort assigned for different LoRaWAN application packages to use
    /// </summary>
    public partial class FPorts
    {
        private List<ApplicationConfig> _applications = AWSConfigs.InitializeCollections ? new List<ApplicationConfig>() : null;
        private int? _clockSync;
        private int? _fuota;
        private int? _multicast;
        private Positioning _positioning;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// Optional LoRaWAN application information, which can be used for geolocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApplicationConfig> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClockSync.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int? ClockSync
        {
            get { return this._clockSync; }
            set { this._clockSync = value; }
        }

        // Check to see if ClockSync property is set
        internal bool IsSetClockSync()
        {
            return this._clockSync.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Fuota.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int? Fuota
        {
            get { return this._fuota; }
            set { this._fuota = value; }
        }

        // Check to see if Fuota property is set
        internal bool IsSetFuota()
        {
            return this._fuota.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Multicast.
        /// </summary>
        [AWSProperty(Min=1, Max=223)]
        public int? Multicast
        {
            get { return this._multicast; }
            set { this._multicast = value; }
        }

        // Check to see if Multicast property is set
        internal bool IsSetMulticast()
        {
            return this._multicast.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// FPort values for the GNSS, stream, and ClockSync functions of the positioning information.
        /// </para>
        /// </summary>
        public Positioning Positioning
        {
            get { return this._positioning; }
            set { this._positioning = value; }
        }

        // Check to see if Positioning property is set
        internal bool IsSetPositioning()
        {
            return this._positioning != null;
        }

    }
}