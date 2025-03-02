// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WorkflowRequest.
    /// </summary>
    public partial class WorkflowRequest : Microsoft.Graph.BaseRequest, IWorkflowRequest
    {
        /// <summary>
        /// Constructs a new WorkflowRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkflowRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Workflow using POST.
        /// </summary>
        /// <param name="workflowToCreate">The Workflow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Workflow.</returns>
        public async System.Threading.Tasks.Task<Workflow> CreateAsync(Workflow workflowToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Workflow>(workflowToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Workflow using POST and returns a <see cref="GraphResponse{Workflow}"/> object.
        /// </summary>
        /// <param name="workflowToCreate">The Workflow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Workflow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Workflow>> CreateResponseAsync(Workflow workflowToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Workflow>(workflowToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Workflow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Workflow>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Workflow and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Workflow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Workflow.</returns>
        public async System.Threading.Tasks.Task<Workflow> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Workflow>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Workflow and returns a <see cref="GraphResponse{Workflow}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Workflow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Workflow>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Workflow>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Workflow using PATCH.
        /// </summary>
        /// <param name="workflowToUpdate">The Workflow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Workflow.</returns>
        public async System.Threading.Tasks.Task<Workflow> UpdateAsync(Workflow workflowToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Workflow>(workflowToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Workflow using PATCH and returns a <see cref="GraphResponse{Workflow}"/> object.
        /// </summary>
        /// <param name="workflowToUpdate">The Workflow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Workflow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Workflow>> UpdateResponseAsync(Workflow workflowToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Workflow>(workflowToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Workflow using PUT.
        /// </summary>
        /// <param name="workflowToUpdate">The Workflow object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Workflow> PutAsync(Workflow workflowToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Workflow>(workflowToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Workflow using PUT and returns a <see cref="GraphResponse{Workflow}"/> object.
        /// </summary>
        /// <param name="workflowToUpdate">The Workflow object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Workflow}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Workflow>> PutResponseAsync(Workflow workflowToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Workflow>(workflowToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkflowRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkflowRequest Expand(Expression<Func<Workflow, object>> expandExpression)
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
        public IWorkflowRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkflowRequest Select(Expression<Func<Workflow, object>> selectExpression)
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
        /// <param name="workflowToInitialize">The <see cref="Workflow"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Workflow workflowToInitialize)
        {

            if (workflowToInitialize != null)
            {
                if (workflowToInitialize.ExecutionScope != null && workflowToInitialize.ExecutionScope.CurrentPage != null)
                {
                    workflowToInitialize.ExecutionScope.InitializeNextPageRequest(this.Client, workflowToInitialize.ExecutionScopeNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    workflowToInitialize.ExecutionScope.AdditionalData = workflowToInitialize.AdditionalData;
                }
                if (workflowToInitialize.Runs != null && workflowToInitialize.Runs.CurrentPage != null)
                {
                    workflowToInitialize.Runs.InitializeNextPageRequest(this.Client, workflowToInitialize.RunsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    workflowToInitialize.Runs.AdditionalData = workflowToInitialize.AdditionalData;
                }
                if (workflowToInitialize.TaskReports != null && workflowToInitialize.TaskReports.CurrentPage != null)
                {
                    workflowToInitialize.TaskReports.InitializeNextPageRequest(this.Client, workflowToInitialize.TaskReportsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    workflowToInitialize.TaskReports.AdditionalData = workflowToInitialize.AdditionalData;
                }
                if (workflowToInitialize.UserProcessingResults != null && workflowToInitialize.UserProcessingResults.CurrentPage != null)
                {
                    workflowToInitialize.UserProcessingResults.InitializeNextPageRequest(this.Client, workflowToInitialize.UserProcessingResultsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    workflowToInitialize.UserProcessingResults.AdditionalData = workflowToInitialize.AdditionalData;
                }
                if (workflowToInitialize.Versions != null && workflowToInitialize.Versions.CurrentPage != null)
                {
                    workflowToInitialize.Versions.InitializeNextPageRequest(this.Client, workflowToInitialize.VersionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    workflowToInitialize.Versions.AdditionalData = workflowToInitialize.AdditionalData;
                }

            }


        }
    }
}
