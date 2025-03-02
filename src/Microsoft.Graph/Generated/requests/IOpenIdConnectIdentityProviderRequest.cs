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
    /// The interface IOpenIdConnectIdentityProviderRequest.
    /// </summary>
    public partial interface IOpenIdConnectIdentityProviderRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OpenIdConnectIdentityProvider using POST.
        /// </summary>
        /// <param name="openIdConnectIdentityProviderToCreate">The OpenIdConnectIdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OpenIdConnectIdentityProvider.</returns>
        System.Threading.Tasks.Task<OpenIdConnectIdentityProvider> CreateAsync(OpenIdConnectIdentityProvider openIdConnectIdentityProviderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified OpenIdConnectIdentityProvider using POST and returns a <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> object.
        /// </summary>
        /// <param name="openIdConnectIdentityProviderToCreate">The OpenIdConnectIdentityProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenIdConnectIdentityProvider>> CreateResponseAsync(OpenIdConnectIdentityProvider openIdConnectIdentityProviderToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OpenIdConnectIdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified OpenIdConnectIdentityProvider and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OpenIdConnectIdentityProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OpenIdConnectIdentityProvider.</returns>
        System.Threading.Tasks.Task<OpenIdConnectIdentityProvider> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified OpenIdConnectIdentityProvider and returns a <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenIdConnectIdentityProvider>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenIdConnectIdentityProvider using PATCH.
        /// </summary>
        /// <param name="openIdConnectIdentityProviderToUpdate">The OpenIdConnectIdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OpenIdConnectIdentityProvider.</returns>
        System.Threading.Tasks.Task<OpenIdConnectIdentityProvider> UpdateAsync(OpenIdConnectIdentityProvider openIdConnectIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenIdConnectIdentityProvider using PATCH and returns a <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> object.
        /// </summary>
        /// <param name="openIdConnectIdentityProviderToUpdate">The OpenIdConnectIdentityProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenIdConnectIdentityProvider>> UpdateResponseAsync(OpenIdConnectIdentityProvider openIdConnectIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenIdConnectIdentityProvider using PUT.
        /// </summary>
        /// <param name="openIdConnectIdentityProviderToUpdate">The OpenIdConnectIdentityProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<OpenIdConnectIdentityProvider> PutAsync(OpenIdConnectIdentityProvider openIdConnectIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified OpenIdConnectIdentityProvider using PUT and returns a <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> object.
        /// </summary>
        /// <param name="openIdConnectIdentityProviderToUpdate">The OpenIdConnectIdentityProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{OpenIdConnectIdentityProvider}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<OpenIdConnectIdentityProvider>> PutResponseAsync(OpenIdConnectIdentityProvider openIdConnectIdentityProviderToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOpenIdConnectIdentityProviderRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOpenIdConnectIdentityProviderRequest Expand(Expression<Func<OpenIdConnectIdentityProvider, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOpenIdConnectIdentityProviderRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOpenIdConnectIdentityProviderRequest Select(Expression<Func<OpenIdConnectIdentityProvider, object>> selectExpression);

    }
}
