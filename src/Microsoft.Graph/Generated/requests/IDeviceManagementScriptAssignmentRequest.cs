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
    /// The interface IDeviceManagementScriptAssignmentRequest.
    /// </summary>
    public partial interface IDeviceManagementScriptAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementScriptAssignment using POST.
        /// </summary>
        /// <param name="deviceManagementScriptAssignmentToCreate">The DeviceManagementScriptAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptAssignment> CreateAsync(DeviceManagementScriptAssignment deviceManagementScriptAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceManagementScriptAssignment using POST and returns a <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptAssignmentToCreate">The DeviceManagementScriptAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptAssignment>> CreateResponseAsync(DeviceManagementScriptAssignment deviceManagementScriptAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementScriptAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceManagementScriptAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementScriptAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceManagementScriptAssignment and returns a <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementScriptAssignment using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptAssignmentToUpdate">The DeviceManagementScriptAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptAssignment.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptAssignment> UpdateAsync(DeviceManagementScriptAssignment deviceManagementScriptAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementScriptAssignment using PATCH and returns a <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptAssignmentToUpdate">The DeviceManagementScriptAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptAssignment>> UpdateResponseAsync(DeviceManagementScriptAssignment deviceManagementScriptAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementScriptAssignment using PUT.
        /// </summary>
        /// <param name="deviceManagementScriptAssignmentToUpdate">The DeviceManagementScriptAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptAssignment> PutAsync(DeviceManagementScriptAssignment deviceManagementScriptAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceManagementScriptAssignment using PUT and returns a <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptAssignmentToUpdate">The DeviceManagementScriptAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceManagementScriptAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptAssignment>> PutResponseAsync(DeviceManagementScriptAssignment deviceManagementScriptAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptAssignmentRequest Expand(Expression<Func<DeviceManagementScriptAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptAssignmentRequest Select(Expression<Func<DeviceManagementScriptAssignment, object>> selectExpression);

    }
}
