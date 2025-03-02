// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CustomTaskExtensionCalloutData.
    /// </summary>
    public partial class CustomTaskExtensionCalloutData : Microsoft.Graph.CustomExtensionData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTaskExtensionCalloutData"/> class.
        /// </summary>
        public CustomTaskExtensionCalloutData()
        {
            this.ODataType = "microsoft.graph.identityGovernance.customTaskExtensionCalloutData";
        }

        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public Microsoft.Graph.User Subject { get; set; }
    
        /// <summary>
        /// Gets or sets task.
        /// </summary>
        [JsonPropertyName("task")]
        public TaskObject @Task { get; set; }
    
        /// <summary>
        /// Gets or sets taskProcessingresult.
        /// </summary>
        [JsonPropertyName("taskProcessingresult")]
        public TaskProcessingResult TaskProcessingresult { get; set; }
    
        /// <summary>
        /// Gets or sets workflow.
        /// </summary>
        [JsonPropertyName("workflow")]
        public Workflow Workflow { get; set; }
    
    }
}
