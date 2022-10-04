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
    /// The type CloudPcReportsRequest.
    /// </summary>
    public partial class CloudPcReportsRequest : BaseRequest, ICloudPcReportsRequest
    {
        /// <summary>
        /// Constructs a new CloudPcReportsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CloudPcReportsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CloudPcReports using POST.
        /// </summary>
        /// <param name="cloudPcReportsToCreate">The CloudPcReports to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcReports.</returns>
        public async System.Threading.Tasks.Task<CloudPcReports> CreateAsync(CloudPcReports cloudPcReportsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<CloudPcReports>(cloudPcReportsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CloudPcReports using POST and returns a <see cref="GraphResponse{CloudPcReports}"/> object.
        /// </summary>
        /// <param name="cloudPcReportsToCreate">The CloudPcReports to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcReports}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcReports>> CreateResponseAsync(CloudPcReports cloudPcReportsToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<CloudPcReports>(cloudPcReportsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified CloudPcReports.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<CloudPcReports>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudPcReports and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified CloudPcReports.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcReports.</returns>
        public async System.Threading.Tasks.Task<CloudPcReports> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<CloudPcReports>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CloudPcReports and returns a <see cref="GraphResponse{CloudPcReports}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcReports}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcReports>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<CloudPcReports>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudPcReports using PATCH.
        /// </summary>
        /// <param name="cloudPcReportsToUpdate">The CloudPcReports to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcReports.</returns>
        public async System.Threading.Tasks.Task<CloudPcReports> UpdateAsync(CloudPcReports cloudPcReportsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<CloudPcReports>(cloudPcReportsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcReports using PATCH and returns a <see cref="GraphResponse{CloudPcReports}"/> object.
        /// </summary>
        /// <param name="cloudPcReportsToUpdate">The CloudPcReports to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcReports}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcReports>> UpdateResponseAsync(CloudPcReports cloudPcReportsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<CloudPcReports>(cloudPcReportsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified CloudPcReports using PUT.
        /// </summary>
        /// <param name="cloudPcReportsToUpdate">The CloudPcReports object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<CloudPcReports> PutAsync(CloudPcReports cloudPcReportsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<CloudPcReports>(cloudPcReportsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcReports using PUT and returns a <see cref="GraphResponse{CloudPcReports}"/> object.
        /// </summary>
        /// <param name="cloudPcReportsToUpdate">The CloudPcReports object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{CloudPcReports}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcReports>> PutResponseAsync(CloudPcReports cloudPcReportsToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<CloudPcReports>(cloudPcReportsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcReportsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcReportsRequest Expand(Expression<Func<CloudPcReports, object>> expandExpression)
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
        public ICloudPcReportsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcReportsRequest Select(Expression<Func<CloudPcReports, object>> selectExpression)
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
        /// <param name="cloudPcReportsToInitialize">The <see cref="CloudPcReports"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CloudPcReports cloudPcReportsToInitialize)
        {

            if (cloudPcReportsToInitialize != null)
            {
                if (cloudPcReportsToInitialize.ExportJobs != null && cloudPcReportsToInitialize.ExportJobs.CurrentPage != null)
                {
                    cloudPcReportsToInitialize.ExportJobs.InitializeNextPageRequest(this.Client, cloudPcReportsToInitialize.ExportJobsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    cloudPcReportsToInitialize.ExportJobs.AdditionalData = cloudPcReportsToInitialize.AdditionalData;
                }

            }


        }
    }
}
