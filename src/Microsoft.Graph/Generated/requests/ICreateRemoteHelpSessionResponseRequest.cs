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
    /// The interface ICreateRemoteHelpSessionResponseRequest.
    /// </summary>
    public partial interface ICreateRemoteHelpSessionResponseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CreateRemoteHelpSessionResponse using POST.
        /// </summary>
        /// <param name="createRemoteHelpSessionResponseToCreate">The CreateRemoteHelpSessionResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CreateRemoteHelpSessionResponse.</returns>
        System.Threading.Tasks.Task<CreateRemoteHelpSessionResponse> CreateAsync(CreateRemoteHelpSessionResponse createRemoteHelpSessionResponseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CreateRemoteHelpSessionResponse using POST and returns a <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> object.
        /// </summary>
        /// <param name="createRemoteHelpSessionResponseToCreate">The CreateRemoteHelpSessionResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CreateRemoteHelpSessionResponse>> CreateResponseAsync(CreateRemoteHelpSessionResponse createRemoteHelpSessionResponseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CreateRemoteHelpSessionResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CreateRemoteHelpSessionResponse and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CreateRemoteHelpSessionResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CreateRemoteHelpSessionResponse.</returns>
        System.Threading.Tasks.Task<CreateRemoteHelpSessionResponse> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CreateRemoteHelpSessionResponse and returns a <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CreateRemoteHelpSessionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CreateRemoteHelpSessionResponse using PATCH.
        /// </summary>
        /// <param name="createRemoteHelpSessionResponseToUpdate">The CreateRemoteHelpSessionResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CreateRemoteHelpSessionResponse.</returns>
        System.Threading.Tasks.Task<CreateRemoteHelpSessionResponse> UpdateAsync(CreateRemoteHelpSessionResponse createRemoteHelpSessionResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CreateRemoteHelpSessionResponse using PATCH and returns a <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> object.
        /// </summary>
        /// <param name="createRemoteHelpSessionResponseToUpdate">The CreateRemoteHelpSessionResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CreateRemoteHelpSessionResponse>> UpdateResponseAsync(CreateRemoteHelpSessionResponse createRemoteHelpSessionResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CreateRemoteHelpSessionResponse using PUT.
        /// </summary>
        /// <param name="createRemoteHelpSessionResponseToUpdate">The CreateRemoteHelpSessionResponse object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CreateRemoteHelpSessionResponse> PutAsync(CreateRemoteHelpSessionResponse createRemoteHelpSessionResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CreateRemoteHelpSessionResponse using PUT and returns a <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> object.
        /// </summary>
        /// <param name="createRemoteHelpSessionResponseToUpdate">The CreateRemoteHelpSessionResponse object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CreateRemoteHelpSessionResponse}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CreateRemoteHelpSessionResponse>> PutResponseAsync(CreateRemoteHelpSessionResponse createRemoteHelpSessionResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICreateRemoteHelpSessionResponseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICreateRemoteHelpSessionResponseRequest Expand(Expression<Func<CreateRemoteHelpSessionResponse, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICreateRemoteHelpSessionResponseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICreateRemoteHelpSessionResponseRequest Select(Expression<Func<CreateRemoteHelpSessionResponse, object>> selectExpression);

    }
}
