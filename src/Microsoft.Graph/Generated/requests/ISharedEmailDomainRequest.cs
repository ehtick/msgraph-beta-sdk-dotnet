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
    /// The interface ISharedEmailDomainRequest.
    /// </summary>
    public partial interface ISharedEmailDomainRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharedEmailDomain using POST.
        /// </summary>
        /// <param name="sharedEmailDomainToCreate">The SharedEmailDomain to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedEmailDomain.</returns>
        System.Threading.Tasks.Task<SharedEmailDomain> CreateAsync(SharedEmailDomain sharedEmailDomainToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SharedEmailDomain using POST and returns a <see cref="GraphResponse{SharedEmailDomain}"/> object.
        /// </summary>
        /// <param name="sharedEmailDomainToCreate">The SharedEmailDomain to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedEmailDomain}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomain>> CreateResponseAsync(SharedEmailDomain sharedEmailDomainToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SharedEmailDomain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SharedEmailDomain and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SharedEmailDomain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedEmailDomain.</returns>
        System.Threading.Tasks.Task<SharedEmailDomain> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SharedEmailDomain and returns a <see cref="GraphResponse{SharedEmailDomain}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedEmailDomain}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomain>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomain using PATCH.
        /// </summary>
        /// <param name="sharedEmailDomainToUpdate">The SharedEmailDomain to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharedEmailDomain.</returns>
        System.Threading.Tasks.Task<SharedEmailDomain> UpdateAsync(SharedEmailDomain sharedEmailDomainToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomain using PATCH and returns a <see cref="GraphResponse{SharedEmailDomain}"/> object.
        /// </summary>
        /// <param name="sharedEmailDomainToUpdate">The SharedEmailDomain to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharedEmailDomain}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomain>> UpdateResponseAsync(SharedEmailDomain sharedEmailDomainToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomain using PUT.
        /// </summary>
        /// <param name="sharedEmailDomainToUpdate">The SharedEmailDomain object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SharedEmailDomain> PutAsync(SharedEmailDomain sharedEmailDomainToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SharedEmailDomain using PUT and returns a <see cref="GraphResponse{SharedEmailDomain}"/> object.
        /// </summary>
        /// <param name="sharedEmailDomainToUpdate">The SharedEmailDomain object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SharedEmailDomain}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedEmailDomain>> PutResponseAsync(SharedEmailDomain sharedEmailDomainToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainRequest Expand(Expression<Func<SharedEmailDomain, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedEmailDomainRequest Select(Expression<Func<SharedEmailDomain, object>> selectExpression);

    }
}
