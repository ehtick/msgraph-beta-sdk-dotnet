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
    /// The interface IDeviceConfigurationDeviceStatusRequest.
    /// </summary>
    public partial interface IDeviceConfigurationDeviceStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceStatus using POST.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToCreate">The DeviceConfigurationDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> CreateAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceStatus using POST and returns a <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToCreate">The DeviceConfigurationDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceStatus>> CreateResponseAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceStatus and returns a <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceStatus>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStatus using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToUpdate">The DeviceConfigurationDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfigurationDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> UpdateAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStatus using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToUpdate">The DeviceConfigurationDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceStatus>> UpdateResponseAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStatus using PUT.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToUpdate">The DeviceConfigurationDeviceStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceStatus> PutAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceStatus using PUT and returns a <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationDeviceStatusToUpdate">The DeviceConfigurationDeviceStatus object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceConfigurationDeviceStatus}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationDeviceStatus>> PutResponseAsync(DeviceConfigurationDeviceStatus deviceConfigurationDeviceStatusToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStatusRequest Expand(Expression<Func<DeviceConfigurationDeviceStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceStatusRequest Select(Expression<Func<DeviceConfigurationDeviceStatus, object>> selectExpression);

    }
}
