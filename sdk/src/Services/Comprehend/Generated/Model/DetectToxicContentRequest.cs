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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the DetectToxicContent operation.
    /// Performs toxicity analysis on the list of text strings that you provide as input.
    /// The API response contains a results list that matches the size of the input list.
    /// For more information about toxicity detection, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/toxicity-detection.html">Toxicity
    /// detection</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </summary>
    public partial class DetectToxicContentRequest : AmazonComprehendRequest
    {
        private LanguageCode _languageCode;
        private List<TextSegment> _textSegments = AWSConfigs.InitializeCollections ? new List<TextSegment>() : null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the input text. Currently, English is the only supported language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TextSegments. 
        /// <para>
        /// A list of up to 10 text strings. Each string has a maximum size of 1 KB, and the maximum
        /// size of the list is 10 KB.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public List<TextSegment> TextSegments
        {
            get { return this._textSegments; }
            set { this._textSegments = value; }
        }

        // Check to see if TextSegments property is set
        internal bool IsSetTextSegments()
        {
            return this._textSegments != null && (this._textSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}