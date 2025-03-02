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
    /// The interface IDirectoryRequest.
    /// </summary>
    public partial interface IDirectoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Directory using POST.
        /// </summary>
        /// <param name="directoryToCreate">The Directory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Directory.</returns>
        System.Threading.Tasks.Task<Directory> CreateAsync(Directory directoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Directory using POST and returns a <see cref="GraphResponse{Directory}"/> object.
        /// </summary>
        /// <param name="directoryToCreate">The Directory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Directory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Directory>> CreateResponseAsync(Directory directoryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Directory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Directory and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Directory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Directory.</returns>
        System.Threading.Tasks.Task<Directory> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Directory and returns a <see cref="GraphResponse{Directory}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Directory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Directory>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Directory using PATCH.
        /// </summary>
        /// <param name="directoryToUpdate">The Directory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Directory.</returns>
        System.Threading.Tasks.Task<Directory> UpdateAsync(Directory directoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Directory using PATCH and returns a <see cref="GraphResponse{Directory}"/> object.
        /// </summary>
        /// <param name="directoryToUpdate">The Directory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Directory}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Directory>> UpdateResponseAsync(Directory directoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Directory using PUT.
        /// </summary>
        /// <param name="directoryToUpdate">The Directory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Directory> PutAsync(Directory directoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Directory using PUT and returns a <see cref="GraphResponse{Directory}"/> object.
        /// </summary>
        /// <param name="directoryToUpdate">The Directory object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Directory}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Directory>> PutResponseAsync(Directory directoryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRequest Expand(Expression<Func<Directory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRequest Select(Expression<Func<Directory, object>> selectExpression);

    }
}
