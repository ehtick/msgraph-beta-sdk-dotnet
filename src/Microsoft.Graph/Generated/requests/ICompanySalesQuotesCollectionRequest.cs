// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICompanySalesQuotesCollectionRequest.
    /// </summary>
    public partial interface ICompanySalesQuotesCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified SalesQuote to the collection via POST.
        /// </summary>
        /// <param name="salesQuote">The SalesQuote to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SalesQuote.</returns>
        System.Threading.Tasks.Task<SalesQuote> AddAsync(SalesQuote salesQuote, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified SalesQuote to the collection via POST and returns a <see cref="GraphResponse{SalesQuote}"/> object of the request.
        /// </summary>
        /// <param name="salesQuote">The SalesQuote to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesQuote}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesQuote>> AddResponseAsync(SalesQuote salesQuote, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICompanySalesQuotesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CompanySalesQuotesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CompanySalesQuotesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanySalesQuotesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest Expand(Expression<Func<SalesQuote, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest Select(Expression<Func<SalesQuote, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesQuotesCollectionRequest OrderBy(string value);
    }
}
