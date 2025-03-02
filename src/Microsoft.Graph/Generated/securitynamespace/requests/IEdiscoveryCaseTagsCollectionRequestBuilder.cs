// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IEdiscoveryCaseTagsCollectionRequestBuilder.
    /// </summary>
    public partial interface IEdiscoveryCaseTagsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEdiscoveryCaseTagsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEdiscoveryCaseTagsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IEdiscoveryReviewTagRequestBuilder"/> for the specified EdiscoveryReviewTag.
        /// </summary>
        /// <param name="id">The ID for the EdiscoveryReviewTag.</param>
        /// <returns>The <see cref="IEdiscoveryReviewTagRequestBuilder"/>.</returns>
        IEdiscoveryReviewTagRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for EdiscoveryReviewTagAsHierarchy.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewTagAsHierarchyRequestBuilder"/>.</returns>
        IEdiscoveryReviewTagAsHierarchyRequestBuilder AsHierarchy();
    }
}
