// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementConfigurationPolicyReorderRequestBuilder.
    /// </summary>
    public partial class DeviceManagementConfigurationPolicyReorderRequestBuilder : BaseActionMethodRequestBuilder<IDeviceManagementConfigurationPolicyReorderRequest>, IDeviceManagementConfigurationPolicyReorderRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DeviceManagementConfigurationPolicyReorderRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="priority">A priority parameter for the OData method call.</param>
        public DeviceManagementConfigurationPolicyReorderRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 priority)
            : base(requestUrl, client)
        {
            this.SetParameter("priority", priority, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDeviceManagementConfigurationPolicyReorderRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DeviceManagementConfigurationPolicyReorderRequest(functionUrl, this.Client, options);

            if (this.HasParameter("priority"))
            {
                request.RequestBody.Priority = this.GetParameter<Int32>("priority");
            }

            return request;
        }
    }
}
