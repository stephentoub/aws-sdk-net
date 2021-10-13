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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Updates to the configuration of the Glue Data Catalog that you use for SQL queries
    /// that you write in a Kinesis Data Analytics Studio notebook.
    /// </summary>
    public partial class GlueDataCatalogConfigurationUpdate
    {
        private string _databaseARNUpdate;

        /// <summary>
        /// Gets and sets the property DatabaseARNUpdate. 
        /// <para>
        /// The updated Amazon Resource Name (ARN) of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DatabaseARNUpdate
        {
            get { return this._databaseARNUpdate; }
            set { this._databaseARNUpdate = value; }
        }

        // Check to see if DatabaseARNUpdate property is set
        internal bool IsSetDatabaseARNUpdate()
        {
            return this._databaseARNUpdate != null;
        }

    }
}