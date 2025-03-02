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
    /// The type Directory Definition.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DirectoryDefinition>))]
    public partial class DirectoryDefinition : Entity
    {
    
        /// <summary>
        /// Gets or sets discoverabilities.
        /// Read only value indicating what type of discovery the app supports. Possible values are: AttributeDataTypes, AttributeNames, AttributeReadOnly, None, ReferenceAttributes, UnknownFutureValue.
        /// </summary>
        [JsonPropertyName("discoverabilities")]
        public DirectoryDefinitionDiscoverabilities? Discoverabilities { get; set; }
    
        /// <summary>
        /// Gets or sets discovery date time.
        /// Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("discoveryDateTime")]
        public DateTimeOffset? DiscoveryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the directory. Must be unique within the synchronization schema. Not nullable.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets objects.
        /// Collection of objects supported by the directory.
        /// </summary>
        [JsonPropertyName("objects")]
        public IEnumerable<ObjectDefinition> Objects { get; set; }
    
        /// <summary>
        /// Gets or sets read only.
        /// </summary>
        [JsonPropertyName("readOnly")]
        public bool? ReadOnly { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Read only value that indicates version discovered. null if discovery has not yet occurred.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
    }
}

