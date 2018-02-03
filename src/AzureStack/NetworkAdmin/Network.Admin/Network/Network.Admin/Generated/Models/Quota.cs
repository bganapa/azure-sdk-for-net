// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Network.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Network quota resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Quota : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Quota class.
        /// </summary>
        public Quota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Quota class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="maxPublicIpsPerSubscription">Maximum number of Public
        /// IP Addresses a tenant subscription can provision.</param>
        /// <param name="maxVnetsPerSubscription">Maximum number of Virtual
        /// Networks a tenant subscription can provision.</param>
        /// <param name="maxVirtualNetworkGatewaysPerSubscription">Maximum
        /// number of Virtual Network Gateways a tenant subscription can
        /// provision.</param>
        /// <param
        /// name="maxVirtualNetworkGatewayConnectionsPerSubscription">Maximum
        /// number of Virtual Network Gateway Connections a tenant subscription
        /// can provision.</param>
        /// <param name="maxLoadBalancersPerSubscription">Maximum number of
        /// Load Balancers a tenant subscription can provision.</param>
        /// <param name="maxNicsPerSubscription">Maximum number of NICs a
        /// tenant subscription can provision.</param>
        /// <param name="maxSecurityGroupsPerSubscription">Maximum number of
        /// Security Groups a tenant subscription can provision.</param>
        /// <param name="migrationPhase">State of migration such as None,
        /// Prepare, Commit and Abort. Possible values include: 'None',
        /// 'Prepare', 'Commit', 'Abort'</param>
        public Quota(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), long? maxPublicIpsPerSubscription = default(long?), long? maxVnetsPerSubscription = default(long?), long? maxVirtualNetworkGatewaysPerSubscription = default(long?), long? maxVirtualNetworkGatewayConnectionsPerSubscription = default(long?), long? maxLoadBalancersPerSubscription = default(long?), long? maxNicsPerSubscription = default(long?), long? maxSecurityGroupsPerSubscription = default(long?), string migrationPhase = default(string))
            : base(id, name, type, location, tags)
        {
            MaxPublicIpsPerSubscription = maxPublicIpsPerSubscription;
            MaxVnetsPerSubscription = maxVnetsPerSubscription;
            MaxVirtualNetworkGatewaysPerSubscription = maxVirtualNetworkGatewaysPerSubscription;
            MaxVirtualNetworkGatewayConnectionsPerSubscription = maxVirtualNetworkGatewayConnectionsPerSubscription;
            MaxLoadBalancersPerSubscription = maxLoadBalancersPerSubscription;
            MaxNicsPerSubscription = maxNicsPerSubscription;
            MaxSecurityGroupsPerSubscription = maxSecurityGroupsPerSubscription;
            MigrationPhase = migrationPhase;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets maximum number of Public IP Addresses a tenant
        /// subscription can provision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxPublicIpsPerSubscription")]
        public long? MaxPublicIpsPerSubscription { get; set; }

        /// <summary>
        /// Gets or sets maximum number of Virtual Networks a tenant
        /// subscription can provision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxVnetsPerSubscription")]
        public long? MaxVnetsPerSubscription { get; set; }

        /// <summary>
        /// Gets or sets maximum number of Virtual Network Gateways a tenant
        /// subscription can provision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxVirtualNetworkGatewaysPerSubscription")]
        public long? MaxVirtualNetworkGatewaysPerSubscription { get; set; }

        /// <summary>
        /// Gets or sets maximum number of Virtual Network Gateway Connections
        /// a tenant subscription can provision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxVirtualNetworkGatewayConnectionsPerSubscription")]
        public long? MaxVirtualNetworkGatewayConnectionsPerSubscription { get; set; }

        /// <summary>
        /// Gets or sets maximum number of Load Balancers a tenant subscription
        /// can provision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxLoadBalancersPerSubscription")]
        public long? MaxLoadBalancersPerSubscription { get; set; }

        /// <summary>
        /// Gets or sets maximum number of NICs a tenant subscription can
        /// provision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxNicsPerSubscription")]
        public long? MaxNicsPerSubscription { get; set; }

        /// <summary>
        /// Gets or sets maximum number of Security Groups a tenant
        /// subscription can provision.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSecurityGroupsPerSubscription")]
        public long? MaxSecurityGroupsPerSubscription { get; set; }

        /// <summary>
        /// Gets or sets state of migration such as None, Prepare, Commit and
        /// Abort. Possible values include: 'None', 'Prepare', 'Commit',
        /// 'Abort'
        /// </summary>
        [JsonProperty(PropertyName = "properties.migrationPhase")]
        public string MigrationPhase { get; set; }

    }
}