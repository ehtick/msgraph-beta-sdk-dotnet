// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsAppHealthAppPerformanceByOSVersionRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsAppHealthAppPerformanceByOSVersion.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsAppHealthAppPerformanceByOSVersion.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsAppHealthAppPerformanceByOSVersionRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsAppHealthAppPerformanceByOSVersionRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
