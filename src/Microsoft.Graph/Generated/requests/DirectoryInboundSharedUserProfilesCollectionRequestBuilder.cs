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
    /// The type DirectoryInboundSharedUserProfilesCollectionRequestBuilder.
    /// </summary>
    public partial class DirectoryInboundSharedUserProfilesCollectionRequestBuilder : BaseRequestBuilder, IDirectoryInboundSharedUserProfilesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DirectoryInboundSharedUserProfilesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DirectoryInboundSharedUserProfilesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDirectoryInboundSharedUserProfilesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDirectoryInboundSharedUserProfilesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DirectoryInboundSharedUserProfilesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IInboundSharedUserProfileRequestBuilder"/> for the specified DirectoryInboundSharedUserProfile.
        /// </summary>
        /// <param name="id">The ID for the DirectoryInboundSharedUserProfile.</param>
        /// <returns>The <see cref="IInboundSharedUserProfileRequestBuilder"/>.</returns>
        public IInboundSharedUserProfileRequestBuilder this[string id]
        {
            get
            {
                return new InboundSharedUserProfileRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
