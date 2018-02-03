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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Virtual Network configuration state.
    /// </summary>
    public partial class VirtualNetworkConfigurationState
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkConfigurationState
        /// class.
        /// </summary>
        public VirtualNetworkConfigurationState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkConfigurationState
        /// class.
        /// </summary>
        /// <param name="status">The virtual network status. Possible values
        /// include: 'Failure', 'Warning', 'Success', 'Uninitialized',
        /// 'InProgress', 'Unknown'</param>
        /// <param name="lastUpdatedTime">Last updated time for the running
        /// state.</param>
        /// <param name="virtualNetworkInterfaceErrors">List of NIC errors
        /// associated with the resource.</param>
        /// <param name="hostErrors">List of NIC errors associated with the
        /// resource.</param>
        public VirtualNetworkConfigurationState(string status = default(string), System.DateTime? lastUpdatedTime = default(System.DateTime?), IList<VirtualNetworkConfigurationStatus> virtualNetworkInterfaceErrors = default(IList<VirtualNetworkConfigurationStatus>), IList<VirtualNetworkConfigurationStatus> hostErrors = default(IList<VirtualNetworkConfigurationStatus>))
        {
            Status = status;
            LastUpdatedTime = lastUpdatedTime;
            VirtualNetworkInterfaceErrors = virtualNetworkInterfaceErrors;
            HostErrors = hostErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual network status. Possible values include:
        /// 'Failure', 'Warning', 'Success', 'Uninitialized', 'InProgress',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets last updated time for the running state.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Gets or sets list of NIC errors associated with the resource.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkInterfaceErrors")]
        public IList<VirtualNetworkConfigurationStatus> VirtualNetworkInterfaceErrors { get; set; }

        /// <summary>
        /// Gets or sets list of NIC errors associated with the resource.
        /// </summary>
        [JsonProperty(PropertyName = "hostErrors")]
        public IList<VirtualNetworkConfigurationStatus> HostErrors { get; set; }

    }
}