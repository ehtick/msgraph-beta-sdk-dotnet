// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IManagedTenantAlertApiNotificationsCollectionWithReferencesPage.
    /// </summary>
    [InterfaceConverter(typeof(Microsoft.Graph.InterfaceConverter<ManagedTenantAlertApiNotificationsCollectionWithReferencesPage>))]
    public interface IManagedTenantAlertApiNotificationsCollectionWithReferencesPage : Microsoft.Graph.ICollectionPage<ManagedTenantApiNotification>
    {
        /// <summary>
        /// Gets the next page <see cref="IManagedTenantAlertApiNotificationsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        IManagedTenantAlertApiNotificationsCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
