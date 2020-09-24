// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Managed Device.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDevice : Entity
    {
    
		///<summary>
		/// The ManagedDevice constructor
		///</summary>
        public ManagedDevice()
        {
            this.ODataType = "microsoft.graph.managedDevice";
        }
	
        /// <summary>
        /// Gets or sets aad registered.
        /// Whether the device is Azure Active Directory registered. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "aadRegistered", Required = Newtonsoft.Json.Required.Default)]
        public bool? AadRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets activation lock bypass code.
        /// Code that allows the Activation Lock on a device to be bypassed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activationLockBypassCode", Required = Newtonsoft.Json.Required.Default)]
        public string ActivationLockBypassCode { get; set; }
    
        /// <summary>
        /// Gets or sets android security patch level.
        /// Android security patch level
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidSecurityPatchLevel", Required = Newtonsoft.Json.Required.Default)]
        public string AndroidSecurityPatchLevel { get; set; }
    
        /// <summary>
        /// Gets or sets autopilot enrolled.
        /// Reports if the managed device is enrolled via auto-pilot. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "autopilotEnrolled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AutopilotEnrolled { get; set; }
    
        /// <summary>
        /// Gets or sets azure active directory device id.
        /// The unique identifier for the Azure Active Directory device. Read only. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureActiveDirectoryDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureActiveDirectoryDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure addevice id.
        /// The unique identifier for the Azure Active Directory device. Read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureADDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureADDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure adregistered.
        /// Whether the device is Azure Active Directory registered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureADRegistered", Required = Newtonsoft.Json.Required.Default)]
        public bool? AzureADRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets chassis type.
        /// Chassis type of the device. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chassisType", Required = Newtonsoft.Json.Required.Default)]
        public ChassisType? ChassisType { get; set; }
    
        /// <summary>
        /// Gets or sets compliance grace period expiration date time.
        /// The DateTime when device compliance grace period expires
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceGracePeriodExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets compliance state.
        /// Compliance state of the device. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceState", Required = Newtonsoft.Json.Required.Default)]
        public ComplianceState? ComplianceState { get; set; }
    
        /// <summary>
        /// Gets or sets configuration manager client enabled features.
        /// ConfigrMgr client enabled features
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationManagerClientEnabledFeatures", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets configuration manager client health state.
        /// Configuration manager client health state, valid only for devices managed by MDM/ConfigMgr Agent
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationManagerClientHealthState", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationManagerClientHealthState ConfigurationManagerClientHealthState { get; set; }
    
        /// <summary>
        /// Gets or sets configuration manager client information.
        /// Configuration manager client information, valid only for devices managed, duel-managed or tri-managed by ConfigMgr Agent
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationManagerClientInformation", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationManagerClientInformation ConfigurationManagerClientInformation { get; set; }
    
        /// <summary>
        /// Gets or sets device action results.
        /// List of ComplexType deviceActionResult objects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceActionResults", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceActionResult> DeviceActionResults { get; set; }
    
        /// <summary>
        /// Gets or sets device category display name.
        /// Device category display name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCategoryDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceCategoryDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets device enrollment type.
        /// Enrollment type of the device. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceEnrollmentType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentType? DeviceEnrollmentType { get; set; }
    
        /// <summary>
        /// Gets or sets device health attestation state.
        /// The device health attestation state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceHealthAttestationState", Required = Newtonsoft.Json.Required.Default)]
        public DeviceHealthAttestationState DeviceHealthAttestationState { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Name of the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device registration state.
        /// Device registration state. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceRegistrationState", Required = Newtonsoft.Json.Required.Default)]
        public DeviceRegistrationState? DeviceRegistrationState { get; set; }
    
        /// <summary>
        /// Gets or sets device type.
        /// Platform of the device. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceType? DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets eas activated.
        /// Whether the device is Exchange ActiveSync activated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "easActivated", Required = Newtonsoft.Json.Required.Default)]
        public bool? EasActivated { get; set; }
    
        /// <summary>
        /// Gets or sets eas activation date time.
        /// Exchange ActivationSync activation time of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "easActivationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EasActivationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets eas device id.
        /// Exchange ActiveSync Id of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "easDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string EasDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets email address.
        /// Email(s) for the user associated with the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddress", Required = Newtonsoft.Json.Required.Default)]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets enrolled date time.
        /// Enrollment time of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrolledDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EnrolledDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets ethernet mac address.
        /// Ethernet MAC. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ethernetMacAddress", Required = Newtonsoft.Json.Required.Default)]
        public string EthernetMacAddress { get; set; }
    
        /// <summary>
        /// Gets or sets exchange access state.
        /// The Access State of the device in Exchange. Possible values are: none, unknown, allowed, blocked, quarantined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeAccessState", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }
    
        /// <summary>
        /// Gets or sets exchange access state reason.
        /// The reason for the device's access state in Exchange. Possible values are: none, unknown, exchangeGlobalRule, exchangeIndividualRule, exchangeDeviceRule, exchangeUpgrade, exchangeMailboxPolicy, other, compliant, notCompliant, notEnrolled, unknownLocation, mfaRequired, azureADBlockDueToAccessPolicy, compromisedPassword, deviceNotKnownWithManagedApp.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeAccessStateReason", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }
    
        /// <summary>
        /// Gets or sets exchange last successful sync date time.
        /// Last time the device contacted Exchange.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeLastSuccessfulSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets free storage space in bytes.
        /// Free Storage in Bytes
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "freeStorageSpaceInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? FreeStorageSpaceInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets hardware information.
        /// The hardward details for the device.  Includes information such as storage space, manufacturer, serial number, etc. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hardwareInformation", Required = Newtonsoft.Json.Required.Default)]
        public HardwareInformation HardwareInformation { get; set; }
    
        /// <summary>
        /// Gets or sets iccid.
        /// Integrated Circuit Card Identifier, it is A SIM card's unique identification number. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iccid", Required = Newtonsoft.Json.Required.Default)]
        public string Iccid { get; set; }
    
        /// <summary>
        /// Gets or sets imei.
        /// IMEI
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imei", Required = Newtonsoft.Json.Required.Default)]
        public string Imei { get; set; }
    
        /// <summary>
        /// Gets or sets is encrypted.
        /// Device encryption status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEncrypted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEncrypted { get; set; }
    
        /// <summary>
        /// Gets or sets is supervised.
        /// Device supervised status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isSupervised", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsSupervised { get; set; }
    
        /// <summary>
        /// Gets or sets jail broken.
        /// whether the device is jail broken or rooted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jailBroken", Required = Newtonsoft.Json.Required.Default)]
        public string JailBroken { get; set; }
    
        /// <summary>
        /// Gets or sets join type.
        /// Device join type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "joinType", Required = Newtonsoft.Json.Required.Default)]
        public JoinType? JoinType { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The date and time that the device last completed a successful sync with Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lost mode state.
        /// Indicates if Lost mode is enabled or disabled. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lostModeState", Required = Newtonsoft.Json.Required.Default)]
        public LostModeState? LostModeState { get; set; }
    
        /// <summary>
        /// Gets or sets managed device name.
        /// Automatically generated name to identify a device. Can be overwritten to a user friendly name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceName", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets managed device owner type.
        /// Ownership of the device. Can be 'company' or 'personal'. Possible values are: unknown, company, personal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceOwnerType", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }
    
        /// <summary>
        /// Gets or sets management agent.
        /// Management channel of the device. Intune, EAS, etc. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementAgent", Required = Newtonsoft.Json.Required.Default)]
        public ManagementAgentType? ManagementAgent { get; set; }
    
        /// <summary>
        /// Gets or sets management certificate expiration date.
        /// Reports device management certificate expiration date. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementCertificateExpirationDate", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ManagementCertificateExpirationDate { get; set; }
    
        /// <summary>
        /// Gets or sets management features.
        /// Device management features
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementFeatures", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceManagementFeatures? ManagementFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets management state.
        /// Management state of the device. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementState", Required = Newtonsoft.Json.Required.Default)]
        public ManagementState? ManagementState { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Manufacturer of the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manufacturer", Required = Newtonsoft.Json.Required.Default)]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets meid.
        /// MEID
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meid", Required = Newtonsoft.Json.Required.Default)]
        public string Meid { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model of the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "model", Required = Newtonsoft.Json.Required.Default)]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// Notes on the device created by IT Admin
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notes", Required = Newtonsoft.Json.Required.Default)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// Operating system of the device. Windows, iOS, etc.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// Operating system version of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets owner type.
        /// Ownership of the device. Can be 'company' or 'personal'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerType", Required = Newtonsoft.Json.Required.Default)]
        public OwnerType? OwnerType { get; set; }
    
        /// <summary>
        /// Gets or sets partner reported threat state.
        /// Indicates the threat state of a device when a Mobile Threat Defense partner is in use by the account and device. Read Only. Possible values are: unknown, activated, deactivated, secured, lowSeverity, mediumSeverity, highSeverity, unresponsive, compromised, misconfigured.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "partnerReportedThreatState", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }
    
        /// <summary>
        /// Gets or sets phone number.
        /// Phone number of the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phoneNumber", Required = Newtonsoft.Json.Required.Default)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets physical memory in bytes.
        /// Total Memory in Bytes. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "physicalMemoryInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PhysicalMemoryInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets prefer mdm over group policy applied date time.
        /// Reports the DateTime the preferMdmOverGroupPolicy setting was set.  When set, the Intune MDM settings will override Group Policy settings if there is a conflict. Read Only. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferMdmOverGroupPolicyAppliedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? PreferMdmOverGroupPolicyAppliedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets processor architecture.
        /// Processor architecture. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processorArchitecture", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceArchitecture? ProcessorArchitecture { get; set; }
    
        /// <summary>
        /// Gets or sets remote assistance session error details.
        /// An error string that identifies issues when creating Remote Assistance session objects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteAssistanceSessionErrorDetails", Required = Newtonsoft.Json.Required.Default)]
        public string RemoteAssistanceSessionErrorDetails { get; set; }
    
        /// <summary>
        /// Gets or sets remote assistance session url.
        /// Url that allows a Remote Assistance session to be established with the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteAssistanceSessionUrl", Required = Newtonsoft.Json.Required.Default)]
        public string RemoteAssistanceSessionUrl { get; set; }
    
        /// <summary>
        /// Gets or sets require user enrollment approval.
        /// Reports if the managed iOS device is user approval enrollment. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireUserEnrollmentApproval", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireUserEnrollmentApproval { get; set; }
    
        /// <summary>
        /// Gets or sets retire after date time.
        /// Indicates the time after when a device will be auto retired because of scheduled action. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "retireAfterDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RetireAfterDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tag IDs for this Device instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// SerialNumber
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "serialNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets sku family.
        /// Device sku family
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuFamily", Required = Newtonsoft.Json.Required.Default)]
        public string SkuFamily { get; set; }
    
        /// <summary>
        /// Gets or sets sku number.
        /// Device sku number, see also: https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getproductinfo. Valid values 0 to 2147483647. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuNumber", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SkuNumber { get; set; }
    
        /// <summary>
        /// Gets or sets specification version.
        /// Specification version. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "specificationVersion", Required = Newtonsoft.Json.Required.Default)]
        public string SpecificationVersion { get; set; }
    
        /// <summary>
        /// Gets or sets subscriber carrier.
        /// Subscriber Carrier
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriberCarrier", Required = Newtonsoft.Json.Required.Default)]
        public string SubscriberCarrier { get; set; }
    
        /// <summary>
        /// Gets or sets total storage space in bytes.
        /// Total Storage in Bytes
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalStorageSpaceInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? TotalStorageSpaceInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets udid.
        /// Unique Device Identifier for iOS and macOS devices. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "udid", Required = Newtonsoft.Json.Required.Default)]
        public string Udid { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// User display name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Unique Identifier for the user associated with the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// Device user principal name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets users logged on.
        /// Indicates the last logged on users of a device. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usersLoggedOn", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<LoggedOnUser> UsersLoggedOn { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi mac address.
        /// Wi-Fi MAC
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wiFiMacAddress", Required = Newtonsoft.Json.Required.Default)]
        public string WiFiMacAddress { get; set; }
    
        /// <summary>
        /// Gets or sets windows active malware count.
        /// Count of active malware for this windows device. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsActiveMalwareCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? WindowsActiveMalwareCount { get; set; }
    
        /// <summary>
        /// Gets or sets windows remediated malware count.
        /// Count of remediated malware for this windows device. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsRemediatedMalwareCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? WindowsRemediatedMalwareCount { get; set; }
    
        /// <summary>
        /// Gets or sets security baseline states.
        /// Security baseline states for this device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityBaselineStates", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceSecurityBaselineStatesCollectionPage SecurityBaselineStates { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy states.
        /// Device compliance policy states for this device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicyStates", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceDeviceCompliancePolicyStatesCollectionPage DeviceCompliancePolicyStates { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration states.
        /// Device configuration states for this device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationStates", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceDeviceConfigurationStatesCollectionPage DeviceConfigurationStates { get; set; }
    
        /// <summary>
        /// Gets or sets managed device mobile app configuration states.
        /// Managed device mobile app configuration states for this device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceMobileAppConfigurationStates", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionPage ManagedDeviceMobileAppConfigurationStates { get; set; }
    
        /// <summary>
        /// Gets or sets detected apps.
        /// All applications currently installed on the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectedApps", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceDetectedAppsCollectionWithReferencesPage DetectedApps { get; set; }
    
        /// <summary>
        /// Gets or sets device category.
        /// Device category
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCategory", Required = Newtonsoft.Json.Required.Default)]
        public DeviceCategory DeviceCategory { get; set; }
    
        /// <summary>
        /// Gets or sets log collection requests.
        /// List of log collection requests
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "logCollectionRequests", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceLogCollectionRequestsCollectionPage LogCollectionRequests { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// The primary users associated with the managed device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "users", Required = Newtonsoft.Json.Required.Default)]
        public IManagedDeviceUsersCollectionPage Users { get; set; }
    
        /// <summary>
        /// Gets or sets windows protection state.
        /// The device protection status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsProtectionState", Required = Newtonsoft.Json.Required.Default)]
        public WindowsProtectionState WindowsProtectionState { get; set; }
    
    }
}

