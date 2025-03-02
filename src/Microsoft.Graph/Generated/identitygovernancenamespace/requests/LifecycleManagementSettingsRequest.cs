// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type LifecycleManagementSettingsRequest.
    /// </summary>
    public partial class LifecycleManagementSettingsRequest : Microsoft.Graph.BaseRequest, ILifecycleManagementSettingsRequest
    {
        /// <summary>
        /// Constructs a new LifecycleManagementSettingsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public LifecycleManagementSettingsRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified LifecycleManagementSettings using POST.
        /// </summary>
        /// <param name="lifecycleManagementSettingsToCreate">The LifecycleManagementSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LifecycleManagementSettings.</returns>
        public async System.Threading.Tasks.Task<LifecycleManagementSettings> CreateAsync(LifecycleManagementSettings lifecycleManagementSettingsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<LifecycleManagementSettings>(lifecycleManagementSettingsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified LifecycleManagementSettings using POST and returns a <see cref="GraphResponse{LifecycleManagementSettings}"/> object.
        /// </summary>
        /// <param name="lifecycleManagementSettingsToCreate">The LifecycleManagementSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LifecycleManagementSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LifecycleManagementSettings>> CreateResponseAsync(LifecycleManagementSettings lifecycleManagementSettingsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<LifecycleManagementSettings>(lifecycleManagementSettingsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified LifecycleManagementSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<LifecycleManagementSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified LifecycleManagementSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified LifecycleManagementSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LifecycleManagementSettings.</returns>
        public async System.Threading.Tasks.Task<LifecycleManagementSettings> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<LifecycleManagementSettings>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified LifecycleManagementSettings and returns a <see cref="GraphResponse{LifecycleManagementSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LifecycleManagementSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LifecycleManagementSettings>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<LifecycleManagementSettings>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified LifecycleManagementSettings using PATCH.
        /// </summary>
        /// <param name="lifecycleManagementSettingsToUpdate">The LifecycleManagementSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LifecycleManagementSettings.</returns>
        public async System.Threading.Tasks.Task<LifecycleManagementSettings> UpdateAsync(LifecycleManagementSettings lifecycleManagementSettingsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<LifecycleManagementSettings>(lifecycleManagementSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified LifecycleManagementSettings using PATCH and returns a <see cref="GraphResponse{LifecycleManagementSettings}"/> object.
        /// </summary>
        /// <param name="lifecycleManagementSettingsToUpdate">The LifecycleManagementSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{LifecycleManagementSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LifecycleManagementSettings>> UpdateResponseAsync(LifecycleManagementSettings lifecycleManagementSettingsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<LifecycleManagementSettings>(lifecycleManagementSettingsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified LifecycleManagementSettings using PUT.
        /// </summary>
        /// <param name="lifecycleManagementSettingsToUpdate">The LifecycleManagementSettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<LifecycleManagementSettings> PutAsync(LifecycleManagementSettings lifecycleManagementSettingsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<LifecycleManagementSettings>(lifecycleManagementSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified LifecycleManagementSettings using PUT and returns a <see cref="GraphResponse{LifecycleManagementSettings}"/> object.
        /// </summary>
        /// <param name="lifecycleManagementSettingsToUpdate">The LifecycleManagementSettings object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{LifecycleManagementSettings}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<LifecycleManagementSettings>> PutResponseAsync(LifecycleManagementSettings lifecycleManagementSettingsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<LifecycleManagementSettings>(lifecycleManagementSettingsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILifecycleManagementSettingsRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILifecycleManagementSettingsRequest Expand(Expression<Func<LifecycleManagementSettings, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ILifecycleManagementSettingsRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ILifecycleManagementSettingsRequest Select(Expression<Func<LifecycleManagementSettings, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="lifecycleManagementSettingsToInitialize">The <see cref="LifecycleManagementSettings"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(LifecycleManagementSettings lifecycleManagementSettingsToInitialize)
        {

        }
    }
}
