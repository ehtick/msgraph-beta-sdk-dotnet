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
    /// The interface IAccessReviewMyDecisionsCollectionRequest.
    /// </summary>
    public partial interface IAccessReviewMyDecisionsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified AccessReviewDecision to the collection via POST.
        /// </summary>
        /// <param name="accessReviewDecision">The AccessReviewDecision to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewDecision.</returns>
        System.Threading.Tasks.Task<AccessReviewDecision> AddAsync(AccessReviewDecision accessReviewDecision, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified AccessReviewDecision to the collection via POST and returns a <see cref="GraphResponse{AccessReviewDecision}"/> object of the request.
        /// </summary>
        /// <param name="accessReviewDecision">The AccessReviewDecision to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewDecision}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewDecision>> AddResponseAsync(AccessReviewDecision accessReviewDecision, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAccessReviewMyDecisionsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{AccessReviewMyDecisionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewMyDecisionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewMyDecisionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest Expand(Expression<Func<AccessReviewDecision, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest Select(Expression<Func<AccessReviewDecision, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewMyDecisionsCollectionRequest OrderBy(string value);
    }
}
