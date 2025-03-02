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
    /// The interface IVerticalSectionRequest.
    /// </summary>
    public partial interface IVerticalSectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified VerticalSection using POST.
        /// </summary>
        /// <param name="verticalSectionToCreate">The VerticalSection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created VerticalSection.</returns>
        System.Threading.Tasks.Task<VerticalSection> CreateAsync(VerticalSection verticalSectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified VerticalSection using POST and returns a <see cref="GraphResponse{VerticalSection}"/> object.
        /// </summary>
        /// <param name="verticalSectionToCreate">The VerticalSection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VerticalSection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VerticalSection>> CreateResponseAsync(VerticalSection verticalSectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified VerticalSection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified VerticalSection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified VerticalSection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The VerticalSection.</returns>
        System.Threading.Tasks.Task<VerticalSection> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified VerticalSection and returns a <see cref="GraphResponse{VerticalSection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VerticalSection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VerticalSection>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified VerticalSection using PATCH.
        /// </summary>
        /// <param name="verticalSectionToUpdate">The VerticalSection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated VerticalSection.</returns>
        System.Threading.Tasks.Task<VerticalSection> UpdateAsync(VerticalSection verticalSectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified VerticalSection using PATCH and returns a <see cref="GraphResponse{VerticalSection}"/> object.
        /// </summary>
        /// <param name="verticalSectionToUpdate">The VerticalSection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{VerticalSection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VerticalSection>> UpdateResponseAsync(VerticalSection verticalSectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified VerticalSection using PUT.
        /// </summary>
        /// <param name="verticalSectionToUpdate">The VerticalSection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<VerticalSection> PutAsync(VerticalSection verticalSectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified VerticalSection using PUT and returns a <see cref="GraphResponse{VerticalSection}"/> object.
        /// </summary>
        /// <param name="verticalSectionToUpdate">The VerticalSection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{VerticalSection}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<VerticalSection>> PutResponseAsync(VerticalSection verticalSectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IVerticalSectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IVerticalSectionRequest Expand(Expression<Func<VerticalSection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IVerticalSectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IVerticalSectionRequest Select(Expression<Func<VerticalSection, object>> selectExpression);

    }
}
