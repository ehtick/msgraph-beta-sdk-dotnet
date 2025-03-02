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
    /// The type Cloud Pc Snapshot.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcSnapshot>))]
    public partial class CloudPcSnapshot : Entity
    {
    
        /// <summary>
        /// Gets or sets cloud pc id.
        /// The unique identifier for the Cloud PC.
        /// </summary>
        [JsonPropertyName("cloudPcId")]
        public string CloudPcId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time at which the snapshot was taken. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last restored date time.
        /// The date and time at which the snapshot was last used to restore the Cloud PC device. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("lastRestoredDateTime")]
        public DateTimeOffset? LastRestoredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets snapshot type.
        /// </summary>
        [JsonPropertyName("snapshotType")]
        public CloudPcSnapshotType? SnapshotType { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the Cloud PC snapshot. The possible values are: ready, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public CloudPcSnapshotStatus? Status { get; set; }
    
    }
}

