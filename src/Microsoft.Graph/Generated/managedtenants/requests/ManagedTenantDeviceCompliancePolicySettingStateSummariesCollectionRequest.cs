// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest.
    /// </summary>
    public partial class ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest : Microsoft.Graph.BaseRequest, IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest
    {
        /// <summary>
        /// Constructs a new ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified DeviceCompliancePolicySettingStateSummary to the collection via POST.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummary">The DeviceCompliancePolicySettingStateSummary to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicySettingStateSummary.</returns>
        public System.Threading.Tasks.Task<DeviceCompliancePolicySettingStateSummary> AddAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummary, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsync<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummary, cancellationToken);
        }

        /// <summary>
        /// Adds the specified DeviceCompliancePolicySettingStateSummary to the collection via POST and returns a <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.
        /// </summary>
        /// <param name="deviceCompliancePolicySettingStateSummary">The DeviceCompliancePolicySettingStateSummary to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicySettingStateSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicySettingStateSummary>> AddResponseAsync(DeviceCompliancePolicySettingStateSummary deviceCompliancePolicySettingStateSummary, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceCompliancePolicySettingStateSummary>(deviceCompliancePolicySettingStateSummary, cancellationToken);
        }


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionPage> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response?.Value?.CurrentPage != null)
            {
                response.Value.InitializeNextPageRequest(this.Client, response.NextLink);
                // Copy the additional data collection to the page itself so that information is not lost
                response.Value.AdditionalData = response.AdditionalData;
                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionResponse>(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Expand(Expression<Func<DeviceCompliancePolicySettingStateSummary, object>> expandExpression)
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
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Select(Expression<Func<DeviceCompliancePolicySettingStateSummary, object>> selectExpression)
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
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$orderby", value));
            return this;
        }
    }
}
