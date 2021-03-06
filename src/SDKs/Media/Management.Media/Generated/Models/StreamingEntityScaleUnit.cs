// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// scale units definition
    /// </summary>
    public partial class StreamingEntityScaleUnit
    {
        /// <summary>
        /// Initializes a new instance of the StreamingEntityScaleUnit class.
        /// </summary>
        public StreamingEntityScaleUnit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamingEntityScaleUnit class.
        /// </summary>
        /// <param name="scaleUnit">The scale unit number of the
        /// StreamingEndpoint.</param>
        public StreamingEntityScaleUnit(int? scaleUnit = default(int?))
        {
            ScaleUnit = scaleUnit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the scale unit number of the StreamingEndpoint.
        /// </summary>
        [JsonProperty(PropertyName = "scaleUnit")]
        public int? ScaleUnit { get; set; }

    }
}
