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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
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
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListConnectorDestinations Request Marshaller
    /// </summary>       
    public class ListConnectorDestinationsRequestMarshaller : IMarshaller<IRequest, ListConnectorDestinationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListConnectorDestinationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListConnectorDestinationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTManagedIntegrations");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-03";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCloudConnectorId())
                request.Parameters.Add("CloudConnectorId", StringUtils.FromString(publicRequest.CloudConnectorId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/connector-destinations";
            request.UseQueryString = true;

            return request;
        }
        private static ListConnectorDestinationsRequestMarshaller _instance = new ListConnectorDestinationsRequestMarshaller();        

        internal static ListConnectorDestinationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListConnectorDestinationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}