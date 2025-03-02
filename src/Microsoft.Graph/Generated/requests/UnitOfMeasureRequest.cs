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
    /// The type UnitOfMeasureRequest.
    /// </summary>
    public partial class UnitOfMeasureRequest : BaseRequest, IUnitOfMeasureRequest
    {
        /// <summary>
        /// Constructs a new UnitOfMeasureRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnitOfMeasureRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnitOfMeasure using POST.
        /// </summary>
        /// <param name="unitOfMeasureToCreate">The UnitOfMeasure to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnitOfMeasure.</returns>
        public async System.Threading.Tasks.Task<UnitOfMeasure> CreateAsync(UnitOfMeasure unitOfMeasureToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UnitOfMeasure>(unitOfMeasureToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnitOfMeasure using POST and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="unitOfMeasureToCreate">The UnitOfMeasure to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> CreateResponseAsync(UnitOfMeasure unitOfMeasureToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UnitOfMeasure>(unitOfMeasureToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UnitOfMeasure.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UnitOfMeasure>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnitOfMeasure and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UnitOfMeasure.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnitOfMeasure.</returns>
        public async System.Threading.Tasks.Task<UnitOfMeasure> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UnitOfMeasure>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnitOfMeasure and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UnitOfMeasure>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnitOfMeasure using PATCH.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnitOfMeasure.</returns>
        public async System.Threading.Tasks.Task<UnitOfMeasure> UpdateAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UnitOfMeasure>(unitOfMeasureToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnitOfMeasure using PATCH and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnitOfMeasure}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> UpdateResponseAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UnitOfMeasure>(unitOfMeasureToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnitOfMeasure using PUT.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UnitOfMeasure> PutAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UnitOfMeasure>(unitOfMeasureToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnitOfMeasure using PUT and returns a <see cref="GraphResponse{UnitOfMeasure}"/> object.
        /// </summary>
        /// <param name="unitOfMeasureToUpdate">The UnitOfMeasure object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UnitOfMeasure}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnitOfMeasure>> PutResponseAsync(UnitOfMeasure unitOfMeasureToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UnitOfMeasure>(unitOfMeasureToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnitOfMeasureRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnitOfMeasureRequest Expand(Expression<Func<UnitOfMeasure, object>> expandExpression)
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
        public IUnitOfMeasureRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnitOfMeasureRequest Select(Expression<Func<UnitOfMeasure, object>> selectExpression)
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
        /// <param name="unitOfMeasureToInitialize">The <see cref="UnitOfMeasure"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnitOfMeasure unitOfMeasureToInitialize)
        {

        }
    }
}
