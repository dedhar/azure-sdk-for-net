// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights
{
    /// <summary>
    /// Operations for metric values.
    /// </summary>
    public partial interface IMetricOperations
    {
        /// <summary>
        /// The List Metric operation lists the metric value sets for the
        /// resource metrics.
        /// </summary>
        /// <param name='resourceUri'>
        /// The resource identifier of the target resource to get metrics for.
        /// </param>
        /// <param name='filterString'>
        /// An OData $filter expression that supports querying by the name,
        /// startTime, endTime and timeGrain of the metric value sets. For
        /// example, "(name.value eq 'Percentage CPU') and startTime eq
        /// 2014-07-02T01:00Z and endTime eq 2014-08-21T01:00:00Z and
        /// timeGrain eq duration'PT1H'". In the expression, startTime,
        /// endTime and timeGrain are required. Name is optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Metric values operation response.
        /// </returns>
        Task<MetricListResponse> GetMetricsAsync(string resourceUri, string filterString, CancellationToken cancellationToken);
    }
}
