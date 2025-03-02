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
    /// The interface IEducationSynchronizationProfileRequest.
    /// </summary>
    public partial interface IEducationSynchronizationProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationSynchronizationProfile using POST.
        /// </summary>
        /// <param name="educationSynchronizationProfileToCreate">The EducationSynchronizationProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationSynchronizationProfile.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationProfile> CreateAsync(EducationSynchronizationProfile educationSynchronizationProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EducationSynchronizationProfile using POST and returns a <see cref="GraphResponse{EducationSynchronizationProfile}"/> object.
        /// </summary>
        /// <param name="educationSynchronizationProfileToCreate">The EducationSynchronizationProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationSynchronizationProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationProfile>> CreateResponseAsync(EducationSynchronizationProfile educationSynchronizationProfileToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationSynchronizationProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationSynchronizationProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationSynchronizationProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationSynchronizationProfile.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationProfile> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationSynchronizationProfile and returns a <see cref="GraphResponse{EducationSynchronizationProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationSynchronizationProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationProfile>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationProfile using PATCH.
        /// </summary>
        /// <param name="educationSynchronizationProfileToUpdate">The EducationSynchronizationProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationSynchronizationProfile.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationProfile> UpdateAsync(EducationSynchronizationProfile educationSynchronizationProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationProfile using PATCH and returns a <see cref="GraphResponse{EducationSynchronizationProfile}"/> object.
        /// </summary>
        /// <param name="educationSynchronizationProfileToUpdate">The EducationSynchronizationProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationSynchronizationProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationProfile>> UpdateResponseAsync(EducationSynchronizationProfile educationSynchronizationProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationProfile using PUT.
        /// </summary>
        /// <param name="educationSynchronizationProfileToUpdate">The EducationSynchronizationProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationSynchronizationProfile> PutAsync(EducationSynchronizationProfile educationSynchronizationProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationSynchronizationProfile using PUT and returns a <see cref="GraphResponse{EducationSynchronizationProfile}"/> object.
        /// </summary>
        /// <param name="educationSynchronizationProfileToUpdate">The EducationSynchronizationProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationSynchronizationProfile}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationSynchronizationProfile>> PutResponseAsync(EducationSynchronizationProfile educationSynchronizationProfileToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationProfileRequest Expand(Expression<Func<EducationSynchronizationProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationSynchronizationProfileRequest Select(Expression<Func<EducationSynchronizationProfile, object>> selectExpression);

    }
}
