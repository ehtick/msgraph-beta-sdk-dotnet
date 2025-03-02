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
    /// The type AccessReviewRequest.
    /// </summary>
    public partial class AccessReviewRequest : BaseRequest, IAccessReviewRequest
    {
        /// <summary>
        /// Constructs a new AccessReviewRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessReviewRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessReview using POST.
        /// </summary>
        /// <param name="accessReviewToCreate">The AccessReview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReview.</returns>
        public async System.Threading.Tasks.Task<AccessReview> CreateAsync(AccessReview accessReviewToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AccessReview>(accessReviewToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AccessReview using POST and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <param name="accessReviewToCreate">The AccessReview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReview}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReview>> CreateResponseAsync(AccessReview accessReviewToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AccessReview>(accessReviewToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AccessReview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AccessReview>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessReview and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AccessReview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReview.</returns>
        public async System.Threading.Tasks.Task<AccessReview> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AccessReview>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessReview and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReview}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReview>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AccessReview>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessReview using PATCH.
        /// </summary>
        /// <param name="accessReviewToUpdate">The AccessReview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReview.</returns>
        public async System.Threading.Tasks.Task<AccessReview> UpdateAsync(AccessReview accessReviewToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AccessReview>(accessReviewToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessReview using PATCH and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <param name="accessReviewToUpdate">The AccessReview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessReview}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReview>> UpdateResponseAsync(AccessReview accessReviewToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AccessReview>(accessReviewToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessReview using PUT.
        /// </summary>
        /// <param name="accessReviewToUpdate">The AccessReview object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AccessReview> PutAsync(AccessReview accessReviewToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AccessReview>(accessReviewToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessReview using PUT and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <param name="accessReviewToUpdate">The AccessReview object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AccessReview}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessReview>> PutResponseAsync(AccessReview accessReviewToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AccessReview>(accessReviewToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewRequest Expand(Expression<Func<AccessReview, object>> expandExpression)
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
        public IAccessReviewRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessReviewRequest Select(Expression<Func<AccessReview, object>> selectExpression)
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
        /// <param name="accessReviewToInitialize">The <see cref="AccessReview"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessReview accessReviewToInitialize)
        {

            if (accessReviewToInitialize != null)
            {
                if (accessReviewToInitialize.Decisions != null && accessReviewToInitialize.Decisions.CurrentPage != null)
                {
                    accessReviewToInitialize.Decisions.InitializeNextPageRequest(this.Client, accessReviewToInitialize.DecisionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessReviewToInitialize.Decisions.AdditionalData = accessReviewToInitialize.AdditionalData;
                }
                if (accessReviewToInitialize.Instances != null && accessReviewToInitialize.Instances.CurrentPage != null)
                {
                    accessReviewToInitialize.Instances.InitializeNextPageRequest(this.Client, accessReviewToInitialize.InstancesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessReviewToInitialize.Instances.AdditionalData = accessReviewToInitialize.AdditionalData;
                }
                if (accessReviewToInitialize.MyDecisions != null && accessReviewToInitialize.MyDecisions.CurrentPage != null)
                {
                    accessReviewToInitialize.MyDecisions.InitializeNextPageRequest(this.Client, accessReviewToInitialize.MyDecisionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessReviewToInitialize.MyDecisions.AdditionalData = accessReviewToInitialize.AdditionalData;
                }
                if (accessReviewToInitialize.Reviewers != null && accessReviewToInitialize.Reviewers.CurrentPage != null)
                {
                    accessReviewToInitialize.Reviewers.InitializeNextPageRequest(this.Client, accessReviewToInitialize.ReviewersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessReviewToInitialize.Reviewers.AdditionalData = accessReviewToInitialize.AdditionalData;
                }

            }


        }
    }
}
