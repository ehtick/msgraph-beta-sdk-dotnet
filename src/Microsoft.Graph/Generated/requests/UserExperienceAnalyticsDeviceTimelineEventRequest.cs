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
    /// The type UserExperienceAnalyticsDeviceTimelineEventRequest.
    /// </summary>
    public partial class UserExperienceAnalyticsDeviceTimelineEventRequest : BaseRequest, IUserExperienceAnalyticsDeviceTimelineEventRequest
    {
        /// <summary>
        /// Constructs a new UserExperienceAnalyticsDeviceTimelineEventRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserExperienceAnalyticsDeviceTimelineEventRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceTimelineEvent using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceTimelineEventToCreate">The UserExperienceAnalyticsDeviceTimelineEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsDeviceTimelineEvent.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceTimelineEvent> CreateAsync(UserExperienceAnalyticsDeviceTimelineEvent userExperienceAnalyticsDeviceTimelineEventToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UserExperienceAnalyticsDeviceTimelineEvent>(userExperienceAnalyticsDeviceTimelineEventToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceTimelineEvent using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceTimelineEventToCreate">The UserExperienceAnalyticsDeviceTimelineEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>> CreateResponseAsync(UserExperienceAnalyticsDeviceTimelineEvent userExperienceAnalyticsDeviceTimelineEventToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>(userExperienceAnalyticsDeviceTimelineEventToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceTimelineEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UserExperienceAnalyticsDeviceTimelineEvent>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceTimelineEvent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceTimelineEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsDeviceTimelineEvent.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceTimelineEvent> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UserExperienceAnalyticsDeviceTimelineEvent>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceTimelineEvent and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceTimelineEvent using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceTimelineEventToUpdate">The UserExperienceAnalyticsDeviceTimelineEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsDeviceTimelineEvent.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceTimelineEvent> UpdateAsync(UserExperienceAnalyticsDeviceTimelineEvent userExperienceAnalyticsDeviceTimelineEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsDeviceTimelineEvent>(userExperienceAnalyticsDeviceTimelineEventToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceTimelineEvent using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceTimelineEventToUpdate">The UserExperienceAnalyticsDeviceTimelineEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>> UpdateResponseAsync(UserExperienceAnalyticsDeviceTimelineEvent userExperienceAnalyticsDeviceTimelineEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>(userExperienceAnalyticsDeviceTimelineEventToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceTimelineEvent using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceTimelineEventToUpdate">The UserExperienceAnalyticsDeviceTimelineEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceTimelineEvent> PutAsync(UserExperienceAnalyticsDeviceTimelineEvent userExperienceAnalyticsDeviceTimelineEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsDeviceTimelineEvent>(userExperienceAnalyticsDeviceTimelineEventToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceTimelineEvent using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceTimelineEventToUpdate">The UserExperienceAnalyticsDeviceTimelineEvent object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UserExperienceAnalyticsDeviceTimelineEvent}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>> PutResponseAsync(UserExperienceAnalyticsDeviceTimelineEvent userExperienceAnalyticsDeviceTimelineEventToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsDeviceTimelineEvent>(userExperienceAnalyticsDeviceTimelineEventToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsDeviceTimelineEventRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsDeviceTimelineEventRequest Expand(Expression<Func<UserExperienceAnalyticsDeviceTimelineEvent, object>> expandExpression)
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
        public IUserExperienceAnalyticsDeviceTimelineEventRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsDeviceTimelineEventRequest Select(Expression<Func<UserExperienceAnalyticsDeviceTimelineEvent, object>> selectExpression)
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
        /// <param name="userExperienceAnalyticsDeviceTimelineEventToInitialize">The <see cref="UserExperienceAnalyticsDeviceTimelineEvent"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserExperienceAnalyticsDeviceTimelineEvent userExperienceAnalyticsDeviceTimelineEventToInitialize)
        {

        }
    }
}
