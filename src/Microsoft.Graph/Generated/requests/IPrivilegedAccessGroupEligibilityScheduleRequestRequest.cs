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
    /// The interface IPrivilegedAccessGroupEligibilityScheduleRequestRequest.
    /// </summary>
    public partial interface IPrivilegedAccessGroupEligibilityScheduleRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrivilegedAccessGroupEligibilityScheduleRequestObject using POST.
        /// </summary>
        /// <param name="privilegedAccessGroupEligibilityScheduleRequestObjectToCreate">The PrivilegedAccessGroupEligibilityScheduleRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedAccessGroupEligibilityScheduleRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedAccessGroupEligibilityScheduleRequestObject> CreateAsync(PrivilegedAccessGroupEligibilityScheduleRequestObject privilegedAccessGroupEligibilityScheduleRequestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified PrivilegedAccessGroupEligibilityScheduleRequestObject using POST and returns a <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="privilegedAccessGroupEligibilityScheduleRequestObjectToCreate">The PrivilegedAccessGroupEligibilityScheduleRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedAccessGroupEligibilityScheduleRequestObject>> CreateResponseAsync(PrivilegedAccessGroupEligibilityScheduleRequestObject privilegedAccessGroupEligibilityScheduleRequestObjectToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrivilegedAccessGroupEligibilityScheduleRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PrivilegedAccessGroupEligibilityScheduleRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrivilegedAccessGroupEligibilityScheduleRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedAccessGroupEligibilityScheduleRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedAccessGroupEligibilityScheduleRequestObject> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PrivilegedAccessGroupEligibilityScheduleRequestObject and returns a <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedAccessGroupEligibilityScheduleRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrivilegedAccessGroupEligibilityScheduleRequestObject using PATCH.
        /// </summary>
        /// <param name="privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate">The PrivilegedAccessGroupEligibilityScheduleRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrivilegedAccessGroupEligibilityScheduleRequestObject.</returns>
        System.Threading.Tasks.Task<PrivilegedAccessGroupEligibilityScheduleRequestObject> UpdateAsync(PrivilegedAccessGroupEligibilityScheduleRequestObject privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrivilegedAccessGroupEligibilityScheduleRequestObject using PATCH and returns a <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate">The PrivilegedAccessGroupEligibilityScheduleRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedAccessGroupEligibilityScheduleRequestObject>> UpdateResponseAsync(PrivilegedAccessGroupEligibilityScheduleRequestObject privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrivilegedAccessGroupEligibilityScheduleRequestObject using PUT.
        /// </summary>
        /// <param name="privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate">The PrivilegedAccessGroupEligibilityScheduleRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PrivilegedAccessGroupEligibilityScheduleRequestObject> PutAsync(PrivilegedAccessGroupEligibilityScheduleRequestObject privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PrivilegedAccessGroupEligibilityScheduleRequestObject using PUT and returns a <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> object.
        /// </summary>
        /// <param name="privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate">The PrivilegedAccessGroupEligibilityScheduleRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PrivilegedAccessGroupEligibilityScheduleRequestObject}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedAccessGroupEligibilityScheduleRequestObject>> PutResponseAsync(PrivilegedAccessGroupEligibilityScheduleRequestObject privilegedAccessGroupEligibilityScheduleRequestObjectToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedAccessGroupEligibilityScheduleRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedAccessGroupEligibilityScheduleRequestRequest Expand(Expression<Func<PrivilegedAccessGroupEligibilityScheduleRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedAccessGroupEligibilityScheduleRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedAccessGroupEligibilityScheduleRequestRequest Select(Expression<Func<PrivilegedAccessGroupEligibilityScheduleRequestObject, object>> selectExpression);

    }
}
