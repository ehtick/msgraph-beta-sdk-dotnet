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
    /// The type LearningProviderRequest.
    /// </summary>
    public partial class LearningProviderRequest : BaseRequest, ILearningProviderRequest
    {
        /// <summary>
        /// Constructs a new LearningProviderRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public LearningProviderRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified LearningProvider using POST.
        /// </summary>
        /// <param name="learningProviderToCreate">The LearningProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LearningProvider.</returns>
        public async System.Threading.Tasks.Task<LearningProvider> CreateAsync(LearningProvider learningProviderToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<LearningProvider>(learningProviderToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified LearningProvider using POST and returns a <see cref="GraphResponse{LearningProvider}"/> object.
        /// </summary>
        /// <param name="learningProviderToCreate">The LearningProvider to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LearningProvider}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LearningProvider>> CreateResponseAsync(LearningProvider learningProviderToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<LearningProvider>(learningProviderToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified LearningProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<LearningProvider>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified LearningProvider and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified LearningProvider.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LearningProvider.</returns>
        public async System.Threading.Tasks.Task<LearningProvider> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<LearningProvider>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified LearningProvider and returns a <see cref="GraphResponse{LearningProvider}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LearningProvider}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LearningProvider>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<LearningProvider>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified LearningProvider using PATCH.
        /// </summary>
        /// <param name="learningProviderToUpdate">The LearningProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LearningProvider.</returns>
        public async System.Threading.Tasks.Task<LearningProvider> UpdateAsync(LearningProvider learningProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<LearningProvider>(learningProviderToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified LearningProvider using PATCH and returns a <see cref="GraphResponse{LearningProvider}"/> object.
        /// </summary>
        /// <param name="learningProviderToUpdate">The LearningProvider to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{LearningProvider}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LearningProvider>> UpdateResponseAsync(LearningProvider learningProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<LearningProvider>(learningProviderToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified LearningProvider using PUT.
        /// </summary>
        /// <param name="learningProviderToUpdate">The LearningProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<LearningProvider> PutAsync(LearningProvider learningProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<LearningProvider>(learningProviderToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified LearningProvider using PUT and returns a <see cref="GraphResponse{LearningProvider}"/> object.
        /// </summary>
        /// <param name="learningProviderToUpdate">The LearningProvider object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{LearningProvider}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LearningProvider>> PutResponseAsync(LearningProvider learningProviderToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<LearningProvider>(learningProviderToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILearningProviderRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILearningProviderRequest Expand(Expression<Func<LearningProvider, object>> expandExpression)
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
        public ILearningProviderRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ILearningProviderRequest Select(Expression<Func<LearningProvider, object>> selectExpression)
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
        /// <param name="learningProviderToInitialize">The <see cref="LearningProvider"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(LearningProvider learningProviderToInitialize)
        {

            if (learningProviderToInitialize != null)
            {
                if (learningProviderToInitialize.LearningContents != null && learningProviderToInitialize.LearningContents.CurrentPage != null)
                {
                    learningProviderToInitialize.LearningContents.InitializeNextPageRequest(this.Client, learningProviderToInitialize.LearningContentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    learningProviderToInitialize.LearningContents.AdditionalData = learningProviderToInitialize.AdditionalData;
                }

            }


        }
    }
}
