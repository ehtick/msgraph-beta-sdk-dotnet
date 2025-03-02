// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AdminWindowsUpdatesUpdatableAssetsCollectionRequest.
    /// </summary>
    public partial class AdminWindowsUpdatesUpdatableAssetsCollectionRequest : BaseRequest, IAdminWindowsUpdatesUpdatableAssetsCollectionRequest
    {
        /// <summary>
        /// Constructs a new AdminWindowsUpdatesUpdatableAssetsCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AdminWindowsUpdatesUpdatableAssetsCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified Microsoft.Graph.WindowsUpdates.UpdatableAsset to the collection via POST.
        /// </summary>
        /// <param name="updatableAsset">The Microsoft.Graph.WindowsUpdates.UpdatableAsset to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Microsoft.Graph.WindowsUpdates.UpdatableAsset.</returns>
        public System.Threading.Tasks.Task<Microsoft.Graph.WindowsUpdates.UpdatableAsset> AddAsync(Microsoft.Graph.WindowsUpdates.UpdatableAsset updatableAsset, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsync<Microsoft.Graph.WindowsUpdates.UpdatableAsset>(updatableAsset, cancellationToken);
        }

        /// <summary>
        /// Adds the specified Microsoft.Graph.WindowsUpdates.UpdatableAsset to the collection via POST and returns a <see cref="GraphResponse{Microsoft.Graph.WindowsUpdates.UpdatableAsset}"/> object of the request.
        /// </summary>
        /// <param name="updatableAsset">The Microsoft.Graph.WindowsUpdates.UpdatableAsset to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Microsoft.Graph.WindowsUpdates.UpdatableAsset}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Microsoft.Graph.WindowsUpdates.UpdatableAsset>> AddResponseAsync(Microsoft.Graph.WindowsUpdates.UpdatableAsset updatableAsset, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Microsoft.Graph.WindowsUpdates.UpdatableAsset>(updatableAsset, cancellationToken);
        }


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IAdminWindowsUpdatesUpdatableAssetsCollectionPage> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<AdminWindowsUpdatesUpdatableAssetsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
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
        /// Gets the collection page and returns a <see cref="GraphResponse{AdminWindowsUpdatesUpdatableAssetsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdminWindowsUpdatesUpdatableAssetsCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AdminWindowsUpdatesUpdatableAssetsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AdminWindowsUpdatesUpdatableAssetsCollectionResponse>(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest Expand(Expression<Func<Microsoft.Graph.WindowsUpdates.UpdatableAsset, object>> expandExpression)
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
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest Select(Expression<Func<Microsoft.Graph.WindowsUpdates.UpdatableAsset, object>> selectExpression)
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
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
