// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface ITenantGroupTenantSearchCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<TenantGroupTenantSearchCollectionPage>))]
    public interface ITenantGroupTenantSearchCollectionPage : Microsoft.Graph.ICollectionPage<TenantGroup>
    {
        /// <summary>
        /// Gets the next page <see cref="ITenantGroupTenantSearchRequest"/> instance.
        /// </summary>
        ITenantGroupTenantSearchRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
