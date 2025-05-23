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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Container for the parameters to the ListDataSets operation.
    /// Lists the data sets imported for a specific application. In Amazon Web Services Mainframe
    /// Modernization, data sets are associated with applications deployed on runtime environments.
    /// This is known as importing data sets. Currently, Amazon Web Services Mainframe Modernization
    /// can import data sets into catalogs using <a href="https://docs.aws.amazon.com/m2/latest/APIReference/API_CreateDataSetImportTask.html">CreateDataSetImportTask</a>.
    /// </summary>
    public partial class ListDataSetsRequest : AmazonMainframeModernizationRequest
    {
        private string _applicationId;
        private int? _maxResults;
        private string _nameFilter;
        private string _nextToken;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application for which you want to list the associated
        /// data sets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameFilter. 
        /// <para>
        /// Filter dataset name matching the specified pattern. Can use * and % as wild cards.
        /// </para>
        /// </summary>
        public string NameFilter
        {
            get { return this._nameFilter; }
            set { this._nameFilter = value; }
        }

        // Check to see if NameFilter property is set
        internal bool IsSetNameFilter()
        {
            return this._nameFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token returned from a previous call to this operation. This specifies
        /// the next item to return. To return to the beginning of the list, exclude this parameter.
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
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the data set name, which you can use to filter the list of data sets.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}