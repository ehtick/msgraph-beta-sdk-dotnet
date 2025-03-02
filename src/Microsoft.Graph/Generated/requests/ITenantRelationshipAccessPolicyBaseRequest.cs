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
    /// The interface ITenantRelationshipAccessPolicyBaseRequest.
    /// </summary>
    public partial interface ITenantRelationshipAccessPolicyBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TenantRelationshipAccessPolicyBase using POST.
        /// </summary>
        /// <param name="tenantRelationshipAccessPolicyBaseToCreate">The TenantRelationshipAccessPolicyBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TenantRelationshipAccessPolicyBase.</returns>
        System.Threading.Tasks.Task<TenantRelationshipAccessPolicyBase> CreateAsync(TenantRelationshipAccessPolicyBase tenantRelationshipAccessPolicyBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TenantRelationshipAccessPolicyBase using POST and returns a <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> object.
        /// </summary>
        /// <param name="tenantRelationshipAccessPolicyBaseToCreate">The TenantRelationshipAccessPolicyBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantRelationshipAccessPolicyBase>> CreateResponseAsync(TenantRelationshipAccessPolicyBase tenantRelationshipAccessPolicyBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TenantRelationshipAccessPolicyBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TenantRelationshipAccessPolicyBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TenantRelationshipAccessPolicyBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TenantRelationshipAccessPolicyBase.</returns>
        System.Threading.Tasks.Task<TenantRelationshipAccessPolicyBase> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TenantRelationshipAccessPolicyBase and returns a <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantRelationshipAccessPolicyBase>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantRelationshipAccessPolicyBase using PATCH.
        /// </summary>
        /// <param name="tenantRelationshipAccessPolicyBaseToUpdate">The TenantRelationshipAccessPolicyBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TenantRelationshipAccessPolicyBase.</returns>
        System.Threading.Tasks.Task<TenantRelationshipAccessPolicyBase> UpdateAsync(TenantRelationshipAccessPolicyBase tenantRelationshipAccessPolicyBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantRelationshipAccessPolicyBase using PATCH and returns a <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> object.
        /// </summary>
        /// <param name="tenantRelationshipAccessPolicyBaseToUpdate">The TenantRelationshipAccessPolicyBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantRelationshipAccessPolicyBase>> UpdateResponseAsync(TenantRelationshipAccessPolicyBase tenantRelationshipAccessPolicyBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantRelationshipAccessPolicyBase using PUT.
        /// </summary>
        /// <param name="tenantRelationshipAccessPolicyBaseToUpdate">The TenantRelationshipAccessPolicyBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TenantRelationshipAccessPolicyBase> PutAsync(TenantRelationshipAccessPolicyBase tenantRelationshipAccessPolicyBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TenantRelationshipAccessPolicyBase using PUT and returns a <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> object.
        /// </summary>
        /// <param name="tenantRelationshipAccessPolicyBaseToUpdate">The TenantRelationshipAccessPolicyBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TenantRelationshipAccessPolicyBase}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TenantRelationshipAccessPolicyBase>> PutResponseAsync(TenantRelationshipAccessPolicyBase tenantRelationshipAccessPolicyBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITenantRelationshipAccessPolicyBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITenantRelationshipAccessPolicyBaseRequest Expand(Expression<Func<TenantRelationshipAccessPolicyBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITenantRelationshipAccessPolicyBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITenantRelationshipAccessPolicyBaseRequest Select(Expression<Func<TenantRelationshipAccessPolicyBase, object>> selectExpression);

    }
}
