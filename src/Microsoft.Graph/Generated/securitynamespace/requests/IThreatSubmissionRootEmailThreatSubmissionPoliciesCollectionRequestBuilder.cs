// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IThreatSubmissionRootEmailThreatSubmissionPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial interface IThreatSubmissionRootEmailThreatSubmissionPoliciesCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IThreatSubmissionRootEmailThreatSubmissionPoliciesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IThreatSubmissionRootEmailThreatSubmissionPoliciesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IEmailThreatSubmissionPolicyRequestBuilder"/> for the specified EmailThreatSubmissionPolicy.
        /// </summary>
        /// <param name="id">The ID for the EmailThreatSubmissionPolicy.</param>
        /// <returns>The <see cref="IEmailThreatSubmissionPolicyRequestBuilder"/>.</returns>
        IEmailThreatSubmissionPolicyRequestBuilder this[string id] { get; }

        
    }
}
