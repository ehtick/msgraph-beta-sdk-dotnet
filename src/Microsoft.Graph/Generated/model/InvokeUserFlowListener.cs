// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Invoke User Flow Listener.
    /// </summary>
    public partial class InvokeUserFlowListener : AuthenticationListener
    {
    
        ///<summary>
        /// The InvokeUserFlowListener constructor
        ///</summary>
        public InvokeUserFlowListener()
        {
            this.ODataType = "microsoft.graph.invokeUserFlowListener";
        }

        /// <summary>
        /// Gets or sets user flow.
        /// The user flow that is invoked when this action executes.
        /// </summary>
        [JsonPropertyName("userFlow")]
        public B2xIdentityUserFlow UserFlow { get; set; }
    
    }
}

