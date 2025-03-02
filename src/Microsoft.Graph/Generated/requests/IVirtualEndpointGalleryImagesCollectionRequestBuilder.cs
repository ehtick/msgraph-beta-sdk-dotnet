// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IVirtualEndpointGalleryImagesCollectionRequestBuilder.
    /// </summary>
    public partial interface IVirtualEndpointGalleryImagesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICloudPcGalleryImageRequestBuilder"/> for the specified CloudPcGalleryImage.
        /// </summary>
        /// <param name="id">The ID for the CloudPcGalleryImage.</param>
        /// <returns>The <see cref="ICloudPcGalleryImageRequestBuilder"/>.</returns>
        ICloudPcGalleryImageRequestBuilder this[string id] { get; }

        
    }
}
