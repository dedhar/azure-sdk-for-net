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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation accounts.  (see
    /// http://aka.ms/azureautomationsdk/automationaccountoperations for more
    /// information)
    /// </summary>
    internal partial class AutomationAccountOperations : IServiceOperations<AutomationManagementClient>, IAutomationAccountOperations
    {
        /// <summary>
        /// Initializes a new instance of the AutomationAccountOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal AutomationAccountOperations(AutomationManagementClient client)
        {
            this._client = client;
        }
        
        private AutomationManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Automation.AutomationManagementClient.
        /// </summary>
        public AutomationManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create automation account.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async Task<LongRunningOperationStatusResponse> BeginCreateAsync(string resourceGroupName, AutomationAccountCreateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.Name == null)
            {
                throw new ArgumentNullException("parameters.Name");
            }
            if (parameters.Name.Length > 100)
            {
                throw new ArgumentOutOfRangeException("parameters.Name");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "BeginCreateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            if (this.Client.ResourceNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            }
            url = url + "/AutomationAccount/";
            url = url + Uri.EscapeDataString(parameters.Name);
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2013-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement resourceElement = new XElement(XName.Get("Resource", "http://schemas.microsoft.com/windowsazure"));
                requestDoc.Add(resourceElement);
                
                XElement nameElement = new XElement(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                resourceElement.Add(nameElement);
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    LongRunningOperationStatusResponse result = null;
                    // Deserialize Response
                    result = new LongRunningOperationStatusResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccountName'>
        /// Required. Automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async Task<LongRunningOperationStatusResponse> BeginDeleteAsync(string resourceGroupName, string automationAccountName, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (automationAccountName == null)
            {
                throw new ArgumentNullException("automationAccountName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("automationAccountName", automationAccountName);
                TracingAdapter.Enter(invocationId, this, "BeginDeleteAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            if (this.Client.ResourceNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            }
            url = url + "/AutomationAccount/";
            url = url + Uri.EscapeDataString(automationAccountName);
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Delete;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2013-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    LongRunningOperationStatusResponse result = null;
                    // Deserialize Response
                    result = new LongRunningOperationStatusResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create automation account.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async Task<LongRunningOperationStatusResponse> CreateAsync(string resourceGroupName, AutomationAccountCreateParameters parameters, CancellationToken cancellationToken)
        {
            AutomationManagementClient client = this.Client;
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "CreateAsync", tracingParameters);
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            LongRunningOperationStatusResponse response = await client.AutomationAccounts.BeginCreateAsync(resourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
            if (response.Status == OperationStatus.Succeeded)
            {
                return response;
            }
            cancellationToken.ThrowIfCancellationRequested();
            LongRunningOperationStatusResponse result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
            int delayInSeconds = 10;
            if (client.LongRunningOperationInitialTimeout >= 0)
            {
                delayInSeconds = client.LongRunningOperationInitialTimeout;
            }
            while ((result.Status != OperationStatus.InProgress) == false)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await TaskEx.Delay(delayInSeconds * 1000, cancellationToken).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                delayInSeconds = 5;
                if (client.LongRunningOperationRetryTimeout >= 0)
                {
                    delayInSeconds = client.LongRunningOperationRetryTimeout;
                }
            }
            
            if (shouldTrace)
            {
                TracingAdapter.Exit(invocationId, result);
            }
            
            if (result.Status != OperationStatus.Succeeded)
            {
                if (result.Error != null)
                {
                    CloudException ex = new CloudException(result.Error.Code + " : " + result.Error.Message);
                    ex.Error = new CloudError();
                    ex.Error.Code = result.Error.Code;
                    ex.Error.Message = result.Error.Message;
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
                else
                {
                    CloudException ex = new CloudException("");
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
            }
            
            return result;
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccountName'>
        /// Required. Automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public async Task<LongRunningOperationStatusResponse> DeleteAsync(string resourceGroupName, string automationAccountName, CancellationToken cancellationToken)
        {
            AutomationManagementClient client = this.Client;
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("automationAccountName", automationAccountName);
                TracingAdapter.Enter(invocationId, this, "DeleteAsync", tracingParameters);
            }
            
            cancellationToken.ThrowIfCancellationRequested();
            LongRunningOperationStatusResponse response = await client.AutomationAccounts.BeginDeleteAsync(resourceGroupName, automationAccountName, cancellationToken).ConfigureAwait(false);
            if (response.Status == OperationStatus.Succeeded)
            {
                return response;
            }
            cancellationToken.ThrowIfCancellationRequested();
            LongRunningOperationStatusResponse result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
            int delayInSeconds = 10;
            if (client.LongRunningOperationInitialTimeout >= 0)
            {
                delayInSeconds = client.LongRunningOperationInitialTimeout;
            }
            while ((result.Status != OperationStatus.InProgress) == false)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await TaskEx.Delay(delayInSeconds * 1000, cancellationToken).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                result = await client.GetOperationStatusAsync(response.RequestId, cancellationToken).ConfigureAwait(false);
                delayInSeconds = 5;
                if (client.LongRunningOperationRetryTimeout >= 0)
                {
                    delayInSeconds = client.LongRunningOperationRetryTimeout;
                }
            }
            
            if (shouldTrace)
            {
                TracingAdapter.Exit(invocationId, result);
            }
            
            if (result.Status != OperationStatus.Succeeded)
            {
                if (result.Error != null)
                {
                    CloudException ex = new CloudException(result.Error.Code + " : " + result.Error.Message);
                    ex.Error = new CloudError();
                    ex.Error.Code = result.Error.Code;
                    ex.Error.Message = result.Error.Message;
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
                else
                {
                    CloudException ex = new CloudException("");
                    if (shouldTrace)
                    {
                        TracingAdapter.Error(invocationId, ex);
                    }
                    throw ex;
                }
            }
            
            return result;
        }
    }
}
