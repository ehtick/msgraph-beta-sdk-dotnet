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
    /// The type DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
