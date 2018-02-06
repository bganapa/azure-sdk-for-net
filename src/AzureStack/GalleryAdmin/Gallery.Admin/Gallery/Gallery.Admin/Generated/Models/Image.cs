// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Gallery.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Image
    {
        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        public Image()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        public Image(string id = default(string), string uri = default(string), string type = default(string))
        {
            Id = id;
            Uri = uri;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
