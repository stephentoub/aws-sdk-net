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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a control's enablement status in a specified standard.
    /// </summary>
    public partial class StandardsControlAssociationDetail
    {
        private AssociationStatus _associationStatus;
        private List<string> _relatedRequirements = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _securityControlArn;
        private string _securityControlId;
        private string _standardsArn;
        private List<string> _standardsControlArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _standardsControlDescription;
        private string _standardsControlTitle;
        private DateTime? _updatedAt;
        private string _updatedReason;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        ///  Specifies whether a control is enabled or disabled in a specified standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationStatus AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedRequirements. 
        /// <para>
        ///  The requirement that underlies a control in the compliance framework related to the
        /// standard. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RelatedRequirements
        {
            get { return this._relatedRequirements; }
            set { this._relatedRequirements = value; }
        }

        // Check to see if RelatedRequirements property is set
        internal bool IsSetRelatedRequirements()
        {
            return this._relatedRequirements != null && (this._relatedRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityControlArn. 
        /// <para>
        ///  The ARN of a security control across standards, such as <c>arn:aws:securityhub:eu-central-1:123456789012:security-control/S3.1</c>.
        /// This parameter doesn't mention a specific standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityControlArn
        {
            get { return this._securityControlArn; }
            set { this._securityControlArn = value; }
        }

        // Check to see if SecurityControlArn property is set
        internal bool IsSetSecurityControlArn()
        {
            return this._securityControlArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The unique identifier of a security control across standards. Values for this field
        /// typically consist of an Amazon Web Services service name and a number, such as APIGateway.3.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityControlId
        {
            get { return this._securityControlId; }
            set { this._securityControlId = value; }
        }

        // Check to see if SecurityControlId property is set
        internal bool IsSetSecurityControlId()
        {
            return this._securityControlId != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a security standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StandardsArn
        {
            get { return this._standardsArn; }
            set { this._standardsArn = value; }
        }

        // Check to see if StandardsArn property is set
        internal bool IsSetStandardsArn()
        {
            return this._standardsArn != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsControlArns. 
        /// <para>
        ///  Provides the input parameter that Security Hub uses to call the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_UpdateStandardsControl.html">UpdateStandardsControl</a>
        /// API. This API can be used to enable or disable a control in a specified standard.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StandardsControlArns
        {
            get { return this._standardsControlArns; }
            set { this._standardsControlArns = value; }
        }

        // Check to see if StandardsControlArns property is set
        internal bool IsSetStandardsControlArns()
        {
            return this._standardsControlArns != null && (this._standardsControlArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StandardsControlDescription. 
        /// <para>
        ///  The description of a control. This typically summarizes how Security Hub evaluates
        /// the control and the conditions under which it produces a failed finding. This parameter
        /// may reference a specific standard. 
        /// </para>
        /// </summary>
        public string StandardsControlDescription
        {
            get { return this._standardsControlDescription; }
            set { this._standardsControlDescription = value; }
        }

        // Check to see if StandardsControlDescription property is set
        internal bool IsSetStandardsControlDescription()
        {
            return this._standardsControlDescription != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsControlTitle. 
        /// <para>
        ///  The title of a control. This field may reference a specific standard. 
        /// </para>
        /// </summary>
        public string StandardsControlTitle
        {
            get { return this._standardsControlTitle; }
            set { this._standardsControlTitle = value; }
        }

        // Check to see if StandardsControlTitle property is set
        internal bool IsSetStandardsControlTitle()
        {
            return this._standardsControlTitle != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The time at which the enablement status of the control in the specified standard
        /// was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedReason. 
        /// <para>
        ///  The reason for updating the enablement status of a control in a specified standard.
        /// 
        /// </para>
        /// </summary>
        public string UpdatedReason
        {
            get { return this._updatedReason; }
            set { this._updatedReason = value; }
        }

        // Check to see if UpdatedReason property is set
        internal bool IsSetUpdatedReason()
        {
            return this._updatedReason != null;
        }

    }
}