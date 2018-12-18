// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NetworkInterfaceTapConfigurationsOperations.
    /// </summary>
    public static partial class NetworkInterfaceTapConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified tap configuration from the NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            public static void Delete(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName)
            {
                operations.DeleteAsync(resourceGroupName, networkInterfaceName, tapConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified tap configuration from the NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the specified tap configuration on a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            public static NetworkInterfaceTapConfiguration Get(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName)
            {
                return operations.GetAsync(resourceGroupName, networkInterfaceName, tapConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified tap configuration on a network interface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterfaceTapConfiguration> GetAsync(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Tap configuration in the specified NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            /// <param name='tapConfigurationParameters'>
            /// Parameters supplied to the create or update tap configuration operation.
            /// </param>
            public static NetworkInterfaceTapConfiguration CreateOrUpdate(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName, NetworkInterfaceTapConfiguration tapConfigurationParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Tap configuration in the specified NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            /// <param name='tapConfigurationParameters'>
            /// Parameters supplied to the create or update tap configuration operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterfaceTapConfiguration> CreateOrUpdateAsync(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName, NetworkInterfaceTapConfiguration tapConfigurationParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all Tap configurations in a network interface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            public static IPage<NetworkInterfaceTapConfiguration> List(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName)
            {
                return operations.ListAsync(resourceGroupName, networkInterfaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all Tap configurations in a network interface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkInterfaceTapConfiguration>> ListAsync(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified tap configuration from the NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            public static void BeginDelete(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, networkInterfaceName, tapConfigurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified tap configuration from the NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a Tap configuration in the specified NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            /// <param name='tapConfigurationParameters'>
            /// Parameters supplied to the create or update tap configuration operation.
            /// </param>
            public static NetworkInterfaceTapConfiguration BeginCreateOrUpdate(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName, NetworkInterfaceTapConfiguration tapConfigurationParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Tap configuration in the specified NetworkInterface.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkInterfaceName'>
            /// The name of the network interface.
            /// </param>
            /// <param name='tapConfigurationName'>
            /// The name of the tap configuration.
            /// </param>
            /// <param name='tapConfigurationParameters'>
            /// Parameters supplied to the create or update tap configuration operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkInterfaceTapConfiguration> BeginCreateOrUpdateAsync(this INetworkInterfaceTapConfigurationsOperations operations, string resourceGroupName, string networkInterfaceName, string tapConfigurationName, NetworkInterfaceTapConfiguration tapConfigurationParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkInterfaceName, tapConfigurationName, tapConfigurationParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all Tap configurations in a network interface
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkInterfaceTapConfiguration> ListNext(this INetworkInterfaceTapConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all Tap configurations in a network interface
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
            public static async Task<IPage<NetworkInterfaceTapConfiguration>> ListNextAsync(this INetworkInterfaceTapConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}