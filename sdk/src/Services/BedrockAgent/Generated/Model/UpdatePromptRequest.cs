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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePrompt operation.
    /// Modifies a prompt in your prompt library. Include both fields that you want to keep
    /// and fields that you want to replace. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management.html">Prompt
    /// management in Amazon Bedrock</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management-manage.html#prompt-management-edit">Edit
    /// prompts in your prompt library</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class UpdatePromptRequest : AmazonBedrockAgentRequest
    {
        private string _customerEncryptionKeyArn;
        private string _defaultVariant;
        private string _description;
        private string _name;
        private string _promptIdentifier;
        private List<PromptVariant> _variants = AWSConfigs.InitializeCollections ? new List<PromptVariant>() : null;

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to encrypt the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CustomerEncryptionKeyArn
        {
            get { return this._customerEncryptionKeyArn; }
            set { this._customerEncryptionKeyArn = value; }
        }

        // Check to see if CustomerEncryptionKeyArn property is set
        internal bool IsSetCustomerEncryptionKeyArn()
        {
            return this._customerEncryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultVariant. 
        /// <para>
        /// The name of the default variant for the prompt. This value must match the <c>name</c>
        /// field in the relevant <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_PromptVariant.html">PromptVariant</a>
        /// object.
        /// </para>
        /// </summary>
        public string DefaultVariant
        {
            get { return this._defaultVariant; }
            set { this._defaultVariant = value; }
        }

        // Check to see if DefaultVariant property is set
        internal bool IsSetDefaultVariant()
        {
            return this._defaultVariant != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PromptIdentifier. 
        /// <para>
        /// The unique identifier of the prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PromptIdentifier
        {
            get { return this._promptIdentifier; }
            set { this._promptIdentifier = value; }
        }

        // Check to see if PromptIdentifier property is set
        internal bool IsSetPromptIdentifier()
        {
            return this._promptIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Variants. 
        /// <para>
        /// A list of objects, each containing details about a variant of the prompt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1)]
        public List<PromptVariant> Variants
        {
            get { return this._variants; }
            set { this._variants = value; }
        }

        // Check to see if Variants property is set
        internal bool IsSetVariants()
        {
            return this._variants != null && (this._variants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}