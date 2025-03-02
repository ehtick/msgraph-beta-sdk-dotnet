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
    /// The type DeviceManagementSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementSettings>))]
    public partial class DeviceManagementSettings
    {

        /// <summary>
        /// Gets or sets androidDeviceAdministratorEnrollmentEnabled.
        /// The property to determine if Android device administrator enrollment is enabled for this account.
        /// </summary>
        [JsonPropertyName("androidDeviceAdministratorEnrollmentEnabled")]
        public bool? AndroidDeviceAdministratorEnrollmentEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets derivedCredentialProvider.
        /// The Derived Credential Provider to use for this account. Possible values are: notConfigured, entrustDataCard, purebred, xTec, intercede.
        /// </summary>
        [JsonPropertyName("derivedCredentialProvider")]
        public DerivedCredentialProviderType? DerivedCredentialProvider { get; set; }
    
        /// <summary>
        /// Gets or sets derivedCredentialUrl.
        /// The Derived Credential Provider self-service URI.
        /// </summary>
        [JsonPropertyName("derivedCredentialUrl")]
        public string DerivedCredentialUrl { get; set; }
    
        /// <summary>
        /// Gets or sets deviceComplianceCheckinThresholdDays.
        /// The number of days a device is allowed to go without checking in to remain compliant.
        /// </summary>
        [JsonPropertyName("deviceComplianceCheckinThresholdDays")]
        public Int32? DeviceComplianceCheckinThresholdDays { get; set; }
    
        /// <summary>
        /// Gets or sets deviceInactivityBeforeRetirementInDay.
        /// When the device does not check in for specified number of days, the company data might be removed and the device will not be under management. Valid values 30 to 270
        /// </summary>
        [JsonPropertyName("deviceInactivityBeforeRetirementInDay")]
        public Int32? DeviceInactivityBeforeRetirementInDay { get; set; }
    
        /// <summary>
        /// Gets or sets enableAutopilotDiagnostics.
        /// Determines whether the autopilot diagnostic feature is enabled or not.
        /// </summary>
        [JsonPropertyName("enableAutopilotDiagnostics")]
        public bool? EnableAutopilotDiagnostics { get; set; }
    
        /// <summary>
        /// Gets or sets enableDeviceGroupMembershipReport.
        /// Determines whether the device group membership report feature is enabled or not.
        /// </summary>
        [JsonPropertyName("enableDeviceGroupMembershipReport")]
        public bool? EnableDeviceGroupMembershipReport { get; set; }
    
        /// <summary>
        /// Gets or sets enableEnhancedTroubleshootingExperience.
        /// Determines whether the enhanced troubleshooting UX is enabled or not.
        /// </summary>
        [JsonPropertyName("enableEnhancedTroubleshootingExperience")]
        public bool? EnableEnhancedTroubleshootingExperience { get; set; }
    
        /// <summary>
        /// Gets or sets enableLogCollection.
        /// Determines whether the log collection feature should be available for use.
        /// </summary>
        [JsonPropertyName("enableLogCollection")]
        public bool? EnableLogCollection { get; set; }
    
        /// <summary>
        /// Gets or sets enhancedJailBreak.
        /// Is feature enabled or not for enhanced jailbreak detection.
        /// </summary>
        [JsonPropertyName("enhancedJailBreak")]
        public bool? EnhancedJailBreak { get; set; }
    
        /// <summary>
        /// Gets or sets ignoreDevicesForUnsupportedSettingsEnabled.
        /// The property to determine whether to ignore unsupported compliance settings on certian models of devices.
        /// </summary>
        [JsonPropertyName("ignoreDevicesForUnsupportedSettingsEnabled")]
        public bool? IgnoreDevicesForUnsupportedSettingsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isScheduledActionEnabled.
        /// Is feature enabled or not for scheduled action for rule.
        /// </summary>
        [JsonPropertyName("isScheduledActionEnabled")]
        public bool? IsScheduledActionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets secureByDefault.
        /// Device should be noncompliant when there is no compliance policy targeted when this is true
        /// </summary>
        [JsonPropertyName("secureByDefault")]
        public bool? SecureByDefault { get; set; }
    
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
