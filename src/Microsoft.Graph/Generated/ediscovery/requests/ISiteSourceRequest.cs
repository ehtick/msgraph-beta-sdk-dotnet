// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISiteSourceRequest.
    /// </summary>
    public partial interface ISiteSourceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified SiteSource using POST.
        /// </summary>
        /// <param name="siteSourceToCreate">The SiteSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SiteSource.</returns>
        System.Threading.Tasks.Task<SiteSource> CreateAsync(SiteSource siteSourceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SiteSource using POST and returns a <see cref="GraphResponse{SiteSource}"/> object.
        /// </summary>
        /// <param name="siteSourceToCreate">The SiteSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SiteSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteSource>> CreateResponseAsync(SiteSource siteSourceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SiteSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SiteSource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SiteSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SiteSource.</returns>
        System.Threading.Tasks.Task<SiteSource> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SiteSource and returns a <see cref="GraphResponse{SiteSource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SiteSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteSource>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SiteSource using PATCH.
        /// </summary>
        /// <param name="siteSourceToUpdate">The SiteSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SiteSource.</returns>
        System.Threading.Tasks.Task<SiteSource> UpdateAsync(SiteSource siteSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SiteSource using PATCH and returns a <see cref="GraphResponse{SiteSource}"/> object.
        /// </summary>
        /// <param name="siteSourceToUpdate">The SiteSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SiteSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteSource>> UpdateResponseAsync(SiteSource siteSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SiteSource using PUT.
        /// </summary>
        /// <param name="siteSourceToUpdate">The SiteSource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SiteSource> PutAsync(SiteSource siteSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SiteSource using PUT and returns a <see cref="GraphResponse{SiteSource}"/> object.
        /// </summary>
        /// <param name="siteSourceToUpdate">The SiteSource object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SiteSource}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteSource>> PutResponseAsync(SiteSource siteSourceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISiteSourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISiteSourceRequest Expand(Expression<Func<SiteSource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISiteSourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISiteSourceRequest Select(Expression<Func<SiteSource, object>> selectExpression);

    }
}
