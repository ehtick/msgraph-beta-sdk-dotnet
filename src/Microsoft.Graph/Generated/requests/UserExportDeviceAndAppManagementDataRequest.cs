// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type UserExportDeviceAndAppManagementDataRequest.
    /// </summary>
    public partial class UserExportDeviceAndAppManagementDataRequest : BaseRequest, IUserExportDeviceAndAppManagementDataRequest
    {
        /// <summary>
        /// Constructs a new UserExportDeviceAndAppManagementDataRequest.
        /// </summary>
        public UserExportDeviceAndAppManagementDataRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<DeviceAndAppManagementData> GetAsync(
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsync<DeviceAndAppManagementData>(null, cancellationToken);
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementData>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceAndAppManagementData>(null, cancellationToken);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<DeviceAndAppManagementData> PatchAsync(DeviceAndAppManagementData deviceandappmanagementdata,
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PATCH;
            return this.SendAsync<DeviceAndAppManagementData>(deviceandappmanagementdata, cancellationToken);
        }

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementData>> PatchResponseAsync(DeviceAndAppManagementData deviceandappmanagementdata, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceAndAppManagementData>(deviceandappmanagementdata, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<DeviceAndAppManagementData> PutAsync(DeviceAndAppManagementData deviceandappmanagementdata,
            CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            return this.SendAsync<DeviceAndAppManagementData>(deviceandappmanagementdata, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementData>> PutResponseAsync(DeviceAndAppManagementData deviceandappmanagementdata, CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceAndAppManagementData>(deviceandappmanagementdata, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExportDeviceAndAppManagementDataRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExportDeviceAndAppManagementDataRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
