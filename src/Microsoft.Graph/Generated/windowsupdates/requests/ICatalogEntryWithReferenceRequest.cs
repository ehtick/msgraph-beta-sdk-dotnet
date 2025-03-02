// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICatalogEntryWithReferenceRequest.
    /// </summary>
    public partial interface ICatalogEntryWithReferenceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Gets the specified CatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CatalogEntry.</returns>
        System.Threading.Tasks.Task<CatalogEntry> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CatalogEntry and returns a <see cref="GraphResponse{CatalogEntry}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CatalogEntry>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified CatalogEntry using POST.
        /// </summary>
        /// <param name="catalogEntryToCreate">The CatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CatalogEntry.</returns>
        System.Threading.Tasks.Task<CatalogEntry> CreateAsync(CatalogEntry catalogEntryToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified CatalogEntry using POST and returns a <see cref="GraphResponse{CatalogEntry}"/> object.
        /// </summary>
        /// <param name="catalogEntryToCreate">The CatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CatalogEntry>> CreateResponseAsync(CatalogEntry catalogEntryToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified CatalogEntry using PATCH.
        /// </summary>
        /// <param name="catalogEntryToUpdate">The CatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CatalogEntry.</returns>
        System.Threading.Tasks.Task<CatalogEntry> UpdateAsync(CatalogEntry catalogEntryToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified CatalogEntry using PATCH and returns a <see cref="GraphResponse{CatalogEntry}"/> object.
        /// </summary>
        /// <param name="catalogEntryToUpdate">The CatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CatalogEntry>> UpdateResponseAsync(CatalogEntry catalogEntryToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified CatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified CatalogEntry and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICatalogEntryWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICatalogEntryWithReferenceRequest Expand(Expression<Func<CatalogEntry, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICatalogEntryWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICatalogEntryWithReferenceRequest Select(Expression<Func<CatalogEntry, object>> selectExpression);

    }
}
