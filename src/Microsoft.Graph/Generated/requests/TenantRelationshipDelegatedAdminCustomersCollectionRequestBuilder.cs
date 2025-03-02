// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type TenantRelationshipDelegatedAdminCustomersCollectionRequestBuilder.
    /// </summary>
    public partial class TenantRelationshipDelegatedAdminCustomersCollectionRequestBuilder : BaseRequestBuilder, ITenantRelationshipDelegatedAdminCustomersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TenantRelationshipDelegatedAdminCustomersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TenantRelationshipDelegatedAdminCustomersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITenantRelationshipDelegatedAdminCustomersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITenantRelationshipDelegatedAdminCustomersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TenantRelationshipDelegatedAdminCustomersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDelegatedAdminCustomerRequestBuilder"/> for the specified TenantRelationshipDelegatedAdminCustomer.
        /// </summary>
        /// <param name="id">The ID for the TenantRelationshipDelegatedAdminCustomer.</param>
        /// <returns>The <see cref="IDelegatedAdminCustomerRequestBuilder"/>.</returns>
        public IDelegatedAdminCustomerRequestBuilder this[string id]
        {
            get
            {
                return new DelegatedAdminCustomerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
