// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ThreatSubmissionRootUrlThreatsCollectionRequest.
    /// </summary>
    public partial class ThreatSubmissionRootUrlThreatsCollectionRequest : Microsoft.Graph.BaseRequest, IThreatSubmissionRootUrlThreatsCollectionRequest
    {
        /// <summary>
        /// Constructs a new ThreatSubmissionRootUrlThreatsCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ThreatSubmissionRootUrlThreatsCollectionRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified UrlThreatSubmission to the collection via POST.
        /// </summary>
        /// <param name="urlThreatSubmission">The UrlThreatSubmission to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UrlThreatSubmission.</returns>
        public System.Threading.Tasks.Task<UrlThreatSubmission> AddAsync(UrlThreatSubmission urlThreatSubmission, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsync<UrlThreatSubmission>(urlThreatSubmission, cancellationToken);
        }

        /// <summary>
        /// Adds the specified UrlThreatSubmission to the collection via POST and returns a <see cref="GraphResponse{UrlThreatSubmission}"/> object of the request.
        /// </summary>
        /// <param name="urlThreatSubmission">The UrlThreatSubmission to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UrlThreatSubmission}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UrlThreatSubmission>> AddResponseAsync(UrlThreatSubmission urlThreatSubmission, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UrlThreatSubmission>(urlThreatSubmission, cancellationToken);
        }


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IThreatSubmissionRootUrlThreatsCollectionPage> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<ThreatSubmissionRootUrlThreatsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
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
        /// Gets the collection page and returns a <see cref="GraphResponse{ThreatSubmissionRootUrlThreatsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ThreatSubmissionRootUrlThreatsCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ThreatSubmissionRootUrlThreatsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ThreatSubmissionRootUrlThreatsCollectionResponse>(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootUrlThreatsCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootUrlThreatsCollectionRequest Expand(Expression<Func<UrlThreatSubmission, object>> expandExpression)
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
        public IThreatSubmissionRootUrlThreatsCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootUrlThreatsCollectionRequest Select(Expression<Func<UrlThreatSubmission, object>> selectExpression)
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
        public IThreatSubmissionRootUrlThreatsCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootUrlThreatsCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootUrlThreatsCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootUrlThreatsCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$orderby", value));
            return this;
        }
    }
}
