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
    /// The interface IIdentityProtectionRootRequest.
    /// </summary>
    public partial interface IIdentityProtectionRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IdentityProtectionRoot using POST.
        /// </summary>
        /// <param name="identityProtectionRootToCreate">The IdentityProtectionRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityProtectionRoot.</returns>
        System.Threading.Tasks.Task<IdentityProtectionRoot> CreateAsync(IdentityProtectionRoot identityProtectionRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IdentityProtectionRoot using POST and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="identityProtectionRootToCreate">The IdentityProtectionRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityProtectionRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> CreateResponseAsync(IdentityProtectionRoot identityProtectionRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IdentityProtectionRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IdentityProtectionRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IdentityProtectionRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityProtectionRoot.</returns>
        System.Threading.Tasks.Task<IdentityProtectionRoot> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IdentityProtectionRoot and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityProtectionRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PATCH.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityProtectionRoot.</returns>
        System.Threading.Tasks.Task<IdentityProtectionRoot> UpdateAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PATCH and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityProtectionRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> UpdateResponseAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PUT.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IdentityProtectionRoot> PutAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PUT and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IdentityProtectionRoot}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> PutResponseAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProtectionRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProtectionRootRequest Expand(Expression<Func<IdentityProtectionRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProtectionRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityProtectionRootRequest Select(Expression<Func<IdentityProtectionRoot, object>> selectExpression);

    }
}
