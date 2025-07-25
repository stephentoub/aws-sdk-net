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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Metric filters express how CloudWatch Logs would extract metric observations from
    /// ingested log events and transform them into metric data in a CloudWatch metric.
    /// </summary>
    public partial class MetricFilter
    {
        private bool? _applyOnTransformedLogs;
        private DateTime? _creationTime;
        private string _filterName;
        private string _filterPattern;
        private string _logGroupName;
        private List<MetricTransformation> _metricTransformations = AWSConfigs.InitializeCollections ? new List<MetricTransformation>() : null;

        /// <summary>
        /// Gets and sets the property ApplyOnTransformedLogs. 
        /// <para>
        /// This parameter is valid only for log groups that have an active log transformer. For
        /// more information about log transformers, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
        /// </para>
        ///  
        /// <para>
        /// If this value is <c>true</c>, the metric filter is applied on the transformed version
        /// of the log events instead of the original ingested log events.
        /// </para>
        /// </summary>
        public bool? ApplyOnTransformedLogs
        {
            get { return this._applyOnTransformedLogs; }
            set { this._applyOnTransformedLogs = value; }
        }

        // Check to see if ApplyOnTransformedLogs property is set
        internal bool IsSetApplyOnTransformedLogs()
        {
            return this._applyOnTransformedLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the metric filter, expressed as the number of milliseconds after
        /// <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The name of the metric filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterPattern.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricTransformations. 
        /// <para>
        /// The metric transformations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<MetricTransformation> MetricTransformations
        {
            get { return this._metricTransformations; }
            set { this._metricTransformations = value; }
        }

        // Check to see if MetricTransformations property is set
        internal bool IsSetMetricTransformations()
        {
            return this._metricTransformations != null && (this._metricTransformations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}