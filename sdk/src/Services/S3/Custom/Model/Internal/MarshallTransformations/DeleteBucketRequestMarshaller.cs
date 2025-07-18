﻿/*
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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
	/// <summary>
	/// DeleteBucket Request Marshaller
	/// </summary>       
	public partial class DeleteBucketRequestMarshaller : IMarshaller<IRequest, DeleteBucketRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, DeleteBucketRequest publicRequest)
        {
			if (publicRequest.BucketRegion != null)
			{
				RegionEndpoint regionEndpoint;
#pragma warning disable CR1004
				if (publicRequest.BucketRegion == S3Region.USEast1)
				{
					regionEndpoint = RegionEndpoint.USEast1;
				}
				else if (publicRequest.BucketRegion == S3Region.EUWest1)
				{
					regionEndpoint = RegionEndpoint.EUWest1;
				}
				else
				{
					regionEndpoint = RegionEndpoint.GetBySystemName(publicRequest.BucketRegion.Value);
				}
#pragma warning restore CR1004
				defaultRequest.AlternateEndpoint = regionEndpoint;
			}
		}
    }
}
