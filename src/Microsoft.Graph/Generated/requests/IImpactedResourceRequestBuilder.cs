// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IImpactedResourceRequestBuilder.
    /// </summary>
    public partial interface IImpactedResourceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IImpactedResourceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IImpactedResourceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ImpactedResourceComplete.
        /// </summary>
        /// <returns>The <see cref="IImpactedResourceCompleteRequestBuilder"/>.</returns>
        IImpactedResourceCompleteRequestBuilder Complete();

        /// <summary>
        /// Gets the request builder for ImpactedResourceDismiss.
        /// </summary>
        /// <returns>The <see cref="IImpactedResourceDismissRequestBuilder"/>.</returns>
        IImpactedResourceDismissRequestBuilder Dismiss(
            string dismissReason = null);

        /// <summary>
        /// Gets the request builder for ImpactedResourcePostpone.
        /// </summary>
        /// <returns>The <see cref="IImpactedResourcePostponeRequestBuilder"/>.</returns>
        IImpactedResourcePostponeRequestBuilder Postpone(
            DateTimeOffset postponeUntilDateTime);

        /// <summary>
        /// Gets the request builder for ImpactedResourceReactivate.
        /// </summary>
        /// <returns>The <see cref="IImpactedResourceReactivateRequestBuilder"/>.</returns>
        IImpactedResourceReactivateRequestBuilder Reactivate();
    
    }
}
