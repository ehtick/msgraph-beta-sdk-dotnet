// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ThreatSubmissionRootRequest.
    /// </summary>
    public partial class ThreatSubmissionRootRequest : Microsoft.Graph.BaseRequest, IThreatSubmissionRootRequest
    {
        /// <summary>
        /// Constructs a new ThreatSubmissionRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ThreatSubmissionRootRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ThreatSubmissionRoot using POST.
        /// </summary>
        /// <param name="threatSubmissionRootToCreate">The ThreatSubmissionRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ThreatSubmissionRoot.</returns>
        public async System.Threading.Tasks.Task<ThreatSubmissionRoot> CreateAsync(ThreatSubmissionRoot threatSubmissionRootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ThreatSubmissionRoot>(threatSubmissionRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ThreatSubmissionRoot using POST and returns a <see cref="GraphResponse{ThreatSubmissionRoot}"/> object.
        /// </summary>
        /// <param name="threatSubmissionRootToCreate">The ThreatSubmissionRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ThreatSubmissionRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ThreatSubmissionRoot>> CreateResponseAsync(ThreatSubmissionRoot threatSubmissionRootToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ThreatSubmissionRoot>(threatSubmissionRootToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ThreatSubmissionRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ThreatSubmissionRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ThreatSubmissionRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ThreatSubmissionRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ThreatSubmissionRoot.</returns>
        public async System.Threading.Tasks.Task<ThreatSubmissionRoot> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ThreatSubmissionRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ThreatSubmissionRoot and returns a <see cref="GraphResponse{ThreatSubmissionRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ThreatSubmissionRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ThreatSubmissionRoot>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ThreatSubmissionRoot>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ThreatSubmissionRoot using PATCH.
        /// </summary>
        /// <param name="threatSubmissionRootToUpdate">The ThreatSubmissionRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ThreatSubmissionRoot.</returns>
        public async System.Threading.Tasks.Task<ThreatSubmissionRoot> UpdateAsync(ThreatSubmissionRoot threatSubmissionRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ThreatSubmissionRoot>(threatSubmissionRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ThreatSubmissionRoot using PATCH and returns a <see cref="GraphResponse{ThreatSubmissionRoot}"/> object.
        /// </summary>
        /// <param name="threatSubmissionRootToUpdate">The ThreatSubmissionRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ThreatSubmissionRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ThreatSubmissionRoot>> UpdateResponseAsync(ThreatSubmissionRoot threatSubmissionRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ThreatSubmissionRoot>(threatSubmissionRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ThreatSubmissionRoot using PUT.
        /// </summary>
        /// <param name="threatSubmissionRootToUpdate">The ThreatSubmissionRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ThreatSubmissionRoot> PutAsync(ThreatSubmissionRoot threatSubmissionRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ThreatSubmissionRoot>(threatSubmissionRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ThreatSubmissionRoot using PUT and returns a <see cref="GraphResponse{ThreatSubmissionRoot}"/> object.
        /// </summary>
        /// <param name="threatSubmissionRootToUpdate">The ThreatSubmissionRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ThreatSubmissionRoot}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ThreatSubmissionRoot>> PutResponseAsync(ThreatSubmissionRoot threatSubmissionRootToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ThreatSubmissionRoot>(threatSubmissionRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootRequest Expand(Expression<Func<ThreatSubmissionRoot, object>> expandExpression)
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
        public IThreatSubmissionRootRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IThreatSubmissionRootRequest Select(Expression<Func<ThreatSubmissionRoot, object>> selectExpression)
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
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="threatSubmissionRootToInitialize">The <see cref="ThreatSubmissionRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ThreatSubmissionRoot threatSubmissionRootToInitialize)
        {

            if (threatSubmissionRootToInitialize != null)
            {
                if (threatSubmissionRootToInitialize.EmailThreats != null && threatSubmissionRootToInitialize.EmailThreats.CurrentPage != null)
                {
                    threatSubmissionRootToInitialize.EmailThreats.InitializeNextPageRequest(this.Client, threatSubmissionRootToInitialize.EmailThreatsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    threatSubmissionRootToInitialize.EmailThreats.AdditionalData = threatSubmissionRootToInitialize.AdditionalData;
                }
                if (threatSubmissionRootToInitialize.EmailThreatSubmissionPolicies != null && threatSubmissionRootToInitialize.EmailThreatSubmissionPolicies.CurrentPage != null)
                {
                    threatSubmissionRootToInitialize.EmailThreatSubmissionPolicies.InitializeNextPageRequest(this.Client, threatSubmissionRootToInitialize.EmailThreatSubmissionPoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    threatSubmissionRootToInitialize.EmailThreatSubmissionPolicies.AdditionalData = threatSubmissionRootToInitialize.AdditionalData;
                }
                if (threatSubmissionRootToInitialize.FileThreats != null && threatSubmissionRootToInitialize.FileThreats.CurrentPage != null)
                {
                    threatSubmissionRootToInitialize.FileThreats.InitializeNextPageRequest(this.Client, threatSubmissionRootToInitialize.FileThreatsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    threatSubmissionRootToInitialize.FileThreats.AdditionalData = threatSubmissionRootToInitialize.AdditionalData;
                }
                if (threatSubmissionRootToInitialize.UrlThreats != null && threatSubmissionRootToInitialize.UrlThreats.CurrentPage != null)
                {
                    threatSubmissionRootToInitialize.UrlThreats.InitializeNextPageRequest(this.Client, threatSubmissionRootToInitialize.UrlThreatsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    threatSubmissionRootToInitialize.UrlThreats.AdditionalData = threatSubmissionRootToInitialize.AdditionalData;
                }

            }


        }
    }
}
