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
    /// The interface ICaseOperationRequest.
    /// </summary>
    public partial interface ICaseOperationRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified CaseOperation using POST.
        /// </summary>
        /// <param name="caseOperationToCreate">The CaseOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CaseOperation.</returns>
        System.Threading.Tasks.Task<CaseOperation> CreateAsync(CaseOperation caseOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CaseOperation using POST and returns a <see cref="GraphResponse{CaseOperation}"/> object.
        /// </summary>
        /// <param name="caseOperationToCreate">The CaseOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CaseOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseOperation>> CreateResponseAsync(CaseOperation caseOperationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CaseOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CaseOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CaseOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CaseOperation.</returns>
        System.Threading.Tasks.Task<CaseOperation> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CaseOperation and returns a <see cref="GraphResponse{CaseOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CaseOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseOperation>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CaseOperation using PATCH.
        /// </summary>
        /// <param name="caseOperationToUpdate">The CaseOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CaseOperation.</returns>
        System.Threading.Tasks.Task<CaseOperation> UpdateAsync(CaseOperation caseOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CaseOperation using PATCH and returns a <see cref="GraphResponse{CaseOperation}"/> object.
        /// </summary>
        /// <param name="caseOperationToUpdate">The CaseOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CaseOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseOperation>> UpdateResponseAsync(CaseOperation caseOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CaseOperation using PUT.
        /// </summary>
        /// <param name="caseOperationToUpdate">The CaseOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CaseOperation> PutAsync(CaseOperation caseOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CaseOperation using PUT and returns a <see cref="GraphResponse{CaseOperation}"/> object.
        /// </summary>
        /// <param name="caseOperationToUpdate">The CaseOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CaseOperation}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseOperation>> PutResponseAsync(CaseOperation caseOperationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseOperationRequest Expand(Expression<Func<CaseOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseOperationRequest Select(Expression<Func<CaseOperation, object>> selectExpression);

    }
}
