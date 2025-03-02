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
    /// The interface IInboundSharedUserProfileRequest.
    /// </summary>
    public partial interface IInboundSharedUserProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified InboundSharedUserProfile using POST.
        /// </summary>
        /// <param name="inboundSharedUserProfileToCreate">The InboundSharedUserProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InboundSharedUserProfile.</returns>
        System.Threading.Tasks.Task<InboundSharedUserProfile> CreateAsync(InboundSharedUserProfile inboundSharedUserProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified InboundSharedUserProfile using POST and returns a <see cref="GraphResponse{InboundSharedUserProfile}"/> object.
        /// </summary>
        /// <param name="inboundSharedUserProfileToCreate">The InboundSharedUserProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InboundSharedUserProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InboundSharedUserProfile>> CreateResponseAsync(InboundSharedUserProfile inboundSharedUserProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InboundSharedUserProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InboundSharedUserProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InboundSharedUserProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InboundSharedUserProfile.</returns>
        System.Threading.Tasks.Task<InboundSharedUserProfile> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InboundSharedUserProfile and returns a <see cref="GraphResponse{InboundSharedUserProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InboundSharedUserProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InboundSharedUserProfile>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InboundSharedUserProfile using PATCH.
        /// </summary>
        /// <param name="inboundSharedUserProfileToUpdate">The InboundSharedUserProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InboundSharedUserProfile.</returns>
        System.Threading.Tasks.Task<InboundSharedUserProfile> UpdateAsync(InboundSharedUserProfile inboundSharedUserProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InboundSharedUserProfile using PATCH and returns a <see cref="GraphResponse{InboundSharedUserProfile}"/> object.
        /// </summary>
        /// <param name="inboundSharedUserProfileToUpdate">The InboundSharedUserProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{InboundSharedUserProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InboundSharedUserProfile>> UpdateResponseAsync(InboundSharedUserProfile inboundSharedUserProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InboundSharedUserProfile using PUT.
        /// </summary>
        /// <param name="inboundSharedUserProfileToUpdate">The InboundSharedUserProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<InboundSharedUserProfile> PutAsync(InboundSharedUserProfile inboundSharedUserProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InboundSharedUserProfile using PUT and returns a <see cref="GraphResponse{InboundSharedUserProfile}"/> object.
        /// </summary>
        /// <param name="inboundSharedUserProfileToUpdate">The InboundSharedUserProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{InboundSharedUserProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<InboundSharedUserProfile>> PutResponseAsync(InboundSharedUserProfile inboundSharedUserProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IInboundSharedUserProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IInboundSharedUserProfileRequest Expand(Expression<Func<InboundSharedUserProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IInboundSharedUserProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IInboundSharedUserProfileRequest Select(Expression<Func<InboundSharedUserProfile, object>> selectExpression);

    }
}
