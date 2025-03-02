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
    /// The type EntitlementManagementSubjectsCollectionRequestBuilder.
    /// </summary>
    public partial class EntitlementManagementSubjectsCollectionRequestBuilder : BaseRequestBuilder, IEntitlementManagementSubjectsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EntitlementManagementSubjectsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EntitlementManagementSubjectsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEntitlementManagementSubjectsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEntitlementManagementSubjectsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EntitlementManagementSubjectsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessPackageSubjectRequestBuilder"/> for the specified EntitlementManagementAccessPackageSubject.
        /// </summary>
        /// <param name="id">The ID for the EntitlementManagementAccessPackageSubject.</param>
        /// <returns>The <see cref="IAccessPackageSubjectRequestBuilder"/>.</returns>
        public IAccessPackageSubjectRequestBuilder this[string id]
        {
            get
            {
                return new AccessPackageSubjectRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
