// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IVirtualEndpointGalleryImagesCollectionRequest.
    /// </summary>
    public partial interface IVirtualEndpointGalleryImagesCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified CloudPcGalleryImage to the collection via POST.
        /// </summary>
        /// <param name="cloudPcGalleryImage">The CloudPcGalleryImage to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcGalleryImage.</returns>
        System.Threading.Tasks.Task<CloudPcGalleryImage> AddAsync(CloudPcGalleryImage cloudPcGalleryImage, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified CloudPcGalleryImage to the collection via POST and returns a <see cref="GraphResponse{CloudPcGalleryImage}"/> object of the request.
        /// </summary>
        /// <param name="cloudPcGalleryImage">The CloudPcGalleryImage to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcGalleryImage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcGalleryImage>> AddResponseAsync(CloudPcGalleryImage cloudPcGalleryImage, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IVirtualEndpointGalleryImagesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{VirtualEndpointGalleryImagesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VirtualEndpointGalleryImagesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<VirtualEndpointGalleryImagesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Expand(Expression<Func<CloudPcGalleryImage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Select(Expression<Func<CloudPcGalleryImage, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointGalleryImagesCollectionRequest OrderBy(string value);
    }
}
