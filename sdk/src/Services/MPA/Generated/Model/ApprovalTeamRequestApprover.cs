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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for an approver.
    /// </summary>
    public partial class ApprovalTeamRequestApprover
    {
        private string _primaryIdentityId;
        private string _primaryIdentitySourceArn;

        /// <summary>
        /// Gets and sets the property PrimaryIdentityId. 
        /// <para>
        /// ID for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PrimaryIdentityId
        {
            get { return this._primaryIdentityId; }
            set { this._primaryIdentityId = value; }
        }

        // Check to see if PrimaryIdentityId property is set
        internal bool IsSetPrimaryIdentityId()
        {
            return this._primaryIdentityId != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryIdentitySourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the identity source. The identity source manages the
        /// user authentication for approvers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string PrimaryIdentitySourceArn
        {
            get { return this._primaryIdentitySourceArn; }
            set { this._primaryIdentitySourceArn = value; }
        }

        // Check to see if PrimaryIdentitySourceArn property is set
        internal bool IsSetPrimaryIdentitySourceArn()
        {
            return this._primaryIdentitySourceArn != null;
        }

    }
}