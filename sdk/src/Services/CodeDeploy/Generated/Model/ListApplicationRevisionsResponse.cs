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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a <c>ListApplicationRevisions</c> operation.
    /// </summary>
    public partial class ListApplicationRevisionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RevisionLocation> _revisions = AWSConfigs.InitializeCollections ? new List<RevisionLocation>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a large amount of information is returned, an identifier is also returned. It can
        /// be used in a subsequent list application revisions call to return the next set of
        /// application revisions in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Revisions. 
        /// <para>
        /// A list of locations that contain the matching revisions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RevisionLocation> Revisions
        {
            get { return this._revisions; }
            set { this._revisions = value; }
        }

        // Check to see if Revisions property is set
        internal bool IsSetRevisions()
        {
            return this._revisions != null && (this._revisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}