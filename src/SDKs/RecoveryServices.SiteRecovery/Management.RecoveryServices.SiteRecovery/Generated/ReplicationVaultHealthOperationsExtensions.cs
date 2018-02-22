// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationVaultHealthOperations.
    /// </summary>
    public static partial class ReplicationVaultHealthOperationsExtensions
    {
            /// <summary>
            /// Gets the health summary for the vault.
            /// </summary>
            /// <remarks>
            /// Gets the health details of the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static VaultHealthDetails Get(this IReplicationVaultHealthOperations operations)
            {
                return operations.GetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the health summary for the vault.
            /// </summary>
            /// <remarks>
            /// Gets the health details of the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultHealthDetails> GetAsync(this IReplicationVaultHealthOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refreshes health summary of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static VaultHealthDetails Refresh(this IReplicationVaultHealthOperations operations)
            {
                return operations.RefreshAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refreshes health summary of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultHealthDetails> RefreshAsync(this IReplicationVaultHealthOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RefreshWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refreshes health summary of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static VaultHealthDetails BeginRefresh(this IReplicationVaultHealthOperations operations)
            {
                return operations.BeginRefreshAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refreshes health summary of the vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VaultHealthDetails> BeginRefreshAsync(this IReplicationVaultHealthOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRefreshWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
