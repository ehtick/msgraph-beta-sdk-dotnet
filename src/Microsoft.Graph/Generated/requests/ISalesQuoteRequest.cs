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
    /// The interface ISalesQuoteRequest.
    /// </summary>
    public partial interface ISalesQuoteRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SalesQuote using POST.
        /// </summary>
        /// <param name="salesQuoteToCreate">The SalesQuote to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SalesQuote.</returns>
        System.Threading.Tasks.Task<SalesQuote> CreateAsync(SalesQuote salesQuoteToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SalesQuote using POST and returns a <see cref="GraphResponse{SalesQuote}"/> object.
        /// </summary>
        /// <param name="salesQuoteToCreate">The SalesQuote to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesQuote}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesQuote>> CreateResponseAsync(SalesQuote salesQuoteToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SalesQuote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SalesQuote and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SalesQuote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SalesQuote.</returns>
        System.Threading.Tasks.Task<SalesQuote> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SalesQuote and returns a <see cref="GraphResponse{SalesQuote}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesQuote}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesQuote>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SalesQuote using PATCH.
        /// </summary>
        /// <param name="salesQuoteToUpdate">The SalesQuote to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SalesQuote.</returns>
        System.Threading.Tasks.Task<SalesQuote> UpdateAsync(SalesQuote salesQuoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SalesQuote using PATCH and returns a <see cref="GraphResponse{SalesQuote}"/> object.
        /// </summary>
        /// <param name="salesQuoteToUpdate">The SalesQuote to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SalesQuote}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesQuote>> UpdateResponseAsync(SalesQuote salesQuoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SalesQuote using PUT.
        /// </summary>
        /// <param name="salesQuoteToUpdate">The SalesQuote object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SalesQuote> PutAsync(SalesQuote salesQuoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SalesQuote using PUT and returns a <see cref="GraphResponse{SalesQuote}"/> object.
        /// </summary>
        /// <param name="salesQuoteToUpdate">The SalesQuote object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SalesQuote}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesQuote>> PutResponseAsync(SalesQuote salesQuoteToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISalesQuoteRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISalesQuoteRequest Expand(Expression<Func<SalesQuote, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISalesQuoteRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISalesQuoteRequest Select(Expression<Func<SalesQuote, object>> selectExpression);

    }
}
