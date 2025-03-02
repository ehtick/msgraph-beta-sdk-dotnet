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
    /// The interface IIosEducationDeviceConfigurationRequest.
    /// </summary>
    public partial interface IIosEducationDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosEducationDeviceConfiguration using POST.
        /// </summary>
        /// <param name="iosEducationDeviceConfigurationToCreate">The IosEducationDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosEducationDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<IosEducationDeviceConfiguration> CreateAsync(IosEducationDeviceConfiguration iosEducationDeviceConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IosEducationDeviceConfiguration using POST and returns a <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="iosEducationDeviceConfigurationToCreate">The IosEducationDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosEducationDeviceConfiguration>> CreateResponseAsync(IosEducationDeviceConfiguration iosEducationDeviceConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosEducationDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IosEducationDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosEducationDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosEducationDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<IosEducationDeviceConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IosEducationDeviceConfiguration and returns a <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosEducationDeviceConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosEducationDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="iosEducationDeviceConfigurationToUpdate">The IosEducationDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosEducationDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<IosEducationDeviceConfiguration> UpdateAsync(IosEducationDeviceConfiguration iosEducationDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosEducationDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="iosEducationDeviceConfigurationToUpdate">The IosEducationDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosEducationDeviceConfiguration>> UpdateResponseAsync(IosEducationDeviceConfiguration iosEducationDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosEducationDeviceConfiguration using PUT.
        /// </summary>
        /// <param name="iosEducationDeviceConfigurationToUpdate">The IosEducationDeviceConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosEducationDeviceConfiguration> PutAsync(IosEducationDeviceConfiguration iosEducationDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IosEducationDeviceConfiguration using PUT and returns a <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="iosEducationDeviceConfigurationToUpdate">The IosEducationDeviceConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosEducationDeviceConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosEducationDeviceConfiguration>> PutResponseAsync(IosEducationDeviceConfiguration iosEducationDeviceConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosEducationDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosEducationDeviceConfigurationRequest Expand(Expression<Func<IosEducationDeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosEducationDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosEducationDeviceConfigurationRequest Select(Expression<Func<IosEducationDeviceConfiguration, object>> selectExpression);

    }
}
