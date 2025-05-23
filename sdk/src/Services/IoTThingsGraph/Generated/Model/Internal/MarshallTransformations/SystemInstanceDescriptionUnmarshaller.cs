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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTThingsGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTThingsGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SystemInstanceDescription Object
    /// </summary>  
    public class SystemInstanceDescriptionUnmarshaller : IJsonUnmarshaller<SystemInstanceDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SystemInstanceDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SystemInstanceDescription unmarshalledObject = new SystemInstanceDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("definition", targetDepth))
                {
                    var unmarshaller = DefinitionDocumentUnmarshaller.Instance;
                    unmarshalledObject.Definition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("flowActionsRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FlowActionsRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("metricsConfiguration", targetDepth))
                {
                    var unmarshaller = MetricsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MetricsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("s3BucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3BucketName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("summary", targetDepth))
                {
                    var unmarshaller = SystemInstanceSummaryUnmarshaller.Instance;
                    unmarshalledObject.Summary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("validatedDependencyRevisions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DependencyRevision, DependencyRevisionUnmarshaller>(DependencyRevisionUnmarshaller.Instance);
                    unmarshalledObject.ValidatedDependencyRevisions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("validatedNamespaceVersion", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ValidatedNamespaceVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SystemInstanceDescriptionUnmarshaller _instance = new SystemInstanceDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SystemInstanceDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}