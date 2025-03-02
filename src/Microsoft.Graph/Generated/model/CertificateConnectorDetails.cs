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
    /// The type Certificate Connector Details.
    /// </summary>
    public partial class CertificateConnectorDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets connector name.
        /// Connector name (set during enrollment).
        /// </summary>
        [JsonPropertyName("connectorName")]
        public string ConnectorName { get; set; }
    
        /// <summary>
        /// Gets or sets connector version.
        /// Version of the connector installed.
        /// </summary>
        [JsonPropertyName("connectorVersion")]
        public string ConnectorVersion { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment date time.
        /// Date/time when this connector was enrolled.
        /// </summary>
        [JsonPropertyName("enrollmentDateTime")]
        public DateTimeOffset? EnrollmentDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last checkin date time.
        /// Date/time when this connector last connected to the service.
        /// </summary>
        [JsonPropertyName("lastCheckinDateTime")]
        public DateTimeOffset? LastCheckinDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets machine name.
        /// Name of the machine hosting this connector service.
        /// </summary>
        [JsonPropertyName("machineName")]
        public string MachineName { get; set; }
    
    }
}

