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
    /// The interface IDeletedItemContainerWorkflowsCollectionRequest.
    /// </summary>
    public partial interface IDeletedItemContainerWorkflowsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified Microsoft.Graph.IdentityGovernanceNamespace.Workflow to the collection via POST.
        /// </summary>
        /// <param name="workflow">The Microsoft.Graph.IdentityGovernanceNamespace.Workflow to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Microsoft.Graph.IdentityGovernanceNamespace.Workflow.</returns>
        System.Threading.Tasks.Task<Microsoft.Graph.IdentityGovernanceNamespace.Workflow> AddAsync(Microsoft.Graph.IdentityGovernanceNamespace.Workflow workflow, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified Microsoft.Graph.IdentityGovernanceNamespace.Workflow to the collection via POST and returns a <see cref="GraphResponse{Microsoft.Graph.IdentityGovernanceNamespace.Workflow}"/> object of the request.
        /// </summary>
        /// <param name="workflow">The Microsoft.Graph.IdentityGovernanceNamespace.Workflow to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Microsoft.Graph.IdentityGovernanceNamespace.Workflow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Microsoft.Graph.IdentityGovernanceNamespace.Workflow>> AddResponseAsync(Microsoft.Graph.IdentityGovernanceNamespace.Workflow workflow, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeletedItemContainerWorkflowsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeletedItemContainerWorkflowsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeletedItemContainerWorkflowsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeletedItemContainerWorkflowsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest Expand(Expression<Func<Microsoft.Graph.IdentityGovernanceNamespace.Workflow, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest Select(Expression<Func<Microsoft.Graph.IdentityGovernanceNamespace.Workflow, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeletedItemContainerWorkflowsCollectionRequest OrderBy(string value);
    }
}
