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
    /// The interface IWin32LobAppRequest.
    /// </summary>
    public partial interface IWin32LobAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Win32LobApp using POST.
        /// </summary>
        /// <param name="win32LobAppToCreate">The Win32LobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Win32LobApp.</returns>
        System.Threading.Tasks.Task<Win32LobApp> CreateAsync(Win32LobApp win32LobAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Win32LobApp using POST and returns a <see cref="GraphResponse{Win32LobApp}"/> object.
        /// </summary>
        /// <param name="win32LobAppToCreate">The Win32LobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Win32LobApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Win32LobApp>> CreateResponseAsync(Win32LobApp win32LobAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Win32LobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Win32LobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Win32LobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Win32LobApp.</returns>
        System.Threading.Tasks.Task<Win32LobApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Win32LobApp and returns a <see cref="GraphResponse{Win32LobApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Win32LobApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Win32LobApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Win32LobApp using PATCH.
        /// </summary>
        /// <param name="win32LobAppToUpdate">The Win32LobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Win32LobApp.</returns>
        System.Threading.Tasks.Task<Win32LobApp> UpdateAsync(Win32LobApp win32LobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Win32LobApp using PATCH and returns a <see cref="GraphResponse{Win32LobApp}"/> object.
        /// </summary>
        /// <param name="win32LobAppToUpdate">The Win32LobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Win32LobApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Win32LobApp>> UpdateResponseAsync(Win32LobApp win32LobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Win32LobApp using PUT.
        /// </summary>
        /// <param name="win32LobAppToUpdate">The Win32LobApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Win32LobApp> PutAsync(Win32LobApp win32LobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Win32LobApp using PUT and returns a <see cref="GraphResponse{Win32LobApp}"/> object.
        /// </summary>
        /// <param name="win32LobAppToUpdate">The Win32LobApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Win32LobApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Win32LobApp>> PutResponseAsync(Win32LobApp win32LobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWin32LobAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWin32LobAppRequest Expand(Expression<Func<Win32LobApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWin32LobAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWin32LobAppRequest Select(Expression<Func<Win32LobApp, object>> selectExpression);

    }
}
