// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type OemWarrantyInformationOnboardingRequestBuilder.
    /// </summary>
    public partial class OemWarrantyInformationOnboardingRequestBuilder : EntityRequestBuilder, IOemWarrantyInformationOnboardingRequestBuilder
    {

        /// <summary>
        /// Constructs a new OemWarrantyInformationOnboardingRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OemWarrantyInformationOnboardingRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOemWarrantyInformationOnboardingRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOemWarrantyInformationOnboardingRequest Request(IEnumerable<Option> options)
        {
            return new OemWarrantyInformationOnboardingRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for OemWarrantyInformationOnboardingDisable.
        /// </summary>
        /// <returns>The <see cref="IOemWarrantyInformationOnboardingDisableRequestBuilder"/>.</returns>
        public IOemWarrantyInformationOnboardingDisableRequestBuilder Disable()
        {
            return new OemWarrantyInformationOnboardingDisableRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.disable"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for OemWarrantyInformationOnboardingEnable.
        /// </summary>
        /// <returns>The <see cref="IOemWarrantyInformationOnboardingEnableRequestBuilder"/>.</returns>
        public IOemWarrantyInformationOnboardingEnableRequestBuilder Enable()
        {
            return new OemWarrantyInformationOnboardingEnableRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.enable"),
                this.Client);
        }
    
    }
}
