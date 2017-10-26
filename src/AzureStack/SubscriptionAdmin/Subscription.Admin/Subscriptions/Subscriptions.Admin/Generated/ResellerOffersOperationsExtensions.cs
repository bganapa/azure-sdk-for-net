// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ResellerOffersOperations.
    /// </summary>
    public static partial class ResellerOffersOperationsExtensions
    {
            /// <summary>
            /// Get the list of delegatedProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProvider'>
            /// Reseller identifier.
            /// </param>
            public static IPage<DelegatedProviderOffer> List(this IResellerOffersOperations operations, string delegatedProvider)
            {
                return operations.ListAsync(delegatedProvider).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of delegatedProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProvider'>
            /// Reseller identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DelegatedProviderOffer>> ListAsync(this IResellerOffersOperations operations, string delegatedProvider, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(delegatedProvider, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of delegatedProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProvider'>
            /// Reseller identifier.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            public static DelegatedProviderOffer Get(this IResellerOffersOperations operations, string delegatedProvider, string offer)
            {
                return operations.GetAsync(delegatedProvider, offer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of delegatedProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProvider'>
            /// Reseller identifier.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DelegatedProviderOffer> GetAsync(this IResellerOffersOperations operations, string delegatedProvider, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(delegatedProvider, offer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of delegatedProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DelegatedProviderOffer> ListNext(this IResellerOffersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of delegatedProviders.
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
            public static async Task<IPage<DelegatedProviderOffer>> ListNextAsync(this IResellerOffersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
