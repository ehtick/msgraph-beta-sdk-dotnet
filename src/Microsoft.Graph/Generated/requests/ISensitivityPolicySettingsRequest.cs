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
    /// The interface ISensitivityPolicySettingsRequest.
    /// </summary>
    public partial interface ISensitivityPolicySettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SensitivityPolicySettings using POST.
        /// </summary>
        /// <param name="sensitivityPolicySettingsToCreate">The SensitivityPolicySettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SensitivityPolicySettings.</returns>
        System.Threading.Tasks.Task<SensitivityPolicySettings> CreateAsync(SensitivityPolicySettings sensitivityPolicySettingsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SensitivityPolicySettings using POST and returns a <see cref="GraphResponse{SensitivityPolicySettings}"/> object.
        /// </summary>
        /// <param name="sensitivityPolicySettingsToCreate">The SensitivityPolicySettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SensitivityPolicySettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SensitivityPolicySettings>> CreateResponseAsync(SensitivityPolicySettings sensitivityPolicySettingsToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SensitivityPolicySettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SensitivityPolicySettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SensitivityPolicySettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SensitivityPolicySettings.</returns>
        System.Threading.Tasks.Task<SensitivityPolicySettings> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SensitivityPolicySettings and returns a <see cref="GraphResponse{SensitivityPolicySettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SensitivityPolicySettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SensitivityPolicySettings>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SensitivityPolicySettings using PATCH.
        /// </summary>
        /// <param name="sensitivityPolicySettingsToUpdate">The SensitivityPolicySettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SensitivityPolicySettings.</returns>
        System.Threading.Tasks.Task<SensitivityPolicySettings> UpdateAsync(SensitivityPolicySettings sensitivityPolicySettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SensitivityPolicySettings using PATCH and returns a <see cref="GraphResponse{SensitivityPolicySettings}"/> object.
        /// </summary>
        /// <param name="sensitivityPolicySettingsToUpdate">The SensitivityPolicySettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SensitivityPolicySettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SensitivityPolicySettings>> UpdateResponseAsync(SensitivityPolicySettings sensitivityPolicySettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SensitivityPolicySettings using PUT.
        /// </summary>
        /// <param name="sensitivityPolicySettingsToUpdate">The SensitivityPolicySettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SensitivityPolicySettings> PutAsync(SensitivityPolicySettings sensitivityPolicySettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SensitivityPolicySettings using PUT and returns a <see cref="GraphResponse{SensitivityPolicySettings}"/> object.
        /// </summary>
        /// <param name="sensitivityPolicySettingsToUpdate">The SensitivityPolicySettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SensitivityPolicySettings}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SensitivityPolicySettings>> PutResponseAsync(SensitivityPolicySettings sensitivityPolicySettingsToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISensitivityPolicySettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISensitivityPolicySettingsRequest Expand(Expression<Func<SensitivityPolicySettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISensitivityPolicySettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISensitivityPolicySettingsRequest Select(Expression<Func<SensitivityPolicySettings, object>> selectExpression);

    }
}
