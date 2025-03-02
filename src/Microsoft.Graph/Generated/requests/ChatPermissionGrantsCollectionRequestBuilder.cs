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
    /// The type ChatPermissionGrantsCollectionRequestBuilder.
    /// </summary>
    public partial class ChatPermissionGrantsCollectionRequestBuilder : BaseRequestBuilder, IChatPermissionGrantsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ChatPermissionGrantsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChatPermissionGrantsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IChatPermissionGrantsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IChatPermissionGrantsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ChatPermissionGrantsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IResourceSpecificPermissionGrantRequestBuilder"/> for the specified ChatResourceSpecificPermissionGrant.
        /// </summary>
        /// <param name="id">The ID for the ChatResourceSpecificPermissionGrant.</param>
        /// <returns>The <see cref="IResourceSpecificPermissionGrantRequestBuilder"/>.</returns>
        public IResourceSpecificPermissionGrantRequestBuilder this[string id]
        {
            get
            {
                return new ResourceSpecificPermissionGrantRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
