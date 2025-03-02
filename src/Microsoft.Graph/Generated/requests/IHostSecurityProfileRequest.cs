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
    /// The interface IHostSecurityProfileRequest.
    /// </summary>
    public partial interface IHostSecurityProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified HostSecurityProfile using POST.
        /// </summary>
        /// <param name="hostSecurityProfileToCreate">The HostSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> CreateAsync(HostSecurityProfile hostSecurityProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified HostSecurityProfile using POST and returns a <see cref="GraphResponse{HostSecurityProfile}"/> object.
        /// </summary>
        /// <param name="hostSecurityProfileToCreate">The HostSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HostSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostSecurityProfile>> CreateResponseAsync(HostSecurityProfile hostSecurityProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HostSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified HostSecurityProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HostSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified HostSecurityProfile and returns a <see cref="GraphResponse{HostSecurityProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{HostSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostSecurityProfile>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostSecurityProfile using PATCH.
        /// </summary>
        /// <param name="hostSecurityProfileToUpdate">The HostSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated HostSecurityProfile.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> UpdateAsync(HostSecurityProfile hostSecurityProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostSecurityProfile using PATCH and returns a <see cref="GraphResponse{HostSecurityProfile}"/> object.
        /// </summary>
        /// <param name="hostSecurityProfileToUpdate">The HostSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{HostSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostSecurityProfile>> UpdateResponseAsync(HostSecurityProfile hostSecurityProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostSecurityProfile using PUT.
        /// </summary>
        /// <param name="hostSecurityProfileToUpdate">The HostSecurityProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<HostSecurityProfile> PutAsync(HostSecurityProfile hostSecurityProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified HostSecurityProfile using PUT and returns a <see cref="GraphResponse{HostSecurityProfile}"/> object.
        /// </summary>
        /// <param name="hostSecurityProfileToUpdate">The HostSecurityProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{HostSecurityProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<HostSecurityProfile>> PutResponseAsync(HostSecurityProfile hostSecurityProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Expand(Expression<Func<HostSecurityProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IHostSecurityProfileRequest Select(Expression<Func<HostSecurityProfile, object>> selectExpression);

    }
}
