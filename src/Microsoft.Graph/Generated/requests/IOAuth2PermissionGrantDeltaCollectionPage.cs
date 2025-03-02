// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IOAuth2PermissionGrantDeltaCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<OAuth2PermissionGrantDeltaCollectionPage>))]
    public interface IOAuth2PermissionGrantDeltaCollectionPage : ICollectionPage<OAuth2PermissionGrant>
    {
        /// <summary>
        /// Gets the next page <see cref="IOAuth2PermissionGrantDeltaRequest"/> instance.
        /// </summary>
        IOAuth2PermissionGrantDeltaRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
