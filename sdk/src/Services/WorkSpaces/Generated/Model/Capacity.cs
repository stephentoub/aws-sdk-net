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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the user capacity for a pool of WorkSpaces.
    /// </summary>
    public partial class Capacity
    {
        private int? _desiredUserSessions;

        /// <summary>
        /// Gets and sets the property DesiredUserSessions. 
        /// <para>
        /// The desired number of user sessions for the WorkSpaces in the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? DesiredUserSessions
        {
            get { return this._desiredUserSessions; }
            set { this._desiredUserSessions = value; }
        }

        // Check to see if DesiredUserSessions property is set
        internal bool IsSetDesiredUserSessions()
        {
            return this._desiredUserSessions.HasValue; 
        }

    }
}