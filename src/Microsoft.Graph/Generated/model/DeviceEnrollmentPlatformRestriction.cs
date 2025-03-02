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
    /// The type DeviceEnrollmentPlatformRestriction.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceEnrollmentPlatformRestriction>))]
    public partial class DeviceEnrollmentPlatformRestriction
    {

        /// <summary>
        /// Gets or sets blockedManufacturers.
        /// Collection of blocked Manufacturers.
        /// </summary>
        [JsonPropertyName("blockedManufacturers")]
        public IEnumerable<string> BlockedManufacturers { get; set; }
    
        /// <summary>
        /// Gets or sets blockedSkus.
        /// Collection of blocked Skus.
        /// </summary>
        [JsonPropertyName("blockedSkus")]
        public IEnumerable<string> BlockedSkus { get; set; }
    
        /// <summary>
        /// Gets or sets osMaximumVersion.
        /// Max OS version supported
        /// </summary>
        [JsonPropertyName("osMaximumVersion")]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets osMinimumVersion.
        /// Min OS version supported
        /// </summary>
        [JsonPropertyName("osMinimumVersion")]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets personalDeviceEnrollmentBlocked.
        /// Block personally owned devices from enrolling
        /// </summary>
        [JsonPropertyName("personalDeviceEnrollmentBlocked")]
        public bool? PersonalDeviceEnrollmentBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets platformBlocked.
        /// Block the platform from enrolling
        /// </summary>
        [JsonPropertyName("platformBlocked")]
        public bool? PlatformBlocked { get; set; }
    
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
