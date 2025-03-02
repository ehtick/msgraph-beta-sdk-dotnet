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
    /// The type ClassificationJobResponseRequest.
    /// </summary>
    public partial class ClassificationJobResponseRequest : BaseRequest, IClassificationJobResponseRequest
    {
        /// <summary>
        /// Constructs a new ClassificationJobResponseRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ClassificationJobResponseRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ClassificationJobResponse using POST.
        /// </summary>
        /// <param name="classificationJobResponseToCreate">The ClassificationJobResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ClassificationJobResponse.</returns>
        public async System.Threading.Tasks.Task<ClassificationJobResponse> CreateAsync(ClassificationJobResponse classificationJobResponseToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ClassificationJobResponse>(classificationJobResponseToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ClassificationJobResponse using POST and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="classificationJobResponseToCreate">The ClassificationJobResponse to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ClassificationJobResponse}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> CreateResponseAsync(ClassificationJobResponse classificationJobResponseToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ClassificationJobResponse>(classificationJobResponseToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ClassificationJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ClassificationJobResponse>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ClassificationJobResponse and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ClassificationJobResponse.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ClassificationJobResponse.</returns>
        public async System.Threading.Tasks.Task<ClassificationJobResponse> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ClassificationJobResponse>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ClassificationJobResponse and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ClassificationJobResponse}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ClassificationJobResponse>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PATCH.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ClassificationJobResponse.</returns>
        public async System.Threading.Tasks.Task<ClassificationJobResponse> UpdateAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ClassificationJobResponse>(classificationJobResponseToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PATCH and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ClassificationJobResponse}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> UpdateResponseAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ClassificationJobResponse>(classificationJobResponseToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PUT.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ClassificationJobResponse> PutAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ClassificationJobResponse>(classificationJobResponseToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ClassificationJobResponse using PUT and returns a <see cref="GraphResponse{ClassificationJobResponse}"/> object.
        /// </summary>
        /// <param name="classificationJobResponseToUpdate">The ClassificationJobResponse object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ClassificationJobResponse}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ClassificationJobResponse>> PutResponseAsync(ClassificationJobResponse classificationJobResponseToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ClassificationJobResponse>(classificationJobResponseToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IClassificationJobResponseRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IClassificationJobResponseRequest Expand(Expression<Func<ClassificationJobResponse, object>> expandExpression)
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
        public IClassificationJobResponseRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IClassificationJobResponseRequest Select(Expression<Func<ClassificationJobResponse, object>> selectExpression)
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
        /// <param name="classificationJobResponseToInitialize">The <see cref="ClassificationJobResponse"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ClassificationJobResponse classificationJobResponseToInitialize)
        {

        }
    }
}
