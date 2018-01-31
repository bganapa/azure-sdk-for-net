// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Update.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UpdateLocationsOperations.
    /// </summary>
    public static partial class UpdateLocationsOperationsExtensions
    {
            /// <summary>
            /// Get the list of update locations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the AzureStack instance.
            /// </param>
            public static IEnumerable<UpdateLocation> List(this IUpdateLocationsOperations operations, string location)
            {
                return operations.ListAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of update locations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the AzureStack instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<UpdateLocation>> ListAsync(this IUpdateLocationsOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an update location based on name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the AzureStack instance.
            /// </param>
            /// <param name='updateLocation'>
            /// The name of the update location.
            /// </param>
            public static UpdateLocation Get(this IUpdateLocationsOperations operations, string location, string updateLocation)
            {
                return operations.GetAsync(location, updateLocation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an update location based on name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the AzureStack instance.
            /// </param>
            /// <param name='updateLocation'>
            /// The name of the update location.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UpdateLocation> GetAsync(this IUpdateLocationsOperations operations, string location, string updateLocation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, updateLocation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
