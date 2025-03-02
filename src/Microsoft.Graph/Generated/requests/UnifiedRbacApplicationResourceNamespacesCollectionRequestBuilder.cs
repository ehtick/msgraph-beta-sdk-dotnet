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
    /// The type UnifiedRbacApplicationResourceNamespacesCollectionRequestBuilder.
    /// </summary>
    public partial class UnifiedRbacApplicationResourceNamespacesCollectionRequestBuilder : BaseRequestBuilder, IUnifiedRbacApplicationResourceNamespacesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UnifiedRbacApplicationResourceNamespacesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UnifiedRbacApplicationResourceNamespacesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUnifiedRbacApplicationResourceNamespacesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUnifiedRbacApplicationResourceNamespacesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UnifiedRbacApplicationResourceNamespacesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUnifiedRbacResourceNamespaceRequestBuilder"/> for the specified UnifiedRbacApplicationUnifiedRbacResourceNamespace.
        /// </summary>
        /// <param name="id">The ID for the UnifiedRbacApplicationUnifiedRbacResourceNamespace.</param>
        /// <returns>The <see cref="IUnifiedRbacResourceNamespaceRequestBuilder"/>.</returns>
        public IUnifiedRbacResourceNamespaceRequestBuilder this[string id]
        {
            get
            {
                return new UnifiedRbacResourceNamespaceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
