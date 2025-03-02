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
    /// The type CartToClassAssociationRequest.
    /// </summary>
    public partial class CartToClassAssociationRequest : BaseRequest, ICartToClassAssociationRequest
    {
        /// <summary>
        /// Constructs a new CartToClassAssociationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CartToClassAssociationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CartToClassAssociation using POST.
        /// </summary>
        /// <param name="cartToClassAssociationToCreate">The CartToClassAssociation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CartToClassAssociation.</returns>
        public async System.Threading.Tasks.Task<CartToClassAssociation> CreateAsync(CartToClassAssociation cartToClassAssociationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<CartToClassAssociation>(cartToClassAssociationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CartToClassAssociation using POST and returns a <see cref="GraphResponse{CartToClassAssociation}"/> object.
        /// </summary>
        /// <param name="cartToClassAssociationToCreate">The CartToClassAssociation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CartToClassAssociation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CartToClassAssociation>> CreateResponseAsync(CartToClassAssociation cartToClassAssociationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<CartToClassAssociation>(cartToClassAssociationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CartToClassAssociation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<CartToClassAssociation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CartToClassAssociation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CartToClassAssociation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CartToClassAssociation.</returns>
        public async System.Threading.Tasks.Task<CartToClassAssociation> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<CartToClassAssociation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CartToClassAssociation and returns a <see cref="GraphResponse{CartToClassAssociation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CartToClassAssociation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CartToClassAssociation>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<CartToClassAssociation>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CartToClassAssociation using PATCH.
        /// </summary>
        /// <param name="cartToClassAssociationToUpdate">The CartToClassAssociation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CartToClassAssociation.</returns>
        public async System.Threading.Tasks.Task<CartToClassAssociation> UpdateAsync(CartToClassAssociation cartToClassAssociationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<CartToClassAssociation>(cartToClassAssociationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CartToClassAssociation using PATCH and returns a <see cref="GraphResponse{CartToClassAssociation}"/> object.
        /// </summary>
        /// <param name="cartToClassAssociationToUpdate">The CartToClassAssociation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CartToClassAssociation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CartToClassAssociation>> UpdateResponseAsync(CartToClassAssociation cartToClassAssociationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<CartToClassAssociation>(cartToClassAssociationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CartToClassAssociation using PUT.
        /// </summary>
        /// <param name="cartToClassAssociationToUpdate">The CartToClassAssociation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<CartToClassAssociation> PutAsync(CartToClassAssociation cartToClassAssociationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<CartToClassAssociation>(cartToClassAssociationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CartToClassAssociation using PUT and returns a <see cref="GraphResponse{CartToClassAssociation}"/> object.
        /// </summary>
        /// <param name="cartToClassAssociationToUpdate">The CartToClassAssociation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{CartToClassAssociation}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CartToClassAssociation>> PutResponseAsync(CartToClassAssociation cartToClassAssociationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<CartToClassAssociation>(cartToClassAssociationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICartToClassAssociationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICartToClassAssociationRequest Expand(Expression<Func<CartToClassAssociation, object>> expandExpression)
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
        public ICartToClassAssociationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICartToClassAssociationRequest Select(Expression<Func<CartToClassAssociation, object>> selectExpression)
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
        /// <param name="cartToClassAssociationToInitialize">The <see cref="CartToClassAssociation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CartToClassAssociation cartToClassAssociationToInitialize)
        {

        }
    }
}
