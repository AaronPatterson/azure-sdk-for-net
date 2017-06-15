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
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.TrafficManager;
using Microsoft.Azure.Management.TrafficManager.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.TrafficManager
{
    /// <summary>
    /// Operations for retrieving the Geographic Hierarchy for use with
    /// Geographic traffic routing.
    /// </summary>
    internal partial class GeographicHierarchyOperations : IServiceOperations<TrafficManagerManagementClient>, IGeographicHierarchyOperations
    {
        /// <summary>
        /// Initializes a new instance of the GeographicHierarchyOperations
        /// class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal GeographicHierarchyOperations(TrafficManagerManagementClient client)
        {
            this._client = client;
        }
        
        private TrafficManagerManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.TrafficManager.TrafficManagerManagementClient.
        /// </summary>
        public TrafficManagerManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Gets a hierarchy of regions for use with the Geographic Traffic
        /// Routing Method.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'CreateOrUpdate'
        /// operation.
        /// </returns>
        public async Task<GeographicHierarchyGetResponse> GetDefaultAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                TracingAdapter.Enter(invocationId, this, "GetDefaultAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "providers/";
            url = url + "Microsoft.Network";
            url = url + "/trafficManagerGeographicHierarchies/default";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2017-03-01");
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
                    if (statusCode >= HttpStatusCode.BadRequest)
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
                    GeographicHierarchyGetResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new GeographicHierarchyGetResponse();
                    JToken responseDoc = null;
                    if (string.IsNullOrEmpty(responseContent) == false)
                    {
                        responseDoc = JToken.Parse(responseContent);
                    }
                    
                    if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                    {
                        GeographicHierarchy geographicHierarchyInstance = new GeographicHierarchy();
                        result.GeographicHierarchy = geographicHierarchyInstance;
                        
                        JToken propertiesValue = responseDoc["properties"];
                        if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                        {
                            GeographicHierarchyProperties propertiesInstance = new GeographicHierarchyProperties();
                            geographicHierarchyInstance.Properties = propertiesInstance;
                            
                            JToken geographicHierarchyValue = propertiesValue["geographicHierarchy"];
                            if (geographicHierarchyValue != null && geographicHierarchyValue.Type != JTokenType.Null)
                            {
                                HierarchyRoot geographicHierarchyInstance2 = new HierarchyRoot();
                                propertiesInstance.Root = geographicHierarchyInstance2;
                                
                                JToken regionsArray = geographicHierarchyValue["regions"];
                                if (regionsArray != null && regionsArray.Type != JTokenType.Null)
                                {
                                    geographicHierarchyInstance2.Regions = new List<RegionalGrouping>();
                                    foreach (JToken regionsValue in ((JArray)regionsArray))
                                    {
                                        RegionalGrouping regionalGroupingInstance = new RegionalGrouping();
                                        geographicHierarchyInstance2.Regions.Add(regionalGroupingInstance);
                                        
                                        JToken regionsArray2 = regionsValue["regions"];
                                        if (regionsArray2 != null && regionsArray2.Type != JTokenType.Null)
                                        {
                                            regionalGroupingInstance.Regions = new List<CountryRegion>();
                                            foreach (JToken regionsValue2 in ((JArray)regionsArray2))
                                            {
                                                CountryRegion countryRegionInstance = new CountryRegion();
                                                regionalGroupingInstance.Regions.Add(countryRegionInstance);
                                                
                                                JToken regionsArray3 = regionsValue2["regions"];
                                                if (regionsArray3 != null && regionsArray3.Type != JTokenType.Null)
                                                {
                                                    countryRegionInstance.Regions = new List<StateProvince>();
                                                    foreach (JToken regionsValue3 in ((JArray)regionsArray3))
                                                    {
                                                        StateProvince stateProvinceInstance = new StateProvince();
                                                        countryRegionInstance.Regions.Add(stateProvinceInstance);
                                                        
                                                        JToken codeValue = regionsValue3["code"];
                                                        if (codeValue != null && codeValue.Type != JTokenType.Null)
                                                        {
                                                            string codeInstance = ((string)codeValue);
                                                            stateProvinceInstance.Code = codeInstance;
                                                        }
                                                        
                                                        JToken nameValue = regionsValue3["name"];
                                                        if (nameValue != null && nameValue.Type != JTokenType.Null)
                                                        {
                                                            string nameInstance = ((string)nameValue);
                                                            stateProvinceInstance.Name = nameInstance;
                                                        }
                                                    }
                                                }
                                                
                                                JToken codeValue2 = regionsValue2["code"];
                                                if (codeValue2 != null && codeValue2.Type != JTokenType.Null)
                                                {
                                                    string codeInstance2 = ((string)codeValue2);
                                                    countryRegionInstance.Code = codeInstance2;
                                                }
                                                
                                                JToken nameValue2 = regionsValue2["name"];
                                                if (nameValue2 != null && nameValue2.Type != JTokenType.Null)
                                                {
                                                    string nameInstance2 = ((string)nameValue2);
                                                    countryRegionInstance.Name = nameInstance2;
                                                }
                                            }
                                        }
                                        
                                        JToken codeValue3 = regionsValue["code"];
                                        if (codeValue3 != null && codeValue3.Type != JTokenType.Null)
                                        {
                                            string codeInstance3 = ((string)codeValue3);
                                            regionalGroupingInstance.Code = codeInstance3;
                                        }
                                        
                                        JToken nameValue3 = regionsValue["name"];
                                        if (nameValue3 != null && nameValue3.Type != JTokenType.Null)
                                        {
                                            string nameInstance3 = ((string)nameValue3);
                                            regionalGroupingInstance.Name = nameInstance3;
                                        }
                                    }
                                }
                                
                                JToken codeValue4 = geographicHierarchyValue["code"];
                                if (codeValue4 != null && codeValue4.Type != JTokenType.Null)
                                {
                                    string codeInstance4 = ((string)codeValue4);
                                    geographicHierarchyInstance2.Code = codeInstance4;
                                }
                                
                                JToken nameValue4 = geographicHierarchyValue["name"];
                                if (nameValue4 != null && nameValue4.Type != JTokenType.Null)
                                {
                                    string nameInstance4 = ((string)nameValue4);
                                    geographicHierarchyInstance2.Name = nameInstance4;
                                }
                            }
                        }
                        
                        JToken idValue = responseDoc["id"];
                        if (idValue != null && idValue.Type != JTokenType.Null)
                        {
                            string idInstance = ((string)idValue);
                            geographicHierarchyInstance.Id = idInstance;
                        }
                        
                        JToken nameValue5 = responseDoc["name"];
                        if (nameValue5 != null && nameValue5.Type != JTokenType.Null)
                        {
                            string nameInstance5 = ((string)nameValue5);
                            geographicHierarchyInstance.Name = nameInstance5;
                        }
                        
                        JToken typeValue = responseDoc["type"];
                        if (typeValue != null && typeValue.Type != JTokenType.Null)
                        {
                            string typeInstance = ((string)typeValue);
                            geographicHierarchyInstance.Type = typeInstance;
                        }
                        
                        JToken locationValue = responseDoc["location"];
                        if (locationValue != null && locationValue.Type != JTokenType.Null)
                        {
                            string locationInstance = ((string)locationValue);
                            geographicHierarchyInstance.Location = locationInstance;
                        }
                        
                        JToken tagsSequenceElement = ((JToken)responseDoc["tags"]);
                        if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                        {
                            foreach (JProperty property in tagsSequenceElement)
                            {
                                string tagsKey = ((string)property.Name);
                                string tagsValue = ((string)property.Value);
                                geographicHierarchyInstance.Tags.Add(tagsKey, tagsValue);
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