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
    /// The type GroupPolicyDefinitionRequest.
    /// </summary>
    public partial class GroupPolicyDefinitionRequest : BaseRequest, IGroupPolicyDefinitionRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyDefinitionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyDefinitionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyDefinition using POST.
        /// </summary>
        /// <param name="groupPolicyDefinitionToCreate">The GroupPolicyDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyDefinition.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinition> CreateAsync(GroupPolicyDefinition groupPolicyDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyDefinition>(groupPolicyDefinitionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyDefinition using POST and returns a <see cref="GraphResponse{GroupPolicyDefinition}"/> object.
        /// </summary>
        /// <param name="groupPolicyDefinitionToCreate">The GroupPolicyDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinition>> CreateResponseAsync(GroupPolicyDefinition groupPolicyDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyDefinition>(groupPolicyDefinitionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyDefinition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyDefinition.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinition> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyDefinition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinition and returns a <see cref="GraphResponse{GroupPolicyDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinition>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyDefinition>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyDefinition using PATCH.
        /// </summary>
        /// <param name="groupPolicyDefinitionToUpdate">The GroupPolicyDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyDefinition.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinition> UpdateAsync(GroupPolicyDefinition groupPolicyDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyDefinition>(groupPolicyDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyDefinition using PATCH and returns a <see cref="GraphResponse{GroupPolicyDefinition}"/> object.
        /// </summary>
        /// <param name="groupPolicyDefinitionToUpdate">The GroupPolicyDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinition>> UpdateResponseAsync(GroupPolicyDefinition groupPolicyDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyDefinition>(groupPolicyDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyDefinition using PUT.
        /// </summary>
        /// <param name="groupPolicyDefinitionToUpdate">The GroupPolicyDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinition> PutAsync(GroupPolicyDefinition groupPolicyDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyDefinition>(groupPolicyDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyDefinition using PUT and returns a <see cref="GraphResponse{GroupPolicyDefinition}"/> object.
        /// </summary>
        /// <param name="groupPolicyDefinitionToUpdate">The GroupPolicyDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyDefinition}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinition>> PutResponseAsync(GroupPolicyDefinition groupPolicyDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyDefinition>(groupPolicyDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionRequest Expand(Expression<Func<GroupPolicyDefinition, object>> expandExpression)
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
        public IGroupPolicyDefinitionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionRequest Select(Expression<Func<GroupPolicyDefinition, object>> selectExpression)
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
        /// <param name="groupPolicyDefinitionToInitialize">The <see cref="GroupPolicyDefinition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyDefinition groupPolicyDefinitionToInitialize)
        {

            if (groupPolicyDefinitionToInitialize != null)
            {
                if (groupPolicyDefinitionToInitialize.Presentations != null && groupPolicyDefinitionToInitialize.Presentations.CurrentPage != null)
                {
                    groupPolicyDefinitionToInitialize.Presentations.InitializeNextPageRequest(this.Client, groupPolicyDefinitionToInitialize.PresentationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    groupPolicyDefinitionToInitialize.Presentations.AdditionalData = groupPolicyDefinitionToInitialize.AdditionalData;
                }

            }


        }
    }
}
