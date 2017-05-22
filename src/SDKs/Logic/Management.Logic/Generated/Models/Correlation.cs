// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The correlation property.
    /// </summary>
    public partial class Correlation
    {
        /// <summary>
        /// Initializes a new instance of the Correlation class.
        /// </summary>
        public Correlation() { }

        /// <summary>
        /// Initializes a new instance of the Correlation class.
        /// </summary>
        /// <param name="clientTrackingId">The client tracking id.</param>
        public Correlation(string clientTrackingId = default(string))
        {
            ClientTrackingId = clientTrackingId;
        }

        /// <summary>
        /// Gets or sets the client tracking id.
        /// </summary>
        [JsonProperty(PropertyName = "clientTrackingId")]
        public string ClientTrackingId { get; set; }

    }
}
