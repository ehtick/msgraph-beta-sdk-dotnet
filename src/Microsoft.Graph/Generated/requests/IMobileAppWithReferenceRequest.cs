// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IMobileAppWithReferenceRequest.
    /// </summary>
    public partial interface IMobileAppWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified MobileApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileApp.</returns>
        System.Threading.Tasks.Task<MobileApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MobileApp and returns a <see cref="GraphResponse{MobileApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileApp>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified MobileApp using POST.
        /// </summary>
        /// <param name="mobileAppToCreate">The MobileApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileApp.</returns>
        System.Threading.Tasks.Task<MobileApp> CreateAsync(MobileApp mobileAppToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified MobileApp using POST and returns a <see cref="GraphResponse{MobileApp}"/> object.
        /// </summary>
        /// <param name="mobileAppToCreate">The MobileApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileApp>> CreateResponseAsync(MobileApp mobileAppToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified MobileApp using PATCH.
        /// </summary>
        /// <param name="mobileAppToUpdate">The MobileApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileApp.</returns>
        System.Threading.Tasks.Task<MobileApp> UpdateAsync(MobileApp mobileAppToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified MobileApp using PATCH and returns a <see cref="GraphResponse{MobileApp}"/> object.
        /// </summary>
        /// <param name="mobileAppToUpdate">The MobileApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileApp>> UpdateResponseAsync(MobileApp mobileAppToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified MobileApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified MobileApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppWithReferenceRequest Expand(Expression<Func<MobileApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppWithReferenceRequest Select(Expression<Func<MobileApp, object>> selectExpression);

    }
}
