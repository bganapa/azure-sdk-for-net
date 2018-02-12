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
    /// Offer delegation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DelegatedOffer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DelegatedOffer class.
        /// </summary>
        public DelegatedOffer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DelegatedOffer class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="resourceTags">Resource tags.</param>
        /// <param name="delegatedProviderSubscriptionId">Identifier of the
        /// DelegatedProvider subscription that delegated the offer.</param>
        /// <param name="offerName">Name of the base admin offer.</param>
        /// <param name="offerDisplayName">Display name of the base admin
        /// offer.</param>
        /// <param name="offerDescription">Description of the base admin
        /// offer.</param>
        /// <param name="offerResourceGroupName">Resource group name of the
        /// base admin offer.</param>
        /// <param name="delegatedProviderOfferName">Name of the base
        /// DelegatedProvider offer (when the DelegatedProvider is not the
        /// admin subscription).</param>
        /// <param name="delegatedProviderOfferDisplayName">Display name of the
        /// base DelegatedProvider offer (when the DelegatedProvider is not the
        /// admin subscription).</param>
        /// <param name="delegatedProviderOfferDescription">Description of the
        /// base DelegatedProvider offer (when the DelegatedProvider is not the
        /// admin subscription).</param>
        /// <param name="delegatedProviderOfferResourceGroupName">Resource
        /// group name of the base DelegatedProvider offer (when the
        /// DelegatedProvider is not the admin subscription).</param>
        /// <param name="subscriptionId">Identifier of the subscription
        /// receiving the delegated offer.</param>
        public DelegatedOffer(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, string> resourceTags = default(IDictionary<string, string>), string delegatedProviderSubscriptionId = default(string), string offerName = default(string), string offerDisplayName = default(string), string offerDescription = default(string), string offerResourceGroupName = default(string), string delegatedProviderOfferName = default(string), string delegatedProviderOfferDisplayName = default(string), string delegatedProviderOfferDescription = default(string), string delegatedProviderOfferResourceGroupName = default(string), string subscriptionId = default(string))
            : base(id, name, type, location, tags)
        {
            ResourceTags = resourceTags;
            DelegatedProviderSubscriptionId = delegatedProviderSubscriptionId;
            OfferName = offerName;
            OfferDisplayName = offerDisplayName;
            OfferDescription = offerDescription;
            OfferResourceGroupName = offerResourceGroupName;
            DelegatedProviderOfferName = delegatedProviderOfferName;
            DelegatedProviderOfferDisplayName = delegatedProviderOfferDisplayName;
            DelegatedProviderOfferDescription = delegatedProviderOfferDescription;
            DelegatedProviderOfferResourceGroupName = delegatedProviderOfferResourceGroupName;
            SubscriptionId = subscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceTags")]
        public IDictionary<string, string> ResourceTags { get; set; }

        /// <summary>
        /// Gets or sets identifier of the DelegatedProvider subscription that
        /// delegated the offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.delegatedProviderSubscriptionId")]
        public string DelegatedProviderSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets name of the base admin offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerName")]
        public string OfferName { get; set; }

        /// <summary>
        /// Gets or sets display name of the base admin offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerDisplayName")]
        public string OfferDisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of the base admin offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerDescription")]
        public string OfferDescription { get; set; }

        /// <summary>
        /// Gets or sets resource group name of the base admin offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerResourceGroupName")]
        public string OfferResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets name of the base DelegatedProvider offer (when the
        /// DelegatedProvider is not the admin subscription).
        /// </summary>
        [JsonProperty(PropertyName = "properties.delegatedProviderOfferName")]
        public string DelegatedProviderOfferName { get; set; }

        /// <summary>
        /// Gets or sets display name of the base DelegatedProvider offer (when
        /// the DelegatedProvider is not the admin subscription).
        /// </summary>
        [JsonProperty(PropertyName = "properties.delegatedProviderOfferDisplayName")]
        public string DelegatedProviderOfferDisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of the base DelegatedProvider offer (when
        /// the DelegatedProvider is not the admin subscription).
        /// </summary>
        [JsonProperty(PropertyName = "properties.delegatedProviderOfferDescription")]
        public string DelegatedProviderOfferDescription { get; set; }

        /// <summary>
        /// Gets or sets resource group name of the base DelegatedProvider
        /// offer (when the DelegatedProvider is not the admin subscription).
        /// </summary>
        [JsonProperty(PropertyName = "properties.delegatedProviderOfferResourceGroupName")]
        public string DelegatedProviderOfferResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets identifier of the subscription receiving the delegated
        /// offer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

    }
}
