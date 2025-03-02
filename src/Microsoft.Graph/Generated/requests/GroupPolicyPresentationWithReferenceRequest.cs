// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type GroupPolicyPresentationWithReferenceRequest.
    /// </summary>
    public partial class GroupPolicyPresentationWithReferenceRequest : BaseRequest, IGroupPolicyPresentationWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyPresentationWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyPresentationWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentation.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentation> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyPresentation>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentation and returns a <see cref="GraphResponse{GroupPolicyPresentation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentation>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentation>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified GroupPolicyPresentation using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationToCreate">The GroupPolicyPresentation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentation.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentation> CreateAsync(GroupPolicyPresentation groupPolicyPresentationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyPresentation>(groupPolicyPresentationToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified GroupPolicyPresentation using POST and returns a <see cref="GraphResponse{GroupPolicyPresentation}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationToCreate">The GroupPolicyPresentation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentation>> CreateResponseAsync(GroupPolicyPresentation groupPolicyPresentationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentation>(groupPolicyPresentationToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified GroupPolicyPresentation using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationToUpdate">The GroupPolicyPresentation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentation.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentation> UpdateAsync(GroupPolicyPresentation groupPolicyPresentationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyPresentation>(groupPolicyPresentationToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified GroupPolicyPresentation using PATCH and returns a <see cref="GraphResponse{GroupPolicyPresentation}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationToUpdate">The GroupPolicyPresentation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentation>> UpdateResponseAsync(GroupPolicyPresentation groupPolicyPresentationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentation>(groupPolicyPresentationToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified GroupPolicyPresentation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyPresentation>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified GroupPolicyPresentation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationWithReferenceRequest Expand(Expression<Func<GroupPolicyPresentation, object>> expandExpression)
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
        public IGroupPolicyPresentationWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationWithReferenceRequest Select(Expression<Func<GroupPolicyPresentation, object>> selectExpression)
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

    }
}
