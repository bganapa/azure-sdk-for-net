// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Update.Admin.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Pageable list of update runs.
    /// </summary>
    public partial class Step
    {
        /// <summary>
        /// Initializes a new instance of the Step class.
        /// </summary>
        public Step()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Step class.
        /// </summary>
        /// <param name="name">Name of the step.</param>
        /// <param name="description">Description of the step.</param>
        /// <param name="errorMessage">Error message if any.</param>
        /// <param name="status">State of the step.</param>
        /// <param name="startTimeUtc">Time at which this step started
        /// executing</param>
        /// <param name="endTimeUtc">Time at which this step stopped
        /// executing</param>
        /// <param name="stepProperty">Inner steps</param>
        public Step(string name = default(string), string description = default(string), string errorMessage = default(string), string status = default(string), System.DateTime? startTimeUtc = default(System.DateTime?), System.DateTime? endTimeUtc = default(System.DateTime?), IList<Step> stepProperty = default(IList<Step>))
        {
            Name = name;
            Description = description;
            ErrorMessage = errorMessage;
            Status = status;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            StepProperty = stepProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the step.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the step.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets error message if any.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets state of the step.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets time at which this step started executing
        /// </summary>
        [JsonProperty(PropertyName = "startTimeUtc")]
        public System.DateTime? StartTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets time at which this step stopped executing
        /// </summary>
        [JsonProperty(PropertyName = "endTimeUtc")]
        public System.DateTime? EndTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets inner steps
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public IList<Step> StepProperty { get; set; }

    }
}