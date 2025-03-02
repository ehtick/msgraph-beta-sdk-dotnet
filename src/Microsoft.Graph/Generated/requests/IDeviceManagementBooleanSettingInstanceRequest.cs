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
    /// The interface IDeviceManagementBooleanSettingInstanceRequest.
    /// </summary>
    public partial interface IDeviceManagementBooleanSettingInstanceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementBooleanSettingInstance using POST.
        /// </summary>
        /// <param name="deviceManagementBooleanSettingInstanceToCreate">The DeviceManagementBooleanSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementBooleanSettingInstance.</returns>
        System.Threading.Tasks.Task<DeviceManagementBooleanSettingInstance> CreateAsync(DeviceManagementBooleanSettingInstance deviceManagementBooleanSettingInstanceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagementBooleanSettingInstance using POST and returns a <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementBooleanSettingInstanceToCreate">The DeviceManagementBooleanSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementBooleanSettingInstance>> CreateResponseAsync(DeviceManagementBooleanSettingInstance deviceManagementBooleanSettingInstanceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementBooleanSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementBooleanSettingInstance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementBooleanSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementBooleanSettingInstance.</returns>
        System.Threading.Tasks.Task<DeviceManagementBooleanSettingInstance> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementBooleanSettingInstance and returns a <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementBooleanSettingInstance>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementBooleanSettingInstance using PATCH.
        /// </summary>
        /// <param name="deviceManagementBooleanSettingInstanceToUpdate">The DeviceManagementBooleanSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementBooleanSettingInstance.</returns>
        System.Threading.Tasks.Task<DeviceManagementBooleanSettingInstance> UpdateAsync(DeviceManagementBooleanSettingInstance deviceManagementBooleanSettingInstanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementBooleanSettingInstance using PATCH and returns a <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementBooleanSettingInstanceToUpdate">The DeviceManagementBooleanSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementBooleanSettingInstance>> UpdateResponseAsync(DeviceManagementBooleanSettingInstance deviceManagementBooleanSettingInstanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementBooleanSettingInstance using PUT.
        /// </summary>
        /// <param name="deviceManagementBooleanSettingInstanceToUpdate">The DeviceManagementBooleanSettingInstance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementBooleanSettingInstance> PutAsync(DeviceManagementBooleanSettingInstance deviceManagementBooleanSettingInstanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementBooleanSettingInstance using PUT and returns a <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementBooleanSettingInstanceToUpdate">The DeviceManagementBooleanSettingInstance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementBooleanSettingInstance}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementBooleanSettingInstance>> PutResponseAsync(DeviceManagementBooleanSettingInstance deviceManagementBooleanSettingInstanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementBooleanSettingInstanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementBooleanSettingInstanceRequest Expand(Expression<Func<DeviceManagementBooleanSettingInstance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementBooleanSettingInstanceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementBooleanSettingInstanceRequest Select(Expression<Func<DeviceManagementBooleanSettingInstance, object>> selectExpression);

    }
}
