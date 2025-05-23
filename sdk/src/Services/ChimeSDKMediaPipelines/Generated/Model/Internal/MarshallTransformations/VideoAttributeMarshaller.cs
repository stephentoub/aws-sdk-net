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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VideoAttribute Marshaller
    /// </summary>
    public class VideoAttributeMarshaller : IRequestMarshaller<VideoAttribute, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VideoAttribute requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBorderColor())
            {
                context.Writer.WritePropertyName("BorderColor");
                context.Writer.WriteStringValue(requestObject.BorderColor);
            }

            if(requestObject.IsSetBorderThickness())
            {
                context.Writer.WritePropertyName("BorderThickness");
                context.Writer.WriteNumberValue(requestObject.BorderThickness.Value);
            }

            if(requestObject.IsSetCornerRadius())
            {
                context.Writer.WritePropertyName("CornerRadius");
                context.Writer.WriteNumberValue(requestObject.CornerRadius.Value);
            }

            if(requestObject.IsSetHighlightColor())
            {
                context.Writer.WritePropertyName("HighlightColor");
                context.Writer.WriteStringValue(requestObject.HighlightColor);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VideoAttributeMarshaller Instance = new VideoAttributeMarshaller();

    }
}