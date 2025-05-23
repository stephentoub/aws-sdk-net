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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
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
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGlobalTableSettings Request Marshaller
    /// </summary>       
    public class UpdateGlobalTableSettingsRequestMarshaller : IMarshaller<IRequest, UpdateGlobalTableSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGlobalTableSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGlobalTableSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.UpdateGlobalTableSettings";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetGlobalTableBillingMode())
            {
                context.Writer.WritePropertyName("GlobalTableBillingMode");
                context.Writer.WriteStringValue(publicRequest.GlobalTableBillingMode);
            }

            if(publicRequest.IsSetGlobalTableGlobalSecondaryIndexSettingsUpdate())
            {
                context.Writer.WritePropertyName("GlobalTableGlobalSecondaryIndexSettingsUpdate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGlobalTableGlobalSecondaryIndexSettingsUpdateListValue in publicRequest.GlobalTableGlobalSecondaryIndexSettingsUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GlobalTableGlobalSecondaryIndexSettingsUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequestGlobalTableGlobalSecondaryIndexSettingsUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGlobalTableName())
            {
                context.Writer.WritePropertyName("GlobalTableName");
                context.Writer.WriteStringValue(publicRequest.GlobalTableName);
            }

            if(publicRequest.IsSetGlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate())
            {
                context.Writer.WritePropertyName("GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate");
                context.Writer.WriteStartObject();

                var marshaller = AutoScalingSettingsUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.GlobalTableProvisionedWriteCapacityAutoScalingSettingsUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGlobalTableProvisionedWriteCapacityUnits())
            {
                context.Writer.WritePropertyName("GlobalTableProvisionedWriteCapacityUnits");
                context.Writer.WriteNumberValue(publicRequest.GlobalTableProvisionedWriteCapacityUnits.Value);
            }

            if(publicRequest.IsSetReplicaSettingsUpdate())
            {
                context.Writer.WritePropertyName("ReplicaSettingsUpdate");
                context.Writer.WriteStartArray();
                foreach(var publicRequestReplicaSettingsUpdateListValue in publicRequest.ReplicaSettingsUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReplicaSettingsUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequestReplicaSettingsUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static UpdateGlobalTableSettingsRequestMarshaller _instance = new UpdateGlobalTableSettingsRequestMarshaller();        

        internal static UpdateGlobalTableSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGlobalTableSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}