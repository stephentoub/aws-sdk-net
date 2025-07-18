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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the AddTags operation.
    /// Adds one or more tags to a trail, event data store, dashboard, or channel, up to a
    /// limit of 50. Overwrites an existing tag's value when a new value is specified for
    /// an existing tag key. Tag key names must be unique; you cannot have two keys with the
    /// same name but different values. If you specify a key without a value, the tag will
    /// be created with the specified key and a value of null. You can tag a trail or event
    /// data store that applies to all Amazon Web Services Regions only from the Region in
    /// which the trail or event data store was created (also known as its home Region).
    /// </summary>
    public partial class AddTagsRequest : AmazonCloudTrailRequest
    {
        private string _resourceId;
        private List<Tag> _tagsList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Specifies the ARN of the trail, event data store, dashboard, or channel to which one
        /// or more tags will be added.
        /// </para>
        ///  
        /// <para>
        /// The format of a trail ARN is: <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The format of an event data store ARN is: <c>arn:aws:cloudtrail:us-east-2:123456789012:eventdatastore/EXAMPLE-f852-4e8f-8bd1-bcf6cEXAMPLE</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The format of a dashboard ARN is: <c>arn:aws:cloudtrail:us-east-1:123456789012:dashboard/exampleDash</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The format of a channel ARN is: <c>arn:aws:cloudtrail:us-east-2:123456789012:channel/01234567890</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TagsList. 
        /// <para>
        /// Contains a list of tags, up to a limit of 50
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=200)]
        public List<Tag> TagsList
        {
            get { return this._tagsList; }
            set { this._tagsList = value; }
        }

        // Check to see if TagsList property is set
        internal bool IsSetTagsList()
        {
            return this._tagsList != null && (this._tagsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}