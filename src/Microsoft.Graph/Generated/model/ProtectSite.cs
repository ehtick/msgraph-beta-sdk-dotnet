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
    /// The type ProtectSite.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ProtectSite>))]
    public partial class ProtectSite : LabelActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectSite"/> class.
        /// </summary>
        public ProtectSite()
        {
            this.ODataType = "microsoft.graph.protectSite";
        }

        /// <summary>
        /// Gets or sets accessType.
        /// </summary>
        [JsonPropertyName("accessType")]
        public SiteAccessType? AccessType { get; set; }
    
        /// <summary>
        /// Gets or sets conditionalAccessProtectionLevelId.
        /// </summary>
        [JsonPropertyName("conditionalAccessProtectionLevelId")]
        public string ConditionalAccessProtectionLevelId { get; set; }
    
    }
}
