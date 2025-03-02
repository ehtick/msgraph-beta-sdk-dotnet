// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeletedItemContainerRequest.
    /// </summary>
    public partial interface IDeletedItemContainerRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeletedItemContainer using POST.
        /// </summary>
        /// <param name="deletedItemContainerToCreate">The DeletedItemContainer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeletedItemContainer.</returns>
        System.Threading.Tasks.Task<DeletedItemContainer> CreateAsync(DeletedItemContainer deletedItemContainerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeletedItemContainer using POST and returns a <see cref="GraphResponse{DeletedItemContainer}"/> object.
        /// </summary>
        /// <param name="deletedItemContainerToCreate">The DeletedItemContainer to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeletedItemContainer}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeletedItemContainer>> CreateResponseAsync(DeletedItemContainer deletedItemContainerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeletedItemContainer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeletedItemContainer and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeletedItemContainer.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeletedItemContainer.</returns>
        System.Threading.Tasks.Task<DeletedItemContainer> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeletedItemContainer and returns a <see cref="GraphResponse{DeletedItemContainer}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeletedItemContainer}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeletedItemContainer>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeletedItemContainer using PATCH.
        /// </summary>
        /// <param name="deletedItemContainerToUpdate">The DeletedItemContainer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeletedItemContainer.</returns>
        System.Threading.Tasks.Task<DeletedItemContainer> UpdateAsync(DeletedItemContainer deletedItemContainerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeletedItemContainer using PATCH and returns a <see cref="GraphResponse{DeletedItemContainer}"/> object.
        /// </summary>
        /// <param name="deletedItemContainerToUpdate">The DeletedItemContainer to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeletedItemContainer}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeletedItemContainer>> UpdateResponseAsync(DeletedItemContainer deletedItemContainerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeletedItemContainer using PUT.
        /// </summary>
        /// <param name="deletedItemContainerToUpdate">The DeletedItemContainer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeletedItemContainer> PutAsync(DeletedItemContainer deletedItemContainerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeletedItemContainer using PUT and returns a <see cref="GraphResponse{DeletedItemContainer}"/> object.
        /// </summary>
        /// <param name="deletedItemContainerToUpdate">The DeletedItemContainer object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeletedItemContainer}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeletedItemContainer>> PutResponseAsync(DeletedItemContainer deletedItemContainerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerRequest Expand(Expression<Func<DeletedItemContainer, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerRequest Select(Expression<Func<DeletedItemContainer, object>> selectExpression);

    }
}
