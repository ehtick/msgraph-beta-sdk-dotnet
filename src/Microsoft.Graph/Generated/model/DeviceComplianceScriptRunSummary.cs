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
    /// The type Device Compliance Script Run Summary.
    /// </summary>
    public partial class DeviceComplianceScriptRunSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets detection script error device count.
        /// Number of devices on which the detection script execution encountered an error and did not complete. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("detectionScriptErrorDeviceCount")]
        public Int32? DetectionScriptErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets detection script pending device count.
        /// Number of devices which have not yet run the latest version of the device compliance script. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("detectionScriptPendingDeviceCount")]
        public Int32? DetectionScriptPendingDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets issue detected device count.
        /// Number of devices for which the detection script found an issue. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("issueDetectedDeviceCount")]
        public Int32? IssueDetectedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets last script run date time.
        /// Last run time for the script across all devices
        /// </summary>
        [JsonPropertyName("lastScriptRunDateTime")]
        public DateTimeOffset? LastScriptRunDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets no issue detected device count.
        /// Number of devices for which the detection script did not find an issue and the device is healthy. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("noIssueDetectedDeviceCount")]
        public Int32? NoIssueDetectedDeviceCount { get; set; }
    
    }
}

