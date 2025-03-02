// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedTenantTicketingEndpointRequest.
    /// </summary>
    public partial interface IManagedTenantTicketingEndpointRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedTenantTicketingEndpoint using POST.
        /// </summary>
        /// <param name="managedTenantTicketingEndpointToCreate">The ManagedTenantTicketingEndpoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedTenantTicketingEndpoint.</returns>
        System.Threading.Tasks.Task<ManagedTenantTicketingEndpoint> CreateAsync(ManagedTenantTicketingEndpoint managedTenantTicketingEndpointToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagedTenantTicketingEndpoint using POST and returns a <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> object.
        /// </summary>
        /// <param name="managedTenantTicketingEndpointToCreate">The ManagedTenantTicketingEndpoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantTicketingEndpoint>> CreateResponseAsync(ManagedTenantTicketingEndpoint managedTenantTicketingEndpointToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedTenantTicketingEndpoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagedTenantTicketingEndpoint and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedTenantTicketingEndpoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedTenantTicketingEndpoint.</returns>
        System.Threading.Tasks.Task<ManagedTenantTicketingEndpoint> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagedTenantTicketingEndpoint and returns a <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantTicketingEndpoint>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantTicketingEndpoint using PATCH.
        /// </summary>
        /// <param name="managedTenantTicketingEndpointToUpdate">The ManagedTenantTicketingEndpoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedTenantTicketingEndpoint.</returns>
        System.Threading.Tasks.Task<ManagedTenantTicketingEndpoint> UpdateAsync(ManagedTenantTicketingEndpoint managedTenantTicketingEndpointToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantTicketingEndpoint using PATCH and returns a <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> object.
        /// </summary>
        /// <param name="managedTenantTicketingEndpointToUpdate">The ManagedTenantTicketingEndpoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantTicketingEndpoint>> UpdateResponseAsync(ManagedTenantTicketingEndpoint managedTenantTicketingEndpointToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantTicketingEndpoint using PUT.
        /// </summary>
        /// <param name="managedTenantTicketingEndpointToUpdate">The ManagedTenantTicketingEndpoint object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagedTenantTicketingEndpoint> PutAsync(ManagedTenantTicketingEndpoint managedTenantTicketingEndpointToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagedTenantTicketingEndpoint using PUT and returns a <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> object.
        /// </summary>
        /// <param name="managedTenantTicketingEndpointToUpdate">The ManagedTenantTicketingEndpoint object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagedTenantTicketingEndpoint}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantTicketingEndpoint>> PutResponseAsync(ManagedTenantTicketingEndpoint managedTenantTicketingEndpointToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantTicketingEndpointRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantTicketingEndpointRequest Expand(Expression<Func<ManagedTenantTicketingEndpoint, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantTicketingEndpointRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantTicketingEndpointRequest Select(Expression<Func<ManagedTenantTicketingEndpoint, object>> selectExpression);

    }
}
