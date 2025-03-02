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
    /// The type IosImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial class IosImportedPFXCertificateProfileRequest : BaseRequest, IIosImportedPFXCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new IosImportedPFXCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosImportedPFXCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToCreate">The IosImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> CreateAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IosImportedPFXCertificateProfile>(iosImportedPFXCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToCreate">The IosImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> CreateResponseAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IosImportedPFXCertificateProfile>(iosImportedPFXCertificateProfileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IosImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IosImportedPFXCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IosImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IosImportedPFXCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosImportedPFXCertificateProfile and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IosImportedPFXCertificateProfile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> UpdateAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IosImportedPFXCertificateProfile>(iosImportedPFXCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> UpdateResponseAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IosImportedPFXCertificateProfile>(iosImportedPFXCertificateProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PUT.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IosImportedPFXCertificateProfile> PutAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IosImportedPFXCertificateProfile>(iosImportedPFXCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosImportedPFXCertificateProfile using PUT and returns a <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosImportedPFXCertificateProfileToUpdate">The IosImportedPFXCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IosImportedPFXCertificateProfile}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosImportedPFXCertificateProfile>> PutResponseAsync(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IosImportedPFXCertificateProfile>(iosImportedPFXCertificateProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosImportedPFXCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosImportedPFXCertificateProfileRequest Expand(Expression<Func<IosImportedPFXCertificateProfile, object>> expandExpression)
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
        public IIosImportedPFXCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosImportedPFXCertificateProfileRequest Select(Expression<Func<IosImportedPFXCertificateProfile, object>> selectExpression)
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
        /// <param name="iosImportedPFXCertificateProfileToInitialize">The <see cref="IosImportedPFXCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosImportedPFXCertificateProfile iosImportedPFXCertificateProfileToInitialize)
        {

            if (iosImportedPFXCertificateProfileToInitialize != null)
            {
                if (iosImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates != null && iosImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.CurrentPage != null)
                {
                    iosImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.InitializeNextPageRequest(this.Client, iosImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStatesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    iosImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.AdditionalData = iosImportedPFXCertificateProfileToInitialize.AdditionalData;
                }

            }


        }
    }
}
