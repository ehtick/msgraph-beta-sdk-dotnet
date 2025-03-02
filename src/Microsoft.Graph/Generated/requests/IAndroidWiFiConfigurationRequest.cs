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
    /// The interface IAndroidWiFiConfigurationRequest.
    /// </summary>
    public partial interface IAndroidWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWiFiConfiguration using POST.
        /// </summary>
        /// <param name="androidWiFiConfigurationToCreate">The AndroidWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWiFiConfiguration> CreateAsync(AndroidWiFiConfiguration androidWiFiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AndroidWiFiConfiguration using POST and returns a <see cref="GraphResponse{AndroidWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWiFiConfigurationToCreate">The AndroidWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWiFiConfiguration>> CreateResponseAsync(AndroidWiFiConfiguration androidWiFiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWiFiConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidWiFiConfiguration and returns a <see cref="GraphResponse{AndroidWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="androidWiFiConfigurationToUpdate">The AndroidWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidWiFiConfiguration> UpdateAsync(AndroidWiFiConfiguration androidWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWiFiConfigurationToUpdate">The AndroidWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWiFiConfiguration>> UpdateResponseAsync(AndroidWiFiConfiguration androidWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="androidWiFiConfigurationToUpdate">The AndroidWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidWiFiConfiguration> PutAsync(AndroidWiFiConfiguration androidWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidWiFiConfiguration using PUT and returns a <see cref="GraphResponse{AndroidWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="androidWiFiConfigurationToUpdate">The AndroidWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidWiFiConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWiFiConfiguration>> PutResponseAsync(AndroidWiFiConfiguration androidWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWiFiConfigurationRequest Expand(Expression<Func<AndroidWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWiFiConfigurationRequest Select(Expression<Func<AndroidWiFiConfiguration, object>> selectExpression);

    }
}
