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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsNetworkFirewallRuleGroupDetails Marshaller
    /// </summary>
    public class AwsNetworkFirewallRuleGroupDetailsMarshaller : IRequestMarshaller<AwsNetworkFirewallRuleGroupDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsNetworkFirewallRuleGroupDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapacity())
            {
                context.Writer.WritePropertyName("Capacity");
                context.Writer.WriteNumberValue(requestObject.Capacity.Value);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetRuleGroup())
            {
                context.Writer.WritePropertyName("RuleGroup");
                context.Writer.WriteStartObject();

                var marshaller = RuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRuleGroupArn())
            {
                context.Writer.WritePropertyName("RuleGroupArn");
                context.Writer.WriteStringValue(requestObject.RuleGroupArn);
            }

            if(requestObject.IsSetRuleGroupId())
            {
                context.Writer.WritePropertyName("RuleGroupId");
                context.Writer.WriteStringValue(requestObject.RuleGroupId);
            }

            if(requestObject.IsSetRuleGroupName())
            {
                context.Writer.WritePropertyName("RuleGroupName");
                context.Writer.WriteStringValue(requestObject.RuleGroupName);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsNetworkFirewallRuleGroupDetailsMarshaller Instance = new AwsNetworkFirewallRuleGroupDetailsMarshaller();

    }
}