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
    /// The type MacOSSoftwareUpdateCategorySummaryRequest.
    /// </summary>
    public partial class MacOSSoftwareUpdateCategorySummaryRequest : BaseRequest, IMacOSSoftwareUpdateCategorySummaryRequest
    {
        /// <summary>
        /// Constructs a new MacOSSoftwareUpdateCategorySummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSSoftwareUpdateCategorySummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateCategorySummary using POST.
        /// </summary>
        /// <param name="macOSSoftwareUpdateCategorySummaryToCreate">The MacOSSoftwareUpdateCategorySummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSSoftwareUpdateCategorySummary.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateCategorySummary> CreateAsync(MacOSSoftwareUpdateCategorySummary macOSSoftwareUpdateCategorySummaryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MacOSSoftwareUpdateCategorySummary>(macOSSoftwareUpdateCategorySummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSSoftwareUpdateCategorySummary using POST and returns a <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateCategorySummaryToCreate">The MacOSSoftwareUpdateCategorySummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateCategorySummary>> CreateResponseAsync(MacOSSoftwareUpdateCategorySummary macOSSoftwareUpdateCategorySummaryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateCategorySummary>(macOSSoftwareUpdateCategorySummaryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateCategorySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MacOSSoftwareUpdateCategorySummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSSoftwareUpdateCategorySummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateCategorySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSSoftwareUpdateCategorySummary.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateCategorySummary> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MacOSSoftwareUpdateCategorySummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSSoftwareUpdateCategorySummary and returns a <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateCategorySummary>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateCategorySummary>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateCategorySummary using PATCH.
        /// </summary>
        /// <param name="macOSSoftwareUpdateCategorySummaryToUpdate">The MacOSSoftwareUpdateCategorySummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSSoftwareUpdateCategorySummary.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateCategorySummary> UpdateAsync(MacOSSoftwareUpdateCategorySummary macOSSoftwareUpdateCategorySummaryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MacOSSoftwareUpdateCategorySummary>(macOSSoftwareUpdateCategorySummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateCategorySummary using PATCH and returns a <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateCategorySummaryToUpdate">The MacOSSoftwareUpdateCategorySummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateCategorySummary>> UpdateResponseAsync(MacOSSoftwareUpdateCategorySummary macOSSoftwareUpdateCategorySummaryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateCategorySummary>(macOSSoftwareUpdateCategorySummaryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateCategorySummary using PUT.
        /// </summary>
        /// <param name="macOSSoftwareUpdateCategorySummaryToUpdate">The MacOSSoftwareUpdateCategorySummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MacOSSoftwareUpdateCategorySummary> PutAsync(MacOSSoftwareUpdateCategorySummary macOSSoftwareUpdateCategorySummaryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MacOSSoftwareUpdateCategorySummary>(macOSSoftwareUpdateCategorySummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSSoftwareUpdateCategorySummary using PUT and returns a <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/> object.
        /// </summary>
        /// <param name="macOSSoftwareUpdateCategorySummaryToUpdate">The MacOSSoftwareUpdateCategorySummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MacOSSoftwareUpdateCategorySummary}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSSoftwareUpdateCategorySummary>> PutResponseAsync(MacOSSoftwareUpdateCategorySummary macOSSoftwareUpdateCategorySummaryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MacOSSoftwareUpdateCategorySummary>(macOSSoftwareUpdateCategorySummaryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateCategorySummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateCategorySummaryRequest Expand(Expression<Func<MacOSSoftwareUpdateCategorySummary, object>> expandExpression)
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
        public IMacOSSoftwareUpdateCategorySummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSSoftwareUpdateCategorySummaryRequest Select(Expression<Func<MacOSSoftwareUpdateCategorySummary, object>> selectExpression)
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
        /// <param name="macOSSoftwareUpdateCategorySummaryToInitialize">The <see cref="MacOSSoftwareUpdateCategorySummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSSoftwareUpdateCategorySummary macOSSoftwareUpdateCategorySummaryToInitialize)
        {

            if (macOSSoftwareUpdateCategorySummaryToInitialize != null)
            {
                if (macOSSoftwareUpdateCategorySummaryToInitialize.UpdateStateSummaries != null && macOSSoftwareUpdateCategorySummaryToInitialize.UpdateStateSummaries.CurrentPage != null)
                {
                    macOSSoftwareUpdateCategorySummaryToInitialize.UpdateStateSummaries.InitializeNextPageRequest(this.Client, macOSSoftwareUpdateCategorySummaryToInitialize.UpdateStateSummariesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    macOSSoftwareUpdateCategorySummaryToInitialize.UpdateStateSummaries.AdditionalData = macOSSoftwareUpdateCategorySummaryToInitialize.AdditionalData;
                }

            }


        }
    }
}
