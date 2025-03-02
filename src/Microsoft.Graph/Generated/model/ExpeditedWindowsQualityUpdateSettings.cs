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
    /// The type ExpeditedWindowsQualityUpdateSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ExpeditedWindowsQualityUpdateSettings>))]
    public partial class ExpeditedWindowsQualityUpdateSettings
    {

        /// <summary>
        /// Gets or sets daysUntilForcedReboot.
        /// The number of days after installation that forced reboot will happen.
        /// </summary>
        [JsonPropertyName("daysUntilForcedReboot")]
        public Int32? DaysUntilForcedReboot { get; set; }
    
        /// <summary>
        /// Gets or sets qualityUpdateRelease.
        /// The release date to identify a quality update.
        /// </summary>
        [JsonPropertyName("qualityUpdateRelease")]
        public string QualityUpdateRelease { get; set; }
    
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
