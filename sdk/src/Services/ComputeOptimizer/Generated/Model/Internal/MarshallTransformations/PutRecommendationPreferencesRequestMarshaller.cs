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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
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
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRecommendationPreferences Request Marshaller
    /// </summary>       
    public class PutRecommendationPreferencesRequestMarshaller : IMarshaller<IRequest, PutRecommendationPreferencesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRecommendationPreferencesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRecommendationPreferencesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizer");
            string target = "ComputeOptimizerService.PutRecommendationPreferences";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
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
            if(publicRequest.IsSetEnhancedInfrastructureMetrics())
            {
                context.Writer.WritePropertyName("enhancedInfrastructureMetrics");
                context.Writer.WriteStringValue(publicRequest.EnhancedInfrastructureMetrics);
            }

            if(publicRequest.IsSetExternalMetricsPreference())
            {
                context.Writer.WritePropertyName("externalMetricsPreference");
                context.Writer.WriteStartObject();

                var marshaller = ExternalMetricsPreferenceMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExternalMetricsPreference, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInferredWorkloadTypes())
            {
                context.Writer.WritePropertyName("inferredWorkloadTypes");
                context.Writer.WriteStringValue(publicRequest.InferredWorkloadTypes);
            }

            if(publicRequest.IsSetLookBackPeriod())
            {
                context.Writer.WritePropertyName("lookBackPeriod");
                context.Writer.WriteStringValue(publicRequest.LookBackPeriod);
            }

            if(publicRequest.IsSetPreferredResources())
            {
                context.Writer.WritePropertyName("preferredResources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPreferredResourcesListValue in publicRequest.PreferredResources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PreferredResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestPreferredResourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.WriteStringValue(publicRequest.ResourceType);
            }

            if(publicRequest.IsSetSavingsEstimationMode())
            {
                context.Writer.WritePropertyName("savingsEstimationMode");
                context.Writer.WriteStringValue(publicRequest.SavingsEstimationMode);
            }

            if(publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.WriteStartObject();

                var marshaller = ScopeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Scope, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUtilizationPreferences())
            {
                context.Writer.WritePropertyName("utilizationPreferences");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUtilizationPreferencesListValue in publicRequest.UtilizationPreferences)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UtilizationPreferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequestUtilizationPreferencesListValue, context);

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
        private static PutRecommendationPreferencesRequestMarshaller _instance = new PutRecommendationPreferencesRequestMarshaller();        

        internal static PutRecommendationPreferencesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRecommendationPreferencesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}