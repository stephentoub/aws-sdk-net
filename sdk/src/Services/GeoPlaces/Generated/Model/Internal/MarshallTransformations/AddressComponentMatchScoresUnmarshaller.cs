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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoPlaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AddressComponentMatchScores Object
    /// </summary>  
    public class AddressComponentMatchScoresUnmarshaller : IJsonUnmarshaller<AddressComponentMatchScores, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AddressComponentMatchScores Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AddressComponentMatchScores unmarshalledObject = new AddressComponentMatchScores();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AddressNumber", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.AddressNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Block", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Block = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Building", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Building = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("District", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.District = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Intersection", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.Intersection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Locality", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Locality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PostalCode", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.PostalCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecondaryAddressComponents", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SecondaryAddressComponentMatchScore, SecondaryAddressComponentMatchScoreUnmarshaller>(SecondaryAddressComponentMatchScoreUnmarshaller.Instance);
                    unmarshalledObject.SecondaryAddressComponents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubBlock", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.SubBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubDistrict", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.SubDistrict = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubRegion", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.SubRegion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AddressComponentMatchScoresUnmarshaller _instance = new AddressComponentMatchScoresUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddressComponentMatchScoresUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}