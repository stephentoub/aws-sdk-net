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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the PutPartnerEvents operation.
    /// This is used by SaaS partners to write events to a customer's partner event bus. Amazon
    /// Web Services customers do not use this operation.
    /// 
    ///  
    /// <para>
    /// For information on calculating event batch size, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-putevent-size.html">Calculating
    /// EventBridge PutEvents event entry size</a> in the <i>EventBridge User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutPartnerEventsRequest : AmazonEventBridgeRequest
    {
        private List<PutPartnerEventsRequestEntry> _entries = AWSConfigs.InitializeCollections ? new List<PutPartnerEventsRequestEntry>() : null;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of events to write to the event bus.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<PutPartnerEventsRequestEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}