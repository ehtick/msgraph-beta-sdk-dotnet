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
    /// The type UserExperienceAnalyticsBatteryHealthAppImpactRequest.
    /// </summary>
    public partial class UserExperienceAnalyticsBatteryHealthAppImpactRequest : BaseRequest, IUserExperienceAnalyticsBatteryHealthAppImpactRequest
    {
        /// <summary>
        /// Constructs a new UserExperienceAnalyticsBatteryHealthAppImpactRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserExperienceAnalyticsBatteryHealthAppImpactRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsBatteryHealthAppImpact using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsBatteryHealthAppImpactToCreate">The UserExperienceAnalyticsBatteryHealthAppImpact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsBatteryHealthAppImpact.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsBatteryHealthAppImpact> CreateAsync(UserExperienceAnalyticsBatteryHealthAppImpact userExperienceAnalyticsBatteryHealthAppImpactToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UserExperienceAnalyticsBatteryHealthAppImpact>(userExperienceAnalyticsBatteryHealthAppImpactToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsBatteryHealthAppImpact using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsBatteryHealthAppImpactToCreate">The UserExperienceAnalyticsBatteryHealthAppImpact to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>> CreateResponseAsync(UserExperienceAnalyticsBatteryHealthAppImpact userExperienceAnalyticsBatteryHealthAppImpactToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>(userExperienceAnalyticsBatteryHealthAppImpactToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsBatteryHealthAppImpact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UserExperienceAnalyticsBatteryHealthAppImpact>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsBatteryHealthAppImpact and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsBatteryHealthAppImpact.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsBatteryHealthAppImpact.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsBatteryHealthAppImpact> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UserExperienceAnalyticsBatteryHealthAppImpact>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsBatteryHealthAppImpact and returns a <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBatteryHealthAppImpact using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsBatteryHealthAppImpactToUpdate">The UserExperienceAnalyticsBatteryHealthAppImpact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsBatteryHealthAppImpact.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsBatteryHealthAppImpact> UpdateAsync(UserExperienceAnalyticsBatteryHealthAppImpact userExperienceAnalyticsBatteryHealthAppImpactToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsBatteryHealthAppImpact>(userExperienceAnalyticsBatteryHealthAppImpactToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBatteryHealthAppImpact using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsBatteryHealthAppImpactToUpdate">The UserExperienceAnalyticsBatteryHealthAppImpact to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>> UpdateResponseAsync(UserExperienceAnalyticsBatteryHealthAppImpact userExperienceAnalyticsBatteryHealthAppImpactToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>(userExperienceAnalyticsBatteryHealthAppImpactToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBatteryHealthAppImpact using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsBatteryHealthAppImpactToUpdate">The UserExperienceAnalyticsBatteryHealthAppImpact object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsBatteryHealthAppImpact> PutAsync(UserExperienceAnalyticsBatteryHealthAppImpact userExperienceAnalyticsBatteryHealthAppImpactToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsBatteryHealthAppImpact>(userExperienceAnalyticsBatteryHealthAppImpactToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBatteryHealthAppImpact using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsBatteryHealthAppImpactToUpdate">The UserExperienceAnalyticsBatteryHealthAppImpact object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UserExperienceAnalyticsBatteryHealthAppImpact}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>> PutResponseAsync(UserExperienceAnalyticsBatteryHealthAppImpact userExperienceAnalyticsBatteryHealthAppImpactToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsBatteryHealthAppImpact>(userExperienceAnalyticsBatteryHealthAppImpactToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsBatteryHealthAppImpactRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsBatteryHealthAppImpactRequest Expand(Expression<Func<UserExperienceAnalyticsBatteryHealthAppImpact, object>> expandExpression)
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
        public IUserExperienceAnalyticsBatteryHealthAppImpactRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsBatteryHealthAppImpactRequest Select(Expression<Func<UserExperienceAnalyticsBatteryHealthAppImpact, object>> selectExpression)
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
        /// <param name="userExperienceAnalyticsBatteryHealthAppImpactToInitialize">The <see cref="UserExperienceAnalyticsBatteryHealthAppImpact"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserExperienceAnalyticsBatteryHealthAppImpact userExperienceAnalyticsBatteryHealthAppImpactToInitialize)
        {

        }
    }
}
