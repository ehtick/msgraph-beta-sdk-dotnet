// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IEdiscoveryFileTagsCollectionWithReferencesPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<EdiscoveryFileTagsCollectionWithReferencesPage>))]
    public interface IEdiscoveryFileTagsCollectionWithReferencesPage : Microsoft.Graph.ICollectionPage<EdiscoveryReviewTag>
    {
        /// <summary>
        /// Gets the next page <see cref="IEdiscoveryFileTagsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        IEdiscoveryFileTagsCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
