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
    /// The type ManagedDeviceRequest.
    /// </summary>
    public partial class ManagedDeviceRequest : BaseRequest, IManagedDeviceRequest
    {
        /// <summary>
        /// Constructs a new ManagedDeviceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedDeviceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedDevice using POST.
        /// </summary>
        /// <param name="managedDeviceToCreate">The ManagedDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDevice.</returns>
        public async System.Threading.Tasks.Task<ManagedDevice> CreateAsync(ManagedDevice managedDeviceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ManagedDevice>(managedDeviceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagedDevice using POST and returns a <see cref="GraphResponse{ManagedDevice}"/> object.
        /// </summary>
        /// <param name="managedDeviceToCreate">The ManagedDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDevice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDevice>> CreateResponseAsync(ManagedDevice managedDeviceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ManagedDevice>(managedDeviceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ManagedDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ManagedDevice>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedDevice and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ManagedDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDevice.</returns>
        public async System.Threading.Tasks.Task<ManagedDevice> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ManagedDevice>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagedDevice and returns a <see cref="GraphResponse{ManagedDevice}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDevice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDevice>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagedDevice>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedDevice using PATCH.
        /// </summary>
        /// <param name="managedDeviceToUpdate">The ManagedDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDevice.</returns>
        public async System.Threading.Tasks.Task<ManagedDevice> UpdateAsync(ManagedDevice managedDeviceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ManagedDevice>(managedDeviceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedDevice using PATCH and returns a <see cref="GraphResponse{ManagedDevice}"/> object.
        /// </summary>
        /// <param name="managedDeviceToUpdate">The ManagedDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDevice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDevice>> UpdateResponseAsync(ManagedDevice managedDeviceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ManagedDevice>(managedDeviceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ManagedDevice using PUT.
        /// </summary>
        /// <param name="managedDeviceToUpdate">The ManagedDevice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ManagedDevice> PutAsync(ManagedDevice managedDeviceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ManagedDevice>(managedDeviceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedDevice using PUT and returns a <see cref="GraphResponse{ManagedDevice}"/> object.
        /// </summary>
        /// <param name="managedDeviceToUpdate">The ManagedDevice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ManagedDevice}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDevice>> PutResponseAsync(ManagedDevice managedDeviceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ManagedDevice>(managedDeviceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceRequest Expand(Expression<Func<ManagedDevice, object>> expandExpression)
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
        public IManagedDeviceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceRequest Select(Expression<Func<ManagedDevice, object>> selectExpression)
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
        /// <param name="managedDeviceToInitialize">The <see cref="ManagedDevice"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedDevice managedDeviceToInitialize)
        {

            if (managedDeviceToInitialize != null)
            {
                if (managedDeviceToInitialize.AssignmentFilterEvaluationStatusDetails != null && managedDeviceToInitialize.AssignmentFilterEvaluationStatusDetails.CurrentPage != null)
                {
                    managedDeviceToInitialize.AssignmentFilterEvaluationStatusDetails.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.AssignmentFilterEvaluationStatusDetailsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.AssignmentFilterEvaluationStatusDetails.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.DeviceCompliancePolicyStates != null && managedDeviceToInitialize.DeviceCompliancePolicyStates.CurrentPage != null)
                {
                    managedDeviceToInitialize.DeviceCompliancePolicyStates.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.DeviceCompliancePolicyStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.DeviceCompliancePolicyStates.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.DeviceConfigurationStates != null && managedDeviceToInitialize.DeviceConfigurationStates.CurrentPage != null)
                {
                    managedDeviceToInitialize.DeviceConfigurationStates.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.DeviceConfigurationStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.DeviceConfigurationStates.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.ManagedDeviceMobileAppConfigurationStates != null && managedDeviceToInitialize.ManagedDeviceMobileAppConfigurationStates.CurrentPage != null)
                {
                    managedDeviceToInitialize.ManagedDeviceMobileAppConfigurationStates.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.ManagedDeviceMobileAppConfigurationStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.ManagedDeviceMobileAppConfigurationStates.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.SecurityBaselineStates != null && managedDeviceToInitialize.SecurityBaselineStates.CurrentPage != null)
                {
                    managedDeviceToInitialize.SecurityBaselineStates.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.SecurityBaselineStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.SecurityBaselineStates.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.DetectedApps != null && managedDeviceToInitialize.DetectedApps.CurrentPage != null)
                {
                    managedDeviceToInitialize.DetectedApps.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.DetectedAppsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.DetectedApps.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.DeviceHealthScriptStates != null && managedDeviceToInitialize.DeviceHealthScriptStates.CurrentPage != null)
                {
                    managedDeviceToInitialize.DeviceHealthScriptStates.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.DeviceHealthScriptStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.DeviceHealthScriptStates.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.LogCollectionRequests != null && managedDeviceToInitialize.LogCollectionRequests.CurrentPage != null)
                {
                    managedDeviceToInitialize.LogCollectionRequests.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.LogCollectionRequestsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.LogCollectionRequests.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }
                if (managedDeviceToInitialize.Users != null && managedDeviceToInitialize.Users.CurrentPage != null)
                {
                    managedDeviceToInitialize.Users.InitializeNextPageRequest(this.Client, managedDeviceToInitialize.UsersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    managedDeviceToInitialize.Users.AdditionalData = managedDeviceToInitialize.AdditionalData;
                }

            }


        }
    }
}
