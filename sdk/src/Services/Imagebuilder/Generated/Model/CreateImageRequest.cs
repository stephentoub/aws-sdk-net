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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImage operation.
    /// Creates a new image. This request will create a new image along with all of the configured
    /// output resources defined in the distribution configuration. You must specify exactly
    /// one recipe for your image, using either a ContainerRecipeArn or an ImageRecipeArn.
    /// </summary>
    public partial class CreateImageRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private string _containerRecipeArn;
        private string _distributionConfigurationArn;
        private bool? _enhancedImageMetadataEnabled;
        private string _executionRole;
        private string _imageRecipeArn;
        private ImageScanningConfiguration _imageScanningConfiguration;
        private ImageTestsConfiguration _imageTestsConfiguration;
        private string _infrastructureConfigurationArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<WorkflowConfiguration> _workflows = AWSConfigs.InitializeCollections ? new List<WorkflowConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe that defines how images are
        /// configured and tested.
        /// </para>
        /// </summary>
        public string ContainerRecipeArn
        {
            get { return this._containerRecipeArn; }
            set { this._containerRecipeArn = value; }
        }

        // Check to see if ContainerRecipeArn property is set
        internal bool IsSetContainerRecipeArn()
        {
            return this._containerRecipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration that defines and
        /// configures the outputs of your pipeline.
        /// </para>
        /// </summary>
        public string DistributionConfigurationArn
        {
            get { return this._distributionConfigurationArn; }
            set { this._distributionConfigurationArn = value; }
        }

        // Check to see if DistributionConfigurationArn property is set
        internal bool IsSetDistributionConfigurationArn()
        {
            return this._distributionConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedImageMetadataEnabled. 
        /// <para>
        /// Collects additional information about the image being created, including the operating
        /// system (OS) version and package list. This information is used to enhance the overall
        /// experience of using EC2 Image Builder. Enabled by default.
        /// </para>
        /// </summary>
        public bool? EnhancedImageMetadataEnabled
        {
            get { return this._enhancedImageMetadataEnabled; }
            set { this._enhancedImageMetadataEnabled = value; }
        }

        // Check to see if EnhancedImageMetadataEnabled property is set
        internal bool IsSetEnhancedImageMetadataEnabled()
        {
            return this._enhancedImageMetadataEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) for the IAM role you create that grants Image
        /// Builder access to perform workflow actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property ImageRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image recipe that defines how images are configured,
        /// tested, and assessed.
        /// </para>
        /// </summary>
        public string ImageRecipeArn
        {
            get { return this._imageRecipeArn; }
            set { this._imageRecipeArn = value; }
        }

        // Check to see if ImageRecipeArn property is set
        internal bool IsSetImageRecipeArn()
        {
            return this._imageRecipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// Contains settings for vulnerability scans.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration
        {
            get { return this._imageScanningConfiguration; }
            set { this._imageScanningConfiguration = value; }
        }

        // Check to see if ImageScanningConfiguration property is set
        internal bool IsSetImageScanningConfiguration()
        {
            return this._imageScanningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// The image tests configuration of the image.
        /// </para>
        /// </summary>
        public ImageTestsConfiguration ImageTestsConfiguration
        {
            get { return this._imageTestsConfiguration; }
            set { this._imageTestsConfiguration = value; }
        }

        // Check to see if ImageTestsConfiguration property is set
        internal bool IsSetImageTestsConfiguration()
        {
            return this._imageTestsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration that defines the
        /// environment in which your image will be built and tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InfrastructureConfigurationArn
        {
            get { return this._infrastructureConfigurationArn; }
            set { this._infrastructureConfigurationArn = value; }
        }

        // Check to see if InfrastructureConfigurationArn property is set
        internal bool IsSetInfrastructureConfigurationArn()
        {
            return this._infrastructureConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property Workflows. 
        /// <para>
        /// Contains an array of workflow configuration objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkflowConfiguration> Workflows
        {
            get { return this._workflows; }
            set { this._workflows = value; }
        }

        // Check to see if Workflows property is set
        internal bool IsSetWorkflows()
        {
            return this._workflows != null && (this._workflows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}