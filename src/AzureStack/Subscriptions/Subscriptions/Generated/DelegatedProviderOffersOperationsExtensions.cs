// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DelegatedProviderOffersOperations.
    /// </summary>
    public static partial class DelegatedProviderOffersOperationsExtensions
    {
            /// <summary>
            /// Get the list of offers for the specified delegated provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProviderId'>
            /// Id of the delegated provider.
            /// </param>
            public static IPage<Offer> List(this IDelegatedProviderOffersOperations operations, string delegatedProviderId)
            {
                return operations.ListAsync(delegatedProviderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of offers for the specified delegated provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProviderId'>
            /// Id of the delegated provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Offer>> ListAsync(this IDelegatedProviderOffersOperations operations, string delegatedProviderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(delegatedProviderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified offer for the delegated provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProviderId'>
            /// Id of the delegated provider.
            /// </param>
            /// <param name='offerName'>
            /// Name of the offer.
            /// </param>
            public static Offer Get(this IDelegatedProviderOffersOperations operations, string delegatedProviderId, string offerName)
            {
                return operations.GetAsync(delegatedProviderId, offerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified offer for the delegated provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='delegatedProviderId'>
            /// Id of the delegated provider.
            /// </param>
            /// <param name='offerName'>
            /// Name of the offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Offer> GetAsync(this IDelegatedProviderOffersOperations operations, string delegatedProviderId, string offerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(delegatedProviderId, offerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of offers for the specified delegated provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Offer> ListNext(this IDelegatedProviderOffersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of offers for the specified delegated provider.
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
            public static async Task<IPage<Offer>> ListNextAsync(this IDelegatedProviderOffersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}