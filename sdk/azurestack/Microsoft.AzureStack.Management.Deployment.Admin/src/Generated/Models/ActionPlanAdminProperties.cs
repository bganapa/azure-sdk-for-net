// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Deployment.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Action Plan Properties
    /// </summary>
    public partial class ActionPlanAdminProperties
    {
        /// <summary>
        /// Initializes a new instance of the ActionPlanAdminProperties class.
        /// </summary>
        public ActionPlanAdminProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActionPlanAdminProperties class.
        /// </summary>
        /// <param name="actionPlanUri">Action plan uri</param>
        /// <param name="resourceGroupName">The target resource group
        /// name</param>
        /// <param name="subscriptionId">The target subscription
        /// identifier</param>
        /// <param name="parameters">The deployment parameters in JToken
        /// format</param>
        /// <param name="startTime">The deployment start time</param>
        /// <param name="endTime">The deployment end time</param>
        /// <param name="error">Error Information</param>
        /// <param name="provisioningState">The provisioning state</param>
        public ActionPlanAdminProperties(string actionPlanUri = default(string), string resourceGroupName = default(string), string subscriptionId = default(string), string parameters = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), ExtendedErrorInfo error = default(ExtendedErrorInfo), ProvisioningState provisioningState = default(ProvisioningState))
        {
            ActionPlanUri = actionPlanUri;
            ResourceGroupName = resourceGroupName;
            SubscriptionId = subscriptionId;
            Parameters = parameters;
            StartTime = startTime;
            EndTime = endTime;
            Error = error;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets action plan uri
        /// </summary>
        [JsonProperty(PropertyName = "actionPlanUri")]
        public string ActionPlanUri { get; set; }

        /// <summary>
        /// Gets or sets the target resource group name
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the target subscription identifier
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the deployment parameters in JToken format
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public string Parameters { get; set; }

        /// <summary>
        /// Gets or sets the deployment start time
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the deployment end time
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets error Information
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ExtendedErrorInfo Error { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public ProvisioningState ProvisioningState { get; set; }

    }
}
