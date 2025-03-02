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
    /// The interface IMacOSCertificateProfileBaseWithReferenceRequest.
    /// </summary>
    public partial interface IMacOSCertificateProfileBaseWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified MacOSCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<MacOSCertificateProfileBase> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MacOSCertificateProfileBase and returns a <see cref="GraphResponse{MacOSCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCertificateProfileBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCertificateProfileBase>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified MacOSCertificateProfileBase using POST.
        /// </summary>
        /// <param name="macOSCertificateProfileBaseToCreate">The MacOSCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<MacOSCertificateProfileBase> CreateAsync(MacOSCertificateProfileBase macOSCertificateProfileBaseToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified MacOSCertificateProfileBase using POST and returns a <see cref="GraphResponse{MacOSCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="macOSCertificateProfileBaseToCreate">The MacOSCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSCertificateProfileBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCertificateProfileBase>> CreateResponseAsync(MacOSCertificateProfileBase macOSCertificateProfileBaseToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified MacOSCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="macOSCertificateProfileBaseToUpdate">The MacOSCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<MacOSCertificateProfileBase> UpdateAsync(MacOSCertificateProfileBase macOSCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified MacOSCertificateProfileBase using PATCH and returns a <see cref="GraphResponse{MacOSCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="macOSCertificateProfileBaseToUpdate">The MacOSCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSCertificateProfileBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSCertificateProfileBase>> UpdateResponseAsync(MacOSCertificateProfileBase macOSCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified MacOSCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified MacOSCertificateProfileBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCertificateProfileBaseWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCertificateProfileBaseWithReferenceRequest Expand(Expression<Func<MacOSCertificateProfileBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCertificateProfileBaseWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCertificateProfileBaseWithReferenceRequest Select(Expression<Func<MacOSCertificateProfileBase, object>> selectExpression);

    }
}
