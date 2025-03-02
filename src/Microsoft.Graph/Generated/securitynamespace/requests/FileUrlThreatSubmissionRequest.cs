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
    /// The type FileUrlThreatSubmissionRequest.
    /// </summary>
    public partial class FileUrlThreatSubmissionRequest : Microsoft.Graph.BaseRequest, IFileUrlThreatSubmissionRequest
    {
        /// <summary>
        /// Constructs a new FileUrlThreatSubmissionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public FileUrlThreatSubmissionRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified FileUrlThreatSubmission using POST.
        /// </summary>
        /// <param name="fileUrlThreatSubmissionToCreate">The FileUrlThreatSubmission to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FileUrlThreatSubmission.</returns>
        public async System.Threading.Tasks.Task<FileUrlThreatSubmission> CreateAsync(FileUrlThreatSubmission fileUrlThreatSubmissionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<FileUrlThreatSubmission>(fileUrlThreatSubmissionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified FileUrlThreatSubmission using POST and returns a <see cref="GraphResponse{FileUrlThreatSubmission}"/> object.
        /// </summary>
        /// <param name="fileUrlThreatSubmissionToCreate">The FileUrlThreatSubmission to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileUrlThreatSubmission}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileUrlThreatSubmission>> CreateResponseAsync(FileUrlThreatSubmission fileUrlThreatSubmissionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<FileUrlThreatSubmission>(fileUrlThreatSubmissionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified FileUrlThreatSubmission.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<FileUrlThreatSubmission>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified FileUrlThreatSubmission and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified FileUrlThreatSubmission.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FileUrlThreatSubmission.</returns>
        public async System.Threading.Tasks.Task<FileUrlThreatSubmission> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<FileUrlThreatSubmission>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified FileUrlThreatSubmission and returns a <see cref="GraphResponse{FileUrlThreatSubmission}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileUrlThreatSubmission}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileUrlThreatSubmission>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<FileUrlThreatSubmission>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified FileUrlThreatSubmission using PATCH.
        /// </summary>
        /// <param name="fileUrlThreatSubmissionToUpdate">The FileUrlThreatSubmission to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated FileUrlThreatSubmission.</returns>
        public async System.Threading.Tasks.Task<FileUrlThreatSubmission> UpdateAsync(FileUrlThreatSubmission fileUrlThreatSubmissionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<FileUrlThreatSubmission>(fileUrlThreatSubmissionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified FileUrlThreatSubmission using PATCH and returns a <see cref="GraphResponse{FileUrlThreatSubmission}"/> object.
        /// </summary>
        /// <param name="fileUrlThreatSubmissionToUpdate">The FileUrlThreatSubmission to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{FileUrlThreatSubmission}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileUrlThreatSubmission>> UpdateResponseAsync(FileUrlThreatSubmission fileUrlThreatSubmissionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<FileUrlThreatSubmission>(fileUrlThreatSubmissionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified FileUrlThreatSubmission using PUT.
        /// </summary>
        /// <param name="fileUrlThreatSubmissionToUpdate">The FileUrlThreatSubmission object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<FileUrlThreatSubmission> PutAsync(FileUrlThreatSubmission fileUrlThreatSubmissionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<FileUrlThreatSubmission>(fileUrlThreatSubmissionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified FileUrlThreatSubmission using PUT and returns a <see cref="GraphResponse{FileUrlThreatSubmission}"/> object.
        /// </summary>
        /// <param name="fileUrlThreatSubmissionToUpdate">The FileUrlThreatSubmission object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{FileUrlThreatSubmission}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<FileUrlThreatSubmission>> PutResponseAsync(FileUrlThreatSubmission fileUrlThreatSubmissionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<FileUrlThreatSubmission>(fileUrlThreatSubmissionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFileUrlThreatSubmissionRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFileUrlThreatSubmissionRequest Expand(Expression<Func<FileUrlThreatSubmission, object>> expandExpression)
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
        public IFileUrlThreatSubmissionRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IFileUrlThreatSubmissionRequest Select(Expression<Func<FileUrlThreatSubmission, object>> selectExpression)
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
        /// <param name="fileUrlThreatSubmissionToInitialize">The <see cref="FileUrlThreatSubmission"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(FileUrlThreatSubmission fileUrlThreatSubmissionToInitialize)
        {

        }
    }
}
