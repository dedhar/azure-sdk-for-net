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
    /// Extension methods for ExpressRouteCircuitsRoutesTableOperations.
    /// </summary>
    public static partial class ExpressRouteCircuitsRoutesTableOperationsExtensions
    {
            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route crossConnection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsRoutesTableListResult List(this IExpressRouteCircuitsRoutesTableOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath)
            {
                return operations.ListAsync(resourceGroupName, crossConnectionName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route crossConnection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableListResult> ListAsync(this IExpressRouteCircuitsRoutesTableOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route crossConnection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            public static ExpressRouteCircuitsRoutesTableListResult BeginList(this IExpressRouteCircuitsRoutesTableOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath)
            {
                return operations.BeginListAsync(resourceGroupName, crossConnectionName, peeringName, devicePath).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently advertised routes table associated with the express
            /// route crossConnection in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='crossConnectionName'>
            /// The name of the ExpressRouteCrossConnection.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='devicePath'>
            /// The path of the device.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitsRoutesTableListResult> BeginListAsync(this IExpressRouteCircuitsRoutesTableOperations operations, string resourceGroupName, string crossConnectionName, string peeringName, string devicePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListWithHttpMessagesAsync(resourceGroupName, crossConnectionName, peeringName, devicePath, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
