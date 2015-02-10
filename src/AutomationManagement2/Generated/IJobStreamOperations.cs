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
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation job streams.  (see
    /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
    /// information)
    /// </summary>
    public partial interface IJobStreamOperations
    {
        /// <summary>
        /// Retrieve the job stream identified by job stream id.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// The job id.
        /// </param>
        /// <param name='jobStreamId'>
        /// The job stream id.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get job stream operation.
        /// </returns>
        Task<JobStreamGetResponse> GetAsync(string resourceGroupName, string automationAccount, Guid jobId, string jobStreamId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a list of jobs streams identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// The job Id.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the list job stream's stream items
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        Task<JobStreamListResponse> ListAsync(string resourceGroupName, string automationAccount, Guid jobId, JobStreamListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of job streams using next link.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        Task<JobStreamListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a list of test job streams identified by runbook name.
        /// (see http://aka.ms/azureautomationsdk/jobstreamoperations for
        /// more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the list job stream's stream items
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        Task<JobStreamListResponse> ListTestJobStreamsAsync(string resourceGroupName, string automationAccount, string runbookName, JobStreamListParameters parameters, CancellationToken cancellationToken);
    }
}
