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
    /// The type DeviceManagementComplianceActionItemRequest.
    /// </summary>
    public partial class DeviceManagementComplianceActionItemRequest : BaseRequest, IDeviceManagementComplianceActionItemRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementComplianceActionItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementComplianceActionItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementComplianceActionItem using POST.
        /// </summary>
        /// <param name="deviceManagementComplianceActionItemToCreate">The DeviceManagementComplianceActionItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementComplianceActionItem.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplianceActionItem> CreateAsync(DeviceManagementComplianceActionItem deviceManagementComplianceActionItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementComplianceActionItem>(deviceManagementComplianceActionItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementComplianceActionItem using POST and returns a <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplianceActionItemToCreate">The DeviceManagementComplianceActionItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplianceActionItem>> CreateResponseAsync(DeviceManagementComplianceActionItem deviceManagementComplianceActionItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplianceActionItem>(deviceManagementComplianceActionItemToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementComplianceActionItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementComplianceActionItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementComplianceActionItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementComplianceActionItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementComplianceActionItem.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplianceActionItem> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementComplianceActionItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementComplianceActionItem and returns a <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplianceActionItem>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplianceActionItem>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplianceActionItem using PATCH.
        /// </summary>
        /// <param name="deviceManagementComplianceActionItemToUpdate">The DeviceManagementComplianceActionItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementComplianceActionItem.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplianceActionItem> UpdateAsync(DeviceManagementComplianceActionItem deviceManagementComplianceActionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementComplianceActionItem>(deviceManagementComplianceActionItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplianceActionItem using PATCH and returns a <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplianceActionItemToUpdate">The DeviceManagementComplianceActionItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplianceActionItem>> UpdateResponseAsync(DeviceManagementComplianceActionItem deviceManagementComplianceActionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplianceActionItem>(deviceManagementComplianceActionItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplianceActionItem using PUT.
        /// </summary>
        /// <param name="deviceManagementComplianceActionItemToUpdate">The DeviceManagementComplianceActionItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplianceActionItem> PutAsync(DeviceManagementComplianceActionItem deviceManagementComplianceActionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementComplianceActionItem>(deviceManagementComplianceActionItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplianceActionItem using PUT and returns a <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplianceActionItemToUpdate">The DeviceManagementComplianceActionItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementComplianceActionItem}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplianceActionItem>> PutResponseAsync(DeviceManagementComplianceActionItem deviceManagementComplianceActionItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplianceActionItem>(deviceManagementComplianceActionItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplianceActionItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplianceActionItemRequest Expand(Expression<Func<DeviceManagementComplianceActionItem, object>> expandExpression)
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
        public IDeviceManagementComplianceActionItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplianceActionItemRequest Select(Expression<Func<DeviceManagementComplianceActionItem, object>> selectExpression)
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
        /// <param name="deviceManagementComplianceActionItemToInitialize">The <see cref="DeviceManagementComplianceActionItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementComplianceActionItem deviceManagementComplianceActionItemToInitialize)
        {

        }
    }
}
