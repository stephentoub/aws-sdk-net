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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetWorkUnitResults operation.
    /// Returns the work units resulting from the query. Work units can be executed in any
    /// order and in parallel.
    /// </summary>
    public partial class GetWorkUnitResultsRequest : AmazonLakeFormationRequest
    {
        private string _queryId;
        private long? _workUnitId;
        private string _workUnitToken;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the plan query operation for which to get results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkUnitId. 
        /// <para>
        /// The work unit ID for which to get results. Value generated by enumerating <c>WorkUnitIdMin</c>
        /// to <c>WorkUnitIdMax</c> (inclusive) from the <c>WorkUnitRange</c> in the output of
        /// <c>GetWorkUnits</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? WorkUnitId
        {
            get { return this._workUnitId; }
            set { this._workUnitId = value; }
        }

        // Check to see if WorkUnitId property is set
        internal bool IsSetWorkUnitId()
        {
            return this._workUnitId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkUnitToken. 
        /// <para>
        /// A work token used to query the execution service. Token output from <c>GetWorkUnits</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string WorkUnitToken
        {
            get { return this._workUnitToken; }
            set { this._workUnitToken = value; }
        }

        // Check to see if WorkUnitToken property is set
        internal bool IsSetWorkUnitToken()
        {
            return this._workUnitToken != null;
        }

    }
}