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
    /// The interface IWindowsIdentityProtectionConfigurationRequest.
    /// </summary>
    public partial interface IWindowsIdentityProtectionConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsIdentityProtectionConfiguration using POST.
        /// </summary>
        /// <param name="windowsIdentityProtectionConfigurationToCreate">The WindowsIdentityProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsIdentityProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsIdentityProtectionConfiguration> CreateAsync(WindowsIdentityProtectionConfiguration windowsIdentityProtectionConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WindowsIdentityProtectionConfiguration using POST and returns a <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsIdentityProtectionConfigurationToCreate">The WindowsIdentityProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsIdentityProtectionConfiguration>> CreateResponseAsync(WindowsIdentityProtectionConfiguration windowsIdentityProtectionConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsIdentityProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WindowsIdentityProtectionConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsIdentityProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsIdentityProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsIdentityProtectionConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WindowsIdentityProtectionConfiguration and returns a <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsIdentityProtectionConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsIdentityProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsIdentityProtectionConfigurationToUpdate">The WindowsIdentityProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsIdentityProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsIdentityProtectionConfiguration> UpdateAsync(WindowsIdentityProtectionConfiguration windowsIdentityProtectionConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsIdentityProtectionConfiguration using PATCH and returns a <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsIdentityProtectionConfigurationToUpdate">The WindowsIdentityProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsIdentityProtectionConfiguration>> UpdateResponseAsync(WindowsIdentityProtectionConfiguration windowsIdentityProtectionConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsIdentityProtectionConfiguration using PUT.
        /// </summary>
        /// <param name="windowsIdentityProtectionConfigurationToUpdate">The WindowsIdentityProtectionConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WindowsIdentityProtectionConfiguration> PutAsync(WindowsIdentityProtectionConfiguration windowsIdentityProtectionConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WindowsIdentityProtectionConfiguration using PUT and returns a <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsIdentityProtectionConfigurationToUpdate">The WindowsIdentityProtectionConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WindowsIdentityProtectionConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsIdentityProtectionConfiguration>> PutResponseAsync(WindowsIdentityProtectionConfiguration windowsIdentityProtectionConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsIdentityProtectionConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsIdentityProtectionConfigurationRequest Expand(Expression<Func<WindowsIdentityProtectionConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsIdentityProtectionConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsIdentityProtectionConfigurationRequest Select(Expression<Func<WindowsIdentityProtectionConfiguration, object>> selectExpression);

    }
}
