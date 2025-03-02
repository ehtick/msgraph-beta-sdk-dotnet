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
    /// The interface IAccessPackageResourceScopeRequest.
    /// </summary>
    public partial interface IAccessPackageResourceScopeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessPackageResourceScope using POST.
        /// </summary>
        /// <param name="accessPackageResourceScopeToCreate">The AccessPackageResourceScope to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageResourceScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceScope> CreateAsync(AccessPackageResourceScope accessPackageResourceScopeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AccessPackageResourceScope using POST and returns a <see cref="GraphResponse{AccessPackageResourceScope}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceScopeToCreate">The AccessPackageResourceScope to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceScope}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceScope>> CreateResponseAsync(AccessPackageResourceScope accessPackageResourceScopeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessPackageResourceScope.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AccessPackageResourceScope and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessPackageResourceScope.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageResourceScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceScope> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AccessPackageResourceScope and returns a <see cref="GraphResponse{AccessPackageResourceScope}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceScope}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceScope>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageResourceScope using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceScopeToUpdate">The AccessPackageResourceScope to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageResourceScope.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceScope> UpdateAsync(AccessPackageResourceScope accessPackageResourceScopeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageResourceScope using PATCH and returns a <see cref="GraphResponse{AccessPackageResourceScope}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceScopeToUpdate">The AccessPackageResourceScope to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceScope}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceScope>> UpdateResponseAsync(AccessPackageResourceScope accessPackageResourceScopeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageResourceScope using PUT.
        /// </summary>
        /// <param name="accessPackageResourceScopeToUpdate">The AccessPackageResourceScope object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AccessPackageResourceScope> PutAsync(AccessPackageResourceScope accessPackageResourceScopeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AccessPackageResourceScope using PUT and returns a <see cref="GraphResponse{AccessPackageResourceScope}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceScopeToUpdate">The AccessPackageResourceScope object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AccessPackageResourceScope}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceScope>> PutResponseAsync(AccessPackageResourceScope accessPackageResourceScopeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceScopeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceScopeRequest Expand(Expression<Func<AccessPackageResourceScope, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceScopeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessPackageResourceScopeRequest Select(Expression<Func<AccessPackageResourceScope, object>> selectExpression);

    }
}
