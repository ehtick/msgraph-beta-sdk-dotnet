// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IDeviceManagementResourceAccessProfilesCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<DeviceManagementResourceAccessProfilesCollectionPage>))]
    public interface IDeviceManagementResourceAccessProfilesCollectionPage : ICollectionPage<DeviceManagementResourceAccessProfileBase>
    {
        /// <summary>
        /// Gets the next page <see cref="IDeviceManagementResourceAccessProfilesCollectionRequest"/> instance.
        /// </summary>
        IDeviceManagementResourceAccessProfilesCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
