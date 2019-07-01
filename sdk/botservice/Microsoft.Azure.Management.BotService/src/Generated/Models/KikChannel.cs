// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Kik channel definition
    /// </summary>
    public partial class KikChannel : Channel
    {
        /// <summary>
        /// Initializes a new instance of the KikChannel class.
        /// </summary>
        public KikChannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KikChannel class.
        /// </summary>
        /// <param name="properties">The set of properties specific to Kik
        /// channel resource</param>
        public KikChannel(KikChannelProperties properties = default(KikChannelProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of properties specific to Kik channel resource
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public KikChannelProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}