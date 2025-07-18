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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings for the action to deactivate the image in a specific layer.
    /// </summary>
    public partial class StaticImageOutputDeactivateScheduleActionSettings
    {
        private int? _fadeOut;
        private int? _layer;
        private List<string> _outputNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FadeOut. The time in milliseconds for the image to fade
        /// out. Default is 0 (no fade-out).
        /// </summary>
        [AWSProperty(Min=0)]
        public int? FadeOut
        {
            get { return this._fadeOut; }
            set { this._fadeOut = value; }
        }

        // Check to see if FadeOut property is set
        internal bool IsSetFadeOut()
        {
            return this._fadeOut.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Layer. The image overlay layer to deactivate, 0 to 7. Default
        /// is 0.
        /// </summary>
        [AWSProperty(Min=0, Max=7)]
        public int? Layer
        {
            get { return this._layer; }
            set { this._layer = value; }
        }

        // Check to see if Layer property is set
        internal bool IsSetLayer()
        {
            return this._layer.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputNames. The name(s) of the output(s) the deactivation
        /// should apply to.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> OutputNames
        {
            get { return this._outputNames; }
            set { this._outputNames = value; }
        }

        // Check to see if OutputNames property is set
        internal bool IsSetOutputNames()
        {
            return this._outputNames != null && (this._outputNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}