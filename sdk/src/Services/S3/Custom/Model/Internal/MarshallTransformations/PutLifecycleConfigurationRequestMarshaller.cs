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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591,CS0612,CS0618

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Lifecycle Request Marshaller
    /// </summary>
    public class PutLifecycleConfigurationRequestMarshaller : IMarshaller<IRequest, PutLifecycleConfigurationRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutLifecycleConfigurationRequest)input);
		}

        public IRequest Marshall(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest)
        {
            IRequest request = new DefaultRequest(putLifecycleConfigurationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putLifecycleConfigurationRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(putLifecycleConfigurationRequest.ExpectedBucketOwner));

            if (putLifecycleConfigurationRequest.IsSetChecksumAlgorithm())
                request.Headers[S3Constants.AmzHeaderSdkChecksumAlgorithm] = S3Transforms.ToStringValue(putLifecycleConfigurationRequest.ChecksumAlgorithm);

            if (string.IsNullOrEmpty(putLifecycleConfigurationRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutLifecycleConfigurationRequest.BucketName");

            request.ResourcePath = "/";

            request.AddSubResource("lifecycle");

            var stringWriter = new XMLEncodedStringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                var lifecycleConfigurationLifecycleConfiguration = putLifecycleConfigurationRequest.Configuration;
                if (lifecycleConfigurationLifecycleConfiguration != null)
                {
                    xmlWriter.WriteStartElement("LifecycleConfiguration", S3Constants.S3RequestXmlNamespace);

                    if (lifecycleConfigurationLifecycleConfiguration != null)
                    {
                        var lifecycleConfigurationLifecycleConfigurationrulesList = lifecycleConfigurationLifecycleConfiguration.Rules;
                        if (lifecycleConfigurationLifecycleConfigurationrulesList != null && lifecycleConfigurationLifecycleConfigurationrulesList.Count > 0)
                        {
                            foreach (var lifecycleConfigurationLifecycleConfigurationrulesListValue in lifecycleConfigurationLifecycleConfigurationrulesList)
                            {
                                xmlWriter.WriteStartElement("Rule");
                                if (lifecycleConfigurationLifecycleConfigurationrulesListValue != null)
                                {
                                    var expiration = lifecycleConfigurationLifecycleConfigurationrulesListValue.Expiration;
                                    if (expiration != null)
                                    {
                                        xmlWriter.WriteStartElement("Expiration");
                                        if (expiration.IsSetDate())
                                        {
                                            xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(expiration.Date.Value));
                                        }
                                        if (expiration.IsSetDays())
                                        {
                                            xmlWriter.WriteElementString("Days", S3Transforms.ToXmlStringValue(expiration.Days.Value));
                                        }
                                        if (expiration.IsSetExpiredObjectDeleteMarker())
                                        {
                                            xmlWriter.WriteElementString("ExpiredObjectDeleteMarker", S3Transforms.ToXmlStringValue(expiration.ExpiredObjectDeleteMarker.Value));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }

                                    var transitions = lifecycleConfigurationLifecycleConfigurationrulesListValue.Transitions;
                                    if (transitions != null && transitions.Count > 0)
                                    {
                                        foreach (var transition in transitions)
                                        {
                                            if (transition != null)
                                            {
                                                xmlWriter.WriteStartElement("Transition");
                                                if (transition.IsSetDate())
                                                {
                                                    xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(transition.Date.Value));
                                                }
                                                if (transition.IsSetDays())
                                                {
                                                    xmlWriter.WriteElementString("Days", S3Transforms.ToXmlStringValue(transition.Days.Value));
                                                }
                                                if (transition.IsSetStorageClass())
                                                {
                                                    xmlWriter.WriteElementString("StorageClass", S3Transforms.ToXmlStringValue(transition.StorageClass));
                                                }
                                                xmlWriter.WriteEndElement();
                                            }
                                        }
                                    }

                                    var noncurrentVersionExpiration = lifecycleConfigurationLifecycleConfigurationrulesListValue.NoncurrentVersionExpiration;
                                    if (noncurrentVersionExpiration != null)
                                    {
                                        xmlWriter.WriteStartElement("NoncurrentVersionExpiration");
                                        if (noncurrentVersionExpiration.IsSetNewerNoncurrentVersions())
                                        {
                                            xmlWriter.WriteElementString("NewerNoncurrentVersions", S3Transforms.ToXmlStringValue(noncurrentVersionExpiration.NewerNoncurrentVersions.Value));
                                        }
                                        if (noncurrentVersionExpiration.IsSetNoncurrentDays())
                                        {
                                            xmlWriter.WriteElementString("NoncurrentDays", S3Transforms.ToXmlStringValue(noncurrentVersionExpiration.NoncurrentDays.Value));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }

                                    var noncurrentVersionTransitions = lifecycleConfigurationLifecycleConfigurationrulesListValue.NoncurrentVersionTransitions;
                                    if (noncurrentVersionTransitions != null && noncurrentVersionTransitions.Count > 0)
                                    {
                                        foreach (var noncurrentVersionTransition in noncurrentVersionTransitions)
                                        {
                                            if (noncurrentVersionTransition != null)
                                            {
                                                xmlWriter.WriteStartElement("NoncurrentVersionTransition");
                                                if (noncurrentVersionTransition.IsSetNewerNoncurrentVersions())
                                                {
                                                    xmlWriter.WriteElementString("NewerNoncurrentVersions", S3Transforms.ToXmlStringValue(noncurrentVersionTransition.NewerNoncurrentVersions.Value));
                                                }
                                                if (noncurrentVersionTransition.IsSetNoncurrentDays())
                                                {
                                                    xmlWriter.WriteElementString("NoncurrentDays", S3Transforms.ToXmlStringValue(noncurrentVersionTransition.NoncurrentDays.Value));
                                                }
                                                if (noncurrentVersionTransition.IsSetStorageClass())
                                                {
                                                    xmlWriter.WriteElementString("StorageClass", S3Transforms.ToXmlStringValue(noncurrentVersionTransition.StorageClass));
                                                }
                                                xmlWriter.WriteEndElement();
                                            }
                                        }
                                    }

                                    var abortIncompleteMultipartUpload = lifecycleConfigurationLifecycleConfigurationrulesListValue.AbortIncompleteMultipartUpload;
                                    if (abortIncompleteMultipartUpload != null)
                                    {
                                        xmlWriter.WriteStartElement("AbortIncompleteMultipartUpload");
                                        if (abortIncompleteMultipartUpload.IsSetDaysAfterInitiation())
                                        {
                                            xmlWriter.WriteElementString("DaysAfterInitiation", S3Transforms.ToXmlStringValue(abortIncompleteMultipartUpload.DaysAfterInitiation.Value));
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                }
                                if (lifecycleConfigurationLifecycleConfigurationrulesListValue.IsSetId())
                                {
                                    xmlWriter.WriteElementString("ID", S3Transforms.ToXmlStringValue(lifecycleConfigurationLifecycleConfigurationrulesListValue.Id));
                                }

                                if (lifecycleConfigurationLifecycleConfigurationrulesListValue.IsSetFilter())
                                {
                                    xmlWriter.WriteStartElement("Filter");
                                    if (lifecycleConfigurationLifecycleConfigurationrulesListValue.Filter.IsSetLifecycleFilterPredicate())
                                        lifecycleConfigurationLifecycleConfigurationrulesListValue.Filter.LifecycleFilterPredicate.Accept(new LifecycleFilterPredicateMarshallVisitor(xmlWriter));
                                    xmlWriter.WriteEndElement();
                                }

                                if (lifecycleConfigurationLifecycleConfigurationrulesListValue.IsSetStatus())
                                {
                                    xmlWriter.WriteElementString("Status", S3Transforms.ToXmlStringValue(lifecycleConfigurationLifecycleConfigurationrulesListValue.Status));
                                }
                                else
                                {
                                    xmlWriter.WriteElementString("Status", "Disabled");
                                }
                                xmlWriter.WriteEndElement();
                            }
                        }
                    }
                    xmlWriter.WriteEndElement();
                }
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(
                    request, 
                    putLifecycleConfigurationRequest.ChecksumAlgorithm, 
                    fallbackToMD5: false, 
                    isRequestChecksumRequired: true, 
                    headerName: S3Constants.AmzHeaderSdkChecksumAlgorithm
                );
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

	    private static PutLifecycleConfigurationRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutLifecycleConfigurationRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new PutLifecycleConfigurationRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

