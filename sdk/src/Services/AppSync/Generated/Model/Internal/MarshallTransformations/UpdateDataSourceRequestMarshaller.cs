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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDataSource Request Marshaller
    /// </summary>       
    public class UpdateDataSourceRequestMarshaller : IMarshaller<IRequest, UpdateDataSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDataSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDataSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
                throw new AmazonAppSyncException("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            if (!publicRequest.IsSetName())
                throw new AmazonAppSyncException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/v1/apis/{apiId}/datasources/{name}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDynamodbConfig())
            {
                context.Writer.WritePropertyName("dynamodbConfig");
                context.Writer.WriteStartObject();

                var marshaller = DynamodbDataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DynamodbConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetElasticsearchConfig())
            {
                context.Writer.WritePropertyName("elasticsearchConfig");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchDataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ElasticsearchConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEventBridgeConfig())
            {
                context.Writer.WritePropertyName("eventBridgeConfig");
                context.Writer.WriteStartObject();

                var marshaller = EventBridgeDataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.EventBridgeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHttpConfig())
            {
                context.Writer.WritePropertyName("httpConfig");
                context.Writer.WriteStartObject();

                var marshaller = HttpDataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.HttpConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLambdaConfig())
            {
                context.Writer.WritePropertyName("lambdaConfig");
                context.Writer.WriteStartObject();

                var marshaller = LambdaDataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.LambdaConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMetricsConfig())
            {
                context.Writer.WritePropertyName("metricsConfig");
                context.Writer.WriteStringValue(publicRequest.MetricsConfig);
            }

            if(publicRequest.IsSetOpenSearchServiceConfig())
            {
                context.Writer.WritePropertyName("openSearchServiceConfig");
                context.Writer.WriteStartObject();

                var marshaller = OpenSearchServiceDataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OpenSearchServiceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRelationalDatabaseConfig())
            {
                context.Writer.WritePropertyName("relationalDatabaseConfig");
                context.Writer.WriteStartObject();

                var marshaller = RelationalDatabaseDataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.RelationalDatabaseConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceRoleArn())
            {
                context.Writer.WritePropertyName("serviceRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceRoleArn);
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateDataSourceRequestMarshaller _instance = new UpdateDataSourceRequestMarshaller();        

        internal static UpdateDataSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDataSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}