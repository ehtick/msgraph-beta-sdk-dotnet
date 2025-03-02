// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;

    /// <summary>
    /// The type EdiscoveryReviewTagChildTagsCollectionWithReferencesPage.
    /// </summary>
    public partial class EdiscoveryReviewTagChildTagsCollectionWithReferencesPage : Microsoft.Graph.CollectionPage<EdiscoveryReviewTag>, IEdiscoveryReviewTagChildTagsCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IEdiscoveryReviewTagChildTagsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IEdiscoveryReviewTagChildTagsCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new EdiscoveryReviewTagChildTagsCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
