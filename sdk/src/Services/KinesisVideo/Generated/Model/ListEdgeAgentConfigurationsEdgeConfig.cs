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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// A description of a single stream's edge configuration.
    /// </summary>
    public partial class ListEdgeAgentConfigurationsEdgeConfig
    {
        private DateTime? _creationTime;
        private EdgeConfig _edgeConfig;
        private string _failedStatusDetails;
        private DateTime? _lastUpdatedTime;
        private string _streamARN;
        private string _streamName;
        private SyncStatus _syncStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the stream first created the edge config.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeConfig.
        /// </summary>
        public EdgeConfig EdgeConfig
        {
            get { return this._edgeConfig; }
            set { this._edgeConfig = value; }
        }

        // Check to see if EdgeConfig property is set
        internal bool IsSetEdgeConfig()
        {
            return this._edgeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FailedStatusDetails. 
        /// <para>
        /// A description of the generated failure status.
        /// </para>
        /// </summary>
        public string FailedStatusDetails
        {
            get { return this._failedStatusDetails; }
            set { this._failedStatusDetails = value; }
        }

        // Check to see if FailedStatusDetails property is set
        internal bool IsSetFailedStatusDetails()
        {
            return this._failedStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the stream last updated the edge config.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

        /// <summary>
        /// Gets and sets the property SyncStatus. 
        /// <para>
        /// The current sync status of the stream's edge configuration.
        /// </para>
        /// </summary>
        public SyncStatus SyncStatus
        {
            get { return this._syncStatus; }
            set { this._syncStatus = value; }
        }

        // Check to see if SyncStatus property is set
        internal bool IsSetSyncStatus()
        {
            return this._syncStatus != null;
        }

    }
}