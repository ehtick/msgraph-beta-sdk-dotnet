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
    /// The interface IEducationSynchronizationErrorRequest.
    /// </summary>
    public partial interface IEducationSynchronizationErrorRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationSynchronizationError using POST.
        /// </summary>
        /// <param name="educationSynchronizationErrorToCreate">The EducationSynchronizationError to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> CreateAsync(EducationSynchronizationError educationSynchronizationErrorToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EducationSynchronizationError using POST and returns a <see cref="GraphResponse{EducationSynchronizationError}"/> object.
        /// </summary>
        /// <param name="educationSynchronizationErrorToCreate">The EducationSynchronizationError to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationSynchronizationError}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationError>> CreateResponseAsync(EducationSynchronizationError educationSynchronizationErrorToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationSynchronizationError.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationSynchronizationError and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationSynchronizationError.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationSynchronizationError and returns a <see cref="GraphResponse{EducationSynchronizationError}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationSynchronizationError}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationError>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationError using PATCH.
        /// </summary>
        /// <param name="educationSynchronizationErrorToUpdate">The EducationSynchronizationError to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationSynchronizationError.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> UpdateAsync(EducationSynchronizationError educationSynchronizationErrorToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationError using PATCH and returns a <see cref="GraphResponse{EducationSynchronizationError}"/> object.
        /// </summary>
        /// <param name="educationSynchronizationErrorToUpdate">The EducationSynchronizationError to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationSynchronizationError}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationError>> UpdateResponseAsync(EducationSynchronizationError educationSynchronizationErrorToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationError using PUT.
        /// </summary>
        /// <param name="educationSynchronizationErrorToUpdate">The EducationSynchronizationError object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationError> PutAsync(EducationSynchronizationError educationSynchronizationErrorToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationError using PUT and returns a <see cref="GraphResponse{EducationSynchronizationError}"/> object.
        /// </summary>
        /// <param name="educationSynchronizationErrorToUpdate">The EducationSynchronizationError object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationSynchronizationError}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationError>> PutResponseAsync(EducationSynchronizationError educationSynchronizationErrorToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Expand(Expression<Func<EducationSynchronizationError, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationErrorRequest Select(Expression<Func<EducationSynchronizationError, object>> selectExpression);

    }
}
