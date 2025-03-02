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
    /// The type AccessReviewInstanceDecisionItemRequest.
    /// </summary>
    public partial class AccessReviewInstanceDecisionItemRequest : BaseRequest, IAccessReviewInstanceDecisionItemRequest
    {
        /// <summary>
        /// Constructs a new AccessReviewInstanceDecisionItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessReviewInstanceDecisionItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessReviewInstanceDecisionItem using POST.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItemToCreate">The AccessReviewInstanceDecisionItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewInstanceDecisionItem.</returns>
        public async System.Threading.Tasks.Task<AccessReviewInstanceDecisionItem> CreateAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AccessReviewInstanceDecisionItem>(accessReviewInstanceDecisionItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AccessReviewInstanceDecisionItem using POST and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItemToCreate">The AccessReviewInstanceDecisionItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionItem>> CreateResponseAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AccessReviewInstanceDecisionItem>(accessReviewInstanceDecisionItemToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AccessReviewInstanceDecisionItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AccessReviewInstanceDecisionItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessReviewInstanceDecisionItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AccessReviewInstanceDecisionItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReviewInstanceDecisionItem.</returns>
        public async System.Threading.Tasks.Task<AccessReviewInstanceDecisionItem> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AccessReviewInstanceDecisionItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessReviewInstanceDecisionItem and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionItem>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AccessReviewInstanceDecisionItem>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessReviewInstanceDecisionItem using PATCH.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItemToUpdate">The AccessReviewInstanceDecisionItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReviewInstanceDecisionItem.</returns>
        public async System.Threading.Tasks.Task<AccessReviewInstanceDecisionItem> UpdateAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AccessReviewInstanceDecisionItem>(accessReviewInstanceDecisionItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessReviewInstanceDecisionItem using PATCH and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItemToUpdate">The AccessReviewInstanceDecisionItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionItem>> UpdateResponseAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AccessReviewInstanceDecisionItem>(accessReviewInstanceDecisionItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessReviewInstanceDecisionItem using PUT.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItemToUpdate">The AccessReviewInstanceDecisionItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AccessReviewInstanceDecisionItem> PutAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AccessReviewInstanceDecisionItem>(accessReviewInstanceDecisionItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessReviewInstanceDecisionItem using PUT and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItemToUpdate">The AccessReviewInstanceDecisionItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionItem>> PutResponseAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AccessReviewInstanceDecisionItem>(accessReviewInstanceDecisionItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewInstanceDecisionItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewInstanceDecisionItemRequest Expand(Expression<Func<AccessReviewInstanceDecisionItem, object>> expandExpression)
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
        public IAccessReviewInstanceDecisionItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewInstanceDecisionItemRequest Select(Expression<Func<AccessReviewInstanceDecisionItem, object>> selectExpression)
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
        /// <param name="accessReviewInstanceDecisionItemToInitialize">The <see cref="AccessReviewInstanceDecisionItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItemToInitialize)
        {

            if (accessReviewInstanceDecisionItemToInitialize != null)
            {
                if (accessReviewInstanceDecisionItemToInitialize.Insights != null && accessReviewInstanceDecisionItemToInitialize.Insights.CurrentPage != null)
                {
                    accessReviewInstanceDecisionItemToInitialize.Insights.InitializeNextPageRequest(this.Client, accessReviewInstanceDecisionItemToInitialize.InsightsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessReviewInstanceDecisionItemToInitialize.Insights.AdditionalData = accessReviewInstanceDecisionItemToInitialize.AdditionalData;
                }

            }


        }
    }
}
