// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AuthorizationPolicyRequest.
    /// </summary>
    public partial class AuthorizationPolicyRequest : BaseRequest, IAuthorizationPolicyRequest
    {
        /// <summary>
        /// Constructs a new AuthorizationPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AuthorizationPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AuthorizationPolicy using POST.
        /// </summary>
        /// <param name="authorizationPolicyToCreate">The AuthorizationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthorizationPolicy.</returns>
        public async System.Threading.Tasks.Task<AuthorizationPolicy> CreateAsync(AuthorizationPolicy authorizationPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AuthorizationPolicy>(authorizationPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AuthorizationPolicy using POST and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="authorizationPolicyToCreate">The AuthorizationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthorizationPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> CreateResponseAsync(AuthorizationPolicy authorizationPolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AuthorizationPolicy>(authorizationPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AuthorizationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AuthorizationPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AuthorizationPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AuthorizationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthorizationPolicy.</returns>
        public async System.Threading.Tasks.Task<AuthorizationPolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AuthorizationPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AuthorizationPolicy and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthorizationPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AuthorizationPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PATCH.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthorizationPolicy.</returns>
        public async System.Threading.Tasks.Task<AuthorizationPolicy> UpdateAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AuthorizationPolicy>(authorizationPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PATCH and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuthorizationPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> UpdateResponseAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AuthorizationPolicy>(authorizationPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PUT.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AuthorizationPolicy> PutAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AuthorizationPolicy>(authorizationPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AuthorizationPolicy using PUT and returns a <see cref="GraphResponse{AuthorizationPolicy}"/> object.
        /// </summary>
        /// <param name="authorizationPolicyToUpdate">The AuthorizationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AuthorizationPolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthorizationPolicy>> PutResponseAsync(AuthorizationPolicy authorizationPolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AuthorizationPolicy>(authorizationPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthorizationPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthorizationPolicyRequest Expand(Expression<Func<AuthorizationPolicy, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthorizationPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthorizationPolicyRequest Select(Expression<Func<AuthorizationPolicy, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="authorizationPolicyToInitialize">The <see cref="AuthorizationPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AuthorizationPolicy authorizationPolicyToInitialize)
        {

            if (authorizationPolicyToInitialize != null)
            {
                if (authorizationPolicyToInitialize.DefaultUserRoleOverrides != null && authorizationPolicyToInitialize.DefaultUserRoleOverrides.CurrentPage != null)
                {
                    authorizationPolicyToInitialize.DefaultUserRoleOverrides.InitializeNextPageRequest(this.Client, authorizationPolicyToInitialize.DefaultUserRoleOverridesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    authorizationPolicyToInitialize.DefaultUserRoleOverrides.AdditionalData = authorizationPolicyToInitialize.AdditionalData;
                }

            }


        }
    }
}
