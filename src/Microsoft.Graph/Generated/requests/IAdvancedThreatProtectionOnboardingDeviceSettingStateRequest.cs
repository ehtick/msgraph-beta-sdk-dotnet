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
    /// The interface IAdvancedThreatProtectionOnboardingDeviceSettingStateRequest.
    /// </summary>
    public partial interface IAdvancedThreatProtectionOnboardingDeviceSettingStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingDeviceSettingState using POST.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingDeviceSettingStateToCreate">The AdvancedThreatProtectionOnboardingDeviceSettingState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdvancedThreatProtectionOnboardingDeviceSettingState.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingDeviceSettingState> CreateAsync(AdvancedThreatProtectionOnboardingDeviceSettingState advancedThreatProtectionOnboardingDeviceSettingStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingDeviceSettingState using POST and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> object.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingDeviceSettingStateToCreate">The AdvancedThreatProtectionOnboardingDeviceSettingState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingDeviceSettingState>> CreateResponseAsync(AdvancedThreatProtectionOnboardingDeviceSettingState advancedThreatProtectionOnboardingDeviceSettingStateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingDeviceSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingDeviceSettingState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingDeviceSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdvancedThreatProtectionOnboardingDeviceSettingState.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingDeviceSettingState> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingDeviceSettingState and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingDeviceSettingState>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingDeviceSettingState using PATCH.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingDeviceSettingStateToUpdate">The AdvancedThreatProtectionOnboardingDeviceSettingState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AdvancedThreatProtectionOnboardingDeviceSettingState.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingDeviceSettingState> UpdateAsync(AdvancedThreatProtectionOnboardingDeviceSettingState advancedThreatProtectionOnboardingDeviceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingDeviceSettingState using PATCH and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> object.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingDeviceSettingStateToUpdate">The AdvancedThreatProtectionOnboardingDeviceSettingState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingDeviceSettingState>> UpdateResponseAsync(AdvancedThreatProtectionOnboardingDeviceSettingState advancedThreatProtectionOnboardingDeviceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingDeviceSettingState using PUT.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingDeviceSettingStateToUpdate">The AdvancedThreatProtectionOnboardingDeviceSettingState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingDeviceSettingState> PutAsync(AdvancedThreatProtectionOnboardingDeviceSettingState advancedThreatProtectionOnboardingDeviceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingDeviceSettingState using PUT and returns a <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> object.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingDeviceSettingStateToUpdate">The AdvancedThreatProtectionOnboardingDeviceSettingState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AdvancedThreatProtectionOnboardingDeviceSettingState}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdvancedThreatProtectionOnboardingDeviceSettingState>> PutResponseAsync(AdvancedThreatProtectionOnboardingDeviceSettingState advancedThreatProtectionOnboardingDeviceSettingStateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingDeviceSettingStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingDeviceSettingStateRequest Expand(Expression<Func<AdvancedThreatProtectionOnboardingDeviceSettingState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingDeviceSettingStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingDeviceSettingStateRequest Select(Expression<Func<AdvancedThreatProtectionOnboardingDeviceSettingState, object>> selectExpression);

    }
}
