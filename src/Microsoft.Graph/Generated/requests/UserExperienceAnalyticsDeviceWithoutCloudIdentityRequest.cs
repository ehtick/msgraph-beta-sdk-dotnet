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
    /// The type UserExperienceAnalyticsDeviceWithoutCloudIdentityRequest.
    /// </summary>
    public partial class UserExperienceAnalyticsDeviceWithoutCloudIdentityRequest : BaseRequest, IUserExperienceAnalyticsDeviceWithoutCloudIdentityRequest
    {
        /// <summary>
        /// Constructs a new UserExperienceAnalyticsDeviceWithoutCloudIdentityRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserExperienceAnalyticsDeviceWithoutCloudIdentityRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceWithoutCloudIdentityToCreate">The UserExperienceAnalyticsDeviceWithoutCloudIdentity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsDeviceWithoutCloudIdentity.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceWithoutCloudIdentity> CreateAsync(UserExperienceAnalyticsDeviceWithoutCloudIdentity userExperienceAnalyticsDeviceWithoutCloudIdentityToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(userExperienceAnalyticsDeviceWithoutCloudIdentityToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceWithoutCloudIdentityToCreate">The UserExperienceAnalyticsDeviceWithoutCloudIdentity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>> CreateResponseAsync(UserExperienceAnalyticsDeviceWithoutCloudIdentity userExperienceAnalyticsDeviceWithoutCloudIdentityToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(userExperienceAnalyticsDeviceWithoutCloudIdentityToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsDeviceWithoutCloudIdentity.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceWithoutCloudIdentity> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate">The UserExperienceAnalyticsDeviceWithoutCloudIdentity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsDeviceWithoutCloudIdentity.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceWithoutCloudIdentity> UpdateAsync(UserExperienceAnalyticsDeviceWithoutCloudIdentity userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate">The UserExperienceAnalyticsDeviceWithoutCloudIdentity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>> UpdateResponseAsync(UserExperienceAnalyticsDeviceWithoutCloudIdentity userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate">The UserExperienceAnalyticsDeviceWithoutCloudIdentity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceWithoutCloudIdentity> PutAsync(UserExperienceAnalyticsDeviceWithoutCloudIdentity userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceWithoutCloudIdentity using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate">The UserExperienceAnalyticsDeviceWithoutCloudIdentity object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UserExperienceAnalyticsDeviceWithoutCloudIdentity}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>> PutResponseAsync(UserExperienceAnalyticsDeviceWithoutCloudIdentity userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceWithoutCloudIdentity>(userExperienceAnalyticsDeviceWithoutCloudIdentityToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsDeviceWithoutCloudIdentityRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsDeviceWithoutCloudIdentityRequest Expand(Expression<Func<UserExperienceAnalyticsDeviceWithoutCloudIdentity, object>> expandExpression)
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
        public IUserExperienceAnalyticsDeviceWithoutCloudIdentityRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsDeviceWithoutCloudIdentityRequest Select(Expression<Func<UserExperienceAnalyticsDeviceWithoutCloudIdentity, object>> selectExpression)
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
        /// <param name="userExperienceAnalyticsDeviceWithoutCloudIdentityToInitialize">The <see cref="UserExperienceAnalyticsDeviceWithoutCloudIdentity"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserExperienceAnalyticsDeviceWithoutCloudIdentity userExperienceAnalyticsDeviceWithoutCloudIdentityToInitialize)
        {

        }
    }
}
