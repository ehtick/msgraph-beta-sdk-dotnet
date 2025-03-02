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
    /// The interface IMyRoleRequest.
    /// </summary>
    public partial interface IMyRoleRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified MyRole using POST.
        /// </summary>
        /// <param name="myRoleToCreate">The MyRole to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MyRole.</returns>
        System.Threading.Tasks.Task<MyRole> CreateAsync(MyRole myRoleToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MyRole using POST and returns a <see cref="GraphResponse{MyRole}"/> object.
        /// </summary>
        /// <param name="myRoleToCreate">The MyRole to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MyRole}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MyRole>> CreateResponseAsync(MyRole myRoleToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MyRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MyRole and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MyRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MyRole.</returns>
        System.Threading.Tasks.Task<MyRole> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MyRole and returns a <see cref="GraphResponse{MyRole}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MyRole}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MyRole>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MyRole using PATCH.
        /// </summary>
        /// <param name="myRoleToUpdate">The MyRole to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MyRole.</returns>
        System.Threading.Tasks.Task<MyRole> UpdateAsync(MyRole myRoleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MyRole using PATCH and returns a <see cref="GraphResponse{MyRole}"/> object.
        /// </summary>
        /// <param name="myRoleToUpdate">The MyRole to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MyRole}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MyRole>> UpdateResponseAsync(MyRole myRoleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MyRole using PUT.
        /// </summary>
        /// <param name="myRoleToUpdate">The MyRole object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MyRole> PutAsync(MyRole myRoleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MyRole using PUT and returns a <see cref="GraphResponse{MyRole}"/> object.
        /// </summary>
        /// <param name="myRoleToUpdate">The MyRole object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MyRole}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MyRole>> PutResponseAsync(MyRole myRoleToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMyRoleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMyRoleRequest Expand(Expression<Func<MyRole, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMyRoleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMyRoleRequest Select(Expression<Func<MyRole, object>> selectExpression);

    }
}
