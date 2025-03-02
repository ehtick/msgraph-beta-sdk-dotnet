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
    /// The interface IDelegatedAdminRelationshipOperationsCollectionRequest.
    /// </summary>
    public partial interface IDelegatedAdminRelationshipOperationsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified DelegatedAdminRelationshipOperation to the collection via POST.
        /// </summary>
        /// <param name="delegatedAdminRelationshipOperation">The DelegatedAdminRelationshipOperation to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DelegatedAdminRelationshipOperation.</returns>
        System.Threading.Tasks.Task<DelegatedAdminRelationshipOperation> AddAsync(DelegatedAdminRelationshipOperation delegatedAdminRelationshipOperation, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified DelegatedAdminRelationshipOperation to the collection via POST and returns a <see cref="GraphResponse{DelegatedAdminRelationshipOperation}"/> object of the request.
        /// </summary>
        /// <param name="delegatedAdminRelationshipOperation">The DelegatedAdminRelationshipOperation to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DelegatedAdminRelationshipOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedAdminRelationshipOperation>> AddResponseAsync(DelegatedAdminRelationshipOperation delegatedAdminRelationshipOperation, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDelegatedAdminRelationshipOperationsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DelegatedAdminRelationshipOperationsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DelegatedAdminRelationshipOperationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedAdminRelationshipOperationsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest Expand(Expression<Func<DelegatedAdminRelationshipOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest Select(Expression<Func<DelegatedAdminRelationshipOperation, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedAdminRelationshipOperationsCollectionRequest OrderBy(string value);
    }
}
