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
    /// The type User Experience Analytics Device Scope.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserExperienceAnalyticsDeviceScope>))]
    public partial class UserExperienceAnalyticsDeviceScope : Entity
    {
    
        /// <summary>
        /// Gets or sets created date time.
        /// Indicates the creation date and time for the custom device scope.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device scope name.
        /// The name of the user experience analytics device Scope configuration.
        /// </summary>
        [JsonPropertyName("deviceScopeName")]
        public string DeviceScopeName { get; set; }
    
        /// <summary>
        /// Gets or sets enabled.
        /// Indicates whether a device scope is enabled or disabled. When TRUE, the device scope is enabled. When FALSE, the device scope is disabled. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or sets is built in.
        /// Indicates whether the device scope configuration is built-in or custom. When TRUE, the device scope configuration is built-in. When FALSE, the device scope configuration is custom. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("isBuiltIn")]
        public bool? IsBuiltIn { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Indicates the last updated date and time for the custom device scope.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// Device scope configuration query operator. Possible values are: equals, notEquals, contains, notContains, greaterThan, lessThan. Default value: equals. Possible values are: none, equals, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("operator")]
        public DeviceScopeOperator? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets owner id.
        /// The unique identifier of the person (admin) who created the device scope configuration.
        /// </summary>
        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }
    
        /// <summary>
        /// Gets or sets parameter.
        /// Device scope configuration parameter. It will be extended in future to add more parameter. Eg: device scope parameter can be OS version, Disk Type, Device manufacturer, device model or Scope tag. Default value: scopeTag. Possible values are: none, scopeTag, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("parameter")]
        public DeviceScopeParameter? Parameter { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Indicates the device scope status after the device scope has been enabled. Possible values are: none, computing, insufficientData or completed. Default value is none. Possible values are: none, computing, insufficientData, completed, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public DeviceScopeStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The device scope configuration query clause value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or sets value object id.
        /// The unique identifier for a user device scope tag Id used for the creation of device scope configuration.
        /// </summary>
        [JsonPropertyName("valueObjectId")]
        public string ValueObjectId { get; set; }
    
    }
}

