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

using Amazon.Runtime.Telemetry.Tracing;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface ISearch
    {
        /// <summary>
        /// Retrieves the next set (page) of results
        ///
        /// If there are more items in the Scan/Query, PaginationToken will be
        /// set and can be consumed in a new Scan/Query operation to resume
        /// retrieving items from this point.
        /// </summary>
        /// <returns>Next set of Documents matching the search parameters</returns>
        List<Document> GetNextSet();

        /// <summary>
        /// Retrieves all the remaining results
        /// </summary>
        /// <returns>List of Documents matching the search parameters</returns>
        List<Document> GetRemaining();
    }

    public partial class Search : ISearch
    {
        /// <inheritdoc/>
        public List<Document> GetNextSet()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Search), nameof(GetNextSet));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return GetNextSetHelper();
            }
        }

        /// <inheritdoc/>
        public List<Document> GetRemaining()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Search), nameof(GetRemaining));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return GetRemainingHelper();
            }
        }
    }
}
