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
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Hyak.Common.Internals;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API includes operations for managing the virtual
    /// machine extensions in your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157206.aspx for
    /// more information)
    /// </summary>
    internal partial class VirtualMachineExtensionOperations : IServiceOperations<ComputeManagementClient>, IVirtualMachineExtensionOperations
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineExtensionOperations
        /// class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal VirtualMachineExtensionOperations(ComputeManagementClient client)
        {
            this._client = client;
        }
        
        private ComputeManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Compute.ComputeManagementClient.
        /// </summary>
        public ComputeManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The List Resource Extensions operation lists the resource
        /// extensions that are available to add to a Virtual Machine. In
        /// Azure, a process can run as a resource extension of a Virtual
        /// Machine. For example, Remote Desktop Access or the Azure
        /// Diagnostics Agent can run as resource extensions to the Virtual
        /// Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495441.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        public async Task<VirtualMachineExtensionListResponse> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/resourceextensions";
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
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2014-10-01");
                
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
                    if (statusCode != HttpStatusCode.OK)
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
                    VirtualMachineExtensionListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new VirtualMachineExtensionListResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement resourceExtensionsSequenceElement = responseDoc.Element(XName.Get("ResourceExtensions", "http://schemas.microsoft.com/windowsazure"));
                        if (resourceExtensionsSequenceElement != null)
                        {
                            foreach (XElement resourceExtensionsElement in resourceExtensionsSequenceElement.Elements(XName.Get("ResourceExtension", "http://schemas.microsoft.com/windowsazure")))
                            {
                                VirtualMachineExtensionListResponse.ResourceExtension resourceExtensionInstance = new VirtualMachineExtensionListResponse.ResourceExtension();
                                result.ResourceExtensions.Add(resourceExtensionInstance);
                                
                                XElement publisherElement = resourceExtensionsElement.Element(XName.Get("Publisher", "http://schemas.microsoft.com/windowsazure"));
                                if (publisherElement != null)
                                {
                                    string publisherInstance = publisherElement.Value;
                                    resourceExtensionInstance.Publisher = publisherInstance;
                                }
                                
                                XElement nameElement = resourceExtensionsElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                if (nameElement != null)
                                {
                                    string nameInstance = nameElement.Value;
                                    resourceExtensionInstance.Name = nameInstance;
                                }
                                
                                XElement versionElement = resourceExtensionsElement.Element(XName.Get("Version", "http://schemas.microsoft.com/windowsazure"));
                                if (versionElement != null)
                                {
                                    string versionInstance = versionElement.Value;
                                    resourceExtensionInstance.Version = versionInstance;
                                }
                                
                                XElement labelElement = resourceExtensionsElement.Element(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                                if (labelElement != null)
                                {
                                    string labelInstance = labelElement.Value;
                                    resourceExtensionInstance.Label = labelInstance;
                                }
                                
                                XElement descriptionElement = resourceExtensionsElement.Element(XName.Get("Description", "http://schemas.microsoft.com/windowsazure"));
                                if (descriptionElement != null)
                                {
                                    string descriptionInstance = descriptionElement.Value;
                                    resourceExtensionInstance.Description = descriptionInstance;
                                }
                                
                                XElement publicConfigurationSchemaElement = resourceExtensionsElement.Element(XName.Get("PublicConfigurationSchema", "http://schemas.microsoft.com/windowsazure"));
                                if (publicConfigurationSchemaElement != null)
                                {
                                    string publicConfigurationSchemaInstance = TypeConversion.FromBase64String(publicConfigurationSchemaElement.Value);
                                    resourceExtensionInstance.PublicConfigurationSchema = publicConfigurationSchemaInstance;
                                }
                                
                                XElement privateConfigurationSchemaElement = resourceExtensionsElement.Element(XName.Get("PrivateConfigurationSchema", "http://schemas.microsoft.com/windowsazure"));
                                if (privateConfigurationSchemaElement != null)
                                {
                                    string privateConfigurationSchemaInstance = TypeConversion.FromBase64String(privateConfigurationSchemaElement.Value);
                                    resourceExtensionInstance.PrivateConfigurationSchema = privateConfigurationSchemaInstance;
                                }
                                
                                XElement sampleConfigElement = resourceExtensionsElement.Element(XName.Get("SampleConfig", "http://schemas.microsoft.com/windowsazure"));
                                if (sampleConfigElement != null)
                                {
                                    string sampleConfigInstance = TypeConversion.FromBase64String(sampleConfigElement.Value);
                                    resourceExtensionInstance.SampleConfig = sampleConfigInstance;
                                }
                                
                                XElement replicationCompletedElement = resourceExtensionsElement.Element(XName.Get("ReplicationCompleted", "http://schemas.microsoft.com/windowsazure"));
                                if (replicationCompletedElement != null && !string.IsNullOrEmpty(replicationCompletedElement.Value))
                                {
                                    bool replicationCompletedInstance = bool.Parse(replicationCompletedElement.Value);
                                    resourceExtensionInstance.ReplicationCompleted = replicationCompletedInstance;
                                }
                                
                                XElement eulaElement = resourceExtensionsElement.Element(XName.Get("Eula", "http://schemas.microsoft.com/windowsazure"));
                                if (eulaElement != null)
                                {
                                    Uri eulaInstance = TypeConversion.TryParseUri(eulaElement.Value);
                                    resourceExtensionInstance.Eula = eulaInstance;
                                }
                                
                                XElement privacyUriElement = resourceExtensionsElement.Element(XName.Get("PrivacyUri", "http://schemas.microsoft.com/windowsazure"));
                                if (privacyUriElement != null)
                                {
                                    Uri privacyUriInstance = TypeConversion.TryParseUri(privacyUriElement.Value);
                                    resourceExtensionInstance.PrivacyUri = privacyUriInstance;
                                }
                                
                                XElement homepageUriElement = resourceExtensionsElement.Element(XName.Get("HomepageUri", "http://schemas.microsoft.com/windowsazure"));
                                if (homepageUriElement != null)
                                {
                                    Uri homepageUriInstance = TypeConversion.TryParseUri(homepageUriElement.Value);
                                    resourceExtensionInstance.HomepageUri = homepageUriInstance;
                                }
                                
                                XElement isJsonExtensionElement = resourceExtensionsElement.Element(XName.Get("IsJsonExtension", "http://schemas.microsoft.com/windowsazure"));
                                if (isJsonExtensionElement != null && !string.IsNullOrEmpty(isJsonExtensionElement.Value))
                                {
                                    bool isJsonExtensionInstance = bool.Parse(isJsonExtensionElement.Value);
                                    resourceExtensionInstance.IsJsonExtension = isJsonExtensionInstance;
                                }
                                
                                XElement isInternalExtensionElement = resourceExtensionsElement.Element(XName.Get("IsInternalExtension", "http://schemas.microsoft.com/windowsazure"));
                                if (isInternalExtensionElement != null && !string.IsNullOrEmpty(isInternalExtensionElement.Value))
                                {
                                    bool isInternalExtensionInstance = bool.Parse(isInternalExtensionElement.Value);
                                    resourceExtensionInstance.IsInternalExtension = isInternalExtensionInstance;
                                }
                                
                                XElement disallowMajorVersionUpgradeElement = resourceExtensionsElement.Element(XName.Get("DisallowMajorVersionUpgrade", "http://schemas.microsoft.com/windowsazure"));
                                if (disallowMajorVersionUpgradeElement != null && !string.IsNullOrEmpty(disallowMajorVersionUpgradeElement.Value))
                                {
                                    bool disallowMajorVersionUpgradeInstance = bool.Parse(disallowMajorVersionUpgradeElement.Value);
                                    resourceExtensionInstance.DisallowMajorVersionUpgrade = disallowMajorVersionUpgradeInstance;
                                }
                                
                                XElement supportedOSElement = resourceExtensionsElement.Element(XName.Get("SupportedOS", "http://schemas.microsoft.com/windowsazure"));
                                if (supportedOSElement != null)
                                {
                                    string supportedOSInstance = supportedOSElement.Value;
                                    resourceExtensionInstance.SupportedOS = supportedOSInstance;
                                }
                                
                                XElement companyNameElement = resourceExtensionsElement.Element(XName.Get("CompanyName", "http://schemas.microsoft.com/windowsazure"));
                                if (companyNameElement != null)
                                {
                                    string companyNameInstance = companyNameElement.Value;
                                    resourceExtensionInstance.CompanyName = companyNameInstance;
                                }
                                
                                XElement publishedDateElement = resourceExtensionsElement.Element(XName.Get("PublishedDate", "http://schemas.microsoft.com/windowsazure"));
                                if (publishedDateElement != null && !string.IsNullOrEmpty(publishedDateElement.Value))
                                {
                                    DateTime publishedDateInstance = DateTime.Parse(publishedDateElement.Value, CultureInfo.InvariantCulture);
                                    resourceExtensionInstance.PublishedDate = publishedDateInstance;
                                }
                                
                                XElement regionsElement = resourceExtensionsElement.Element(XName.Get("Regions", "http://schemas.microsoft.com/windowsazure"));
                                if (regionsElement != null)
                                {
                                    string regionsInstance = regionsElement.Value;
                                    resourceExtensionInstance.Regions = regionsInstance;
                                }
                            }
                        }
                        
                    }
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
        /// The List Resource Extension Versions operation lists the versions
        /// of a resource extension that are available to add to a Virtual
        /// Machine. In Azure, a process can run as a resource extension of a
        /// Virtual Machine. For example, Remote Desktop Access or the Azure
        /// Diagnostics Agent can run as resource extensions to the Virtual
        /// Machine.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495440.aspx
        /// for more information)
        /// </summary>
        /// <param name='publisherName'>
        /// Required. The name of the publisher.
        /// </param>
        /// <param name='extensionName'>
        /// Required. The name of the extension.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Resource Extensions operation response.
        /// </returns>
        public async Task<VirtualMachineExtensionListResponse> ListVersionsAsync(string publisherName, string extensionName, CancellationToken cancellationToken)
        {
            // Validate
            if (publisherName == null)
            {
                throw new ArgumentNullException("publisherName");
            }
            if (extensionName == null)
            {
                throw new ArgumentNullException("extensionName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("publisherName", publisherName);
                tracingParameters.Add("extensionName", extensionName);
                TracingAdapter.Enter(invocationId, this, "ListVersionsAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/services/resourceextensions/";
            url = url + Uri.EscapeDataString(publisherName);
            url = url + "/";
            url = url + Uri.EscapeDataString(extensionName);
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
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2014-10-01");
                
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
                    if (statusCode != HttpStatusCode.OK)
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
                    VirtualMachineExtensionListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new VirtualMachineExtensionListResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement resourceExtensionsSequenceElement = responseDoc.Element(XName.Get("ResourceExtensions", "http://schemas.microsoft.com/windowsazure"));
                        if (resourceExtensionsSequenceElement != null)
                        {
                            foreach (XElement resourceExtensionsElement in resourceExtensionsSequenceElement.Elements(XName.Get("ResourceExtension", "http://schemas.microsoft.com/windowsazure")))
                            {
                                VirtualMachineExtensionListResponse.ResourceExtension resourceExtensionInstance = new VirtualMachineExtensionListResponse.ResourceExtension();
                                result.ResourceExtensions.Add(resourceExtensionInstance);
                                
                                XElement publisherElement = resourceExtensionsElement.Element(XName.Get("Publisher", "http://schemas.microsoft.com/windowsazure"));
                                if (publisherElement != null)
                                {
                                    string publisherInstance = publisherElement.Value;
                                    resourceExtensionInstance.Publisher = publisherInstance;
                                }
                                
                                XElement nameElement = resourceExtensionsElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                if (nameElement != null)
                                {
                                    string nameInstance = nameElement.Value;
                                    resourceExtensionInstance.Name = nameInstance;
                                }
                                
                                XElement versionElement = resourceExtensionsElement.Element(XName.Get("Version", "http://schemas.microsoft.com/windowsazure"));
                                if (versionElement != null)
                                {
                                    string versionInstance = versionElement.Value;
                                    resourceExtensionInstance.Version = versionInstance;
                                }
                                
                                XElement labelElement = resourceExtensionsElement.Element(XName.Get("Label", "http://schemas.microsoft.com/windowsazure"));
                                if (labelElement != null)
                                {
                                    string labelInstance = labelElement.Value;
                                    resourceExtensionInstance.Label = labelInstance;
                                }
                                
                                XElement descriptionElement = resourceExtensionsElement.Element(XName.Get("Description", "http://schemas.microsoft.com/windowsazure"));
                                if (descriptionElement != null)
                                {
                                    string descriptionInstance = descriptionElement.Value;
                                    resourceExtensionInstance.Description = descriptionInstance;
                                }
                                
                                XElement publicConfigurationSchemaElement = resourceExtensionsElement.Element(XName.Get("PublicConfigurationSchema", "http://schemas.microsoft.com/windowsazure"));
                                if (publicConfigurationSchemaElement != null)
                                {
                                    string publicConfigurationSchemaInstance = TypeConversion.FromBase64String(publicConfigurationSchemaElement.Value);
                                    resourceExtensionInstance.PublicConfigurationSchema = publicConfigurationSchemaInstance;
                                }
                                
                                XElement privateConfigurationSchemaElement = resourceExtensionsElement.Element(XName.Get("PrivateConfigurationSchema", "http://schemas.microsoft.com/windowsazure"));
                                if (privateConfigurationSchemaElement != null)
                                {
                                    string privateConfigurationSchemaInstance = TypeConversion.FromBase64String(privateConfigurationSchemaElement.Value);
                                    resourceExtensionInstance.PrivateConfigurationSchema = privateConfigurationSchemaInstance;
                                }
                                
                                XElement sampleConfigElement = resourceExtensionsElement.Element(XName.Get("SampleConfig", "http://schemas.microsoft.com/windowsazure"));
                                if (sampleConfigElement != null)
                                {
                                    string sampleConfigInstance = TypeConversion.FromBase64String(sampleConfigElement.Value);
                                    resourceExtensionInstance.SampleConfig = sampleConfigInstance;
                                }
                                
                                XElement replicationCompletedElement = resourceExtensionsElement.Element(XName.Get("ReplicationCompleted", "http://schemas.microsoft.com/windowsazure"));
                                if (replicationCompletedElement != null && !string.IsNullOrEmpty(replicationCompletedElement.Value))
                                {
                                    bool replicationCompletedInstance = bool.Parse(replicationCompletedElement.Value);
                                    resourceExtensionInstance.ReplicationCompleted = replicationCompletedInstance;
                                }
                                
                                XElement eulaElement = resourceExtensionsElement.Element(XName.Get("Eula", "http://schemas.microsoft.com/windowsazure"));
                                if (eulaElement != null)
                                {
                                    Uri eulaInstance = TypeConversion.TryParseUri(eulaElement.Value);
                                    resourceExtensionInstance.Eula = eulaInstance;
                                }
                                
                                XElement privacyUriElement = resourceExtensionsElement.Element(XName.Get("PrivacyUri", "http://schemas.microsoft.com/windowsazure"));
                                if (privacyUriElement != null)
                                {
                                    Uri privacyUriInstance = TypeConversion.TryParseUri(privacyUriElement.Value);
                                    resourceExtensionInstance.PrivacyUri = privacyUriInstance;
                                }
                                
                                XElement homepageUriElement = resourceExtensionsElement.Element(XName.Get("HomepageUri", "http://schemas.microsoft.com/windowsazure"));
                                if (homepageUriElement != null)
                                {
                                    Uri homepageUriInstance = TypeConversion.TryParseUri(homepageUriElement.Value);
                                    resourceExtensionInstance.HomepageUri = homepageUriInstance;
                                }
                                
                                XElement isJsonExtensionElement = resourceExtensionsElement.Element(XName.Get("IsJsonExtension", "http://schemas.microsoft.com/windowsazure"));
                                if (isJsonExtensionElement != null && !string.IsNullOrEmpty(isJsonExtensionElement.Value))
                                {
                                    bool isJsonExtensionInstance = bool.Parse(isJsonExtensionElement.Value);
                                    resourceExtensionInstance.IsJsonExtension = isJsonExtensionInstance;
                                }
                                
                                XElement isInternalExtensionElement = resourceExtensionsElement.Element(XName.Get("IsInternalExtension", "http://schemas.microsoft.com/windowsazure"));
                                if (isInternalExtensionElement != null && !string.IsNullOrEmpty(isInternalExtensionElement.Value))
                                {
                                    bool isInternalExtensionInstance = bool.Parse(isInternalExtensionElement.Value);
                                    resourceExtensionInstance.IsInternalExtension = isInternalExtensionInstance;
                                }
                                
                                XElement disallowMajorVersionUpgradeElement = resourceExtensionsElement.Element(XName.Get("DisallowMajorVersionUpgrade", "http://schemas.microsoft.com/windowsazure"));
                                if (disallowMajorVersionUpgradeElement != null && !string.IsNullOrEmpty(disallowMajorVersionUpgradeElement.Value))
                                {
                                    bool disallowMajorVersionUpgradeInstance = bool.Parse(disallowMajorVersionUpgradeElement.Value);
                                    resourceExtensionInstance.DisallowMajorVersionUpgrade = disallowMajorVersionUpgradeInstance;
                                }
                                
                                XElement supportedOSElement = resourceExtensionsElement.Element(XName.Get("SupportedOS", "http://schemas.microsoft.com/windowsazure"));
                                if (supportedOSElement != null)
                                {
                                    string supportedOSInstance = supportedOSElement.Value;
                                    resourceExtensionInstance.SupportedOS = supportedOSInstance;
                                }
                                
                                XElement companyNameElement = resourceExtensionsElement.Element(XName.Get("CompanyName", "http://schemas.microsoft.com/windowsazure"));
                                if (companyNameElement != null)
                                {
                                    string companyNameInstance = companyNameElement.Value;
                                    resourceExtensionInstance.CompanyName = companyNameInstance;
                                }
                                
                                XElement publishedDateElement = resourceExtensionsElement.Element(XName.Get("PublishedDate", "http://schemas.microsoft.com/windowsazure"));
                                if (publishedDateElement != null && !string.IsNullOrEmpty(publishedDateElement.Value))
                                {
                                    DateTime publishedDateInstance = DateTime.Parse(publishedDateElement.Value, CultureInfo.InvariantCulture);
                                    resourceExtensionInstance.PublishedDate = publishedDateInstance;
                                }
                                
                                XElement regionsElement = resourceExtensionsElement.Element(XName.Get("Regions", "http://schemas.microsoft.com/windowsazure"));
                                if (regionsElement != null)
                                {
                                    string regionsInstance = regionsElement.Value;
                                    resourceExtensionInstance.Regions = regionsInstance;
                                }
                            }
                        }
                        
                    }
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
    }
}
