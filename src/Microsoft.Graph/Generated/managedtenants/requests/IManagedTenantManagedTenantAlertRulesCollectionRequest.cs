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
    /// The interface IManagedTenantManagedTenantAlertRulesCollectionRequest.
    /// </summary>
    public partial interface IManagedTenantManagedTenantAlertRulesCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Adds the specified ManagedTenantAlertRule to the collection via POST.
        /// </summary>
        /// <param name="managedTenantAlertRule">The ManagedTenantAlertRule to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedTenantAlertRule.</returns>
        System.Threading.Tasks.Task<ManagedTenantAlertRule> AddAsync(ManagedTenantAlertRule managedTenantAlertRule, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified ManagedTenantAlertRule to the collection via POST and returns a <see cref="GraphResponse{ManagedTenantAlertRule}"/> object of the request.
        /// </summary>
        /// <param name="managedTenantAlertRule">The ManagedTenantAlertRule to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantAlertRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantAlertRule>> AddResponseAsync(ManagedTenantAlertRule managedTenantAlertRule, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IManagedTenantManagedTenantAlertRulesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ManagedTenantManagedTenantAlertRulesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantManagedTenantAlertRulesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedTenantManagedTenantAlertRulesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest Expand(Expression<Func<ManagedTenantAlertRule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest Select(Expression<Func<ManagedTenantAlertRule, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IManagedTenantManagedTenantAlertRulesCollectionRequest OrderBy(string value);
    }
}
