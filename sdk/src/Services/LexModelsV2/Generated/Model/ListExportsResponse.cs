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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the ListExports operation.
    /// </summary>
    public partial class ListExportsResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _botVersion;
        private List<ExportSummary> _exportSummaries = AWSConfigs.InitializeCollections ? new List<ExportSummary>() : null;
        private string _localeId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier assigned to the bot by Amazon Lex.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExportSummaries. 
        /// <para>
        /// Summary information for the exports that meet the filter criteria specified in the
        /// request. The length of the list is specified in the <c>maxResults</c> parameter. If
        /// there are more exports available, the <c>nextToken</c> field contains a token to get
        /// the next page of results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExportSummary> ExportSummaries
        {
            get { return this._exportSummaries; }
            set { this._exportSummaries = value; }
        }

        // Check to see if ExportSummaries property is set
        internal bool IsSetExportSummaries()
        {
            return this._exportSummaries != null && (this._exportSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale specified in the request.
        /// </para>
        /// </summary>
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates whether there are more results to return in a response to the
        /// <c>ListExports</c> operation. If the <c>nextToken</c> field is present, you send the
        /// contents as the <c>nextToken</c> parameter of a <c>ListExports</c> operation request
        /// to get the next page of results.
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

    }
}