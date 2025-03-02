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
    /// The interface IProfileCardPropertyRequest.
    /// </summary>
    public partial interface IProfileCardPropertyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ProfileCardProperty using POST.
        /// </summary>
        /// <param name="profileCardPropertyToCreate">The ProfileCardProperty to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ProfileCardProperty.</returns>
        System.Threading.Tasks.Task<ProfileCardProperty> CreateAsync(ProfileCardProperty profileCardPropertyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ProfileCardProperty using POST and returns a <see cref="GraphResponse{ProfileCardProperty}"/> object.
        /// </summary>
        /// <param name="profileCardPropertyToCreate">The ProfileCardProperty to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ProfileCardProperty}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfileCardProperty>> CreateResponseAsync(ProfileCardProperty profileCardPropertyToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ProfileCardProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ProfileCardProperty and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ProfileCardProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ProfileCardProperty.</returns>
        System.Threading.Tasks.Task<ProfileCardProperty> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ProfileCardProperty and returns a <see cref="GraphResponse{ProfileCardProperty}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ProfileCardProperty}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfileCardProperty>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ProfileCardProperty using PATCH.
        /// </summary>
        /// <param name="profileCardPropertyToUpdate">The ProfileCardProperty to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ProfileCardProperty.</returns>
        System.Threading.Tasks.Task<ProfileCardProperty> UpdateAsync(ProfileCardProperty profileCardPropertyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ProfileCardProperty using PATCH and returns a <see cref="GraphResponse{ProfileCardProperty}"/> object.
        /// </summary>
        /// <param name="profileCardPropertyToUpdate">The ProfileCardProperty to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ProfileCardProperty}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfileCardProperty>> UpdateResponseAsync(ProfileCardProperty profileCardPropertyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ProfileCardProperty using PUT.
        /// </summary>
        /// <param name="profileCardPropertyToUpdate">The ProfileCardProperty object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ProfileCardProperty> PutAsync(ProfileCardProperty profileCardPropertyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ProfileCardProperty using PUT and returns a <see cref="GraphResponse{ProfileCardProperty}"/> object.
        /// </summary>
        /// <param name="profileCardPropertyToUpdate">The ProfileCardProperty object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ProfileCardProperty}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ProfileCardProperty>> PutResponseAsync(ProfileCardProperty profileCardPropertyToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IProfileCardPropertyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IProfileCardPropertyRequest Expand(Expression<Func<ProfileCardProperty, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IProfileCardPropertyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IProfileCardPropertyRequest Select(Expression<Func<ProfileCardProperty, object>> selectExpression);

    }
}
