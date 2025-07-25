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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGlobalTable operation.
    /// Adds or removes replicas in the specified global table. The global table must already
    /// exist to be able to use this operation. Any replica to be added must be empty, have
    /// the same name as the global table, have the same key schema, have DynamoDB Streams
    /// enabled, and have the same provisioned and maximum write capacity units.
    /// 
    ///  <important> 
    /// <para>
    /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
    /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
    /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
    /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
    /// </para>
    ///  
    /// <para>
    /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
    /// the global table version you are using</a>. To update existing global tables from
    /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
    /// global tables</a>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    ///  If you are using global tables <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Version
    /// 2019.11.21</a> (Current) you can use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_UpdateTable.html">UpdateTable</a>
    /// instead. 
    /// </para>
    ///  
    /// <para>
    ///  Although you can use <c>UpdateGlobalTable</c> to add replicas and remove replicas
    /// in a single request, for simplicity we recommend that you issue separate requests
    /// for adding or removing replicas. 
    /// </para>
    ///  </note> 
    /// <para>
    ///  If global secondary indexes are specified, then the following conditions must also
    /// be met: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  The global secondary indexes must have the same name. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The global secondary indexes must have the same hash key and sort key (if present).
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The global secondary indexes must have the same provisioned and maximum write capacity
    /// units. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateGlobalTableRequest : AmazonDynamoDBRequest
    {
        private string _globalTableName;
        private List<ReplicaUpdate> _replicaUpdates = AWSConfigs.InitializeCollections ? new List<ReplicaUpdate>() : null;

        /// <summary>
        /// Gets and sets the property GlobalTableName. 
        /// <para>
        /// The global table name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string GlobalTableName
        {
            get { return this._globalTableName; }
            set { this._globalTableName = value; }
        }

        // Check to see if GlobalTableName property is set
        internal bool IsSetGlobalTableName()
        {
            return this._globalTableName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaUpdates. 
        /// <para>
        /// A list of Regions that should be added or removed from the global table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ReplicaUpdate> ReplicaUpdates
        {
            get { return this._replicaUpdates; }
            set { this._replicaUpdates = value; }
        }

        // Check to see if ReplicaUpdates property is set
        internal bool IsSetReplicaUpdates()
        {
            return this._replicaUpdates != null && (this._replicaUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}