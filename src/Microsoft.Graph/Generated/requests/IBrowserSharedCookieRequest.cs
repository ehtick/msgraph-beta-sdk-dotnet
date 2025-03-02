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
    /// The interface IBrowserSharedCookieRequest.
    /// </summary>
    public partial interface IBrowserSharedCookieRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BrowserSharedCookie using POST.
        /// </summary>
        /// <param name="browserSharedCookieToCreate">The BrowserSharedCookie to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BrowserSharedCookie.</returns>
        System.Threading.Tasks.Task<BrowserSharedCookie> CreateAsync(BrowserSharedCookie browserSharedCookieToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified BrowserSharedCookie using POST and returns a <see cref="GraphResponse{BrowserSharedCookie}"/> object.
        /// </summary>
        /// <param name="browserSharedCookieToCreate">The BrowserSharedCookie to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BrowserSharedCookie}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BrowserSharedCookie>> CreateResponseAsync(BrowserSharedCookie browserSharedCookieToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified BrowserSharedCookie.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified BrowserSharedCookie and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified BrowserSharedCookie.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BrowserSharedCookie.</returns>
        System.Threading.Tasks.Task<BrowserSharedCookie> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified BrowserSharedCookie and returns a <see cref="GraphResponse{BrowserSharedCookie}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BrowserSharedCookie}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BrowserSharedCookie>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BrowserSharedCookie using PATCH.
        /// </summary>
        /// <param name="browserSharedCookieToUpdate">The BrowserSharedCookie to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BrowserSharedCookie.</returns>
        System.Threading.Tasks.Task<BrowserSharedCookie> UpdateAsync(BrowserSharedCookie browserSharedCookieToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BrowserSharedCookie using PATCH and returns a <see cref="GraphResponse{BrowserSharedCookie}"/> object.
        /// </summary>
        /// <param name="browserSharedCookieToUpdate">The BrowserSharedCookie to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BrowserSharedCookie}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BrowserSharedCookie>> UpdateResponseAsync(BrowserSharedCookie browserSharedCookieToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BrowserSharedCookie using PUT.
        /// </summary>
        /// <param name="browserSharedCookieToUpdate">The BrowserSharedCookie object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<BrowserSharedCookie> PutAsync(BrowserSharedCookie browserSharedCookieToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BrowserSharedCookie using PUT and returns a <see cref="GraphResponse{BrowserSharedCookie}"/> object.
        /// </summary>
        /// <param name="browserSharedCookieToUpdate">The BrowserSharedCookie object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{BrowserSharedCookie}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<BrowserSharedCookie>> PutResponseAsync(BrowserSharedCookie browserSharedCookieToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBrowserSharedCookieRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBrowserSharedCookieRequest Expand(Expression<Func<BrowserSharedCookie, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBrowserSharedCookieRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBrowserSharedCookieRequest Select(Expression<Func<BrowserSharedCookie, object>> selectExpression);

    }
}
