// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITriggerTypesRootRequest.
    /// </summary>
    public partial interface ITriggerTypesRootRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified TriggerTypesRoot using POST.
        /// </summary>
        /// <param name="triggerTypesRootToCreate">The TriggerTypesRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TriggerTypesRoot.</returns>
        System.Threading.Tasks.Task<TriggerTypesRoot> CreateAsync(TriggerTypesRoot triggerTypesRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TriggerTypesRoot using POST and returns a <see cref="GraphResponse{TriggerTypesRoot}"/> object.
        /// </summary>
        /// <param name="triggerTypesRootToCreate">The TriggerTypesRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TriggerTypesRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TriggerTypesRoot>> CreateResponseAsync(TriggerTypesRoot triggerTypesRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TriggerTypesRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TriggerTypesRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TriggerTypesRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TriggerTypesRoot.</returns>
        System.Threading.Tasks.Task<TriggerTypesRoot> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TriggerTypesRoot and returns a <see cref="GraphResponse{TriggerTypesRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TriggerTypesRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TriggerTypesRoot>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TriggerTypesRoot using PATCH.
        /// </summary>
        /// <param name="triggerTypesRootToUpdate">The TriggerTypesRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TriggerTypesRoot.</returns>
        System.Threading.Tasks.Task<TriggerTypesRoot> UpdateAsync(TriggerTypesRoot triggerTypesRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TriggerTypesRoot using PATCH and returns a <see cref="GraphResponse{TriggerTypesRoot}"/> object.
        /// </summary>
        /// <param name="triggerTypesRootToUpdate">The TriggerTypesRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TriggerTypesRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TriggerTypesRoot>> UpdateResponseAsync(TriggerTypesRoot triggerTypesRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TriggerTypesRoot using PUT.
        /// </summary>
        /// <param name="triggerTypesRootToUpdate">The TriggerTypesRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TriggerTypesRoot> PutAsync(TriggerTypesRoot triggerTypesRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TriggerTypesRoot using PUT and returns a <see cref="GraphResponse{TriggerTypesRoot}"/> object.
        /// </summary>
        /// <param name="triggerTypesRootToUpdate">The TriggerTypesRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TriggerTypesRoot}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TriggerTypesRoot>> PutResponseAsync(TriggerTypesRoot triggerTypesRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITriggerTypesRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITriggerTypesRootRequest Expand(Expression<Func<TriggerTypesRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITriggerTypesRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITriggerTypesRootRequest Select(Expression<Func<TriggerTypesRoot, object>> selectExpression);

    }
}
