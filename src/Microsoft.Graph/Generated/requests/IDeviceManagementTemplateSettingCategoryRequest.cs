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
    /// The interface IDeviceManagementTemplateSettingCategoryRequest.
    /// </summary>
    public partial interface IDeviceManagementTemplateSettingCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementTemplateSettingCategory using POST.
        /// </summary>
        /// <param name="deviceManagementTemplateSettingCategoryToCreate">The DeviceManagementTemplateSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementTemplateSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplateSettingCategory> CreateAsync(DeviceManagementTemplateSettingCategory deviceManagementTemplateSettingCategoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagementTemplateSettingCategory using POST and returns a <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateSettingCategoryToCreate">The DeviceManagementTemplateSettingCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplateSettingCategory>> CreateResponseAsync(DeviceManagementTemplateSettingCategory deviceManagementTemplateSettingCategoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementTemplateSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementTemplateSettingCategory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementTemplateSettingCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementTemplateSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplateSettingCategory> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementTemplateSettingCategory and returns a <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplateSettingCategory>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementTemplateSettingCategory using PATCH.
        /// </summary>
        /// <param name="deviceManagementTemplateSettingCategoryToUpdate">The DeviceManagementTemplateSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementTemplateSettingCategory.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplateSettingCategory> UpdateAsync(DeviceManagementTemplateSettingCategory deviceManagementTemplateSettingCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementTemplateSettingCategory using PATCH and returns a <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateSettingCategoryToUpdate">The DeviceManagementTemplateSettingCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplateSettingCategory>> UpdateResponseAsync(DeviceManagementTemplateSettingCategory deviceManagementTemplateSettingCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementTemplateSettingCategory using PUT.
        /// </summary>
        /// <param name="deviceManagementTemplateSettingCategoryToUpdate">The DeviceManagementTemplateSettingCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementTemplateSettingCategory> PutAsync(DeviceManagementTemplateSettingCategory deviceManagementTemplateSettingCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementTemplateSettingCategory using PUT and returns a <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateSettingCategoryToUpdate">The DeviceManagementTemplateSettingCategory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementTemplateSettingCategory}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplateSettingCategory>> PutResponseAsync(DeviceManagementTemplateSettingCategory deviceManagementTemplateSettingCategoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateSettingCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateSettingCategoryRequest Expand(Expression<Func<DeviceManagementTemplateSettingCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateSettingCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementTemplateSettingCategoryRequest Select(Expression<Func<DeviceManagementTemplateSettingCategory, object>> selectExpression);

    }
}
