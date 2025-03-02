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
    /// The type SynchronizationRequest.
    /// </summary>
    public partial class SynchronizationRequest : BaseRequest, ISynchronizationRequest
    {
        /// <summary>
        /// Constructs a new SynchronizationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SynchronizationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Synchronization using POST.
        /// </summary>
        /// <param name="synchronizationToCreate">The Synchronization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Synchronization.</returns>
        public async System.Threading.Tasks.Task<Synchronization> CreateAsync(Synchronization synchronizationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Synchronization>(synchronizationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Synchronization using POST and returns a <see cref="GraphResponse{Synchronization}"/> object.
        /// </summary>
        /// <param name="synchronizationToCreate">The Synchronization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Synchronization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Synchronization>> CreateResponseAsync(Synchronization synchronizationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Synchronization>(synchronizationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Synchronization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Synchronization>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Synchronization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Synchronization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Synchronization.</returns>
        public async System.Threading.Tasks.Task<Synchronization> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Synchronization>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Synchronization and returns a <see cref="GraphResponse{Synchronization}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Synchronization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Synchronization>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Synchronization>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Synchronization using PATCH.
        /// </summary>
        /// <param name="synchronizationToUpdate">The Synchronization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Synchronization.</returns>
        public async System.Threading.Tasks.Task<Synchronization> UpdateAsync(Synchronization synchronizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Synchronization>(synchronizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Synchronization using PATCH and returns a <see cref="GraphResponse{Synchronization}"/> object.
        /// </summary>
        /// <param name="synchronizationToUpdate">The Synchronization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Synchronization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Synchronization>> UpdateResponseAsync(Synchronization synchronizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Synchronization>(synchronizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Synchronization using PUT.
        /// </summary>
        /// <param name="synchronizationToUpdate">The Synchronization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Synchronization> PutAsync(Synchronization synchronizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Synchronization>(synchronizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Synchronization using PUT and returns a <see cref="GraphResponse{Synchronization}"/> object.
        /// </summary>
        /// <param name="synchronizationToUpdate">The Synchronization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Synchronization}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Synchronization>> PutResponseAsync(Synchronization synchronizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Synchronization>(synchronizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationRequest Expand(Expression<Func<Synchronization, object>> expandExpression)
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
        public ISynchronizationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISynchronizationRequest Select(Expression<Func<Synchronization, object>> selectExpression)
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
        /// <param name="synchronizationToInitialize">The <see cref="Synchronization"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Synchronization synchronizationToInitialize)
        {

            if (synchronizationToInitialize != null)
            {
                if (synchronizationToInitialize.Jobs != null && synchronizationToInitialize.Jobs.CurrentPage != null)
                {
                    synchronizationToInitialize.Jobs.InitializeNextPageRequest(this.Client, synchronizationToInitialize.JobsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    synchronizationToInitialize.Jobs.AdditionalData = synchronizationToInitialize.AdditionalData;
                }
                if (synchronizationToInitialize.Templates != null && synchronizationToInitialize.Templates.CurrentPage != null)
                {
                    synchronizationToInitialize.Templates.InitializeNextPageRequest(this.Client, synchronizationToInitialize.TemplatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    synchronizationToInitialize.Templates.AdditionalData = synchronizationToInitialize.AdditionalData;
                }

            }


        }
    }
}
