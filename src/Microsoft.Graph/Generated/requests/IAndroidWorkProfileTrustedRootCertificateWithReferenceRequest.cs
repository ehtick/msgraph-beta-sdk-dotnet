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
    /// The interface IAndroidWorkProfileTrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileTrustedRootCertificateWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified AndroidWorkProfileTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidWorkProfileTrustedRootCertificate and returns a <see cref="GraphResponse{AndroidWorkProfileTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileTrustedRootCertificate>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified AndroidWorkProfileTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToCreate">The AndroidWorkProfileTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> CreateAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified AndroidWorkProfileTrustedRootCertificate using POST and returns a <see cref="GraphResponse{AndroidWorkProfileTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToCreate">The AndroidWorkProfileTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileTrustedRootCertificate>> CreateResponseAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified AndroidWorkProfileTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToUpdate">The AndroidWorkProfileTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfileTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileTrustedRootCertificate> UpdateAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified AndroidWorkProfileTrustedRootCertificate using PATCH and returns a <see cref="GraphResponse{AndroidWorkProfileTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileTrustedRootCertificateToUpdate">The AndroidWorkProfileTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileTrustedRootCertificate>> UpdateResponseAsync(AndroidWorkProfileTrustedRootCertificate androidWorkProfileTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified AndroidWorkProfileTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified AndroidWorkProfileTrustedRootCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateWithReferenceRequest Expand(Expression<Func<AndroidWorkProfileTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileTrustedRootCertificateWithReferenceRequest Select(Expression<Func<AndroidWorkProfileTrustedRootCertificate, object>> selectExpression);

    }
}
