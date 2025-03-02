// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ContentApprovalRule.
    /// </summary>
    public partial class ContentApprovalRule : ComplianceChangeRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentApprovalRule"/> class.
        /// </summary>
        public ContentApprovalRule()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.contentApprovalRule";
        }

        /// <summary>
        /// Gets or sets contentFilter.
        /// A filter to determine which content matches the rule on an ongoing basis.
        /// </summary>
        [JsonPropertyName("contentFilter")]
        public ContentFilter ContentFilter { get; set; }
    
        /// <summary>
        /// Gets or sets durationBeforeDeploymentStart.
        /// The time before the deployment starts represented in ISO 8601 format for durations.
        /// </summary>
        [JsonPropertyName("durationBeforeDeploymentStart")]
        public Microsoft.Graph.Duration DurationBeforeDeploymentStart { get; set; }
    
    }
}
