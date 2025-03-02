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
    /// The type DeviceManagementScriptDeviceStateRequest.
    /// </summary>
    public partial class DeviceManagementScriptDeviceStateRequest : BaseRequest, IDeviceManagementScriptDeviceStateRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementScriptDeviceStateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementScriptDeviceStateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptDeviceState using POST.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToCreate">The DeviceManagementScriptDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptDeviceState.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptDeviceState> CreateAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementScriptDeviceState>(deviceManagementScriptDeviceStateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementScriptDeviceState using POST and returns a <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToCreate">The DeviceManagementScriptDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptDeviceState>> CreateResponseAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptDeviceState>(deviceManagementScriptDeviceStateToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementScriptDeviceState>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementScriptDeviceState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptDeviceState.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptDeviceState> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementScriptDeviceState>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementScriptDeviceState and returns a <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptDeviceState>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptDeviceState>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptDeviceState using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToUpdate">The DeviceManagementScriptDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptDeviceState.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptDeviceState> UpdateAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementScriptDeviceState>(deviceManagementScriptDeviceStateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptDeviceState using PATCH and returns a <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToUpdate">The DeviceManagementScriptDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptDeviceState>> UpdateResponseAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptDeviceState>(deviceManagementScriptDeviceStateToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptDeviceState using PUT.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToUpdate">The DeviceManagementScriptDeviceState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementScriptDeviceState> PutAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementScriptDeviceState>(deviceManagementScriptDeviceStateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementScriptDeviceState using PUT and returns a <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToUpdate">The DeviceManagementScriptDeviceState object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptDeviceState>> PutResponseAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementScriptDeviceState>(deviceManagementScriptDeviceStateToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptDeviceStateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptDeviceStateRequest Expand(Expression<Func<DeviceManagementScriptDeviceState, object>> expandExpression)
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
        public IDeviceManagementScriptDeviceStateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScriptDeviceStateRequest Select(Expression<Func<DeviceManagementScriptDeviceState, object>> selectExpression)
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
        /// <param name="deviceManagementScriptDeviceStateToInitialize">The <see cref="DeviceManagementScriptDeviceState"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToInitialize)
        {

        }
    }
}
