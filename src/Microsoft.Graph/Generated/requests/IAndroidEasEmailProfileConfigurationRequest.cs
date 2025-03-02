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
    /// The interface IAndroidEasEmailProfileConfigurationRequest.
    /// </summary>
    public partial interface IAndroidEasEmailProfileConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidEasEmailProfileConfiguration using POST.
        /// </summary>
        /// <param name="androidEasEmailProfileConfigurationToCreate">The AndroidEasEmailProfileConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEasEmailProfileConfiguration> CreateAsync(AndroidEasEmailProfileConfiguration androidEasEmailProfileConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AndroidEasEmailProfileConfiguration using POST and returns a <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> object.
        /// </summary>
        /// <param name="androidEasEmailProfileConfigurationToCreate">The AndroidEasEmailProfileConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidEasEmailProfileConfiguration>> CreateResponseAsync(AndroidEasEmailProfileConfiguration androidEasEmailProfileConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidEasEmailProfileConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidEasEmailProfileConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEasEmailProfileConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidEasEmailProfileConfiguration and returns a <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidEasEmailProfileConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidEasEmailProfileConfiguration using PATCH.
        /// </summary>
        /// <param name="androidEasEmailProfileConfigurationToUpdate">The AndroidEasEmailProfileConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidEasEmailProfileConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidEasEmailProfileConfiguration> UpdateAsync(AndroidEasEmailProfileConfiguration androidEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidEasEmailProfileConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> object.
        /// </summary>
        /// <param name="androidEasEmailProfileConfigurationToUpdate">The AndroidEasEmailProfileConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidEasEmailProfileConfiguration>> UpdateResponseAsync(AndroidEasEmailProfileConfiguration androidEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidEasEmailProfileConfiguration using PUT.
        /// </summary>
        /// <param name="androidEasEmailProfileConfigurationToUpdate">The AndroidEasEmailProfileConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidEasEmailProfileConfiguration> PutAsync(AndroidEasEmailProfileConfiguration androidEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidEasEmailProfileConfiguration using PUT and returns a <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> object.
        /// </summary>
        /// <param name="androidEasEmailProfileConfigurationToUpdate">The AndroidEasEmailProfileConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidEasEmailProfileConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidEasEmailProfileConfiguration>> PutResponseAsync(AndroidEasEmailProfileConfiguration androidEasEmailProfileConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEasEmailProfileConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEasEmailProfileConfigurationRequest Expand(Expression<Func<AndroidEasEmailProfileConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEasEmailProfileConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidEasEmailProfileConfigurationRequest Select(Expression<Func<AndroidEasEmailProfileConfiguration, object>> selectExpression);

    }
}
