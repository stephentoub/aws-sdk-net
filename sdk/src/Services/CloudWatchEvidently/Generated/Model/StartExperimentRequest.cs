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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the StartExperiment operation.
    /// Starts an existing experiment. To create an experiment, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateExperiment.html">CreateExperiment</a>.
    /// </summary>
    public partial class StartExperimentRequest : AmazonCloudWatchEvidentlyRequest
    {
        private DateTime? _analysisCompleteTime;
        private string _experiment;
        private string _project;

        /// <summary>
        /// Gets and sets the property AnalysisCompleteTime. 
        /// <para>
        /// The date and time to end the experiment. This must be no more than 30 days after the
        /// experiment starts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AnalysisCompleteTime
        {
            get { return this._analysisCompleteTime; }
            set { this._analysisCompleteTime = value; }
        }

        // Check to see if AnalysisCompleteTime property is set
        internal bool IsSetAnalysisCompleteTime()
        {
            return this._analysisCompleteTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Experiment. 
        /// <para>
        /// The name of the experiment to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Experiment
        {
            get { return this._experiment; }
            set { this._experiment = value; }
        }

        // Check to see if Experiment property is set
        internal bool IsSetExperiment()
        {
            return this._experiment != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the experiment to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

    }
}