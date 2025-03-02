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
    /// The interface IDeviceHealthScriptPolicyStateRequest.
    /// </summary>
    public partial interface IDeviceHealthScriptPolicyStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceHealthScriptPolicyState using POST.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToCreate">The DeviceHealthScriptPolicyState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceHealthScriptPolicyState.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptPolicyState> CreateAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DeviceHealthScriptPolicyState using POST and returns a <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToCreate">The DeviceHealthScriptPolicyState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptPolicyState>> CreateResponseAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceHealthScriptPolicyState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DeviceHealthScriptPolicyState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceHealthScriptPolicyState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceHealthScriptPolicyState.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptPolicyState> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeviceHealthScriptPolicyState and returns a <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptPolicyState>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceHealthScriptPolicyState using PATCH.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToUpdate">The DeviceHealthScriptPolicyState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceHealthScriptPolicyState.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptPolicyState> UpdateAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceHealthScriptPolicyState using PATCH and returns a <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToUpdate">The DeviceHealthScriptPolicyState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptPolicyState>> UpdateResponseAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceHealthScriptPolicyState using PUT.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToUpdate">The DeviceHealthScriptPolicyState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DeviceHealthScriptPolicyState> PutAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DeviceHealthScriptPolicyState using PUT and returns a <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToUpdate">The DeviceHealthScriptPolicyState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptPolicyState>> PutResponseAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptPolicyStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptPolicyStateRequest Expand(Expression<Func<DeviceHealthScriptPolicyState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptPolicyStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceHealthScriptPolicyStateRequest Select(Expression<Func<DeviceHealthScriptPolicyState, object>> selectExpression);

    }
}
