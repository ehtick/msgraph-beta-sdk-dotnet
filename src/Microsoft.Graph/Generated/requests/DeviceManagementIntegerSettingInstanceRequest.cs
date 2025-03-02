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
    /// The type DeviceManagementIntegerSettingInstanceRequest.
    /// </summary>
    public partial class DeviceManagementIntegerSettingInstanceRequest : BaseRequest, IDeviceManagementIntegerSettingInstanceRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementIntegerSettingInstanceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementIntegerSettingInstanceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntegerSettingInstance using POST.
        /// </summary>
        /// <param name="deviceManagementIntegerSettingInstanceToCreate">The DeviceManagementIntegerSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementIntegerSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntegerSettingInstance> CreateAsync(DeviceManagementIntegerSettingInstance deviceManagementIntegerSettingInstanceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementIntegerSettingInstance>(deviceManagementIntegerSettingInstanceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementIntegerSettingInstance using POST and returns a <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntegerSettingInstanceToCreate">The DeviceManagementIntegerSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntegerSettingInstance>> CreateResponseAsync(DeviceManagementIntegerSettingInstance deviceManagementIntegerSettingInstanceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntegerSettingInstance>(deviceManagementIntegerSettingInstanceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntegerSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementIntegerSettingInstance>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementIntegerSettingInstance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntegerSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementIntegerSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntegerSettingInstance> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementIntegerSettingInstance>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementIntegerSettingInstance and returns a <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntegerSettingInstance>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntegerSettingInstance>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntegerSettingInstance using PATCH.
        /// </summary>
        /// <param name="deviceManagementIntegerSettingInstanceToUpdate">The DeviceManagementIntegerSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementIntegerSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntegerSettingInstance> UpdateAsync(DeviceManagementIntegerSettingInstance deviceManagementIntegerSettingInstanceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementIntegerSettingInstance>(deviceManagementIntegerSettingInstanceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntegerSettingInstance using PATCH and returns a <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntegerSettingInstanceToUpdate">The DeviceManagementIntegerSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntegerSettingInstance>> UpdateResponseAsync(DeviceManagementIntegerSettingInstance deviceManagementIntegerSettingInstanceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntegerSettingInstance>(deviceManagementIntegerSettingInstanceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntegerSettingInstance using PUT.
        /// </summary>
        /// <param name="deviceManagementIntegerSettingInstanceToUpdate">The DeviceManagementIntegerSettingInstance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementIntegerSettingInstance> PutAsync(DeviceManagementIntegerSettingInstance deviceManagementIntegerSettingInstanceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementIntegerSettingInstance>(deviceManagementIntegerSettingInstanceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementIntegerSettingInstance using PUT and returns a <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntegerSettingInstanceToUpdate">The DeviceManagementIntegerSettingInstance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementIntegerSettingInstance}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntegerSettingInstance>> PutResponseAsync(DeviceManagementIntegerSettingInstance deviceManagementIntegerSettingInstanceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementIntegerSettingInstance>(deviceManagementIntegerSettingInstanceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntegerSettingInstanceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntegerSettingInstanceRequest Expand(Expression<Func<DeviceManagementIntegerSettingInstance, object>> expandExpression)
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
        public IDeviceManagementIntegerSettingInstanceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementIntegerSettingInstanceRequest Select(Expression<Func<DeviceManagementIntegerSettingInstance, object>> selectExpression)
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
        /// <param name="deviceManagementIntegerSettingInstanceToInitialize">The <see cref="DeviceManagementIntegerSettingInstance"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementIntegerSettingInstance deviceManagementIntegerSettingInstanceToInitialize)
        {

        }
    }
}
