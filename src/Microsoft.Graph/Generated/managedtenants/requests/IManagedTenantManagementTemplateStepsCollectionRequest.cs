// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedTenantManagementTemplateStepsCollectionRequest.
    /// </summary>
    public partial interface IManagedTenantManagementTemplateStepsCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Adds the specified ManagementTemplateStep to the collection via POST.
        /// </summary>
        /// <param name="managementTemplateStep">The ManagementTemplateStep to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementTemplateStep.</returns>
        System.Threading.Tasks.Task<ManagementTemplateStep> AddAsync(ManagementTemplateStep managementTemplateStep, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified ManagementTemplateStep to the collection via POST and returns a <see cref="GraphResponse{ManagementTemplateStep}"/> object of the request.
        /// </summary>
        /// <param name="managementTemplateStep">The ManagementTemplateStep to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementTemplateStep}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateStep>> AddResponseAsync(ManagementTemplateStep managementTemplateStep, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IManagedTenantManagementTemplateStepsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ManagedTenantManagementTemplateStepsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantManagementTemplateStepsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantManagementTemplateStepsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest Expand(Expression<Func<ManagementTemplateStep, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest Select(Expression<Func<ManagementTemplateStep, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagementTemplateStepsCollectionRequest OrderBy(string value);
    }
}
