// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UpdatePolicyRequest.
    /// </summary>
    public partial class UpdatePolicyRequest : Microsoft.Graph.BaseRequest, IUpdatePolicyRequest
    {
        /// <summary>
        /// Constructs a new UpdatePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UpdatePolicyRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UpdatePolicy using POST.
        /// </summary>
        /// <param name="updatePolicyToCreate">The UpdatePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UpdatePolicy.</returns>
        public async System.Threading.Tasks.Task<UpdatePolicy> CreateAsync(UpdatePolicy updatePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UpdatePolicy>(updatePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UpdatePolicy using POST and returns a <see cref="GraphResponse{UpdatePolicy}"/> object.
        /// </summary>
        /// <param name="updatePolicyToCreate">The UpdatePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UpdatePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UpdatePolicy>> CreateResponseAsync(UpdatePolicy updatePolicyToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UpdatePolicy>(updatePolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UpdatePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UpdatePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UpdatePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UpdatePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UpdatePolicy.</returns>
        public async System.Threading.Tasks.Task<UpdatePolicy> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UpdatePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UpdatePolicy and returns a <see cref="GraphResponse{UpdatePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UpdatePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UpdatePolicy>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UpdatePolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UpdatePolicy using PATCH.
        /// </summary>
        /// <param name="updatePolicyToUpdate">The UpdatePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UpdatePolicy.</returns>
        public async System.Threading.Tasks.Task<UpdatePolicy> UpdateAsync(UpdatePolicy updatePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UpdatePolicy>(updatePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UpdatePolicy using PATCH and returns a <see cref="GraphResponse{UpdatePolicy}"/> object.
        /// </summary>
        /// <param name="updatePolicyToUpdate">The UpdatePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UpdatePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UpdatePolicy>> UpdateResponseAsync(UpdatePolicy updatePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UpdatePolicy>(updatePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UpdatePolicy using PUT.
        /// </summary>
        /// <param name="updatePolicyToUpdate">The UpdatePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UpdatePolicy> PutAsync(UpdatePolicy updatePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UpdatePolicy>(updatePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UpdatePolicy using PUT and returns a <see cref="GraphResponse{UpdatePolicy}"/> object.
        /// </summary>
        /// <param name="updatePolicyToUpdate">The UpdatePolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UpdatePolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UpdatePolicy>> PutResponseAsync(UpdatePolicy updatePolicyToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UpdatePolicy>(updatePolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUpdatePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUpdatePolicyRequest Expand(Expression<Func<UpdatePolicy, object>> expandExpression)
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
        public IUpdatePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUpdatePolicyRequest Select(Expression<Func<UpdatePolicy, object>> selectExpression)
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
        /// <param name="updatePolicyToInitialize">The <see cref="UpdatePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UpdatePolicy updatePolicyToInitialize)
        {

            if (updatePolicyToInitialize != null)
            {
                if (updatePolicyToInitialize.ComplianceChanges != null && updatePolicyToInitialize.ComplianceChanges.CurrentPage != null)
                {
                    updatePolicyToInitialize.ComplianceChanges.InitializeNextPageRequest(this.Client, updatePolicyToInitialize.ComplianceChangesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    updatePolicyToInitialize.ComplianceChanges.AdditionalData = updatePolicyToInitialize.AdditionalData;
                }

            }


        }
    }
}
