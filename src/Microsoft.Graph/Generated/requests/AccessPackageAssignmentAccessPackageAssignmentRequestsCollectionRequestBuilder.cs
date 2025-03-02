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
    /// The type AccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder.
    /// </summary>
    public partial class AccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder : BaseRequestBuilder, IAccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessPackageAssignmentRequestRequestBuilder"/> for the specified AccessPackageAssignmentAccessPackageAssignmentRequest.
        /// </summary>
        /// <param name="id">The ID for the AccessPackageAssignmentAccessPackageAssignmentRequest.</param>
        /// <returns>The <see cref="IAccessPackageAssignmentRequestRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentRequestRequestBuilder this[string id]
        {
            get
            {
                return new AccessPackageAssignmentRequestRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentRequestFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentRequestFilterByCurrentUserRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentRequestFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            AccessPackageAssignmentRequestFilterByCurrentUserOptions on)
        {
            return new AccessPackageAssignmentRequestFilterByCurrentUserRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.filterByCurrentUser"),
                this.Client,
                on);
        }
    }
}
