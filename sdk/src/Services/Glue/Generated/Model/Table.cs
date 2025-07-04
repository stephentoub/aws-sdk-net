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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Represents a collection of related data organized in columns and rows.
    /// </summary>
    public partial class Table
    {
        private string _catalogId;
        private string _createdBy;
        private DateTime? _createTime;
        private string _databaseName;
        private string _description;
        private FederatedTable _federatedTable;
        private bool? _isMultiDialectView;
        private bool? _isRegisteredWithLakeFormation;
        private DateTime? _lastAccessTime;
        private DateTime? _lastAnalyzedTime;
        private string _name;
        private string _owner;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Column> _partitionKeys = AWSConfigs.InitializeCollections ? new List<Column>() : null;
        private int? _retention;
        private TableStatus _status;
        private StorageDescriptor _storageDescriptor;
        private string _tableType;
        private TableIdentifier _targetTable;
        private DateTime? _updateTime;
        private string _versionId;
        private ViewDefinition _viewDefinition;
        private string _viewExpandedText;
        private string _viewOriginalText;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the table resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The person or entity who created the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the table definition was created in the Data Catalog.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database where the table metadata resides. For Hive compatibility,
        /// this must be all lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FederatedTable. 
        /// <para>
        /// A <c>FederatedTable</c> structure that references an entity outside the Glue Data
        /// Catalog.
        /// </para>
        /// </summary>
        public FederatedTable FederatedTable
        {
            get { return this._federatedTable; }
            set { this._federatedTable = value; }
        }

        // Check to see if FederatedTable property is set
        internal bool IsSetFederatedTable()
        {
            return this._federatedTable != null;
        }

        /// <summary>
        /// Gets and sets the property IsMultiDialectView. 
        /// <para>
        /// Specifies whether the view supports the SQL dialects of one or more different query
        /// engines and can therefore be read by those engines.
        /// </para>
        /// </summary>
        public bool? IsMultiDialectView
        {
            get { return this._isMultiDialectView; }
            set { this._isMultiDialectView = value; }
        }

        // Check to see if IsMultiDialectView property is set
        internal bool IsSetIsMultiDialectView()
        {
            return this._isMultiDialectView.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsRegisteredWithLakeFormation. 
        /// <para>
        /// Indicates whether the table has been registered with Lake Formation.
        /// </para>
        /// </summary>
        public bool? IsRegisteredWithLakeFormation
        {
            get { return this._isRegisteredWithLakeFormation; }
            set { this._isRegisteredWithLakeFormation = value; }
        }

        // Check to see if IsRegisteredWithLakeFormation property is set
        internal bool IsSetIsRegisteredWithLakeFormation()
        {
            return this._isRegisteredWithLakeFormation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAccessTime. 
        /// <para>
        /// The last time that the table was accessed. This is usually taken from HDFS, and might
        /// not be reliable.
        /// </para>
        /// </summary>
        public DateTime? LastAccessTime
        {
            get { return this._lastAccessTime; }
            set { this._lastAccessTime = value; }
        }

        // Check to see if LastAccessTime property is set
        internal bool IsSetLastAccessTime()
        {
            return this._lastAccessTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAnalyzedTime. 
        /// <para>
        /// The last time that column statistics were computed for this table.
        /// </para>
        /// </summary>
        public DateTime? LastAnalyzedTime
        {
            get { return this._lastAnalyzedTime; }
            set { this._lastAnalyzedTime = value; }
        }

        // Check to see if LastAnalyzedTime property is set
        internal bool IsSetLastAnalyzedTime()
        {
            return this._lastAnalyzedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The table name. For Hive compatibility, this must be entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// These key-value pairs define properties associated with the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// A list of columns by which the table is partitioned. Only primitive types are supported
        /// as partition keys.
        /// </para>
        ///  
        /// <para>
        /// When you create a table used by Amazon Athena, and you do not specify any <c>partitionKeys</c>,
        /// you must at least set the value of <c>partitionKeys</c> to an empty list. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"PartitionKeys": []</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Column> PartitionKeys
        {
            get { return this._partitionKeys; }
            set { this._partitionKeys = value; }
        }

        // Check to see if PartitionKeys property is set
        internal bool IsSetPartitionKeys()
        {
            return this._partitionKeys != null && (this._partitionKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Retention. 
        /// <para>
        /// The retention time for this table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Retention
        {
            get { return this._retention; }
            set { this._retention = value; }
        }

        // Check to see if Retention property is set
        internal bool IsSetRetention()
        {
            return this._retention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public TableStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StorageDescriptor. 
        /// <para>
        /// A storage descriptor containing information about the physical storage of this table.
        /// </para>
        /// </summary>
        public StorageDescriptor StorageDescriptor
        {
            get { return this._storageDescriptor; }
            set { this._storageDescriptor = value; }
        }

        // Check to see if StorageDescriptor property is set
        internal bool IsSetStorageDescriptor()
        {
            return this._storageDescriptor != null;
        }

        /// <summary>
        /// Gets and sets the property TableType. 
        /// <para>
        /// The type of this table. Glue will create tables with the <c>EXTERNAL_TABLE</c> type.
        /// Other services, such as Athena, may create tables with additional table types. 
        /// </para>
        ///  
        /// <para>
        /// Glue related table types:
        /// </para>
        ///  <dl> <dt>EXTERNAL_TABLE</dt> <dd> 
        /// <para>
        /// Hive compatible attribute - indicates a non-Hive managed table.
        /// </para>
        ///  </dd> <dt>GOVERNED</dt> <dd> 
        /// <para>
        /// Used by Lake Formation. The Glue Data Catalog understands <c>GOVERNED</c>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Max=255)]
        public string TableType
        {
            get { return this._tableType; }
            set { this._tableType = value; }
        }

        // Check to see if TableType property is set
        internal bool IsSetTableType()
        {
            return this._tableType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// A <c>TableIdentifier</c> structure that describes a target table for resource linking.
        /// </para>
        /// </summary>
        public TableIdentifier TargetTable
        {
            get { return this._targetTable; }
            set { this._targetTable = value; }
        }

        // Check to see if TargetTable property is set
        internal bool IsSetTargetTable()
        {
            return this._targetTable != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The last time that the table was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the table version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

        /// <summary>
        /// Gets and sets the property ViewDefinition. 
        /// <para>
        /// A structure that contains all the information that defines the view, including the
        /// dialect or dialects for the view, and the query.
        /// </para>
        /// </summary>
        public ViewDefinition ViewDefinition
        {
            get { return this._viewDefinition; }
            set { this._viewDefinition = value; }
        }

        // Check to see if ViewDefinition property is set
        internal bool IsSetViewDefinition()
        {
            return this._viewDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ViewExpandedText. 
        /// <para>
        /// Included for Apache Hive compatibility. Not used in the normal course of Glue operations.
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
        public string ViewExpandedText
        {
            get { return this._viewExpandedText; }
            set { this._viewExpandedText = value; }
        }

        // Check to see if ViewExpandedText property is set
        internal bool IsSetViewExpandedText()
        {
            return this._viewExpandedText != null;
        }

        /// <summary>
        /// Gets and sets the property ViewOriginalText. 
        /// <para>
        /// Included for Apache Hive compatibility. Not used in the normal course of Glue operations.
        /// If the table is a <c>VIRTUAL_VIEW</c>, certain Athena configuration encoded in base64.
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
        public string ViewOriginalText
        {
            get { return this._viewOriginalText; }
            set { this._viewOriginalText = value; }
        }

        // Check to see if ViewOriginalText property is set
        internal bool IsSetViewOriginalText()
        {
            return this._viewOriginalText != null;
        }

    }
}