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
    /// The type DeviceManagementComplexSettingDefinitionRequest.
    /// </summary>
    public partial class DeviceManagementComplexSettingDefinitionRequest : BaseRequest, IDeviceManagementComplexSettingDefinitionRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementComplexSettingDefinitionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementComplexSettingDefinitionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementComplexSettingDefinition using POST.
        /// </summary>
        /// <param name="deviceManagementComplexSettingDefinitionToCreate">The DeviceManagementComplexSettingDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementComplexSettingDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplexSettingDefinition> CreateAsync(DeviceManagementComplexSettingDefinition deviceManagementComplexSettingDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementComplexSettingDefinition>(deviceManagementComplexSettingDefinitionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementComplexSettingDefinition using POST and returns a <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplexSettingDefinitionToCreate">The DeviceManagementComplexSettingDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplexSettingDefinition>> CreateResponseAsync(DeviceManagementComplexSettingDefinition deviceManagementComplexSettingDefinitionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplexSettingDefinition>(deviceManagementComplexSettingDefinitionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementComplexSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementComplexSettingDefinition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementComplexSettingDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementComplexSettingDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementComplexSettingDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplexSettingDefinition> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementComplexSettingDefinition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementComplexSettingDefinition and returns a <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplexSettingDefinition>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplexSettingDefinition>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplexSettingDefinition using PATCH.
        /// </summary>
        /// <param name="deviceManagementComplexSettingDefinitionToUpdate">The DeviceManagementComplexSettingDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementComplexSettingDefinition.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplexSettingDefinition> UpdateAsync(DeviceManagementComplexSettingDefinition deviceManagementComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementComplexSettingDefinition>(deviceManagementComplexSettingDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplexSettingDefinition using PATCH and returns a <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplexSettingDefinitionToUpdate">The DeviceManagementComplexSettingDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplexSettingDefinition>> UpdateResponseAsync(DeviceManagementComplexSettingDefinition deviceManagementComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplexSettingDefinition>(deviceManagementComplexSettingDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplexSettingDefinition using PUT.
        /// </summary>
        /// <param name="deviceManagementComplexSettingDefinitionToUpdate">The DeviceManagementComplexSettingDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplexSettingDefinition> PutAsync(DeviceManagementComplexSettingDefinition deviceManagementComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementComplexSettingDefinition>(deviceManagementComplexSettingDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplexSettingDefinition using PUT and returns a <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplexSettingDefinitionToUpdate">The DeviceManagementComplexSettingDefinition object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementComplexSettingDefinition}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplexSettingDefinition>> PutResponseAsync(DeviceManagementComplexSettingDefinition deviceManagementComplexSettingDefinitionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplexSettingDefinition>(deviceManagementComplexSettingDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplexSettingDefinitionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplexSettingDefinitionRequest Expand(Expression<Func<DeviceManagementComplexSettingDefinition, object>> expandExpression)
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
        public IDeviceManagementComplexSettingDefinitionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplexSettingDefinitionRequest Select(Expression<Func<DeviceManagementComplexSettingDefinition, object>> selectExpression)
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
        /// <param name="deviceManagementComplexSettingDefinitionToInitialize">The <see cref="DeviceManagementComplexSettingDefinition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementComplexSettingDefinition deviceManagementComplexSettingDefinitionToInitialize)
        {

        }
    }
}
