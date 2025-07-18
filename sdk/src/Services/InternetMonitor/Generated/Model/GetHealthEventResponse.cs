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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
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
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// This is the response object from the GetHealthEvent operation.
    /// </summary>
    public partial class GetHealthEventResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DateTime? _endedAt;
        private string _eventArn;
        private string _eventId;
        private double? _healthScoreThreshold;
        private List<ImpactedLocation> _impactedLocations = AWSConfigs.InitializeCollections ? new List<ImpactedLocation>() : null;
        private HealthEventImpactType _impactType;
        private DateTime? _lastUpdatedAt;
        private double? _percentOfTotalTrafficImpacted;
        private DateTime? _startedAt;
        private HealthEventStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when a health event was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time when a health event was resolved. If the health event is still active, the
        /// end time is not set.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EventArn
        {
            get { return this._eventArn; }
            set { this._eventArn = value; }
        }

        // Check to see if EventArn property is set
        internal bool IsSetEventArn()
        {
            return this._eventArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The internally-generated identifier of a health event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property HealthScoreThreshold. 
        /// <para>
        /// The threshold percentage for a health score that determines, along with other configuration
        /// information, when Internet Monitor creates a health event when there's an internet
        /// issue that affects your application end users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? HealthScoreThreshold
        {
            get { return this._healthScoreThreshold; }
            set { this._healthScoreThreshold = value; }
        }

        // Check to see if HealthScoreThreshold property is set
        internal bool IsSetHealthScoreThreshold()
        {
            return this._healthScoreThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImpactedLocations. 
        /// <para>
        /// The locations affected by a health event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ImpactedLocation> ImpactedLocations
        {
            get { return this._impactedLocations; }
            set { this._impactedLocations = value; }
        }

        // Check to see if ImpactedLocations property is set
        internal bool IsSetImpactedLocations()
        {
            return this._impactedLocations != null && (this._impactedLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactType. 
        /// <para>
        /// The type of impairment of a specific health event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthEventImpactType ImpactType
        {
            get { return this._impactType; }
            set { this._impactType = value; }
        }

        // Check to see if ImpactType property is set
        internal bool IsSetImpactType()
        {
            return this._impactType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time when a health event was last updated or recalculated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentOfTotalTrafficImpacted. 
        /// <para>
        /// The impact on total traffic that a health event has, in increased latency or reduced
        /// availability. This is the percentage of how much latency has increased or availability
        /// has decreased during the event, compared to what is typical for traffic from this
        /// client location to the Amazon Web Services location using this client network.
        /// </para>
        /// </summary>
        public double? PercentOfTotalTrafficImpacted
        {
            get { return this._percentOfTotalTrafficImpacted; }
            set { this._percentOfTotalTrafficImpacted = value; }
        }

        // Check to see if PercentOfTotalTrafficImpacted property is set
        internal bool IsSetPercentOfTotalTrafficImpacted()
        {
            return this._percentOfTotalTrafficImpacted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time when a health event started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a health event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthEventStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}