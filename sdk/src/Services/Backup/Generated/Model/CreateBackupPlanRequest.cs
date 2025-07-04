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
    /// Container for the parameters to the CreateBackupPlan operation.
    /// Creates a backup plan using a backup plan name and backup rules. A backup plan is
    /// a document that contains information that Backup uses to schedule tasks that create
    /// recovery points for resources.
    /// 
    ///  
    /// <para>
    /// If you call <c>CreateBackupPlan</c> with a plan that already exists, you receive an
    /// <c>AlreadyExistsException</c> exception.
    /// </para>
    /// </summary>
    public partial class CreateBackupPlanRequest : AmazonBackupRequest
    {
        private BackupPlanInput _backupPlan;
        private Dictionary<string, string> _backupPlanTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _creatorRequestId;

        /// <summary>
        /// Gets and sets the property BackupPlan. 
        /// <para>
        /// The body of a backup plan. Includes a <c>BackupPlanName</c> and one or more sets of
        /// <c>Rules</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BackupPlanInput BackupPlan
        {
            get { return this._backupPlan; }
            set { this._backupPlan = value; }
        }

        // Check to see if BackupPlan property is set
        internal bool IsSetBackupPlan()
        {
            return this._backupPlan != null;
        }

        /// <summary>
        /// Gets and sets the property BackupPlanTags. 
        /// <para>
        /// The tags to assign to the backup plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> BackupPlanTags
        {
            get { return this._backupPlanTags; }
            set { this._backupPlanTags = value; }
        }

        // Check to see if BackupPlanTags property is set
        internal bool IsSetBackupPlanTags()
        {
            return this._backupPlanTags != null && (this._backupPlanTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// Identifies the request and allows failed requests to be retried without the risk of
        /// running the operation twice. If the request includes a <c>CreatorRequestId</c> that
        /// matches an existing backup plan, that plan is returned. This parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

    }
}