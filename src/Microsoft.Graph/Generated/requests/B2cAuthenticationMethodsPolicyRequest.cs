// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type B2cAuthenticationMethodsPolicyRequest.
    /// </summary>
    public partial class B2cAuthenticationMethodsPolicyRequest : BaseRequest, IB2cAuthenticationMethodsPolicyRequest
    {
        /// <summary>
        /// Constructs a new B2cAuthenticationMethodsPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public B2cAuthenticationMethodsPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified B2cAuthenticationMethodsPolicy using POST.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToCreate">The B2cAuthenticationMethodsPolicy to create.</param>
        /// <returns>The created B2cAuthenticationMethodsPolicy.</returns>
        public System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> CreateAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToCreate)
        {
            return this.CreateAsync(b2cAuthenticationMethodsPolicyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified B2cAuthenticationMethodsPolicy using POST.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToCreate">The B2cAuthenticationMethodsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created B2cAuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> CreateAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified B2cAuthenticationMethodsPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified B2cAuthenticationMethodsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<B2cAuthenticationMethodsPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified B2cAuthenticationMethodsPolicy.
        /// </summary>
        /// <returns>The B2cAuthenticationMethodsPolicy.</returns>
        public System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified B2cAuthenticationMethodsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The B2cAuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<B2cAuthenticationMethodsPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified B2cAuthenticationMethodsPolicy using PATCH.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToUpdate">The B2cAuthenticationMethodsPolicy to update.</param>
        /// <returns>The updated B2cAuthenticationMethodsPolicy.</returns>
        public System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> UpdateAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToUpdate)
        {
            return this.UpdateAsync(b2cAuthenticationMethodsPolicyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified B2cAuthenticationMethodsPolicy using PATCH.
        /// </summary>
        /// <param name="b2cAuthenticationMethodsPolicyToUpdate">The B2cAuthenticationMethodsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated B2cAuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<B2cAuthenticationMethodsPolicy> UpdateAsync(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToUpdate, CancellationToken cancellationToken)
        {
			if (b2cAuthenticationMethodsPolicyToUpdate.AdditionalData != null)
			{
				if (b2cAuthenticationMethodsPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					b2cAuthenticationMethodsPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, b2cAuthenticationMethodsPolicyToUpdate.GetType().Name)
						});
				}
			}
            if (b2cAuthenticationMethodsPolicyToUpdate.AdditionalData != null)
            {
                if (b2cAuthenticationMethodsPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    b2cAuthenticationMethodsPolicyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, b2cAuthenticationMethodsPolicyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<B2cAuthenticationMethodsPolicy>(b2cAuthenticationMethodsPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cAuthenticationMethodsPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cAuthenticationMethodsPolicyRequest Expand(Expression<Func<B2cAuthenticationMethodsPolicy, object>> expandExpression)
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
        public IB2cAuthenticationMethodsPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IB2cAuthenticationMethodsPolicyRequest Select(Expression<Func<B2cAuthenticationMethodsPolicy, object>> selectExpression)
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
        /// <param name="b2cAuthenticationMethodsPolicyToInitialize">The <see cref="B2cAuthenticationMethodsPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(B2cAuthenticationMethodsPolicy b2cAuthenticationMethodsPolicyToInitialize)
        {

        }
    }
}
