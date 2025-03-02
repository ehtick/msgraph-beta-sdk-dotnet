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
    /// The interface IMacOsVppAppRequest.
    /// </summary>
    public partial interface IMacOsVppAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOsVppApp using POST.
        /// </summary>
        /// <param name="macOsVppAppToCreate">The MacOsVppApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOsVppApp.</returns>
        System.Threading.Tasks.Task<MacOsVppApp> CreateAsync(MacOsVppApp macOsVppAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MacOsVppApp using POST and returns a <see cref="GraphResponse{MacOsVppApp}"/> object.
        /// </summary>
        /// <param name="macOsVppAppToCreate">The MacOsVppApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOsVppApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOsVppApp>> CreateResponseAsync(MacOsVppApp macOsVppAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MacOsVppApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MacOsVppApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MacOsVppApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOsVppApp.</returns>
        System.Threading.Tasks.Task<MacOsVppApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MacOsVppApp and returns a <see cref="GraphResponse{MacOsVppApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOsVppApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOsVppApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOsVppApp using PATCH.
        /// </summary>
        /// <param name="macOsVppAppToUpdate">The MacOsVppApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOsVppApp.</returns>
        System.Threading.Tasks.Task<MacOsVppApp> UpdateAsync(MacOsVppApp macOsVppAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOsVppApp using PATCH and returns a <see cref="GraphResponse{MacOsVppApp}"/> object.
        /// </summary>
        /// <param name="macOsVppAppToUpdate">The MacOsVppApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOsVppApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOsVppApp>> UpdateResponseAsync(MacOsVppApp macOsVppAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOsVppApp using PUT.
        /// </summary>
        /// <param name="macOsVppAppToUpdate">The MacOsVppApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MacOsVppApp> PutAsync(MacOsVppApp macOsVppAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOsVppApp using PUT and returns a <see cref="GraphResponse{MacOsVppApp}"/> object.
        /// </summary>
        /// <param name="macOsVppAppToUpdate">The MacOsVppApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MacOsVppApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOsVppApp>> PutResponseAsync(MacOsVppApp macOsVppAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOsVppAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOsVppAppRequest Expand(Expression<Func<MacOsVppApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOsVppAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOsVppAppRequest Select(Expression<Func<MacOsVppApp, object>> selectExpression);

    }
}
