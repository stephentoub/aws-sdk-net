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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetTrustStoreRevocationContent operation.
    /// Retrieves the specified revocation file.
    /// 
    ///  
    /// <para>
    /// This action returns a pre-signed S3 URI which is active for ten minutes.
    /// </para>
    /// </summary>
    public partial class GetTrustStoreRevocationContentRequest : AmazonElasticLoadBalancingV2Request
    {
        private long? _revocationId;
        private string _trustStoreArn;

        /// <summary>
        /// Gets and sets the property RevocationId. 
        /// <para>
        /// The revocation ID of the revocation file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? RevocationId
        {
            get { return this._revocationId; }
            set { this._revocationId = value; }
        }

        // Check to see if RevocationId property is set
        internal bool IsSetRevocationId()
        {
            return this._revocationId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrustStoreArn
        {
            get { return this._trustStoreArn; }
            set { this._trustStoreArn = value; }
        }

        // Check to see if TrustStoreArn property is set
        internal bool IsSetTrustStoreArn()
        {
            return this._trustStoreArn != null;
        }

    }
}