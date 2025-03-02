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
    /// The interface ITeamworkDeviceRequest.
    /// </summary>
    public partial interface ITeamworkDeviceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamworkDevice using POST.
        /// </summary>
        /// <param name="teamworkDeviceToCreate">The TeamworkDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamworkDevice.</returns>
        System.Threading.Tasks.Task<TeamworkDevice> CreateAsync(TeamworkDevice teamworkDeviceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TeamworkDevice using POST and returns a <see cref="GraphResponse{TeamworkDevice}"/> object.
        /// </summary>
        /// <param name="teamworkDeviceToCreate">The TeamworkDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkDevice}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkDevice>> CreateResponseAsync(TeamworkDevice teamworkDeviceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamworkDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TeamworkDevice and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamworkDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamworkDevice.</returns>
        System.Threading.Tasks.Task<TeamworkDevice> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TeamworkDevice and returns a <see cref="GraphResponse{TeamworkDevice}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkDevice}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkDevice>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamworkDevice using PATCH.
        /// </summary>
        /// <param name="teamworkDeviceToUpdate">The TeamworkDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamworkDevice.</returns>
        System.Threading.Tasks.Task<TeamworkDevice> UpdateAsync(TeamworkDevice teamworkDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamworkDevice using PATCH and returns a <see cref="GraphResponse{TeamworkDevice}"/> object.
        /// </summary>
        /// <param name="teamworkDeviceToUpdate">The TeamworkDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamworkDevice}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkDevice>> UpdateResponseAsync(TeamworkDevice teamworkDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamworkDevice using PUT.
        /// </summary>
        /// <param name="teamworkDeviceToUpdate">The TeamworkDevice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TeamworkDevice> PutAsync(TeamworkDevice teamworkDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TeamworkDevice using PUT and returns a <see cref="GraphResponse{TeamworkDevice}"/> object.
        /// </summary>
        /// <param name="teamworkDeviceToUpdate">The TeamworkDevice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TeamworkDevice}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkDevice>> PutResponseAsync(TeamworkDevice teamworkDeviceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkDeviceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkDeviceRequest Expand(Expression<Func<TeamworkDevice, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkDeviceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkDeviceRequest Select(Expression<Func<TeamworkDevice, object>> selectExpression);

    }
}
