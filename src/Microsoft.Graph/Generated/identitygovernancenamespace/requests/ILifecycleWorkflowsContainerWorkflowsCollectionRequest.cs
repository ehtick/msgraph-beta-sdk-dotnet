// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ILifecycleWorkflowsContainerWorkflowsCollectionRequest.
    /// </summary>
    public partial interface ILifecycleWorkflowsContainerWorkflowsCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Adds the specified Workflow to the collection via POST.
        /// </summary>
        /// <param name="workflow">The Workflow to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Workflow.</returns>
        System.Threading.Tasks.Task<Workflow> AddAsync(Workflow workflow, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified Workflow to the collection via POST and returns a <see cref="GraphResponse{Workflow}"/> object of the request.
        /// </summary>
        /// <param name="workflow">The Workflow to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Workflow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Workflow>> AddResponseAsync(Workflow workflow, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ILifecycleWorkflowsContainerWorkflowsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{LifecycleWorkflowsContainerWorkflowsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LifecycleWorkflowsContainerWorkflowsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<LifecycleWorkflowsContainerWorkflowsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest Expand(Expression<Func<Workflow, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest Select(Expression<Func<Workflow, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequest OrderBy(string value);
    }
}
