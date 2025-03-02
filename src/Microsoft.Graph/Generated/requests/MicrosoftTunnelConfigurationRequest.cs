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
    /// The type MicrosoftTunnelConfigurationRequest.
    /// </summary>
    public partial class MicrosoftTunnelConfigurationRequest : BaseRequest, IMicrosoftTunnelConfigurationRequest
    {
        /// <summary>
        /// Constructs a new MicrosoftTunnelConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MicrosoftTunnelConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MicrosoftTunnelConfiguration using POST.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToCreate">The MicrosoftTunnelConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftTunnelConfiguration.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> CreateAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MicrosoftTunnelConfiguration>(microsoftTunnelConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MicrosoftTunnelConfiguration using POST and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToCreate">The MicrosoftTunnelConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> CreateResponseAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelConfiguration>(microsoftTunnelConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MicrosoftTunnelConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MicrosoftTunnelConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MicrosoftTunnelConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MicrosoftTunnelConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftTunnelConfiguration.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MicrosoftTunnelConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MicrosoftTunnelConfiguration and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftTunnelConfiguration.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> UpdateAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MicrosoftTunnelConfiguration>(microsoftTunnelConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PATCH and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> UpdateResponseAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelConfiguration>(microsoftTunnelConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PUT.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelConfiguration> PutAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MicrosoftTunnelConfiguration>(microsoftTunnelConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelConfiguration using PUT and returns a <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/> object.
        /// </summary>
        /// <param name="microsoftTunnelConfigurationToUpdate">The MicrosoftTunnelConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MicrosoftTunnelConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MicrosoftTunnelConfiguration>> PutResponseAsync(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MicrosoftTunnelConfiguration>(microsoftTunnelConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelConfigurationRequest Expand(Expression<Func<MicrosoftTunnelConfiguration, object>> expandExpression)
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
        public IMicrosoftTunnelConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelConfigurationRequest Select(Expression<Func<MicrosoftTunnelConfiguration, object>> selectExpression)
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
        /// <param name="microsoftTunnelConfigurationToInitialize">The <see cref="MicrosoftTunnelConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MicrosoftTunnelConfiguration microsoftTunnelConfigurationToInitialize)
        {

        }
    }
}
