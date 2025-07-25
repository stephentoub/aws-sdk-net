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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
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
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeletePhoneNumber operation.
    /// Moves phone numbers into the <b>Deletion queue</b>. Phone numbers must be disassociated
    /// from any users or Amazon Chime SDK Voice Connectors before they can be deleted. 
    /// 
    ///  
    /// <para>
    ///  Phone numbers remain in the <b>Deletion queue</b> for 7 days before they are deleted
    /// permanently. 
    /// </para>
    /// </summary>
    public partial class BatchDeletePhoneNumberRequest : AmazonChimeSDKVoiceRequest
    {
        private List<string> _phoneNumberIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PhoneNumberIds. 
        /// <para>
        /// List of phone number IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> PhoneNumberIds
        {
            get { return this._phoneNumberIds; }
            set { this._phoneNumberIds = value; }
        }

        // Check to see if PhoneNumberIds property is set
        internal bool IsSetPhoneNumberIds()
        {
            return this._phoneNumberIds != null && (this._phoneNumberIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}