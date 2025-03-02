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
    /// The type Windows Phone81Compliance Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsPhone81CompliancePolicy>))]
    public partial class WindowsPhone81CompliancePolicy : DeviceCompliancePolicy
    {
    
        ///<summary>
        /// The WindowsPhone81CompliancePolicy constructor
        ///</summary>
        public WindowsPhone81CompliancePolicy()
        {
            this.ODataType = "microsoft.graph.windowsPhone81CompliancePolicy";
        }

        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum Windows Phone version.
        /// </summary>
        [JsonPropertyName("osMaximumVersion")]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum Windows Phone version.
        /// </summary>
        [JsonPropertyName("osMinimumVersion")]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Whether or not to block syncing the calendar.
        /// </summary>
        [JsonPropertyName("passwordBlockSimple")]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires.
        /// </summary>
        [JsonPropertyName("passwordExpirationDays")]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonPropertyName("passwordMinimumCharacterSetCount")]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of passwords.
        /// </summary>
        [JsonPropertyName("passwordMinimumLength")]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonPropertyName("passwordMinutesOfInactivityBeforeLock")]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block. Valid values 0 to 24
        /// </summary>
        [JsonPropertyName("passwordPreviousPasswordBlockCount")]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Whether or not to require a password.
        /// </summary>
        [JsonPropertyName("passwordRequired")]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// The required password type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonPropertyName("passwordRequiredType")]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on windows phone devices.
        /// </summary>
        [JsonPropertyName("storageRequireEncryption")]
        public bool? StorageRequireEncryption { get; set; }
    
    }
}

