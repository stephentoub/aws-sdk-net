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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePredictor operation.
    /// <note> 
    /// <para>
    ///  This operation creates a legacy predictor that does not include all the predictor
    /// functionalities provided by Amazon Forecast. To create a predictor that is compatible
    /// with all aspects of Forecast, use <a>CreateAutoPredictor</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates an Amazon Forecast predictor.
    /// </para>
    ///  
    /// <para>
    /// In the request, provide a dataset group and either specify an algorithm or let Amazon
    /// Forecast choose an algorithm for you using AutoML. If you specify an algorithm, you
    /// also can override algorithm-specific hyperparameters.
    /// </para>
    ///  
    /// <para>
    /// Amazon Forecast uses the algorithm to train a predictor using the latest version of
    /// the datasets in the specified dataset group. You can then generate a forecast using
    /// the <a>CreateForecast</a> operation.
    /// </para>
    ///  
    /// <para>
    ///  To see the evaluation metrics, use the <a>GetAccuracyMetrics</a> operation. 
    /// </para>
    ///  
    /// <para>
    /// You can specify a featurization configuration to fill and aggregate the data fields
    /// in the <c>TARGET_TIME_SERIES</c> dataset to improve model training. For more information,
    /// see <a>FeaturizationConfig</a>.
    /// </para>
    ///  
    /// <para>
    /// For RELATED_TIME_SERIES datasets, <c>CreatePredictor</c> verifies that the <c>DataFrequency</c>
    /// specified when the dataset was created matches the <c>ForecastFrequency</c>. TARGET_TIME_SERIES
    /// datasets don't have this restriction. Amazon Forecast also verifies the delimiter
    /// and timestamp format. For more information, see <a>howitworks-datasets-groups</a>.
    /// </para>
    ///  
    /// <para>
    /// By default, predictors are trained and evaluated at the 0.1 (P10), 0.5 (P50), and
    /// 0.9 (P90) quantiles. You can choose custom forecast types to train and evaluate your
    /// predictor by setting the <c>ForecastTypes</c>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>AutoML</b> 
    /// </para>
    ///  
    /// <para>
    /// If you want Amazon Forecast to evaluate each algorithm and choose the one that minimizes
    /// the <c>objective function</c>, set <c>PerformAutoML</c> to <c>true</c>. The <c>objective
    /// function</c> is defined as the mean of the weighted losses over the forecast types.
    /// By default, these are the p10, p50, and p90 quantile losses. For more information,
    /// see <a>EvaluationResult</a>.
    /// </para>
    ///  
    /// <para>
    /// When AutoML is enabled, the following properties are disallowed:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>AlgorithmArn</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>HPOConfig</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PerformHPO</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TrainingParameters</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get a list of all of your predictors, use the <a>ListPredictors</a> operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// Before you can use the predictor to create a forecast, the <c>Status</c> of the predictor
    /// must be <c>ACTIVE</c>, signifying that training has completed. To get the status,
    /// use the <a>DescribePredictor</a> operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePredictorRequest : AmazonForecastServiceRequest
    {
        private string _algorithmArn;
        private AutoMLOverrideStrategy _autoMLOverrideStrategy;
        private EncryptionConfig _encryptionConfig;
        private EvaluationParameters _evaluationParameters;
        private FeaturizationConfig _featurizationConfig;
        private int? _forecastHorizon;
        private List<string> _forecastTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private HyperParameterTuningJobConfig _hpoConfig;
        private InputDataConfig _inputDataConfig;
        private OptimizationMetric _optimizationMetric;
        private bool? _performAutoML;
        private bool? _performHPO;
        private string _predictorName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private Dictionary<string, string> _trainingParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm to use for model training. Required
        /// if <c>PerformAutoML</c> is not set to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Supported algorithms:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>arn:aws:forecast:::algorithm/ARIMA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:forecast:::algorithm/CNN-QR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:forecast:::algorithm/Deep_AR_Plus</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:forecast:::algorithm/ETS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:forecast:::algorithm/NPTS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:forecast:::algorithm/Prophet</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AlgorithmArn
        {
            get { return this._algorithmArn; }
            set { this._algorithmArn = value; }
        }

        // Check to see if AlgorithmArn property is set
        internal bool IsSetAlgorithmArn()
        {
            return this._algorithmArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLOverrideStrategy. <note> 
        /// <para>
        ///  The <c>LatencyOptimized</c> AutoML override strategy is only available in private
        /// beta. Contact Amazon Web Services Support or your account manager to learn more about
        /// access privileges. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Used to overide the default AutoML strategy, which is to optimize predictor accuracy.
        /// To apply an AutoML strategy that minimizes training time, use <c>LatencyOptimized</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only valid for predictors trained using AutoML.
        /// </para>
        /// </summary>
        public AutoMLOverrideStrategy AutoMLOverrideStrategy
        {
            get { return this._autoMLOverrideStrategy; }
            set { this._autoMLOverrideStrategy = value; }
        }

        // Check to see if AutoMLOverrideStrategy property is set
        internal bool IsSetAutoMLOverrideStrategy()
        {
            return this._autoMLOverrideStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// An Key Management Service (KMS) key and the Identity and Access Management (IAM) role
        /// that Amazon Forecast can assume to access the key.
        /// </para>
        /// </summary>
        public EncryptionConfig EncryptionConfig
        {
            get { return this._encryptionConfig; }
            set { this._encryptionConfig = value; }
        }

        // Check to see if EncryptionConfig property is set
        internal bool IsSetEncryptionConfig()
        {
            return this._encryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationParameters. 
        /// <para>
        /// Used to override the default evaluation parameters of the specified algorithm. Amazon
        /// Forecast evaluates a predictor by splitting a dataset into training data and testing
        /// data. The evaluation parameters define how to perform the split and the number of
        /// iterations.
        /// </para>
        /// </summary>
        public EvaluationParameters EvaluationParameters
        {
            get { return this._evaluationParameters; }
            set { this._evaluationParameters = value; }
        }

        // Check to see if EvaluationParameters property is set
        internal bool IsSetEvaluationParameters()
        {
            return this._evaluationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturizationConfig. 
        /// <para>
        /// The featurization configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeaturizationConfig FeaturizationConfig
        {
            get { return this._featurizationConfig; }
            set { this._featurizationConfig = value; }
        }

        // Check to see if FeaturizationConfig property is set
        internal bool IsSetFeaturizationConfig()
        {
            return this._featurizationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastHorizon. 
        /// <para>
        /// Specifies the number of time-steps that the model is trained to predict. The forecast
        /// horizon is also called the prediction length.
        /// </para>
        ///  
        /// <para>
        /// For example, if you configure a dataset for daily data collection (using the <c>DataFrequency</c>
        /// parameter of the <a>CreateDataset</a> operation) and set the forecast horizon to 10,
        /// the model returns predictions for 10 days.
        /// </para>
        ///  
        /// <para>
        /// The maximum forecast horizon is the lesser of 500 time-steps or 1/3 of the TARGET_TIME_SERIES
        /// dataset length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ForecastHorizon
        {
            get { return this._forecastHorizon; }
            set { this._forecastHorizon = value; }
        }

        // Check to see if ForecastHorizon property is set
        internal bool IsSetForecastHorizon()
        {
            return this._forecastHorizon.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// Specifies the forecast types used to train a predictor. You can specify up to five
        /// forecast types. Forecast types can be quantiles from 0.01 to 0.99, by increments of
        /// 0.01 or higher. You can also specify the mean forecast with <c>mean</c>. 
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>["0.10", "0.50", "0.9"]</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> ForecastTypes
        {
            get { return this._forecastTypes; }
            set { this._forecastTypes = value; }
        }

        // Check to see if ForecastTypes property is set
        internal bool IsSetForecastTypes()
        {
            return this._forecastTypes != null && (this._forecastTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HPOConfig. 
        /// <para>
        /// Provides hyperparameter override values for the algorithm. If you don't provide this
        /// parameter, Amazon Forecast uses default values. The individual algorithms specify
        /// which hyperparameters support hyperparameter optimization (HPO). For more information,
        /// see <a>aws-forecast-choosing-recipes</a>.
        /// </para>
        ///  
        /// <para>
        /// If you included the <c>HPOConfig</c> object, you must set <c>PerformHPO</c> to true.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobConfig HPOConfig
        {
            get { return this._hpoConfig; }
            set { this._hpoConfig = value; }
        }

        // Check to see if HPOConfig property is set
        internal bool IsSetHPOConfig()
        {
            return this._hpoConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Describes the dataset group that contains the data to use to train the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationMetric. 
        /// <para>
        /// The accuracy metric used to optimize the predictor.
        /// </para>
        /// </summary>
        public OptimizationMetric OptimizationMetric
        {
            get { return this._optimizationMetric; }
            set { this._optimizationMetric = value; }
        }

        // Check to see if OptimizationMetric property is set
        internal bool IsSetOptimizationMetric()
        {
            return this._optimizationMetric != null;
        }

        /// <summary>
        /// Gets and sets the property PerformAutoML. 
        /// <para>
        /// Whether to perform AutoML. When Amazon Forecast performs AutoML, it evaluates the
        /// algorithms it provides and chooses the best algorithm and configuration for your training
        /// dataset.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>. In this case, you are required to specify an algorithm.
        /// </para>
        ///  
        /// <para>
        /// Set <c>PerformAutoML</c> to <c>true</c> to have Amazon Forecast perform AutoML. This
        /// is a good option if you aren't sure which algorithm is suitable for your training
        /// data. In this case, <c>PerformHPO</c> must be false.
        /// </para>
        /// </summary>
        public bool? PerformAutoML
        {
            get { return this._performAutoML; }
            set { this._performAutoML = value; }
        }

        // Check to see if PerformAutoML property is set
        internal bool IsSetPerformAutoML()
        {
            return this._performAutoML.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformHPO. 
        /// <para>
        /// Whether to perform hyperparameter optimization (HPO). HPO finds optimal hyperparameter
        /// values for your training data. The process of performing HPO is known as running a
        /// hyperparameter tuning job.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>. In this case, Amazon Forecast uses default hyperparameter
        /// values from the chosen algorithm.
        /// </para>
        ///  
        /// <para>
        /// To override the default values, set <c>PerformHPO</c> to <c>true</c> and, optionally,
        /// supply the <a>HyperParameterTuningJobConfig</a> object. The tuning job specifies a
        /// metric to optimize, which hyperparameters participate in tuning, and the valid range
        /// for each tunable hyperparameter. In this case, you are required to specify an algorithm
        /// and <c>PerformAutoML</c> must be false.
        /// </para>
        ///  
        /// <para>
        /// The following algorithms support HPO:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DeepAR+
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CNN-QR
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? PerformHPO
        {
            get { return this._performHPO; }
            set { this._performHPO = value; }
        }

        // Check to see if PerformHPO property is set
        internal bool IsSetPerformHPO()
        {
            return this._performHPO.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// A name for the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string PredictorName
        {
            get { return this._predictorName; }
            set { this._predictorName = value; }
        }

        // Check to see if PredictorName property is set
        internal bool IsSetPredictorName()
        {
            return this._predictorName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you apply to the predictor to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for keys as it is reserved for Amazon Web Services use. You cannot edit
        /// or delete tag keys with this prefix. Values can have this prefix. If a tag value has
        /// <c>aws</c> as its prefix but the key does not, then Forecast considers it to be a
        /// user tag and will count against the limit of 50 tags. Tags with only the key prefix
        /// of <c>aws</c> do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingParameters. 
        /// <para>
        /// The hyperparameters to override for model training. The hyperparameters that you can
        /// override are listed in the individual algorithms. For the list of supported algorithms,
        /// see <a>aws-forecast-choosing-recipes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> TrainingParameters
        {
            get { return this._trainingParameters; }
            set { this._trainingParameters = value; }
        }

        // Check to see if TrainingParameters property is set
        internal bool IsSetTrainingParameters()
        {
            return this._trainingParameters != null && (this._trainingParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}