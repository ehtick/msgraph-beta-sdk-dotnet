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
    /// The interface IDeviceManagementAbstractComplexSettingDefinitionRequest.
    /// </summary>
    public partial interface IDeviceManagementAbstractComplexSettingDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementAbstractComplexSettingDefinition using POST.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingDefinitionToCreate">The DeviceManagementAbstractComplexSettingDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementAbstractComplexSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementAbstractComplexSettingDefinition> CreateAsync(DeviceManagementAbstractComplexSettingDefinition deviceManagementAbstractComplexSettingDefinitionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagementAbstractComplexSettingDefinition using POST and returns a <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingDefinitionToCreate">The DeviceManagementAbstractComplexSettingDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAbstractComplexSettingDefinition>> CreateResponseAsync(DeviceManagementAbstractComplexSettingDefinition deviceManagementAbstractComplexSettingDefinitionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementAbstractComplexSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementAbstractComplexSettingDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementAbstractComplexSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementAbstractComplexSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementAbstractComplexSettingDefinition> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementAbstractComplexSettingDefinition and returns a <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAbstractComplexSettingDefinition>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementAbstractComplexSettingDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingDefinitionToUpdate">The DeviceManagementAbstractComplexSettingDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementAbstractComplexSettingDefinition.</returns>
        System.Threading.Tasks.Task<DeviceManagementAbstractComplexSettingDefinition> UpdateAsync(DeviceManagementAbstractComplexSettingDefinition deviceManagementAbstractComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementAbstractComplexSettingDefinition using PATCH and returns a <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingDefinitionToUpdate">The DeviceManagementAbstractComplexSettingDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAbstractComplexSettingDefinition>> UpdateResponseAsync(DeviceManagementAbstractComplexSettingDefinition deviceManagementAbstractComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementAbstractComplexSettingDefinition using PUT.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingDefinitionToUpdate">The DeviceManagementAbstractComplexSettingDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementAbstractComplexSettingDefinition> PutAsync(DeviceManagementAbstractComplexSettingDefinition deviceManagementAbstractComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementAbstractComplexSettingDefinition using PUT and returns a <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementAbstractComplexSettingDefinitionToUpdate">The DeviceManagementAbstractComplexSettingDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementAbstractComplexSettingDefinition}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementAbstractComplexSettingDefinition>> PutResponseAsync(DeviceManagementAbstractComplexSettingDefinition deviceManagementAbstractComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAbstractComplexSettingDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAbstractComplexSettingDefinitionRequest Expand(Expression<Func<DeviceManagementAbstractComplexSettingDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAbstractComplexSettingDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementAbstractComplexSettingDefinitionRequest Select(Expression<Func<DeviceManagementAbstractComplexSettingDefinition, object>> selectExpression);

    }
}
