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
    /// The type GroupPolicyPresentationDecimalTextBoxRequest.
    /// </summary>
    public partial class GroupPolicyPresentationDecimalTextBoxRequest : BaseRequest, IGroupPolicyPresentationDecimalTextBoxRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyPresentationDecimalTextBoxRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyPresentationDecimalTextBoxRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationDecimalTextBox using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToCreate">The GroupPolicyPresentationDecimalTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationDecimalTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> CreateAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyPresentationDecimalTextBox>(groupPolicyPresentationDecimalTextBoxToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationDecimalTextBox using POST and returns a <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToCreate">The GroupPolicyPresentationDecimalTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationDecimalTextBox>> CreateResponseAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationDecimalTextBox>(groupPolicyPresentationDecimalTextBoxToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyPresentationDecimalTextBox>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationDecimalTextBox and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationDecimalTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyPresentationDecimalTextBox>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationDecimalTextBox and returns a <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationDecimalTextBox>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationDecimalTextBox>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationDecimalTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToUpdate">The GroupPolicyPresentationDecimalTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationDecimalTextBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> UpdateAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyPresentationDecimalTextBox>(groupPolicyPresentationDecimalTextBoxToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationDecimalTextBox using PATCH and returns a <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToUpdate">The GroupPolicyPresentationDecimalTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationDecimalTextBox>> UpdateResponseAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationDecimalTextBox>(groupPolicyPresentationDecimalTextBoxToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationDecimalTextBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToUpdate">The GroupPolicyPresentationDecimalTextBox object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> PutAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyPresentationDecimalTextBox>(groupPolicyPresentationDecimalTextBoxToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationDecimalTextBox using PUT and returns a <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToUpdate">The GroupPolicyPresentationDecimalTextBox object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyPresentationDecimalTextBox}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationDecimalTextBox>> PutResponseAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationDecimalTextBox>(groupPolicyPresentationDecimalTextBoxToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationDecimalTextBoxRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationDecimalTextBoxRequest Expand(Expression<Func<GroupPolicyPresentationDecimalTextBox, object>> expandExpression)
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
        public IGroupPolicyPresentationDecimalTextBoxRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationDecimalTextBoxRequest Select(Expression<Func<GroupPolicyPresentationDecimalTextBox, object>> selectExpression)
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
        /// <param name="groupPolicyPresentationDecimalTextBoxToInitialize">The <see cref="GroupPolicyPresentationDecimalTextBox"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToInitialize)
        {

        }
    }
}
