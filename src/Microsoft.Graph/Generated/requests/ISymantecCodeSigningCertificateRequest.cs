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
    /// The interface ISymantecCodeSigningCertificateRequest.
    /// </summary>
    public partial interface ISymantecCodeSigningCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SymantecCodeSigningCertificate using POST.
        /// </summary>
        /// <param name="symantecCodeSigningCertificateToCreate">The SymantecCodeSigningCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SymantecCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<SymantecCodeSigningCertificate> CreateAsync(SymantecCodeSigningCertificate symantecCodeSigningCertificateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SymantecCodeSigningCertificate using POST and returns a <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="symantecCodeSigningCertificateToCreate">The SymantecCodeSigningCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SymantecCodeSigningCertificate>> CreateResponseAsync(SymantecCodeSigningCertificate symantecCodeSigningCertificateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SymantecCodeSigningCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SymantecCodeSigningCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SymantecCodeSigningCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SymantecCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<SymantecCodeSigningCertificate> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SymantecCodeSigningCertificate and returns a <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SymantecCodeSigningCertificate>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SymantecCodeSigningCertificate using PATCH.
        /// </summary>
        /// <param name="symantecCodeSigningCertificateToUpdate">The SymantecCodeSigningCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SymantecCodeSigningCertificate.</returns>
        System.Threading.Tasks.Task<SymantecCodeSigningCertificate> UpdateAsync(SymantecCodeSigningCertificate symantecCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SymantecCodeSigningCertificate using PATCH and returns a <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="symantecCodeSigningCertificateToUpdate">The SymantecCodeSigningCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SymantecCodeSigningCertificate>> UpdateResponseAsync(SymantecCodeSigningCertificate symantecCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SymantecCodeSigningCertificate using PUT.
        /// </summary>
        /// <param name="symantecCodeSigningCertificateToUpdate">The SymantecCodeSigningCertificate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SymantecCodeSigningCertificate> PutAsync(SymantecCodeSigningCertificate symantecCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SymantecCodeSigningCertificate using PUT and returns a <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> object.
        /// </summary>
        /// <param name="symantecCodeSigningCertificateToUpdate">The SymantecCodeSigningCertificate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SymantecCodeSigningCertificate}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SymantecCodeSigningCertificate>> PutResponseAsync(SymantecCodeSigningCertificate symantecCodeSigningCertificateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISymantecCodeSigningCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISymantecCodeSigningCertificateRequest Expand(Expression<Func<SymantecCodeSigningCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISymantecCodeSigningCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISymantecCodeSigningCertificateRequest Select(Expression<Func<SymantecCodeSigningCertificate, object>> selectExpression);

    }
}
