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
    /// The type GroupPolicyPresentationComboBoxRequest.
    /// </summary>
    public partial class GroupPolicyPresentationComboBoxRequest : BaseRequest, IGroupPolicyPresentationComboBoxRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyPresentationComboBoxRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyPresentationComboBoxRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationComboBox using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToCreate">The GroupPolicyPresentationComboBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationComboBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> CreateAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyPresentationComboBox>(groupPolicyPresentationComboBoxToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyPresentationComboBox using POST and returns a <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToCreate">The GroupPolicyPresentationComboBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationComboBox>> CreateResponseAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationComboBox>(groupPolicyPresentationComboBoxToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationComboBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyPresentationComboBox>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationComboBox and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationComboBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationComboBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyPresentationComboBox>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyPresentationComboBox and returns a <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationComboBox>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationComboBox>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationComboBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToUpdate">The GroupPolicyPresentationComboBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationComboBox.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> UpdateAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyPresentationComboBox>(groupPolicyPresentationComboBoxToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationComboBox using PATCH and returns a <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToUpdate">The GroupPolicyPresentationComboBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationComboBox>> UpdateResponseAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationComboBox>(groupPolicyPresentationComboBoxToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationComboBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToUpdate">The GroupPolicyPresentationComboBox object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyPresentationComboBox> PutAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyPresentationComboBox>(groupPolicyPresentationComboBoxToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyPresentationComboBox using PUT and returns a <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationComboBoxToUpdate">The GroupPolicyPresentationComboBox object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyPresentationComboBox}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationComboBox>> PutResponseAsync(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyPresentationComboBox>(groupPolicyPresentationComboBoxToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationComboBoxRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationComboBoxRequest Expand(Expression<Func<GroupPolicyPresentationComboBox, object>> expandExpression)
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
        public IGroupPolicyPresentationComboBoxRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyPresentationComboBoxRequest Select(Expression<Func<GroupPolicyPresentationComboBox, object>> selectExpression)
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
        /// <param name="groupPolicyPresentationComboBoxToInitialize">The <see cref="GroupPolicyPresentationComboBox"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyPresentationComboBox groupPolicyPresentationComboBoxToInitialize)
        {

        }
    }
}
