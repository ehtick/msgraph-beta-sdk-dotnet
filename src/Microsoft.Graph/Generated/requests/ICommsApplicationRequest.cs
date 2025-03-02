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
    /// The interface ICommsApplicationRequest.
    /// </summary>
    public partial interface ICommsApplicationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CommsApplication using POST.
        /// </summary>
        /// <param name="commsApplicationToCreate">The CommsApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CommsApplication.</returns>
        System.Threading.Tasks.Task<CommsApplication> CreateAsync(CommsApplication commsApplicationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CommsApplication using POST and returns a <see cref="GraphResponse{CommsApplication}"/> object.
        /// </summary>
        /// <param name="commsApplicationToCreate">The CommsApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CommsApplication}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsApplication>> CreateResponseAsync(CommsApplication commsApplicationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CommsApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CommsApplication and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CommsApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CommsApplication.</returns>
        System.Threading.Tasks.Task<CommsApplication> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CommsApplication and returns a <see cref="GraphResponse{CommsApplication}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CommsApplication}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsApplication>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CommsApplication using PATCH.
        /// </summary>
        /// <param name="commsApplicationToUpdate">The CommsApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CommsApplication.</returns>
        System.Threading.Tasks.Task<CommsApplication> UpdateAsync(CommsApplication commsApplicationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CommsApplication using PATCH and returns a <see cref="GraphResponse{CommsApplication}"/> object.
        /// </summary>
        /// <param name="commsApplicationToUpdate">The CommsApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CommsApplication}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsApplication>> UpdateResponseAsync(CommsApplication commsApplicationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CommsApplication using PUT.
        /// </summary>
        /// <param name="commsApplicationToUpdate">The CommsApplication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CommsApplication> PutAsync(CommsApplication commsApplicationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CommsApplication using PUT and returns a <see cref="GraphResponse{CommsApplication}"/> object.
        /// </summary>
        /// <param name="commsApplicationToUpdate">The CommsApplication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CommsApplication}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CommsApplication>> PutResponseAsync(CommsApplication commsApplicationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICommsApplicationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICommsApplicationRequest Expand(Expression<Func<CommsApplication, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICommsApplicationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICommsApplicationRequest Select(Expression<Func<CommsApplication, object>> selectExpression);

    }
}
