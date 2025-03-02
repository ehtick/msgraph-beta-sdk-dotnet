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
    /// The type OfficeClientCheckinStatus.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OfficeClientCheckinStatus>))]
    public partial class OfficeClientCheckinStatus
    {

        /// <summary>
        /// Gets or sets appliedPolicies.
        /// List of policies delivered to the device as last checkin.
        /// </summary>
        [JsonPropertyName("appliedPolicies")]
        public IEnumerable<string> AppliedPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets checkinDateTime.
        /// Last device check-in time in UTC.
        /// </summary>
        [JsonPropertyName("checkinDateTime")]
        public DateTimeOffset? CheckinDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deviceName.
        /// Device name trying to check-in.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets devicePlatform.
        /// Device platform trying to check-in.
        /// </summary>
        [JsonPropertyName("devicePlatform")]
        public string DevicePlatform { get; set; }
    
        /// <summary>
        /// Gets or sets devicePlatformVersion.
        /// Device platform version trying to check-in.
        /// </summary>
        [JsonPropertyName("devicePlatformVersion")]
        public string DevicePlatformVersion { get; set; }
    
        /// <summary>
        /// Gets or sets errorMessage.
        /// Error message if any associated for the last checkin.
        /// </summary>
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// User identifier using the device.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// User principal name using the device.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets wasSuccessful.
        /// If the last checkin was successful.
        /// </summary>
        [JsonPropertyName("wasSuccessful")]
        public bool? WasSuccessful { get; set; }
    
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
