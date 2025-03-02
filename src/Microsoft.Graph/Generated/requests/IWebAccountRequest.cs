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
    /// The interface IWebAccountRequest.
    /// </summary>
    public partial interface IWebAccountRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WebAccount using POST.
        /// </summary>
        /// <param name="webAccountToCreate">The WebAccount to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WebAccount.</returns>
        System.Threading.Tasks.Task<WebAccount> CreateAsync(WebAccount webAccountToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WebAccount using POST and returns a <see cref="GraphResponse{WebAccount}"/> object.
        /// </summary>
        /// <param name="webAccountToCreate">The WebAccount to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WebAccount}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebAccount>> CreateResponseAsync(WebAccount webAccountToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WebAccount.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WebAccount and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WebAccount.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WebAccount.</returns>
        System.Threading.Tasks.Task<WebAccount> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WebAccount and returns a <see cref="GraphResponse{WebAccount}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WebAccount}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebAccount>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebAccount using PATCH.
        /// </summary>
        /// <param name="webAccountToUpdate">The WebAccount to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WebAccount.</returns>
        System.Threading.Tasks.Task<WebAccount> UpdateAsync(WebAccount webAccountToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebAccount using PATCH and returns a <see cref="GraphResponse{WebAccount}"/> object.
        /// </summary>
        /// <param name="webAccountToUpdate">The WebAccount to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WebAccount}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebAccount>> UpdateResponseAsync(WebAccount webAccountToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebAccount using PUT.
        /// </summary>
        /// <param name="webAccountToUpdate">The WebAccount object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WebAccount> PutAsync(WebAccount webAccountToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WebAccount using PUT and returns a <see cref="GraphResponse{WebAccount}"/> object.
        /// </summary>
        /// <param name="webAccountToUpdate">The WebAccount object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WebAccount}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WebAccount>> PutResponseAsync(WebAccount webAccountToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWebAccountRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWebAccountRequest Expand(Expression<Func<WebAccount, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWebAccountRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWebAccountRequest Select(Expression<Func<WebAccount, object>> selectExpression);

    }
}
