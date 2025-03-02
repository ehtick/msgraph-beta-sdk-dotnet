// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type KeyRealValuePair.
    /// </summary>
    public partial class KeyRealValuePair : KeyTypedValuePair
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyRealValuePair"/> class.
        /// </summary>
        public KeyRealValuePair()
        {
            this.ODataType = "microsoft.graph.keyRealValuePair";
        }

        /// <summary>
        /// Gets or sets value.
        /// The real (floating-point) value of the key-value pair.
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; set; }
    
    }
}
