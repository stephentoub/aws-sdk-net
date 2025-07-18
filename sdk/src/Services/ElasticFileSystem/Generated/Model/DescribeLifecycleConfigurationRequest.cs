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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLifecycleConfiguration operation.
    /// Returns the current <c>LifecycleConfiguration</c> object for the specified EFS file
    /// system. Lifecycle management uses the <c>LifecycleConfiguration</c> object to identify
    /// when to move files between storage classes. For a file system without a <c>LifecycleConfiguration</c>
    /// object, the call returns an empty array in the response.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions for the <c>elasticfilesystem:DescribeLifecycleConfiguration</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DescribeLifecycleConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system whose <c>LifecycleConfiguration</c> object you want to retrieve
        /// (String).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

    }
}