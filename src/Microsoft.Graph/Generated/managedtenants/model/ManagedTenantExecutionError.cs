// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ManagedTenantExecutionError.
    /// </summary>
    public partial class ManagedTenantExecutionError : ManagedTenantOperationError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedTenantExecutionError"/> class.
        /// </summary>
        public ManagedTenantExecutionError()
        {
            this.ODataType = "microsoft.graph.managedTenants.managedTenantExecutionError";
        }

        /// <summary>
        /// Gets or sets errorDetails.
        /// Additional error information for the exception. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("errorDetails")]
        public string ErrorDetails { get; set; }
    
        /// <summary>
        /// Gets or sets nodeId.
        /// The node identifier where the exception occurred. Required. Read-only.
        /// </summary>
        [JsonPropertyName("nodeId")]
        public Int32? NodeId { get; set; }
    
        /// <summary>
        /// Gets or sets rawToken.
        /// The token for the exception. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("rawToken")]
        public string RawToken { get; set; }
    
        /// <summary>
        /// Gets or sets statementIndex.
        /// The statement index for the exception. Required. Read-only.
        /// </summary>
        [JsonPropertyName("statementIndex")]
        public Int32? StatementIndex { get; set; }
    
    }
}
