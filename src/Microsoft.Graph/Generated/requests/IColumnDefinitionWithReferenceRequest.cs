// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IColumnDefinitionWithReferenceRequest.
    /// </summary>
    public partial interface IColumnDefinitionWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified ColumnDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ColumnDefinition.</returns>
        System.Threading.Tasks.Task<ColumnDefinition> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ColumnDefinition and returns a <see cref="GraphResponse{ColumnDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ColumnDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ColumnDefinition>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified ColumnDefinition using POST.
        /// </summary>
        /// <param name="columnDefinitionToCreate">The ColumnDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ColumnDefinition.</returns>
        System.Threading.Tasks.Task<ColumnDefinition> CreateAsync(ColumnDefinition columnDefinitionToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified ColumnDefinition using POST and returns a <see cref="GraphResponse{ColumnDefinition}"/> object.
        /// </summary>
        /// <param name="columnDefinitionToCreate">The ColumnDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ColumnDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ColumnDefinition>> CreateResponseAsync(ColumnDefinition columnDefinitionToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified ColumnDefinition using PATCH.
        /// </summary>
        /// <param name="columnDefinitionToUpdate">The ColumnDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ColumnDefinition.</returns>
        System.Threading.Tasks.Task<ColumnDefinition> UpdateAsync(ColumnDefinition columnDefinitionToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified ColumnDefinition using PATCH and returns a <see cref="GraphResponse{ColumnDefinition}"/> object.
        /// </summary>
        /// <param name="columnDefinitionToUpdate">The ColumnDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ColumnDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ColumnDefinition>> UpdateResponseAsync(ColumnDefinition columnDefinitionToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified ColumnDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified ColumnDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IColumnDefinitionWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IColumnDefinitionWithReferenceRequest Expand(Expression<Func<ColumnDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IColumnDefinitionWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IColumnDefinitionWithReferenceRequest Select(Expression<Func<ColumnDefinition, object>> selectExpression);

    }
}
