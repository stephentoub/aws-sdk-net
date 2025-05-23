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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BackupSelection Marshaller
    /// </summary>
    public class BackupSelectionMarshaller : IRequestMarshaller<BackupSelection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BackupSelection requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConditions())
            {
                context.Writer.WritePropertyName("Conditions");
                context.Writer.WriteStartObject();

                var marshaller = ConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Conditions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("IamRoleArn");
                context.Writer.WriteStringValue(requestObject.IamRoleArn);
            }

            if(requestObject.IsSetListOfTags())
            {
                context.Writer.WritePropertyName("ListOfTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectListOfTagsListValue in requestObject.ListOfTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectListOfTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNotResources())
            {
                context.Writer.WritePropertyName("NotResources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNotResourcesListValue in requestObject.NotResources)
                {
                        context.Writer.WriteStringValue(requestObjectNotResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourcesListValue in requestObject.Resources)
                {
                        context.Writer.WriteStringValue(requestObjectResourcesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSelectionName())
            {
                context.Writer.WritePropertyName("SelectionName");
                context.Writer.WriteStringValue(requestObject.SelectionName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BackupSelectionMarshaller Instance = new BackupSelectionMarshaller();

    }
}