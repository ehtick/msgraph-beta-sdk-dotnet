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
    /// The type IosLobAppProvisioningConfigurationRequest.
    /// </summary>
    public partial class IosLobAppProvisioningConfigurationRequest : BaseRequest, IIosLobAppProvisioningConfigurationRequest
    {
        /// <summary>
        /// Constructs a new IosLobAppProvisioningConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosLobAppProvisioningConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfiguration using POST.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToCreate">The IosLobAppProvisioningConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosLobAppProvisioningConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> CreateAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosLobAppProvisioningConfiguration using POST and returns a <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/> object.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToCreate">The IosLobAppProvisioningConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfiguration>> CreateResponseAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IosLobAppProvisioningConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosLobAppProvisioningConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosLobAppProvisioningConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IosLobAppProvisioningConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosLobAppProvisioningConfiguration and returns a <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IosLobAppProvisioningConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfiguration using PATCH.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToUpdate">The IosLobAppProvisioningConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosLobAppProvisioningConfiguration.</returns>
        public async System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> UpdateAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfiguration using PATCH and returns a <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/> object.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToUpdate">The IosLobAppProvisioningConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfiguration>> UpdateResponseAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfiguration using PUT.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToUpdate">The IosLobAppProvisioningConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IosLobAppProvisioningConfiguration> PutAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosLobAppProvisioningConfiguration using PUT and returns a <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/> object.
        /// </summary>
        /// <param name="iosLobAppProvisioningConfigurationToUpdate">The IosLobAppProvisioningConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IosLobAppProvisioningConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosLobAppProvisioningConfiguration>> PutResponseAsync(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IosLobAppProvisioningConfiguration>(iosLobAppProvisioningConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosLobAppProvisioningConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosLobAppProvisioningConfigurationRequest Expand(Expression<Func<IosLobAppProvisioningConfiguration, object>> expandExpression)
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
        public IIosLobAppProvisioningConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosLobAppProvisioningConfigurationRequest Select(Expression<Func<IosLobAppProvisioningConfiguration, object>> selectExpression)
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
        /// <param name="iosLobAppProvisioningConfigurationToInitialize">The <see cref="IosLobAppProvisioningConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosLobAppProvisioningConfiguration iosLobAppProvisioningConfigurationToInitialize)
        {

            if (iosLobAppProvisioningConfigurationToInitialize != null)
            {
                if (iosLobAppProvisioningConfigurationToInitialize.Assignments != null && iosLobAppProvisioningConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.Assignments.InitializeNextPageRequest(this.Client, iosLobAppProvisioningConfigurationToInitialize.AssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    iosLobAppProvisioningConfigurationToInitialize.Assignments.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;
                }
                if (iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses != null && iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses.InitializeNextPageRequest(this.Client, iosLobAppProvisioningConfigurationToInitialize.DeviceStatusesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    iosLobAppProvisioningConfigurationToInitialize.DeviceStatuses.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;
                }
                if (iosLobAppProvisioningConfigurationToInitialize.GroupAssignments != null && iosLobAppProvisioningConfigurationToInitialize.GroupAssignments.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.GroupAssignments.InitializeNextPageRequest(this.Client, iosLobAppProvisioningConfigurationToInitialize.GroupAssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    iosLobAppProvisioningConfigurationToInitialize.GroupAssignments.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;
                }
                if (iosLobAppProvisioningConfigurationToInitialize.UserStatuses != null && iosLobAppProvisioningConfigurationToInitialize.UserStatuses.CurrentPage != null)
                {
                    iosLobAppProvisioningConfigurationToInitialize.UserStatuses.InitializeNextPageRequest(this.Client, iosLobAppProvisioningConfigurationToInitialize.UserStatusesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    iosLobAppProvisioningConfigurationToInitialize.UserStatuses.AdditionalData = iosLobAppProvisioningConfigurationToInitialize.AdditionalData;
                }

            }


        }
    }
}
