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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
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
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetRoutingRule Request Marshaller
    /// </summary>       
    public class GetRoutingRuleRequestMarshaller : IMarshaller<IRequest, GetRoutingRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRoutingRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetRoutingRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field DomainName set");
            request.AddPathResource("{domainName}", StringUtils.FromString(publicRequest.DomainName));
            if (!publicRequest.IsSetRoutingRuleId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field RoutingRuleId set");
            request.AddPathResource("{routingRuleId}", StringUtils.FromString(publicRequest.RoutingRuleId));
            
            if (publicRequest.IsSetDomainNameId())
                request.Parameters.Add("domainNameId", StringUtils.FromString(publicRequest.DomainNameId));
            request.ResourcePath = "/v2/domainnames/{domainName}/routingrules/{routingRuleId}";
            request.UseQueryString = true;

            return request;
        }
        private static GetRoutingRuleRequestMarshaller _instance = new GetRoutingRuleRequestMarshaller();        

        internal static GetRoutingRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRoutingRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}