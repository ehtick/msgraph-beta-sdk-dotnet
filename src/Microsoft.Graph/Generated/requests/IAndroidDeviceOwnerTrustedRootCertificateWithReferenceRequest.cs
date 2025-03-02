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
    /// The interface IAndroidDeviceOwnerTrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial interface IAndroidDeviceOwnerTrustedRootCertificateWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified AndroidDeviceOwnerTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerTrustedRootCertificate> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerTrustedRootCertificate and returns a <see cref="GraphResponse{AndroidDeviceOwnerTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerTrustedRootCertificate>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified AndroidDeviceOwnerTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerTrustedRootCertificateToCreate">The AndroidDeviceOwnerTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerTrustedRootCertificate> CreateAsync(AndroidDeviceOwnerTrustedRootCertificate androidDeviceOwnerTrustedRootCertificateToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified AndroidDeviceOwnerTrustedRootCertificate using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerTrustedRootCertificateToCreate">The AndroidDeviceOwnerTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerTrustedRootCertificate>> CreateResponseAsync(AndroidDeviceOwnerTrustedRootCertificate androidDeviceOwnerTrustedRootCertificateToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified AndroidDeviceOwnerTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerTrustedRootCertificateToUpdate">The AndroidDeviceOwnerTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerTrustedRootCertificate> UpdateAsync(AndroidDeviceOwnerTrustedRootCertificate androidDeviceOwnerTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified AndroidDeviceOwnerTrustedRootCertificate using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerTrustedRootCertificateToUpdate">The AndroidDeviceOwnerTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerTrustedRootCertificate>> UpdateResponseAsync(AndroidDeviceOwnerTrustedRootCertificate androidDeviceOwnerTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified AndroidDeviceOwnerTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified AndroidDeviceOwnerTrustedRootCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerTrustedRootCertificateWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerTrustedRootCertificateWithReferenceRequest Expand(Expression<Func<AndroidDeviceOwnerTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerTrustedRootCertificateWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerTrustedRootCertificateWithReferenceRequest Select(Expression<Func<AndroidDeviceOwnerTrustedRootCertificate, object>> selectExpression);

    }
}
