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
    /// The interface IServicePrincipalCreationPolicyRequest.
    /// </summary>
    public partial interface IServicePrincipalCreationPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ServicePrincipalCreationPolicy using POST.
        /// </summary>
        /// <param name="servicePrincipalCreationPolicyToCreate">The ServicePrincipalCreationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ServicePrincipalCreationPolicy.</returns>
        System.Threading.Tasks.Task<ServicePrincipalCreationPolicy> CreateAsync(ServicePrincipalCreationPolicy servicePrincipalCreationPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ServicePrincipalCreationPolicy using POST and returns a <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> object.
        /// </summary>
        /// <param name="servicePrincipalCreationPolicyToCreate">The ServicePrincipalCreationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalCreationPolicy>> CreateResponseAsync(ServicePrincipalCreationPolicy servicePrincipalCreationPolicyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServicePrincipalCreationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ServicePrincipalCreationPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServicePrincipalCreationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ServicePrincipalCreationPolicy.</returns>
        System.Threading.Tasks.Task<ServicePrincipalCreationPolicy> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ServicePrincipalCreationPolicy and returns a <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalCreationPolicy>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalCreationPolicy using PATCH.
        /// </summary>
        /// <param name="servicePrincipalCreationPolicyToUpdate">The ServicePrincipalCreationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ServicePrincipalCreationPolicy.</returns>
        System.Threading.Tasks.Task<ServicePrincipalCreationPolicy> UpdateAsync(ServicePrincipalCreationPolicy servicePrincipalCreationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalCreationPolicy using PATCH and returns a <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> object.
        /// </summary>
        /// <param name="servicePrincipalCreationPolicyToUpdate">The ServicePrincipalCreationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalCreationPolicy>> UpdateResponseAsync(ServicePrincipalCreationPolicy servicePrincipalCreationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalCreationPolicy using PUT.
        /// </summary>
        /// <param name="servicePrincipalCreationPolicyToUpdate">The ServicePrincipalCreationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ServicePrincipalCreationPolicy> PutAsync(ServicePrincipalCreationPolicy servicePrincipalCreationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ServicePrincipalCreationPolicy using PUT and returns a <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> object.
        /// </summary>
        /// <param name="servicePrincipalCreationPolicyToUpdate">The ServicePrincipalCreationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ServicePrincipalCreationPolicy}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalCreationPolicy>> PutResponseAsync(ServicePrincipalCreationPolicy servicePrincipalCreationPolicyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalCreationPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalCreationPolicyRequest Expand(Expression<Func<ServicePrincipalCreationPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalCreationPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalCreationPolicyRequest Select(Expression<Func<ServicePrincipalCreationPolicy, object>> selectExpression);

    }
}
