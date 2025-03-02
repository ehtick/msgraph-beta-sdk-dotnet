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
    /// The type AttributeMapping.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AttributeMapping>))]
    public partial class AttributeMapping
    {

        /// <summary>
        /// Gets or sets defaultValue.
        /// Default value to be used in case the source property was evaluated to null. Optional.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public string DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets exportMissingReferences.
        /// For internal use only.
        /// </summary>
        [JsonPropertyName("exportMissingReferences")]
        public bool? ExportMissingReferences { get; set; }
    
        /// <summary>
        /// Gets or sets flowBehavior.
        /// Defines when this attribute should be exported to the target directory. Possible values are: FlowWhenChanged and FlowAlways. Default is FlowWhenChanged.
        /// </summary>
        [JsonPropertyName("flowBehavior")]
        public AttributeFlowBehavior? FlowBehavior { get; set; }
    
        /// <summary>
        /// Gets or sets flowType.
        /// Defines when this attribute should be updated in the target directory. Possible values are: Always (default), ObjectAddOnly (only when new object is created), MultiValueAddOnly (only when the change is adding new values to a multi-valued attribute).
        /// </summary>
        [JsonPropertyName("flowType")]
        public AttributeFlowType? FlowType { get; set; }
    
        /// <summary>
        /// Gets or sets matchingPriority.
        /// If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
        /// </summary>
        [JsonPropertyName("matchingPriority")]
        public Int32? MatchingPriority { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// Defines how a value should be extracted (or transformed) from the source object.
        /// </summary>
        [JsonPropertyName("source")]
        public AttributeMappingSource Source { get; set; }
    
        /// <summary>
        /// Gets or sets targetAttributeName.
        /// Name of the attribute on the target object.
        /// </summary>
        [JsonPropertyName("targetAttributeName")]
        public string TargetAttributeName { get; set; }
    
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
