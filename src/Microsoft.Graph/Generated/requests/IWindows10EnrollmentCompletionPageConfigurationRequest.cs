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
    /// The interface IWindows10EnrollmentCompletionPageConfigurationRequest.
    /// </summary>
    public partial interface IWindows10EnrollmentCompletionPageConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10EnrollmentCompletionPageConfiguration using POST.
        /// </summary>
        /// <param name="windows10EnrollmentCompletionPageConfigurationToCreate">The Windows10EnrollmentCompletionPageConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10EnrollmentCompletionPageConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EnrollmentCompletionPageConfiguration> CreateAsync(Windows10EnrollmentCompletionPageConfiguration windows10EnrollmentCompletionPageConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Windows10EnrollmentCompletionPageConfiguration using POST and returns a <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EnrollmentCompletionPageConfigurationToCreate">The Windows10EnrollmentCompletionPageConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10EnrollmentCompletionPageConfiguration>> CreateResponseAsync(Windows10EnrollmentCompletionPageConfiguration windows10EnrollmentCompletionPageConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Windows10EnrollmentCompletionPageConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Windows10EnrollmentCompletionPageConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Windows10EnrollmentCompletionPageConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10EnrollmentCompletionPageConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EnrollmentCompletionPageConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Windows10EnrollmentCompletionPageConfiguration and returns a <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10EnrollmentCompletionPageConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10EnrollmentCompletionPageConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10EnrollmentCompletionPageConfigurationToUpdate">The Windows10EnrollmentCompletionPageConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10EnrollmentCompletionPageConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10EnrollmentCompletionPageConfiguration> UpdateAsync(Windows10EnrollmentCompletionPageConfiguration windows10EnrollmentCompletionPageConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10EnrollmentCompletionPageConfiguration using PATCH and returns a <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EnrollmentCompletionPageConfigurationToUpdate">The Windows10EnrollmentCompletionPageConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10EnrollmentCompletionPageConfiguration>> UpdateResponseAsync(Windows10EnrollmentCompletionPageConfiguration windows10EnrollmentCompletionPageConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10EnrollmentCompletionPageConfiguration using PUT.
        /// </summary>
        /// <param name="windows10EnrollmentCompletionPageConfigurationToUpdate">The Windows10EnrollmentCompletionPageConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Windows10EnrollmentCompletionPageConfiguration> PutAsync(Windows10EnrollmentCompletionPageConfiguration windows10EnrollmentCompletionPageConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Windows10EnrollmentCompletionPageConfiguration using PUT and returns a <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EnrollmentCompletionPageConfigurationToUpdate">The Windows10EnrollmentCompletionPageConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Windows10EnrollmentCompletionPageConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows10EnrollmentCompletionPageConfiguration>> PutResponseAsync(Windows10EnrollmentCompletionPageConfiguration windows10EnrollmentCompletionPageConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EnrollmentCompletionPageConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EnrollmentCompletionPageConfigurationRequest Expand(Expression<Func<Windows10EnrollmentCompletionPageConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EnrollmentCompletionPageConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10EnrollmentCompletionPageConfigurationRequest Select(Expression<Func<Windows10EnrollmentCompletionPageConfiguration, object>> selectExpression);

    }
}
