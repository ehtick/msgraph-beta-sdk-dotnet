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
    /// The type IosWiFiConfigurationRequest.
    /// </summary>
    public partial class IosWiFiConfigurationRequest : BaseRequest, IIosWiFiConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosWiFiConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosWiFiConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosWiFiConfiguration using POST.
        /// </summary>
        /// <param name="iosWiFiConfigurationToCreate">The IosWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosWiFiConfiguration> CreateAsync(IosWiFiConfiguration iosWiFiConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IosWiFiConfiguration>(iosWiFiConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosWiFiConfiguration using POST and returns a <see cref="GraphResponse{IosWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="iosWiFiConfigurationToCreate">The IosWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosWiFiConfiguration>> CreateResponseAsync(IosWiFiConfiguration iosWiFiConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IosWiFiConfiguration>(iosWiFiConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IosWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IosWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IosWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosWiFiConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IosWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosWiFiConfiguration and returns a <see cref="GraphResponse{IosWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IosWiFiConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="iosWiFiConfigurationToUpdate">The IosWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosWiFiConfiguration> UpdateAsync(IosWiFiConfiguration iosWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IosWiFiConfiguration>(iosWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{IosWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="iosWiFiConfigurationToUpdate">The IosWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosWiFiConfiguration>> UpdateResponseAsync(IosWiFiConfiguration iosWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IosWiFiConfiguration>(iosWiFiConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="iosWiFiConfigurationToUpdate">The IosWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IosWiFiConfiguration> PutAsync(IosWiFiConfiguration iosWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IosWiFiConfiguration>(iosWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosWiFiConfiguration using PUT and returns a <see cref="GraphResponse{IosWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="iosWiFiConfigurationToUpdate">The IosWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IosWiFiConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosWiFiConfiguration>> PutResponseAsync(IosWiFiConfiguration iosWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IosWiFiConfiguration>(iosWiFiConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosWiFiConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosWiFiConfigurationRequest Expand(Expression<Func<IosWiFiConfiguration, object>> expandExpression)
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
        public IIosWiFiConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosWiFiConfigurationRequest Select(Expression<Func<IosWiFiConfiguration, object>> selectExpression)
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
        /// <param name="iosWiFiConfigurationToInitialize">The <see cref="IosWiFiConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosWiFiConfiguration iosWiFiConfigurationToInitialize)
        {

        }
    }
}
