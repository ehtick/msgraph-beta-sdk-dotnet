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
    /// The interface IMeetingRegistrationRequest.
    /// </summary>
    public partial interface IMeetingRegistrationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MeetingRegistration using POST.
        /// </summary>
        /// <param name="meetingRegistrationToCreate">The MeetingRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MeetingRegistration.</returns>
        System.Threading.Tasks.Task<MeetingRegistration> CreateAsync(MeetingRegistration meetingRegistrationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MeetingRegistration using POST and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationToCreate">The MeetingRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> CreateResponseAsync(MeetingRegistration meetingRegistrationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MeetingRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MeetingRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MeetingRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MeetingRegistration.</returns>
        System.Threading.Tasks.Task<MeetingRegistration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MeetingRegistration and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistration using PATCH.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MeetingRegistration.</returns>
        System.Threading.Tasks.Task<MeetingRegistration> UpdateAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistration using PATCH and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MeetingRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> UpdateResponseAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistration using PUT.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MeetingRegistration> PutAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MeetingRegistration using PUT and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MeetingRegistration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> PutResponseAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationRequest Expand(Expression<Func<MeetingRegistration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMeetingRegistrationRequest Select(Expression<Func<MeetingRegistration, object>> selectExpression);

    }
}
