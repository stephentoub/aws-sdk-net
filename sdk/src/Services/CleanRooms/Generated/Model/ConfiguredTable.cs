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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A table that has been configured for use in a collaboration.
    /// </summary>
    public partial class ConfiguredTable
    {
        private List<string> _allowedColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AnalysisMethod _analysisMethod;
        private List<string> _analysisRuleTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private DateTime? _createTime;
        private string _description;
        private string _id;
        private string _name;
        private List<string> _selectedAnalysisMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TableReference _tableReference;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AllowedColumns. 
        /// <para>
        /// The columns within the underlying Glue table that can be utilized within collaborations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> AllowedColumns
        {
            get { return this._allowedColumns; }
            set { this._allowedColumns = value; }
        }

        // Check to see if AllowedColumns property is set
        internal bool IsSetAllowedColumns()
        {
            return this._allowedColumns != null && (this._allowedColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnalysisMethod. 
        /// <para>
        /// The analysis method for the configured table.
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_QUERY</c> allows SQL queries to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_JOB</c> allows PySpark jobs to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>MULTIPLE</c> allows both SQL queries and PySpark jobs to be run directly on this
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisMethod AnalysisMethod
        {
            get { return this._analysisMethod; }
            set { this._analysisMethod = value; }
        }

        // Check to see if AnalysisMethod property is set
        internal bool IsSetAnalysisMethod()
        {
            return this._analysisMethod != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisRuleTypes. 
        /// <para>
        /// The types of analysis rules associated with this configured table. Currently, only
        /// one analysis rule may be associated with a configured table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AnalysisRuleTypes
        {
            get { return this._analysisRuleTypes; }
            set { this._analysisRuleTypes = value; }
        }

        // Check to see if AnalysisRuleTypes property is set
        internal bool IsSetAnalysisRuleTypes()
        {
            return this._analysisRuleTypes != null && (this._analysisRuleTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the configured table was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property SelectedAnalysisMethods. 
        /// <para>
        ///  The selected analysis methods for the configured table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedAnalysisMethods
        {
            get { return this._selectedAnalysisMethods; }
            set { this._selectedAnalysisMethods = value; }
        }

        // Check to see if SelectedAnalysisMethods property is set
        internal bool IsSetSelectedAnalysisMethods()
        {
            return this._selectedAnalysisMethods != null && (this._selectedAnalysisMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableReference. 
        /// <para>
        /// The table that this configured table represents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableReference TableReference
        {
            get { return this._tableReference; }
            set { this._tableReference = value; }
        }

        // Check to see if TableReference property is set
        internal bool IsSetTableReference()
        {
            return this._tableReference != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the configured table was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}