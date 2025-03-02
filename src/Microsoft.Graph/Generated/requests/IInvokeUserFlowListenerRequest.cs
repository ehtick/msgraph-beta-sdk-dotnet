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
    /// The interface IInvokeUserFlowListenerRequest.
    /// </summary>
    public partial interface IInvokeUserFlowListenerRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified InvokeUserFlowListener using POST.
        /// </summary>
        /// <param name="invokeUserFlowListenerToCreate">The InvokeUserFlowListener to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InvokeUserFlowListener.</returns>
        System.Threading.Tasks.Task<InvokeUserFlowListener> CreateAsync(InvokeUserFlowListener invokeUserFlowListenerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified InvokeUserFlowListener using POST and returns a <see cref="GraphResponse{InvokeUserFlowListener}"/> object.
        /// </summary>
        /// <param name="invokeUserFlowListenerToCreate">The InvokeUserFlowListener to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InvokeUserFlowListener}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InvokeUserFlowListener>> CreateResponseAsync(InvokeUserFlowListener invokeUserFlowListenerToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InvokeUserFlowListener.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified InvokeUserFlowListener and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InvokeUserFlowListener.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InvokeUserFlowListener.</returns>
        System.Threading.Tasks.Task<InvokeUserFlowListener> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified InvokeUserFlowListener and returns a <see cref="GraphResponse{InvokeUserFlowListener}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{InvokeUserFlowListener}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InvokeUserFlowListener>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InvokeUserFlowListener using PATCH.
        /// </summary>
        /// <param name="invokeUserFlowListenerToUpdate">The InvokeUserFlowListener to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InvokeUserFlowListener.</returns>
        System.Threading.Tasks.Task<InvokeUserFlowListener> UpdateAsync(InvokeUserFlowListener invokeUserFlowListenerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InvokeUserFlowListener using PATCH and returns a <see cref="GraphResponse{InvokeUserFlowListener}"/> object.
        /// </summary>
        /// <param name="invokeUserFlowListenerToUpdate">The InvokeUserFlowListener to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{InvokeUserFlowListener}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<InvokeUserFlowListener>> UpdateResponseAsync(InvokeUserFlowListener invokeUserFlowListenerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InvokeUserFlowListener using PUT.
        /// </summary>
        /// <param name="invokeUserFlowListenerToUpdate">The InvokeUserFlowListener object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<InvokeUserFlowListener> PutAsync(InvokeUserFlowListener invokeUserFlowListenerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified InvokeUserFlowListener using PUT and returns a <see cref="GraphResponse{InvokeUserFlowListener}"/> object.
        /// </summary>
        /// <param name="invokeUserFlowListenerToUpdate">The InvokeUserFlowListener object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{InvokeUserFlowListener}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<InvokeUserFlowListener>> PutResponseAsync(InvokeUserFlowListener invokeUserFlowListenerToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IInvokeUserFlowListenerRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IInvokeUserFlowListenerRequest Expand(Expression<Func<InvokeUserFlowListener, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IInvokeUserFlowListenerRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IInvokeUserFlowListenerRequest Select(Expression<Func<InvokeUserFlowListener, object>> selectExpression);

    }
}
