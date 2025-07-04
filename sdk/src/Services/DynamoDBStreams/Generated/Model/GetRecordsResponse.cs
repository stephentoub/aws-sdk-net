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
 * Do not modify this file. This file is generated from the streams.dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// Represents the output of a <c>GetRecords</c> operation.
    /// </summary>
    public partial class GetRecordsResponse : AmazonWebServiceResponse
    {
        private string _nextShardIterator;
        private List<Record> _records = AWSConfigs.InitializeCollections ? new List<Record>() : null;

        /// <summary>
        /// Gets and sets the property NextShardIterator. 
        /// <para>
        /// The next position in the shard from which to start sequentially reading stream records.
        /// If set to <c>null</c>, the shard has been closed and the requested iterator will not
        /// return any more data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextShardIterator
        {
            get { return this._nextShardIterator; }
            set { this._nextShardIterator = value; }
        }

        // Check to see if NextShardIterator property is set
        internal bool IsSetNextShardIterator()
        {
            return this._nextShardIterator != null;
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The stream records from the shard, which were retrieved using the shard iterator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Record> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}