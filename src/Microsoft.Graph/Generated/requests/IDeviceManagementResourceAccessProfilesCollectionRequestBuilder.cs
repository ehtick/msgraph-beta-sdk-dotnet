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
    /// The interface IDeviceManagementResourceAccessProfilesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementResourceAccessProfilesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementResourceAccessProfilesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementResourceAccessProfilesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceManagementResourceAccessProfileBaseRequestBuilder"/> for the specified DeviceManagementResourceAccessProfileBase.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementResourceAccessProfileBase.</param>
        /// <returns>The <see cref="IDeviceManagementResourceAccessProfileBaseRequestBuilder"/>.</returns>
        IDeviceManagementResourceAccessProfileBaseRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for DeviceManagementResourceAccessProfileBaseQueryByPlatformType.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementResourceAccessProfileBaseQueryByPlatformTypeRequestBuilder"/>.</returns>
        IDeviceManagementResourceAccessProfileBaseQueryByPlatformTypeRequestBuilder QueryByPlatformType(
            PolicyPlatformType platformType);
    }
}
