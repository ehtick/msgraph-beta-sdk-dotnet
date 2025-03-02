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
    /// The interface IDeviceConfigurationUserStateSummaryRequest.
    /// </summary>
    public partial interface IDeviceConfigurationUserStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationUserStateSummary using POST.
        /// </summary>
        /// <param name="deviceConfigurationUserStateSummaryToCreate">The DeviceConfigurationUserStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationUserStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStateSummary> CreateAsync(DeviceConfigurationUserStateSummary deviceConfigurationUserStateSummaryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceConfigurationUserStateSummary using POST and returns a <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationUserStateSummaryToCreate">The DeviceConfigurationUserStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationUserStateSummary>> CreateResponseAsync(DeviceConfigurationUserStateSummary deviceConfigurationUserStateSummaryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationUserStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationUserStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationUserStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationUserStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStateSummary> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationUserStateSummary and returns a <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationUserStateSummary>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationUserStateSummaryToUpdate">The DeviceConfigurationUserStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfigurationUserStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStateSummary> UpdateAsync(DeviceConfigurationUserStateSummary deviceConfigurationUserStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStateSummary using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationUserStateSummaryToUpdate">The DeviceConfigurationUserStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationUserStateSummary>> UpdateResponseAsync(DeviceConfigurationUserStateSummary deviceConfigurationUserStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStateSummary using PUT.
        /// </summary>
        /// <param name="deviceConfigurationUserStateSummaryToUpdate">The DeviceConfigurationUserStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationUserStateSummary> PutAsync(DeviceConfigurationUserStateSummary deviceConfigurationUserStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationUserStateSummary using PUT and returns a <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationUserStateSummaryToUpdate">The DeviceConfigurationUserStateSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceConfigurationUserStateSummary}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationUserStateSummary>> PutResponseAsync(DeviceConfigurationUserStateSummary deviceConfigurationUserStateSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStateSummaryRequest Expand(Expression<Func<DeviceConfigurationUserStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationUserStateSummaryRequest Select(Expression<Func<DeviceConfigurationUserStateSummary, object>> selectExpression);

    }
}
