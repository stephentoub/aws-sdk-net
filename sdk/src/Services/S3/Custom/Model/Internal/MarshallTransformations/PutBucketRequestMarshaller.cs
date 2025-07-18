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

using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Request Marshaller
    /// </summary>       
    public class PutBucketRequestMarshaller : IMarshaller<IRequest, PutBucketRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((PutBucketRequest)input);
		}

        public IRequest Marshall(PutBucketRequest putBucketRequest)
        {
            IRequest request = new DefaultRequest(putBucketRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            if (putBucketRequest.IsSetCannedACL())
                request.Headers.Add(HeaderKeys.XAmzAclHeader, putBucketRequest.CannedACL.Value);
            else if (putBucketRequest.Grants != null && putBucketRequest.Grants.Count > 0)
                ConvertPutWithACLRequest(putBucketRequest, request);

            if(putBucketRequest.IsSetObjectLockEnabledForBucket())
                request.Headers.Add("x-amz-bucket-object-lock-enabled", S3Transforms.ToStringValue(putBucketRequest.ObjectLockEnabledForBucket.Value));

            if (putBucketRequest.IsSetObjectOwnership())
                request.Headers["x-amz-object-ownership"] = putBucketRequest.ObjectOwnership;

            if (string.IsNullOrEmpty(putBucketRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "PutBucketRequest.BucketName");

            request.ResourcePath = "/";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                string regionCode = null;
                var region = putBucketRequest.BucketRegion;
                if (region != null && !string.IsNullOrEmpty(region.Value))
                {
                    regionCode = region.Value;
                }
                else if (!string.IsNullOrEmpty(putBucketRequest.BucketRegionName))
                {
                    if (putBucketRequest.BucketRegionName == "eu-west-1")
                        regionCode = "EU";
                    else if (putBucketRequest.BucketRegionName != "us-east-1")
                        regionCode = putBucketRequest.BucketRegionName;
                }

                if (regionCode != null)
                {
                    xmlWriter.WriteStartElement("CreateBucketConfiguration", S3Constants.S3RequestXmlNamespace);
                    xmlWriter.WriteElementString("LocationConstraint", regionCode);
                }
                if (putBucketRequest.IsSetPutBucketConfiguration())
                {
                    if(regionCode == null)
                        xmlWriter.WriteStartElement("CreateBucketConfiguration", S3Constants.S3RequestXmlNamespace);
                    if (putBucketRequest.PutBucketConfiguration.IsSetLocationConstraint())
                    {
                        xmlWriter.WriteElementString("LocationConstraint", S3Constants.S3RequestXmlNamespace, StringUtils.FromString(putBucketRequest.PutBucketConfiguration.LocationConstraint));
                    }
                    if (putBucketRequest.PutBucketConfiguration.BucketInfo != null)
                    {
                        xmlWriter.WriteStartElement("Bucket", S3Constants.S3RequestXmlNamespace);
                        if (putBucketRequest.PutBucketConfiguration.BucketInfo.IsSetDataRedundancy())
                        {
                            xmlWriter.WriteElementString("DataRedundancy", S3Constants.S3RequestXmlNamespace, StringUtils.FromString(putBucketRequest.PutBucketConfiguration.BucketInfo.DataRedundancy));
                        }
                        if (putBucketRequest.PutBucketConfiguration.BucketInfo.IsSetType())
                        {
                            xmlWriter.WriteElementString("Type", S3Constants.S3RequestXmlNamespace, StringUtils.FromString(putBucketRequest.PutBucketConfiguration.BucketInfo.Type));
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(putBucketRequest.PutBucketConfiguration.Location != null)
                    {
                        xmlWriter.WriteStartElement("Location", S3Constants.S3RequestXmlNamespace);
                        if(putBucketRequest.PutBucketConfiguration.Location.IsSetName())
                        {
                            xmlWriter.WriteElementString("Name", S3Constants.S3RequestXmlNamespace, StringUtils.FromString(putBucketRequest.PutBucketConfiguration.Location.Name));
                        }
                        if (putBucketRequest.PutBucketConfiguration.Location.IsSetType())
                        {
                            xmlWriter.WriteElementString("Type", S3Constants.S3RequestXmlNamespace, StringUtils.FromString(putBucketRequest.PutBucketConfiguration.Location.Type));
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if (putBucketRequest.PutBucketConfiguration.IsSetTags())
                    {
                        xmlWriter.WriteStartElement("Tags", S3Constants.S3RequestXmlNamespace);
                        foreach (var tag in putBucketRequest.PutBucketConfiguration.Tags)
                        {
                            tag.Marshall("Tag", xmlWriter);
                        }
                        xmlWriter.WriteEndElement();
                    }
                }
                if(regionCode != null || putBucketRequest.IsSetPutBucketConfiguration())
                {
                    xmlWriter.WriteEndElement();
                }
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(request);

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        protected internal static void ConvertPutWithACLRequest(PutWithACLRequest request, IRequest irequest)
        {
            Dictionary<S3Permission, string> protoHeaders = new Dictionary<S3Permission, string>();
            if (request.Grants != null)
            {
                foreach (var grant in request.Grants)
                {
                    string grantee = null;
                    if (grant.Grantee.CanonicalUser != null && !string.IsNullOrEmpty(grant.Grantee.CanonicalUser))
                        grantee = string.Format(CultureInfo.InvariantCulture, "id=\"{0}\"", grant.Grantee.CanonicalUser);
                    else if (grant.Grantee.IsSetEmailAddress())
                        grantee = string.Format(CultureInfo.InvariantCulture, "emailAddress=\"{0}\"", grant.Grantee.EmailAddress);
                    else if (grant.Grantee.IsSetURI())
                        grantee = string.Format(CultureInfo.InvariantCulture, "uri=\"{0}\"", grant.Grantee.URI);
                    else continue;

                    string glist = null;
                    if (protoHeaders.TryGetValue(grant.Permission, out glist))
                        protoHeaders[grant.Permission] = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", glist, grantee);
                    else
                        protoHeaders.Add(grant.Permission, grantee);
                }
            }

            foreach (var permission in protoHeaders.Keys)
            {
                if (permission == S3Permission.READ)
                    irequest.Headers[S3Constants.AmzGrantHeaderRead] = protoHeaders[permission];
                if (permission == S3Permission.WRITE)
                    irequest.Headers[S3Constants.AmzGrantHeaderWrite] = protoHeaders[permission];
                if (permission == S3Permission.READ_ACP)
                    irequest.Headers[S3Constants.AmzGrantHeaderReadAcp] = protoHeaders[permission];
                if (permission == S3Permission.WRITE_ACP)
                    irequest.Headers[S3Constants.AmzGrantHeaderWriteAcp] = protoHeaders[permission];
                if (permission == S3Permission.RESTORE_OBJECT)
                    irequest.Headers[S3Constants.AmzGrantHeaderRestoreObject] = protoHeaders[permission];
                if (permission == S3Permission.FULL_CONTROL)
                    irequest.Headers[S3Constants.AmzGrantHeaderFullControl] = protoHeaders[permission];
            }
        }

	    private static PutBucketRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutBucketRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new PutBucketRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}

