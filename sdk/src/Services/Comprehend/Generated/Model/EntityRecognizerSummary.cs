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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes the information about an entity recognizer and its versions.
    /// </summary>
    public partial class EntityRecognizerSummary
    {
        private DateTime? _latestVersionCreatedAt;
        private string _latestVersionName;
        private ModelStatus _latestVersionStatus;
        private int? _numberOfVersions;
        private string _recognizerName;

        /// <summary>
        /// Gets and sets the property LatestVersionCreatedAt. 
        /// <para>
        ///  The time that the latest entity recognizer version was submitted for processing.
        /// </para>
        /// </summary>
        public DateTime? LatestVersionCreatedAt
        {
            get { return this._latestVersionCreatedAt; }
            set { this._latestVersionCreatedAt = value; }
        }

        // Check to see if LatestVersionCreatedAt property is set
        internal bool IsSetLatestVersionCreatedAt()
        {
            return this._latestVersionCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestVersionName. 
        /// <para>
        ///  The version name you assigned to the latest entity recognizer version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string LatestVersionName
        {
            get { return this._latestVersionName; }
            set { this._latestVersionName = value; }
        }

        // Check to see if LatestVersionName property is set
        internal bool IsSetLatestVersionName()
        {
            return this._latestVersionName != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersionStatus. 
        /// <para>
        ///  Provides the status of the latest entity recognizer version.
        /// </para>
        /// </summary>
        public ModelStatus LatestVersionStatus
        {
            get { return this._latestVersionStatus; }
            set { this._latestVersionStatus = value; }
        }

        // Check to see if LatestVersionStatus property is set
        internal bool IsSetLatestVersionStatus()
        {
            return this._latestVersionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfVersions. 
        /// <para>
        ///  The number of versions you created.
        /// </para>
        /// </summary>
        public int? NumberOfVersions
        {
            get { return this._numberOfVersions; }
            set { this._numberOfVersions = value; }
        }

        // Check to see if NumberOfVersions property is set
        internal bool IsSetNumberOfVersions()
        {
            return this._numberOfVersions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecognizerName. 
        /// <para>
        ///  The name that you assigned the entity recognizer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string RecognizerName
        {
            get { return this._recognizerName; }
            set { this._recognizerName = value; }
        }

        // Check to see if RecognizerName property is set
        internal bool IsSetRecognizerName()
        {
            return this._recognizerName != null;
        }

    }
}