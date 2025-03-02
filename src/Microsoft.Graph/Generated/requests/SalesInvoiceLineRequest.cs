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
    /// The type SalesInvoiceLineRequest.
    /// </summary>
    public partial class SalesInvoiceLineRequest : BaseRequest, ISalesInvoiceLineRequest
    {
        /// <summary>
        /// Constructs a new SalesInvoiceLineRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SalesInvoiceLineRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SalesInvoiceLine using POST.
        /// </summary>
        /// <param name="salesInvoiceLineToCreate">The SalesInvoiceLine to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SalesInvoiceLine.</returns>
        public async System.Threading.Tasks.Task<SalesInvoiceLine> CreateAsync(SalesInvoiceLine salesInvoiceLineToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SalesInvoiceLine>(salesInvoiceLineToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SalesInvoiceLine using POST and returns a <see cref="GraphResponse{SalesInvoiceLine}"/> object.
        /// </summary>
        /// <param name="salesInvoiceLineToCreate">The SalesInvoiceLine to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesInvoiceLine}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SalesInvoiceLine>> CreateResponseAsync(SalesInvoiceLine salesInvoiceLineToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SalesInvoiceLine>(salesInvoiceLineToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SalesInvoiceLine.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SalesInvoiceLine>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SalesInvoiceLine and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SalesInvoiceLine.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SalesInvoiceLine.</returns>
        public async System.Threading.Tasks.Task<SalesInvoiceLine> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SalesInvoiceLine>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SalesInvoiceLine and returns a <see cref="GraphResponse{SalesInvoiceLine}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesInvoiceLine}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SalesInvoiceLine>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SalesInvoiceLine>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SalesInvoiceLine using PATCH.
        /// </summary>
        /// <param name="salesInvoiceLineToUpdate">The SalesInvoiceLine to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SalesInvoiceLine.</returns>
        public async System.Threading.Tasks.Task<SalesInvoiceLine> UpdateAsync(SalesInvoiceLine salesInvoiceLineToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SalesInvoiceLine>(salesInvoiceLineToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SalesInvoiceLine using PATCH and returns a <see cref="GraphResponse{SalesInvoiceLine}"/> object.
        /// </summary>
        /// <param name="salesInvoiceLineToUpdate">The SalesInvoiceLine to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SalesInvoiceLine}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SalesInvoiceLine>> UpdateResponseAsync(SalesInvoiceLine salesInvoiceLineToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SalesInvoiceLine>(salesInvoiceLineToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SalesInvoiceLine using PUT.
        /// </summary>
        /// <param name="salesInvoiceLineToUpdate">The SalesInvoiceLine object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<SalesInvoiceLine> PutAsync(SalesInvoiceLine salesInvoiceLineToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<SalesInvoiceLine>(salesInvoiceLineToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SalesInvoiceLine using PUT and returns a <see cref="GraphResponse{SalesInvoiceLine}"/> object.
        /// </summary>
        /// <param name="salesInvoiceLineToUpdate">The SalesInvoiceLine object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{SalesInvoiceLine}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SalesInvoiceLine>> PutResponseAsync(SalesInvoiceLine salesInvoiceLineToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<SalesInvoiceLine>(salesInvoiceLineToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISalesInvoiceLineRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISalesInvoiceLineRequest Expand(Expression<Func<SalesInvoiceLine, object>> expandExpression)
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
        public ISalesInvoiceLineRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISalesInvoiceLineRequest Select(Expression<Func<SalesInvoiceLine, object>> selectExpression)
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
        /// <param name="salesInvoiceLineToInitialize">The <see cref="SalesInvoiceLine"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SalesInvoiceLine salesInvoiceLineToInitialize)
        {

        }
    }
}
