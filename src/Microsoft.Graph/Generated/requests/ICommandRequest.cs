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
    /// The interface ICommandRequest.
    /// </summary>
    public partial interface ICommandRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Command using POST.
        /// </summary>
        /// <param name="commandToCreate">The Command to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Command.</returns>
        System.Threading.Tasks.Task<Command> CreateAsync(Command commandToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Command using POST and returns a <see cref="GraphResponse{Command}"/> object.
        /// </summary>
        /// <param name="commandToCreate">The Command to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Command}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Command>> CreateResponseAsync(Command commandToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Command.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Command and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Command.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Command.</returns>
        System.Threading.Tasks.Task<Command> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Command and returns a <see cref="GraphResponse{Command}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Command}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Command>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Command using PATCH.
        /// </summary>
        /// <param name="commandToUpdate">The Command to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Command.</returns>
        System.Threading.Tasks.Task<Command> UpdateAsync(Command commandToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Command using PATCH and returns a <see cref="GraphResponse{Command}"/> object.
        /// </summary>
        /// <param name="commandToUpdate">The Command to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Command}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Command>> UpdateResponseAsync(Command commandToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Command using PUT.
        /// </summary>
        /// <param name="commandToUpdate">The Command object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Command> PutAsync(Command commandToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Command using PUT and returns a <see cref="GraphResponse{Command}"/> object.
        /// </summary>
        /// <param name="commandToUpdate">The Command object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Command}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Command>> PutResponseAsync(Command commandToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICommandRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICommandRequest Expand(Expression<Func<Command, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICommandRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICommandRequest Select(Expression<Func<Command, object>> selectExpression);

    }
}
