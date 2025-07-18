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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateBackupVaultMpaApprovalTeam operation.
    /// Associates an MPA approval team with a backup vault.
    /// </summary>
    public partial class AssociateBackupVaultMpaApprovalTeamRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private string _mpaApprovalTeamArn;
        private string _requesterComment;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the backup vault to associate with the MPA approval team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property MpaApprovalTeamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the MPA approval team to associate with the backup
        /// vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MpaApprovalTeamArn
        {
            get { return this._mpaApprovalTeamArn; }
            set { this._mpaApprovalTeamArn = value; }
        }

        // Check to see if MpaApprovalTeamArn property is set
        internal bool IsSetMpaApprovalTeamArn()
        {
            return this._mpaApprovalTeamArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterComment. 
        /// <para>
        /// A comment provided by the requester explaining the association request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string RequesterComment
        {
            get { return this._requesterComment; }
            set { this._requesterComment = value; }
        }

        // Check to see if RequesterComment property is set
        internal bool IsSetRequesterComment()
        {
            return this._requesterComment != null;
        }

    }
}