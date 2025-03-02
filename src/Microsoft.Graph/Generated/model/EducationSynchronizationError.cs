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
    /// The type Education Synchronization Error.
    /// </summary>
    public partial class EducationSynchronizationError : Entity
    {
    
        /// <summary>
        /// Gets or sets entry type.
        /// Represents the sync entity (school, section, student, teacher).
        /// </summary>
        [JsonPropertyName("entryType")]
        public string EntryType { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// Represents the error code for this error.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets error message.
        /// Contains a description of the error.
        /// </summary>
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Gets or sets joining value.
        /// The unique identifier for the entry.
        /// </summary>
        [JsonPropertyName("joiningValue")]
        public string JoiningValue { get; set; }
    
        /// <summary>
        /// Gets or sets recorded date time.
        /// The time of occurrence of this error.
        /// </summary>
        [JsonPropertyName("recordedDateTime")]
        public DateTimeOffset? RecordedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reportable identifier.
        /// The identifier of this error entry.
        /// </summary>
        [JsonPropertyName("reportableIdentifier")]
        public string ReportableIdentifier { get; set; }
    
    }
}

