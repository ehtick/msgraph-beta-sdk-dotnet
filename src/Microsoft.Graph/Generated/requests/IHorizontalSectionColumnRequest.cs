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
    /// The interface IHorizontalSectionColumnRequest.
    /// </summary>
    public partial interface IHorizontalSectionColumnRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified HorizontalSectionColumn using POST.
        /// </summary>
        /// <param name="horizontalSectionColumnToCreate">The HorizontalSectionColumn to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created HorizontalSectionColumn.</returns>
        System.Threading.Tasks.Task<HorizontalSectionColumn> CreateAsync(HorizontalSectionColumn horizontalSectionColumnToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified HorizontalSectionColumn using POST and returns a <see cref="GraphResponse{HorizontalSectionColumn}"/> object.
        /// </summary>
        /// <param name="horizontalSectionColumnToCreate">The HorizontalSectionColumn to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HorizontalSectionColumn}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HorizontalSectionColumn>> CreateResponseAsync(HorizontalSectionColumn horizontalSectionColumnToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HorizontalSectionColumn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HorizontalSectionColumn and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HorizontalSectionColumn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The HorizontalSectionColumn.</returns>
        System.Threading.Tasks.Task<HorizontalSectionColumn> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HorizontalSectionColumn and returns a <see cref="GraphResponse{HorizontalSectionColumn}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HorizontalSectionColumn}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HorizontalSectionColumn>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HorizontalSectionColumn using PATCH.
        /// </summary>
        /// <param name="horizontalSectionColumnToUpdate">The HorizontalSectionColumn to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated HorizontalSectionColumn.</returns>
        System.Threading.Tasks.Task<HorizontalSectionColumn> UpdateAsync(HorizontalSectionColumn horizontalSectionColumnToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HorizontalSectionColumn using PATCH and returns a <see cref="GraphResponse{HorizontalSectionColumn}"/> object.
        /// </summary>
        /// <param name="horizontalSectionColumnToUpdate">The HorizontalSectionColumn to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{HorizontalSectionColumn}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HorizontalSectionColumn>> UpdateResponseAsync(HorizontalSectionColumn horizontalSectionColumnToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HorizontalSectionColumn using PUT.
        /// </summary>
        /// <param name="horizontalSectionColumnToUpdate">The HorizontalSectionColumn object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<HorizontalSectionColumn> PutAsync(HorizontalSectionColumn horizontalSectionColumnToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HorizontalSectionColumn using PUT and returns a <see cref="GraphResponse{HorizontalSectionColumn}"/> object.
        /// </summary>
        /// <param name="horizontalSectionColumnToUpdate">The HorizontalSectionColumn object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{HorizontalSectionColumn}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<HorizontalSectionColumn>> PutResponseAsync(HorizontalSectionColumn horizontalSectionColumnToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IHorizontalSectionColumnRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IHorizontalSectionColumnRequest Expand(Expression<Func<HorizontalSectionColumn, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IHorizontalSectionColumnRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IHorizontalSectionColumnRequest Select(Expression<Func<HorizontalSectionColumn, object>> selectExpression);

    }
}
