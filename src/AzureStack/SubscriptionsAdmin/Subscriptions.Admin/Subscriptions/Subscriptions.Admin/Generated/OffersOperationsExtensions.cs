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
    /// Extension methods for OffersOperations.
    /// </summary>
    public static partial class OffersOperationsExtensions
    {
            /// <summary>
            /// Get the list of offers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Offer> ListAll(this IOffersOperations operations)
            {
                return operations.ListAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of offers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Offer>> ListAllAsync(this IOffersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of offers under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            public static IPage<Offer> List(this IOffersOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of offers under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Offer>> ListAsync(this IOffersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            public static Offer Get(this IOffersOperations operations, string resourceGroupName, string offer)
            {
                return operations.GetAsync(resourceGroupName, offer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Offer> GetAsync(this IOffersOperations operations, string resourceGroupName, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, offer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='newOffer'>
            /// New offer.
            /// </param>
            public static Offer CreateOrUpdate(this IOffersOperations operations, string resourceGroupName, string offer, Offer newOffer)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, offer, newOffer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='newOffer'>
            /// New offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Offer> CreateOrUpdateAsync(this IOffersOperations operations, string resourceGroupName, string offer, Offer newOffer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, offer, newOffer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the specified offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            public static void Delete(this IOffersOperations operations, string resourceGroupName, string offer)
            {
                operations.DeleteAsync(resourceGroupName, offer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the specified offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IOffersOperations operations, string resourceGroupName, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, offer, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the offer metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            public static MetricList ListMetrics(this IOffersOperations operations, string resourceGroupName, string offer)
            {
                return operations.ListMetricsAsync(resourceGroupName, offer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the offer metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MetricList> ListMetricsAsync(this IOffersOperations operations, string resourceGroupName, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, offer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            public static MetricDefinitionList ListMetricDefinitions(this IOffersOperations operations, string resourceGroupName, string offer)
            {
                return operations.ListMetricDefinitionsAsync(resourceGroupName, offer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MetricDefinitionList> ListMetricDefinitionsAsync(this IOffersOperations operations, string resourceGroupName, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, offer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Links a plan to an offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='planLink'>
            /// New plan link.
            /// </param>
            public static void Link(this IOffersOperations operations, string resourceGroupName, string offer, PlanLinkDefinition planLink)
            {
                operations.LinkAsync(resourceGroupName, offer, planLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Links a plan to an offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='planLink'>
            /// New plan link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task LinkAsync(this IOffersOperations operations, string resourceGroupName, string offer, PlanLinkDefinition planLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.LinkWithHttpMessagesAsync(resourceGroupName, offer, planLink, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Unlink a plan from an offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='planLink'>
            /// New plan link.
            /// </param>
            public static void Unlink(this IOffersOperations operations, string resourceGroupName, string offer, PlanLinkDefinition planLink)
            {
                operations.UnlinkAsync(resourceGroupName, offer, planLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unlink a plan from an offer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group the resource is located under.
            /// </param>
            /// <param name='offer'>
            /// Name of an offer.
            /// </param>
            /// <param name='planLink'>
            /// New plan link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UnlinkAsync(this IOffersOperations operations, string resourceGroupName, string offer, PlanLinkDefinition planLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UnlinkWithHttpMessagesAsync(resourceGroupName, offer, planLink, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the list of offers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Offer> ListAllNext(this IOffersOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of offers.
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
            public static async Task<IPage<Offer>> ListAllNextAsync(this IOffersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of offers under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Offer> ListNext(this IOffersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of offers under a resource group.
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
            public static async Task<IPage<Offer>> ListNextAsync(this IOffersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
