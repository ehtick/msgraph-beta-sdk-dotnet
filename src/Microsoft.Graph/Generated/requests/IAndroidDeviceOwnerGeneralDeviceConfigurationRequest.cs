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
    /// The interface IAndroidDeviceOwnerGeneralDeviceConfigurationRequest.
    /// </summary>
    public partial interface IAndroidDeviceOwnerGeneralDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidDeviceOwnerGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerGeneralDeviceConfigurationToCreate">The AndroidDeviceOwnerGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerGeneralDeviceConfiguration> CreateAsync(AndroidDeviceOwnerGeneralDeviceConfiguration androidDeviceOwnerGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerGeneralDeviceConfiguration using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerGeneralDeviceConfigurationToCreate">The AndroidDeviceOwnerGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerGeneralDeviceConfiguration>> CreateResponseAsync(AndroidDeviceOwnerGeneralDeviceConfiguration androidDeviceOwnerGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerGeneralDeviceConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerGeneralDeviceConfiguration and returns a <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerGeneralDeviceConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerGeneralDeviceConfigurationToUpdate">The AndroidDeviceOwnerGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerGeneralDeviceConfiguration> UpdateAsync(AndroidDeviceOwnerGeneralDeviceConfiguration androidDeviceOwnerGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerGeneralDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerGeneralDeviceConfigurationToUpdate">The AndroidDeviceOwnerGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerGeneralDeviceConfiguration>> UpdateResponseAsync(AndroidDeviceOwnerGeneralDeviceConfiguration androidDeviceOwnerGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerGeneralDeviceConfiguration using PUT.
        /// </summary>
        /// <param name="androidDeviceOwnerGeneralDeviceConfigurationToUpdate">The AndroidDeviceOwnerGeneralDeviceConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerGeneralDeviceConfiguration> PutAsync(AndroidDeviceOwnerGeneralDeviceConfiguration androidDeviceOwnerGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerGeneralDeviceConfiguration using PUT and returns a <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerGeneralDeviceConfigurationToUpdate">The AndroidDeviceOwnerGeneralDeviceConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AndroidDeviceOwnerGeneralDeviceConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerGeneralDeviceConfiguration>> PutResponseAsync(AndroidDeviceOwnerGeneralDeviceConfiguration androidDeviceOwnerGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerGeneralDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerGeneralDeviceConfigurationRequest Expand(Expression<Func<AndroidDeviceOwnerGeneralDeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerGeneralDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerGeneralDeviceConfigurationRequest Select(Expression<Func<AndroidDeviceOwnerGeneralDeviceConfiguration, object>> selectExpression);

    }
}
