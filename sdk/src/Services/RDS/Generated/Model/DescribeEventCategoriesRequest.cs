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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventCategories operation.
    /// Displays a list of categories for all event source types, or, if specified, for a
    /// specified source type. You can also see this list in the "Amazon RDS event categories
    /// and event messages" section of the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Messages.html">
    /// <i>Amazon RDS User Guide</i> </a> or the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Messages.html">
    /// <i>Amazon Aurora User Guide</i> </a>.
    /// </summary>
    public partial class DescribeEventCategoriesRequest : AmazonRDSRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _sourceType;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter isn't currently supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of source that is generating the events. For RDS Proxy events, specify <c>db-proxy</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>db-instance</c> | <c>db-cluster</c> | <c>db-parameter-group</c> |
        /// <c>db-security-group</c> | <c>db-snapshot</c> | <c>db-cluster-snapshot</c> | <c>db-proxy</c>
        /// 
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}