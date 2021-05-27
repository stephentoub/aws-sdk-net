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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// This is the response object from the CreateAlarmModel operation.
    /// </summary>
    public partial class CreateAlarmModelResponse : AmazonWebServiceResponse
    {
        private string _alarmModelArn;
        private string _alarmModelVersion;
        private DateTime? _creationTime;
        private DateTime? _lastUpdateTime;
        private AlarmModelVersionStatus _status;

        /// <summary>
        /// Gets and sets the property AlarmModelArn. 
        /// <para>
        /// The ARN of the alarm model. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string AlarmModelArn
        {
            get { return this._alarmModelArn; }
            set { this._alarmModelArn = value; }
        }

        // Check to see if AlarmModelArn property is set
        internal bool IsSetAlarmModelArn()
        {
            return this._alarmModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmModelVersion. 
        /// <para>
        /// The version of the alarm model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AlarmModelVersion
        {
            get { return this._alarmModelVersion; }
            set { this._alarmModelVersion = value; }
        }

        // Check to see if AlarmModelVersion property is set
        internal bool IsSetAlarmModelVersion()
        {
            return this._alarmModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the alarm model was created, in the Unix epoch format.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time the alarm model was last updated, in the Unix epoch format.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the alarm model. The status can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> - The alarm model is active and it's ready to evaluate data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVATING</code> - AWS IoT Events is activating your alarm model. Activating
        /// an alarm model can take up to a few minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INACTIVE</code> - The alarm model is inactive, so it isn't ready to evaluate
        /// data. Check your alarm model information and update the alarm model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - You couldn't create or update the alarm model. Check your alarm
        /// model information and try again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AlarmModelVersionStatus Status
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