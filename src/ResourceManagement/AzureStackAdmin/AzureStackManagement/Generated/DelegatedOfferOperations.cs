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
using Hyak.Common;
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.AzureStack.Management
{
    /// <summary>
    /// Operations for delegated offers.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
    /// more information)
    /// </summary>
    internal partial class DelegatedOfferOperations : IServiceOperations<AzureStackClient>, IDelegatedOfferOperations
    {
        /// <summary>
        /// Initializes a new instance of the DelegatedOfferOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal DelegatedOfferOperations(AzureStackClient client)
        {
            this._client = client;
        }
        
        private AzureStackClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.AzureStack.Management.AzureStackClient.
        /// </summary>
        public AzureStackClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Gets a delegated offer.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='offerName'>
        /// Required. the name of the delegated offer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Delegated offer get result.
        /// </returns>
        public async Task<DelegatedOfferGetResult> GetAsync(string offerName, CancellationToken cancellationToken)
        {
            // Validate
            if (offerName == null)
            {
                throw new ArgumentNullException("offerName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("offerName", offerName);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers/Microsoft.Subscriptions/delegatedoffers/";
            url = url + Uri.EscapeDataString(offerName);
            List<string> queryParameters = new List<string>();
            if (this.Client.ApiVersion != null)
            {
                queryParameters.Add("api-version=" + Uri.EscapeDataString(this.Client.ApiVersion));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
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
                    DelegatedOfferGetResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DelegatedOfferGetResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            DelegatedOfferModel delegatedOfferInstance = new DelegatedOfferModel();
                            result.DelegatedOffer = delegatedOfferInstance;
                            
                            JToken offerNameValue = responseDoc["offerName"];
                            if (offerNameValue != null && offerNameValue.Type != JTokenType.Null)
                            {
                                string offerNameInstance = ((string)offerNameValue);
                                delegatedOfferInstance.OfferName = offerNameInstance;
                            }
                            
                            JToken externalReferenceIdValue = responseDoc["externalReferenceId"];
                            if (externalReferenceIdValue != null && externalReferenceIdValue.Type != JTokenType.Null)
                            {
                                string externalReferenceIdInstance = ((string)externalReferenceIdValue);
                                delegatedOfferInstance.ExternalReferenceId = externalReferenceIdInstance;
                            }
                            
                            JToken accessibilityStateValue = responseDoc["accessibilityState"];
                            if (accessibilityStateValue != null && accessibilityStateValue.Type != JTokenType.Null)
                            {
                                AccessibilityState accessibilityStateInstance = ((AccessibilityState)Enum.Parse(typeof(AccessibilityState), ((string)accessibilityStateValue), true));
                                delegatedOfferInstance.AccessibilityState = accessibilityStateInstance;
                            }
                            
                            JToken decommissionedByParentProviderValue = responseDoc["decommissionedByParentProvider"];
                            if (decommissionedByParentProviderValue != null && decommissionedByParentProviderValue.Type != JTokenType.Null)
                            {
                                bool decommissionedByParentProviderInstance = ((bool)decommissionedByParentProviderValue);
                                delegatedOfferInstance.DecommissionedByParentProvider = decommissionedByParentProviderInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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
        /// Get delegated offers for given subscription ID.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public async Task<DelegatedOfferListResult> ListAsync(CancellationToken cancellationToken)
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
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers/Microsoft.Subscriptions/delegatedoffers";
            List<string> queryParameters = new List<string>();
            if (this.Client.ApiVersion != null)
            {
                queryParameters.Add("api-version=" + Uri.EscapeDataString(this.Client.ApiVersion));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
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
                    DelegatedOfferListResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DelegatedOfferListResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    DelegatedOfferModel delegatedOfferModelInstance = new DelegatedOfferModel();
                                    result.DelegatedOffers.Add(delegatedOfferModelInstance);
                                    
                                    JToken offerNameValue = valueValue["offerName"];
                                    if (offerNameValue != null && offerNameValue.Type != JTokenType.Null)
                                    {
                                        string offerNameInstance = ((string)offerNameValue);
                                        delegatedOfferModelInstance.OfferName = offerNameInstance;
                                    }
                                    
                                    JToken externalReferenceIdValue = valueValue["externalReferenceId"];
                                    if (externalReferenceIdValue != null && externalReferenceIdValue.Type != JTokenType.Null)
                                    {
                                        string externalReferenceIdInstance = ((string)externalReferenceIdValue);
                                        delegatedOfferModelInstance.ExternalReferenceId = externalReferenceIdInstance;
                                    }
                                    
                                    JToken accessibilityStateValue = valueValue["accessibilityState"];
                                    if (accessibilityStateValue != null && accessibilityStateValue.Type != JTokenType.Null)
                                    {
                                        AccessibilityState accessibilityStateInstance = ((AccessibilityState)Enum.Parse(typeof(AccessibilityState), ((string)accessibilityStateValue), true));
                                        delegatedOfferModelInstance.AccessibilityState = accessibilityStateInstance;
                                    }
                                    
                                    JToken decommissionedByParentProviderValue = valueValue["decommissionedByParentProvider"];
                                    if (decommissionedByParentProviderValue != null && decommissionedByParentProviderValue.Type != JTokenType.Null)
                                    {
                                        bool decommissionedByParentProviderInstance = ((bool)decommissionedByParentProviderValue);
                                        delegatedOfferModelInstance.DecommissionedByParentProvider = decommissionedByParentProviderInstance;
                                    }
                                }
                            }
                            
                            JToken odatanextLinkValue = responseDoc["@odata.nextLink"];
                            if (odatanextLinkValue != null && odatanextLinkValue.Type != JTokenType.Null)
                            {
                                string odatanextLinkInstance = ((string)odatanextLinkValue);
                                result.NextLink = odatanextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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
        /// Next for get delegated offers for given subscription ID.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='nextLink'>
        /// Required. The next link.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Your documentation here.
        /// </returns>
        public async Task<DelegatedOfferListResult> ListNextAsync(string nextLink, CancellationToken cancellationToken)
        {
            // Validate
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("nextLink", nextLink);
                TracingAdapter.Enter(invocationId, this, "ListNextAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + Uri.EscapeDataString(nextLink);
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
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
                    DelegatedOfferListResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DelegatedOfferListResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    DelegatedOfferModel delegatedOfferModelInstance = new DelegatedOfferModel();
                                    result.DelegatedOffers.Add(delegatedOfferModelInstance);
                                    
                                    JToken offerNameValue = valueValue["offerName"];
                                    if (offerNameValue != null && offerNameValue.Type != JTokenType.Null)
                                    {
                                        string offerNameInstance = ((string)offerNameValue);
                                        delegatedOfferModelInstance.OfferName = offerNameInstance;
                                    }
                                    
                                    JToken externalReferenceIdValue = valueValue["externalReferenceId"];
                                    if (externalReferenceIdValue != null && externalReferenceIdValue.Type != JTokenType.Null)
                                    {
                                        string externalReferenceIdInstance = ((string)externalReferenceIdValue);
                                        delegatedOfferModelInstance.ExternalReferenceId = externalReferenceIdInstance;
                                    }
                                    
                                    JToken accessibilityStateValue = valueValue["accessibilityState"];
                                    if (accessibilityStateValue != null && accessibilityStateValue.Type != JTokenType.Null)
                                    {
                                        AccessibilityState accessibilityStateInstance = ((AccessibilityState)Enum.Parse(typeof(AccessibilityState), ((string)accessibilityStateValue), true));
                                        delegatedOfferModelInstance.AccessibilityState = accessibilityStateInstance;
                                    }
                                    
                                    JToken decommissionedByParentProviderValue = valueValue["decommissionedByParentProvider"];
                                    if (decommissionedByParentProviderValue != null && decommissionedByParentProviderValue.Type != JTokenType.Null)
                                    {
                                        bool decommissionedByParentProviderInstance = ((bool)decommissionedByParentProviderValue);
                                        delegatedOfferModelInstance.DecommissionedByParentProvider = decommissionedByParentProviderInstance;
                                    }
                                }
                            }
                            
                            JToken odatanextLinkValue = responseDoc["@odata.nextLink"];
                            if (odatanextLinkValue != null && odatanextLinkValue.Type != JTokenType.Null)
                            {
                                string odatanextLinkInstance = ((string)odatanextLinkValue);
                                result.NextLink = odatanextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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
        /// Update a delegated offer.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='parameters'>
        /// Required. Parameters to update delegated offer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Delegated offer update result.
        /// </returns>
        public async Task<DelegatedOfferUpdateResult> UpdateAsync(DelegatedOfferUpdateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.DelegatedOffer == null)
            {
                throw new ArgumentNullException("parameters.DelegatedOffer");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "UpdateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/providers/Microsoft.Subscriptions/delegatedoffers/";
            if (parameters.DelegatedOffer.OfferName != null)
            {
                url = url + Uri.EscapeDataString(parameters.DelegatedOffer.OfferName);
            }
            List<string> queryParameters = new List<string>();
            if (this.Client.ApiVersion != null)
            {
                queryParameters.Add("api-version=" + Uri.EscapeDataString(this.Client.ApiVersion));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
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
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject delegatedOfferUpdateParametersValue = new JObject();
                requestDoc = delegatedOfferUpdateParametersValue;
                
                if (parameters.DelegatedOffer.OfferName != null)
                {
                    delegatedOfferUpdateParametersValue["offerName"] = parameters.DelegatedOffer.OfferName;
                }
                
                if (parameters.DelegatedOffer.ExternalReferenceId != null)
                {
                    delegatedOfferUpdateParametersValue["externalReferenceId"] = parameters.DelegatedOffer.ExternalReferenceId;
                }
                
                delegatedOfferUpdateParametersValue["accessibilityState"] = parameters.DelegatedOffer.AccessibilityState.ToString();
                
                delegatedOfferUpdateParametersValue["decommissionedByParentProvider"] = parameters.DelegatedOffer.DecommissionedByParentProvider;
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
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
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Created)
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
                    DelegatedOfferUpdateResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Created)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DelegatedOfferUpdateResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            DelegatedOfferModel delegatedOfferInstance = new DelegatedOfferModel();
                            result.DelegatedOffer = delegatedOfferInstance;
                            
                            JToken offerNameValue = responseDoc["offerName"];
                            if (offerNameValue != null && offerNameValue.Type != JTokenType.Null)
                            {
                                string offerNameInstance = ((string)offerNameValue);
                                delegatedOfferInstance.OfferName = offerNameInstance;
                            }
                            
                            JToken externalReferenceIdValue = responseDoc["externalReferenceId"];
                            if (externalReferenceIdValue != null && externalReferenceIdValue.Type != JTokenType.Null)
                            {
                                string externalReferenceIdInstance = ((string)externalReferenceIdValue);
                                delegatedOfferInstance.ExternalReferenceId = externalReferenceIdInstance;
                            }
                            
                            JToken accessibilityStateValue = responseDoc["accessibilityState"];
                            if (accessibilityStateValue != null && accessibilityStateValue.Type != JTokenType.Null)
                            {
                                AccessibilityState accessibilityStateInstance = ((AccessibilityState)Enum.Parse(typeof(AccessibilityState), ((string)accessibilityStateValue), true));
                                delegatedOfferInstance.AccessibilityState = accessibilityStateInstance;
                            }
                            
                            JToken decommissionedByParentProviderValue = responseDoc["decommissionedByParentProvider"];
                            if (decommissionedByParentProviderValue != null && decommissionedByParentProviderValue.Type != JTokenType.Null)
                            {
                                bool decommissionedByParentProviderInstance = ((bool)decommissionedByParentProviderValue);
                                delegatedOfferInstance.DecommissionedByParentProvider = decommissionedByParentProviderInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
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
