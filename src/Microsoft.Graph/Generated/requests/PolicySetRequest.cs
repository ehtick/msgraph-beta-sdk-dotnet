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
    /// The type PolicySetRequest.
    /// </summary>
    public partial class PolicySetRequest : BaseRequest, IPolicySetRequest
    {
        /// <summary>
        /// Constructs a new PolicySetRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PolicySetRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PolicySet using POST.
        /// </summary>
        /// <param name="policySetToCreate">The PolicySet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PolicySet.</returns>
        public async System.Threading.Tasks.Task<PolicySet> CreateAsync(PolicySet policySetToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<PolicySet>(policySetToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PolicySet using POST and returns a <see cref="GraphResponse{PolicySet}"/> object.
        /// </summary>
        /// <param name="policySetToCreate">The PolicySet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PolicySet}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicySet>> CreateResponseAsync(PolicySet policySetToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<PolicySet>(policySetToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified PolicySet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<PolicySet>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PolicySet and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified PolicySet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PolicySet.</returns>
        public async System.Threading.Tasks.Task<PolicySet> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<PolicySet>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PolicySet and returns a <see cref="GraphResponse{PolicySet}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PolicySet}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicySet>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<PolicySet>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PolicySet using PATCH.
        /// </summary>
        /// <param name="policySetToUpdate">The PolicySet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PolicySet.</returns>
        public async System.Threading.Tasks.Task<PolicySet> UpdateAsync(PolicySet policySetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<PolicySet>(policySetToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PolicySet using PATCH and returns a <see cref="GraphResponse{PolicySet}"/> object.
        /// </summary>
        /// <param name="policySetToUpdate">The PolicySet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PolicySet}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicySet>> UpdateResponseAsync(PolicySet policySetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<PolicySet>(policySetToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PolicySet using PUT.
        /// </summary>
        /// <param name="policySetToUpdate">The PolicySet object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<PolicySet> PutAsync(PolicySet policySetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<PolicySet>(policySetToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PolicySet using PUT and returns a <see cref="GraphResponse{PolicySet}"/> object.
        /// </summary>
        /// <param name="policySetToUpdate">The PolicySet object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{PolicySet}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicySet>> PutResponseAsync(PolicySet policySetToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<PolicySet>(policySetToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicySetRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicySetRequest Expand(Expression<Func<PolicySet, object>> expandExpression)
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
        public IPolicySetRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicySetRequest Select(Expression<Func<PolicySet, object>> selectExpression)
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
        /// <param name="policySetToInitialize">The <see cref="PolicySet"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PolicySet policySetToInitialize)
        {

            if (policySetToInitialize != null)
            {
                if (policySetToInitialize.Assignments != null && policySetToInitialize.Assignments.CurrentPage != null)
                {
                    policySetToInitialize.Assignments.InitializeNextPageRequest(this.Client, policySetToInitialize.AssignmentsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    policySetToInitialize.Assignments.AdditionalData = policySetToInitialize.AdditionalData;
                }
                if (policySetToInitialize.Items != null && policySetToInitialize.Items.CurrentPage != null)
                {
                    policySetToInitialize.Items.InitializeNextPageRequest(this.Client, policySetToInitialize.ItemsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    policySetToInitialize.Items.AdditionalData = policySetToInitialize.AdditionalData;
                }

            }


        }
    }
}
