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
    /// The type EmailAuthenticationMethodConfigurationRequest.
    /// </summary>
    public partial class EmailAuthenticationMethodConfigurationRequest : BaseRequest, IEmailAuthenticationMethodConfigurationRequest
    {
        /// <summary>
        /// Constructs a new EmailAuthenticationMethodConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EmailAuthenticationMethodConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EmailAuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToCreate">The EmailAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> CreateAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EmailAuthenticationMethodConfiguration using POST and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToCreate">The EmailAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> CreateResponseAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EmailAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EmailAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EmailAuthenticationMethodConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EmailAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EmailAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EmailAuthenticationMethodConfiguration and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EmailAuthenticationMethodConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmailAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> UpdateAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PATCH and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> UpdateResponseAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PUT.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> PutAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PUT and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> PutResponseAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailAuthenticationMethodConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailAuthenticationMethodConfigurationRequest Expand(Expression<Func<EmailAuthenticationMethodConfiguration, object>> expandExpression)
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
        public IEmailAuthenticationMethodConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailAuthenticationMethodConfigurationRequest Select(Expression<Func<EmailAuthenticationMethodConfiguration, object>> selectExpression)
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
        /// <param name="emailAuthenticationMethodConfigurationToInitialize">The <see cref="EmailAuthenticationMethodConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToInitialize)
        {

            if (emailAuthenticationMethodConfigurationToInitialize != null)
            {
                if (emailAuthenticationMethodConfigurationToInitialize.IncludeTargets != null && emailAuthenticationMethodConfigurationToInitialize.IncludeTargets.CurrentPage != null)
                {
                    emailAuthenticationMethodConfigurationToInitialize.IncludeTargets.InitializeNextPageRequest(this.Client, emailAuthenticationMethodConfigurationToInitialize.IncludeTargetsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    emailAuthenticationMethodConfigurationToInitialize.IncludeTargets.AdditionalData = emailAuthenticationMethodConfigurationToInitialize.AdditionalData;
                }

            }


        }
    }
}
