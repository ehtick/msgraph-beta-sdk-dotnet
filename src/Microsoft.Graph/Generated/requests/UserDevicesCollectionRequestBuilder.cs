// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserDevicesCollectionRequestBuilder.
    /// </summary>
    public partial class UserDevicesCollectionRequestBuilder : BaseRequestBuilder, IUserDevicesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserDevicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserDevicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserDevicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserDevicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserDevicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceRequestBuilder"/> for the specified UserDevice.
        /// </summary>
        /// <param name="id">The ID for the UserDevice.</param>
        /// <returns>The <see cref="IDeviceRequestBuilder"/>.</returns>
        public IDeviceRequestBuilder this[string id]
        {
            get
            {
                return new DeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceDelta.
        /// </summary>
        /// <returns>The <see cref="IDeviceDeltaRequestBuilder"/>.</returns>
        public IDeviceDeltaRequestBuilder Delta()
        {
            return new DeviceDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}
