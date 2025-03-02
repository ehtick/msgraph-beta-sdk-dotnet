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
    /// The interface IAttachmentSessionRequest.
    /// </summary>
    public partial interface IAttachmentSessionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AttachmentSession using POST.
        /// </summary>
        /// <param name="attachmentSessionToCreate">The AttachmentSession to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AttachmentSession.</returns>
        System.Threading.Tasks.Task<AttachmentSession> CreateAsync(AttachmentSession attachmentSessionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AttachmentSession using POST and returns a <see cref="GraphResponse{AttachmentSession}"/> object.
        /// </summary>
        /// <param name="attachmentSessionToCreate">The AttachmentSession to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AttachmentSession}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AttachmentSession>> CreateResponseAsync(AttachmentSession attachmentSessionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AttachmentSession.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AttachmentSession and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AttachmentSession.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AttachmentSession.</returns>
        System.Threading.Tasks.Task<AttachmentSession> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AttachmentSession and returns a <see cref="GraphResponse{AttachmentSession}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AttachmentSession}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AttachmentSession>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AttachmentSession using PATCH.
        /// </summary>
        /// <param name="attachmentSessionToUpdate">The AttachmentSession to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AttachmentSession.</returns>
        System.Threading.Tasks.Task<AttachmentSession> UpdateAsync(AttachmentSession attachmentSessionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AttachmentSession using PATCH and returns a <see cref="GraphResponse{AttachmentSession}"/> object.
        /// </summary>
        /// <param name="attachmentSessionToUpdate">The AttachmentSession to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AttachmentSession}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AttachmentSession>> UpdateResponseAsync(AttachmentSession attachmentSessionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AttachmentSession using PUT.
        /// </summary>
        /// <param name="attachmentSessionToUpdate">The AttachmentSession object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AttachmentSession> PutAsync(AttachmentSession attachmentSessionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AttachmentSession using PUT and returns a <see cref="GraphResponse{AttachmentSession}"/> object.
        /// </summary>
        /// <param name="attachmentSessionToUpdate">The AttachmentSession object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AttachmentSession}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AttachmentSession>> PutResponseAsync(AttachmentSession attachmentSessionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAttachmentSessionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAttachmentSessionRequest Expand(Expression<Func<AttachmentSession, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAttachmentSessionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAttachmentSessionRequest Select(Expression<Func<AttachmentSession, object>> selectExpression);

    }
}
