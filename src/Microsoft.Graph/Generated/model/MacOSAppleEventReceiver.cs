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
    /// The type MacOSAppleEventReceiver.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSAppleEventReceiver>))]
    public partial class MacOSAppleEventReceiver
    {

        /// <summary>
        /// Gets or sets allowed.
        /// Allow or block this app from receiving Apple events.
        /// </summary>
        [JsonPropertyName("allowed")]
        public bool? Allowed { get; set; }
    
        /// <summary>
        /// Gets or sets codeRequirement.
        /// Code requirement for the app or binary that receives the Apple Event.
        /// </summary>
        [JsonPropertyName("codeRequirement")]
        public string CodeRequirement { get; set; }
    
        /// <summary>
        /// Gets or sets identifier.
        /// Bundle ID of the app or file path of the process or executable that receives the Apple Event.
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    
        /// <summary>
        /// Gets or sets identifierType.
        /// Use bundle ID for an app or path for a process or executable that receives the Apple Event. Possible values are: bundleID, path.
        /// </summary>
        [JsonPropertyName("identifierType")]
        public MacOSProcessIdentifierType? IdentifierType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
