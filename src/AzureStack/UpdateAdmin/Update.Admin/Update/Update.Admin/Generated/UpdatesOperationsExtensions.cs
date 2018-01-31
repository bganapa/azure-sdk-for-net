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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UpdatesOperations.
    /// </summary>
    public static partial class UpdatesOperationsExtensions
    {
            /// <summary>
            /// Get the list of update locations
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
            public static IPage<Update> List(this IUpdatesOperations operations, string location, string updateLocation)
            {
                return operations.ListAsync(location, updateLocation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of update locations
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
            public static async Task<IPage<Update>> ListAsync(this IUpdatesOperations operations, string location, string updateLocation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, updateLocation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a specific update at an update location.
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
            /// <param name='update'>
            /// Name of the update.
            /// </param>
            public static Update Get(this IUpdatesOperations operations, string location, string updateLocation, string update)
            {
                return operations.GetAsync(location, updateLocation, update).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a specific update at an update location.
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
            /// <param name='update'>
            /// Name of the update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Update> GetAsync(this IUpdatesOperations operations, string location, string updateLocation, string update, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, updateLocation, update, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Apply a specific update at an update location.
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
            /// <param name='update'>
            /// Name of the update.
            /// </param>
            public static Update Apply(this IUpdatesOperations operations, string location, string updateLocation, string update)
            {
                return operations.ApplyAsync(location, updateLocation, update).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Apply a specific update at an update location.
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
            /// <param name='update'>
            /// Name of the update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Update> ApplyAsync(this IUpdatesOperations operations, string location, string updateLocation, string update, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApplyWithHttpMessagesAsync(location, updateLocation, update, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Apply a specific update at an update location.
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
            /// <param name='update'>
            /// Name of the update.
            /// </param>
            public static Update BeginApply(this IUpdatesOperations operations, string location, string updateLocation, string update)
            {
                return operations.BeginApplyAsync(location, updateLocation, update).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Apply a specific update at an update location.
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
            /// <param name='update'>
            /// Name of the update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Update> BeginApplyAsync(this IUpdatesOperations operations, string location, string updateLocation, string update, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginApplyWithHttpMessagesAsync(location, updateLocation, update, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of update locations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Update> ListNext(this IUpdatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of update locations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Update>> ListNextAsync(this IUpdatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
