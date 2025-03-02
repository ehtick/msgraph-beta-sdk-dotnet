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
    /// The type Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Configuration>))]
    public partial class Configuration
    {

        /// <summary>
        /// Gets or sets authorizedAppIds.
        /// </summary>
        [JsonPropertyName("authorizedAppIds")]
        public IEnumerable<string> AuthorizedAppIds { get; set; }
    
        /// <summary>
        /// Gets or sets authorizedApps.
        /// </summary>
        [Obsolete("The property name 'authorizedApps' is being renamed to 'authorizedAppIds'. Please use the new property name, as 'authorizedApps' will be deprecated in Aug 2021.")]
        [JsonPropertyName("authorizedApps")]
        public IEnumerable<string> AuthorizedApps { get; set; }
    
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
