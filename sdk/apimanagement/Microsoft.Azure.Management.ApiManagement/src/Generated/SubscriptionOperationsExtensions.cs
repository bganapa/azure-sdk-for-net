// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubscriptionOperations.
    /// </summary>
    public static partial class SubscriptionOperationsExtensions
    {
            /// <summary>
            /// Lists all subscriptions of the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<SubscriptionContract> List(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, ODataQuery<SubscriptionContract> odataQuery = default(ODataQuery<SubscriptionContract>))
            {
                return operations.ListAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all subscriptions of the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SubscriptionContract>> ListAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, ODataQuery<SubscriptionContract> odataQuery = default(ODataQuery<SubscriptionContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the apimanagement subscription
            /// specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            public static SubscriptionGetEntityTagHeaders GetEntityTag(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, sid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the apimanagement subscription
            /// specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionGetEntityTagHeaders> GetEntityTagAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, sid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the specified Subscription entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            public static SubscriptionContract Get(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid)
            {
                return operations.GetAsync(resourceGroupName, serviceName, sid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Subscription entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionContract> GetAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, sid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the subscription of specified user to the specified
            /// product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='notify'>
            /// Notify change in Subscription State.
            /// - If false, do not send any email notification for change of state of
            /// subscription
            /// - If true, send email notification of change of state of subscription
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static SubscriptionContract CreateOrUpdate(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionCreateParameters parameters, bool? notify = default(bool?), string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, sid, parameters, notify, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the subscription of specified user to the specified
            /// product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='notify'>
            /// Notify change in Subscription State.
            /// - If false, do not send any email notification for change of state of
            /// subscription
            /// - If true, send email notification of change of state of subscription
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionContract> CreateOrUpdateAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionCreateParameters parameters, bool? notify = default(bool?), string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, sid, parameters, notify, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the details of a subscription specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='notify'>
            /// Notify change in Subscription State.
            /// - If false, do not send any email notification for change of state of
            /// subscription
            /// - If true, send email notification of change of state of subscription
            /// </param>
            public static void Update(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionUpdateParameters parameters, string ifMatch, bool? notify = default(bool?))
            {
                operations.UpdateAsync(resourceGroupName, serviceName, sid, parameters, ifMatch, notify).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the details of a subscription specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='notify'>
            /// Notify change in Subscription State.
            /// - If false, do not send any email notification for change of state of
            /// subscription
            /// - If true, send email notification of change of state of subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, SubscriptionUpdateParameters parameters, string ifMatch, bool? notify = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, sid, parameters, ifMatch, notify, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, sid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, sid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Regenerates primary key of existing subscription of the API Management
            /// service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            public static void RegeneratePrimaryKey(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid)
            {
                operations.RegeneratePrimaryKeyAsync(resourceGroupName, serviceName, sid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates primary key of existing subscription of the API Management
            /// service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegeneratePrimaryKeyAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegeneratePrimaryKeyWithHttpMessagesAsync(resourceGroupName, serviceName, sid, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Regenerates secondary key of existing subscription of the API Management
            /// service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            public static void RegenerateSecondaryKey(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid)
            {
                operations.RegenerateSecondaryKeyAsync(resourceGroupName, serviceName, sid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates secondary key of existing subscription of the API Management
            /// service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='sid'>
            /// Subscription entity Identifier. The entity represents the association
            /// between a user and a product in API Management.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegenerateSecondaryKeyAsync(this ISubscriptionOperations operations, string resourceGroupName, string serviceName, string sid, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegenerateSecondaryKeyWithHttpMessagesAsync(resourceGroupName, serviceName, sid, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all subscriptions of the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SubscriptionContract> ListNext(this ISubscriptionOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all subscriptions of the API Management service instance.
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
            public static async Task<IPage<SubscriptionContract>> ListNextAsync(this ISubscriptionOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}