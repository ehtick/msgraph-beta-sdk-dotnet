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
    /// The type Sensitivity Policy Settings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SensitivityPolicySettings>))]
    public partial class SensitivityPolicySettings : Entity
    {
    
        /// <summary>
        /// Gets or sets applicable to.
        /// </summary>
        [JsonPropertyName("applicableTo")]
        public SensitivityLabelTarget? ApplicableTo { get; set; }
    
        /// <summary>
        /// Gets or sets downgrade sensitivity requires justification.
        /// </summary>
        [JsonPropertyName("downgradeSensitivityRequiresJustification")]
        public bool? DowngradeSensitivityRequiresJustification { get; set; }
    
        /// <summary>
        /// Gets or sets help web url.
        /// </summary>
        [JsonPropertyName("helpWebUrl")]
        public string HelpWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets is mandatory.
        /// </summary>
        [JsonPropertyName("isMandatory")]
        public bool? IsMandatory { get; set; }
    
    }
}

