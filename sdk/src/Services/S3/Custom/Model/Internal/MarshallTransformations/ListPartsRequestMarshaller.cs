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

using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Parts Request Marshaller
    /// </summary>       
    public class ListPartsRequestMarshaller : IMarshaller<IRequest, ListPartsRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
		public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
		{
			return this.Marshall((ListPartsRequest)input);
		}

        public IRequest Marshall(ListPartsRequest listPartsRequest)
        {
            IRequest request = new DefaultRequest(listPartsRequest, "AmazonS3");

            if (listPartsRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(listPartsRequest.RequestPayer.ToString()));

            if (listPartsRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(listPartsRequest.ExpectedBucketOwner));

            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(listPartsRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "ListPartsRequest.BucketName");
            if (string.IsNullOrEmpty(listPartsRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "ListPartsRequest.Key");
            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(listPartsRequest.Key));
            request.ResourcePath = "/{Key+}";

            if (listPartsRequest.IsSetUploadId())
                request.AddSubResource("uploadId", S3Transforms.ToStringValue(listPartsRequest.UploadId));

            if (listPartsRequest.IsSetMaxParts())
                request.Parameters.Add("max-parts", S3Transforms.ToStringValue(listPartsRequest.MaxParts.Value));
            if (listPartsRequest.IsSetPartNumberMarker())
                request.Parameters.Add("part-number-marker", S3Transforms.ToStringValue(listPartsRequest.PartNumberMarker));
            if (listPartsRequest.IsSetEncoding())
                request.Parameters.Add("encoding-type", S3Transforms.ToStringValue(listPartsRequest.Encoding));
            if (listPartsRequest.IsSetSSECustomerAlgorithm())
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = S3Transforms.ToStringValue(listPartsRequest.SSECustomerAlgorithm);
            if (listPartsRequest.IsSetSSECustomerKey())
                request.Headers["x-amz-server-side-encryption-customer-key"] = S3Transforms.ToStringValue(listPartsRequest.SSECustomerKey);
            if (listPartsRequest.IsSetSSECustomerKeyMD5())
                request.Headers["x-amz-server-side-encryption-customer-key-MD5"] = S3Transforms.ToStringValue(listPartsRequest.SSECustomerKeyMD5);

            request.UseQueryString = true;
            
            return request;
        }

	    private static ListPartsRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static ListPartsRequestMarshaller Instance
	    {
	        get
	        {
	            if (_instance == null)
	            {
	                _instance = new ListPartsRequestMarshaller();
	            }
	            return _instance;
	        }
	    }
    }
}
    
