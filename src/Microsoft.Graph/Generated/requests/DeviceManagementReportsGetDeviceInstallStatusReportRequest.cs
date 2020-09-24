// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type DeviceManagementReportsGetDeviceInstallStatusReportRequest.
    /// </summary>
    public partial class DeviceManagementReportsGetDeviceInstallStatusReportRequest : BaseRequest, IDeviceManagementReportsGetDeviceInstallStatusReportRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementReportsGetDeviceInstallStatusReportRequest.
        /// </summary>
        public DeviceManagementReportsGetDeviceInstallStatusReportRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = "application/json";
            this.RequestBody = new DeviceManagementReportsGetDeviceInstallStatusReportRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public DeviceManagementReportsGetDeviceInstallStatusReportRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public System.Threading.Tasks.Task<Stream> PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="httpCompletionOption">The <see cref="HttpCompletionOption"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<Stream> PostAsync(
            CancellationToken cancellationToken,
            HttpCompletionOption httpCompletionOption = HttpCompletionOption.ResponseContentRead)
        {
            this.Method = "POST";
            return this.SendStreamRequestAsync(null, cancellationToken, httpCompletionOption);
        }



    }
}
