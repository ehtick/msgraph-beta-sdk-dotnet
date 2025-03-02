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
    /// The interface IDeviceManagementConfigurationSimpleSettingDefinitionRequest.
    /// </summary>
    public partial interface IDeviceManagementConfigurationSimpleSettingDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSimpleSettingDefinition using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationSimpleSettingDefinitionToCreate">The DeviceManagementConfigurationSimpleSettingDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationSimpleSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSimpleSettingDefinition> CreateAsync(DeviceManagementConfigurationSimpleSettingDefinition deviceManagementConfigurationSimpleSettingDefinitionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationSimpleSettingDefinition using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSimpleSettingDefinitionToCreate">The DeviceManagementConfigurationSimpleSettingDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSimpleSettingDefinition>> CreateResponseAsync(DeviceManagementConfigurationSimpleSettingDefinition deviceManagementConfigurationSimpleSettingDefinitionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSimpleSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationSimpleSettingDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSimpleSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationSimpleSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSimpleSettingDefinition> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationSimpleSettingDefinition and returns a <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSimpleSettingDefinition>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSimpleSettingDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationSimpleSettingDefinitionToUpdate">The DeviceManagementConfigurationSimpleSettingDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationSimpleSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSimpleSettingDefinition> UpdateAsync(DeviceManagementConfigurationSimpleSettingDefinition deviceManagementConfigurationSimpleSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSimpleSettingDefinition using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSimpleSettingDefinitionToUpdate">The DeviceManagementConfigurationSimpleSettingDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSimpleSettingDefinition>> UpdateResponseAsync(DeviceManagementConfigurationSimpleSettingDefinition deviceManagementConfigurationSimpleSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSimpleSettingDefinition using PUT.
        /// </summary>
        /// <param name="deviceManagementConfigurationSimpleSettingDefinitionToUpdate">The DeviceManagementConfigurationSimpleSettingDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementConfigurationSimpleSettingDefinition> PutAsync(DeviceManagementConfigurationSimpleSettingDefinition deviceManagementConfigurationSimpleSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationSimpleSettingDefinition using PUT and returns a <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationSimpleSettingDefinitionToUpdate">The DeviceManagementConfigurationSimpleSettingDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementConfigurationSimpleSettingDefinition}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationSimpleSettingDefinition>> PutResponseAsync(DeviceManagementConfigurationSimpleSettingDefinition deviceManagementConfigurationSimpleSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSimpleSettingDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSimpleSettingDefinitionRequest Expand(Expression<Func<DeviceManagementConfigurationSimpleSettingDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSimpleSettingDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementConfigurationSimpleSettingDefinitionRequest Select(Expression<Func<DeviceManagementConfigurationSimpleSettingDefinition, object>> selectExpression);

    }
}
