// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an offering of services against which a subscription can be
    /// created.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Offer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Offer class.
        /// </summary>
        public Offer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Offer class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="offerName">Name of the Offer.</param>
        /// <param name="displayName">Display name of offer.</param>
        /// <param name="description">Description of offer.</param>
        /// <param name="externalReferenceId">External reference
        /// identifier.</param>
        /// <param name="state">Offer accessibility state. Possible values
        /// include: 'Private', 'Public', 'Decommissioned'</param>
        /// <param name="subscriptionCount">Current subscription count.</param>
        /// <param name="maxSubscriptionsPerAccount">Maximum subscriptions per
        /// account.</param>
        /// <param name="basePlanIds">Identifiers of the base plans that become
        /// available to the tenant immediately when a tenant subscribes to the
        /// offer.</param>
        /// <param name="addonPlanDefinition">References to add-on plans that a
        /// tenant can optionally acquire as a part of the offer.</param>
        public Offer(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string offerName = default(string), string displayName = default(string), string description = default(string), string externalReferenceId = default(string), string state = default(string), int? subscriptionCount = default(int?), int? maxSubscriptionsPerAccount = default(int?), IList<string> basePlanIds = default(IList<string>), IList<AddonPlanDefinition> addonPlanDefinition = default(IList<AddonPlanDefinition>))
            : base(id, name, type, location, tags)
        {
            OfferName = offerName;
            DisplayName = displayName;
            Description = description;
            ExternalReferenceId = externalReferenceId;
            State = state;
            SubscriptionCount = subscriptionCount;
            MaxSubscriptionsPerAccount = maxSubscriptionsPerAccount;
            BasePlanIds = basePlanIds;
            AddonPlanDefinition = addonPlanDefinition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string OfferName { get; set; }

        /// <summary>
        /// Gets or sets display name of offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets external reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        /// <summary>
        /// Gets or sets offer accessibility state. Possible values include:
        /// 'Private', 'Public', 'Decommissioned'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets current subscription count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionCount")]
        public int? SubscriptionCount { get; set; }

        /// <summary>
        /// Gets or sets maximum subscriptions per account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSubscriptionsPerAccount")]
        public int? MaxSubscriptionsPerAccount { get; set; }

        /// <summary>
        /// Gets or sets identifiers of the base plans that become available to
        /// the tenant immediately when a tenant subscribes to the offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.basePlanIds")]
        public IList<string> BasePlanIds { get; set; }

        /// <summary>
        /// Gets or sets references to add-on plans that a tenant can
        /// optionally acquire as a part of the offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addonPlanDefinition")]
        public IList<AddonPlanDefinition> AddonPlanDefinition { get; set; }

    }
}
