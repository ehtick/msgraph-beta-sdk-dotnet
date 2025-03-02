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
    /// The interface IEducationRootRequest.
    /// </summary>
    public partial interface IEducationRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationRoot using POST.
        /// </summary>
        /// <param name="educationRootToCreate">The EducationRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationRoot.</returns>
        System.Threading.Tasks.Task<EducationRoot> CreateAsync(EducationRoot educationRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EducationRoot using POST and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="educationRootToCreate">The EducationRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationRoot>> CreateResponseAsync(EducationRoot educationRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationRoot.</returns>
        System.Threading.Tasks.Task<EducationRoot> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationRoot and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationRoot>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationRoot using PATCH.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationRoot.</returns>
        System.Threading.Tasks.Task<EducationRoot> UpdateAsync(EducationRoot educationRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationRoot using PATCH and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationRoot>> UpdateResponseAsync(EducationRoot educationRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationRoot using PUT.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationRoot> PutAsync(EducationRoot educationRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationRoot using PUT and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationRoot}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationRoot>> PutResponseAsync(EducationRoot educationRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationRootRequest Expand(Expression<Func<EducationRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationRootRequest Select(Expression<Func<EducationRoot, object>> selectExpression);

    }
}
