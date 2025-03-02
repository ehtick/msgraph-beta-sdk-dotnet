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
    /// The type DelegatedAdminCustomerServiceManagementDetailsCollectionRequestBuilder.
    /// </summary>
    public partial class DelegatedAdminCustomerServiceManagementDetailsCollectionRequestBuilder : BaseRequestBuilder, IDelegatedAdminCustomerServiceManagementDetailsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DelegatedAdminCustomerServiceManagementDetailsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DelegatedAdminCustomerServiceManagementDetailsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDelegatedAdminCustomerServiceManagementDetailsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDelegatedAdminCustomerServiceManagementDetailsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DelegatedAdminCustomerServiceManagementDetailsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDelegatedAdminServiceManagementDetailRequestBuilder"/> for the specified DelegatedAdminCustomerDelegatedAdminServiceManagementDetail.
        /// </summary>
        /// <param name="id">The ID for the DelegatedAdminCustomerDelegatedAdminServiceManagementDetail.</param>
        /// <returns>The <see cref="IDelegatedAdminServiceManagementDetailRequestBuilder"/>.</returns>
        public IDelegatedAdminServiceManagementDetailRequestBuilder this[string id]
        {
            get
            {
                return new DelegatedAdminServiceManagementDetailRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
