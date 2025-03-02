// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICustodianRequest.
    /// </summary>
    public partial interface ICustodianRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Custodian using POST.
        /// </summary>
        /// <param name="custodianToCreate">The Custodian to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Custodian.</returns>
        System.Threading.Tasks.Task<Custodian> CreateAsync(Custodian custodianToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Custodian using POST and returns a <see cref="GraphResponse{Custodian}"/> object.
        /// </summary>
        /// <param name="custodianToCreate">The Custodian to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Custodian}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Custodian>> CreateResponseAsync(Custodian custodianToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Custodian.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Custodian and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Custodian.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Custodian.</returns>
        System.Threading.Tasks.Task<Custodian> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Custodian and returns a <see cref="GraphResponse{Custodian}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Custodian}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Custodian>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Custodian using PATCH.
        /// </summary>
        /// <param name="custodianToUpdate">The Custodian to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Custodian.</returns>
        System.Threading.Tasks.Task<Custodian> UpdateAsync(Custodian custodianToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Custodian using PATCH and returns a <see cref="GraphResponse{Custodian}"/> object.
        /// </summary>
        /// <param name="custodianToUpdate">The Custodian to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Custodian}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Custodian>> UpdateResponseAsync(Custodian custodianToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Custodian using PUT.
        /// </summary>
        /// <param name="custodianToUpdate">The Custodian object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Custodian> PutAsync(Custodian custodianToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Custodian using PUT and returns a <see cref="GraphResponse{Custodian}"/> object.
        /// </summary>
        /// <param name="custodianToUpdate">The Custodian object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Custodian}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Custodian>> PutResponseAsync(Custodian custodianToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustodianRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICustodianRequest Expand(Expression<Func<Custodian, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICustodianRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICustodianRequest Select(Expression<Func<Custodian, object>> selectExpression);

    }
}
