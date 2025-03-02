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
    /// The interface IClassificationJobResponseRequest.
    /// </summary>
    public partial interface IClassificationJobResponseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ClassificationJobResponse using POST.
        /// </summary>
        /// <param name="classificationJobResponseToCreate">The ClassificationJobResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ClassificationJobResponse.</returns>
        System.Threading.Tasks.Task<ClassificationJobResponse> CreateAsync(ClassificationJobResponse classificationJobResponseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ClassificationJobResponse using POST and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="classificationJobResponseToCreate">The ClassificationJobResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ClassificationJobResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> CreateResponseAsync(ClassificationJobResponse classificationJobResponseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ClassificationJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ClassificationJobResponse and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ClassificationJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ClassificationJobResponse.</returns>
        System.Threading.Tasks.Task<ClassificationJobResponse> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ClassificationJobResponse and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ClassificationJobResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PATCH.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ClassificationJobResponse.</returns>
        System.Threading.Tasks.Task<ClassificationJobResponse> UpdateAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PATCH and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ClassificationJobResponse}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> UpdateResponseAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PUT.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ClassificationJobResponse> PutAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PUT and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ClassificationJobResponse}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> PutResponseAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IClassificationJobResponseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IClassificationJobResponseRequest Expand(Expression<Func<ClassificationJobResponse, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IClassificationJobResponseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IClassificationJobResponseRequest Select(Expression<Func<ClassificationJobResponse, object>> selectExpression);

    }
}
