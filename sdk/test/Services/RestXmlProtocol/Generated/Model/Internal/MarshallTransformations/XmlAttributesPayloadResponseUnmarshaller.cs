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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for XmlAttributesPayloadResponse Object
    /// </summary>  
    public class XmlAttributesPayloadResponseUnmarshaller : IXmlUnmarshaller<XmlAttributesPayloadResponse, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public XmlAttributesPayloadResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlAttributesPayloadResponse unmarshalledObject = new XmlAttributesPayloadResponse();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("@test", targetDepth - 1))

                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Attr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("foo", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Foo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }
        private static XmlAttributesPayloadResponseUnmarshaller _instance = new XmlAttributesPayloadResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlAttributesPayloadResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}