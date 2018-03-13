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
    /// Extension methods for AcquiredPlansOperations.
    /// </summary>
    public static partial class AcquiredPlansOperationsExtensions
    {
            /// <summary>
            /// Get a collection of all acquired plans that subscription has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            public static IPage<PlanAcquisition> List(this IAcquiredPlansOperations operations, string targetSubscriptionId)
            {
                return operations.ListAsync(targetSubscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a collection of all acquired plans that subscription has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PlanAcquisition>> ListAsync(this IAcquiredPlansOperations operations, string targetSubscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(targetSubscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an acquired plan from name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            /// <param name='planAcquisitionId'>
            /// The plan acquisition Identifier
            /// </param>
            public static PlanAcquisition Get(this IAcquiredPlansOperations operations, string targetSubscriptionId, string planAcquisitionId)
            {
                return operations.GetAsync(targetSubscriptionId, planAcquisitionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an acquired plan from name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            /// <param name='planAcquisitionId'>
            /// The plan acquisition Identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlanAcquisition> GetAsync(this IAcquiredPlansOperations operations, string targetSubscriptionId, string planAcquisitionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(targetSubscriptionId, planAcquisitionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an acquired plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            /// <param name='planAcquisitionId'>
            /// The plan acquisition Identifier
            /// </param>
            public static void Delete(this IAcquiredPlansOperations operations, string targetSubscriptionId, string planAcquisitionId)
            {
                operations.DeleteAsync(targetSubscriptionId, planAcquisitionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an acquired plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            /// <param name='planAcquisitionId'>
            /// The plan acquisition Identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAcquiredPlansOperations operations, string targetSubscriptionId, string planAcquisitionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(targetSubscriptionId, planAcquisitionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates an acquired plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            /// <param name='planAcquisitionId'>
            /// The plan acquisition Identifier
            /// </param>
            /// <param name='newAcquiredPlan'>
            /// The new acquired plan.
            /// </param>
            public static PlanAcquisition Create(this IAcquiredPlansOperations operations, string targetSubscriptionId, string planAcquisitionId, PlanAcquisition newAcquiredPlan)
            {
                return operations.CreateAsync(targetSubscriptionId, planAcquisitionId, newAcquiredPlan).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an acquired plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetSubscriptionId'>
            /// The target subscription ID.
            /// </param>
            /// <param name='planAcquisitionId'>
            /// The plan acquisition Identifier
            /// </param>
            /// <param name='newAcquiredPlan'>
            /// The new acquired plan.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PlanAcquisition> CreateAsync(this IAcquiredPlansOperations operations, string targetSubscriptionId, string planAcquisitionId, PlanAcquisition newAcquiredPlan, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(targetSubscriptionId, planAcquisitionId, newAcquiredPlan, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a collection of all acquired plans that subscription has access to.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PlanAcquisition> ListNext(this IAcquiredPlansOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a collection of all acquired plans that subscription has access to.
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
            public static async Task<IPage<PlanAcquisition>> ListNextAsync(this IAcquiredPlansOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
