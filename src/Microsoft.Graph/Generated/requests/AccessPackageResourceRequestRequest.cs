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
    /// The type AccessPackageResourceRequestRequest.
    /// </summary>
    public partial class AccessPackageResourceRequestRequest : BaseRequest, IAccessPackageResourceRequestRequest
    {
        /// <summary>
        /// Constructs a new AccessPackageResourceRequestRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessPackageResourceRequestRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessPackageResourceRequestObject using POST.
        /// </summary>
        /// <param name="accessPackageResourceRequestObjectToCreate">The AccessPackageResourceRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageResourceRequestObject.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResourceRequestObject> CreateAsync(AccessPackageResourceRequestObject accessPackageResourceRequestObjectToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AccessPackageResourceRequestObject>(accessPackageResourceRequestObjectToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AccessPackageResourceRequestObject using POST and returns a <see cref="GraphResponse{AccessPackageResourceRequestObject}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceRequestObjectToCreate">The AccessPackageResourceRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceRequestObject>> CreateResponseAsync(AccessPackageResourceRequestObject accessPackageResourceRequestObjectToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AccessPackageResourceRequestObject>(accessPackageResourceRequestObjectToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AccessPackageResourceRequest.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AccessPackageResourceRequestObject>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessPackageResourceRequest and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AccessPackageResourceRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageResourceRequestObject.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResourceRequestObject> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AccessPackageResourceRequestObject>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessPackageResourceRequestObject and returns a <see cref="GraphResponse{AccessPackageResourceRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AccessPackageResourceRequestObject>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessPackageResourceRequestObject using PATCH.
        /// </summary>
        /// <param name="accessPackageResourceRequestObjectToUpdate">The AccessPackageResourceRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageResourceRequestObject.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResourceRequestObject> UpdateAsync(AccessPackageResourceRequestObject accessPackageResourceRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AccessPackageResourceRequestObject>(accessPackageResourceRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackageResourceRequestObject using PATCH and returns a <see cref="GraphResponse{AccessPackageResourceRequestObject}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceRequestObjectToUpdate">The AccessPackageResourceRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageResourceRequestObject}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceRequestObject>> UpdateResponseAsync(AccessPackageResourceRequestObject accessPackageResourceRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AccessPackageResourceRequestObject>(accessPackageResourceRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessPackageResourceRequestObject using PUT.
        /// </summary>
        /// <param name="accessPackageResourceRequestObjectToUpdate">The AccessPackageResourceRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AccessPackageResourceRequestObject> PutAsync(AccessPackageResourceRequestObject accessPackageResourceRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AccessPackageResourceRequestObject>(accessPackageResourceRequestObjectToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackageResourceRequestObject using PUT and returns a <see cref="GraphResponse{AccessPackageResourceRequestObject}"/> object.
        /// </summary>
        /// <param name="accessPackageResourceRequestObjectToUpdate">The AccessPackageResourceRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AccessPackageResourceRequestObject}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageResourceRequestObject>> PutResponseAsync(AccessPackageResourceRequestObject accessPackageResourceRequestObjectToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AccessPackageResourceRequestObject>(accessPackageResourceRequestObjectToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceRequestRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceRequestRequest Expand(Expression<Func<AccessPackageResourceRequestObject, object>> expandExpression)
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
        public IAccessPackageResourceRequestRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageResourceRequestRequest Select(Expression<Func<AccessPackageResourceRequestObject, object>> selectExpression)
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
        /// <param name="accessPackageResourceRequestObjectToInitialize">The <see cref="AccessPackageResourceRequestObject"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessPackageResourceRequestObject accessPackageResourceRequestObjectToInitialize)
        {

        }
    }
}
