// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The windowsAutopilotDeviceIdentity resource represents a Windows Autopilot Device.
    /// </summary>
    public class WindowsAutopilotDeviceIdentity : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Addressable user name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressableUserName
        {
            get { return BackingStore?.Get<string?>("addressableUserName"); }
            set { BackingStore?.Set("addressableUserName", value); }
        }
#nullable restore
#else
        public string AddressableUserName
        {
            get { return BackingStore?.Get<string>("addressableUserName"); }
            set { BackingStore?.Set("addressableUserName", value); }
        }
#endif
        /// <summary>AAD Device ID - to be deprecated</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureActiveDirectoryDeviceId
        {
            get { return BackingStore?.Get<string?>("azureActiveDirectoryDeviceId"); }
            set { BackingStore?.Set("azureActiveDirectoryDeviceId", value); }
        }
#nullable restore
#else
        public string AzureActiveDirectoryDeviceId
        {
            get { return BackingStore?.Get<string>("azureActiveDirectoryDeviceId"); }
            set { BackingStore?.Set("azureActiveDirectoryDeviceId", value); }
        }
#endif
        /// <summary>AAD Device ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureAdDeviceId
        {
            get { return BackingStore?.Get<string?>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
#nullable restore
#else
        public string AzureAdDeviceId
        {
            get { return BackingStore?.Get<string>("azureAdDeviceId"); }
            set { BackingStore?.Set("azureAdDeviceId", value); }
        }
#endif
        /// <summary>Deployment profile currently assigned to the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile? DeploymentProfile
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile?>("deploymentProfile"); }
            set { BackingStore?.Set("deploymentProfile", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile DeploymentProfile
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>("deploymentProfile"); }
            set { BackingStore?.Set("deploymentProfile", value); }
        }
#endif
        /// <summary>Profile set time of the Windows autopilot device.</summary>
        public DateTimeOffset? DeploymentProfileAssignedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("deploymentProfileAssignedDateTime"); }
            set { BackingStore?.Set("deploymentProfileAssignedDateTime", value); }
        }
        /// <summary>The deploymentProfileAssignmentDetailedStatus property</summary>
        public Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentDetailedStatus? DeploymentProfileAssignmentDetailedStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentDetailedStatus?>("deploymentProfileAssignmentDetailedStatus"); }
            set { BackingStore?.Set("deploymentProfileAssignmentDetailedStatus", value); }
        }
        /// <summary>The deploymentProfileAssignmentStatus property</summary>
        public Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentStatus? DeploymentProfileAssignmentStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentStatus?>("deploymentProfileAssignmentStatus"); }
            set { BackingStore?.Set("deploymentProfileAssignmentStatus", value); }
        }
        /// <summary>Surface Hub Device Account Password</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceAccountPassword
        {
            get { return BackingStore?.Get<string?>("deviceAccountPassword"); }
            set { BackingStore?.Set("deviceAccountPassword", value); }
        }
#nullable restore
#else
        public string DeviceAccountPassword
        {
            get { return BackingStore?.Get<string>("deviceAccountPassword"); }
            set { BackingStore?.Set("deviceAccountPassword", value); }
        }
#endif
        /// <summary>Surface Hub Device Account Upn</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceAccountUpn
        {
            get { return BackingStore?.Get<string?>("deviceAccountUpn"); }
            set { BackingStore?.Set("deviceAccountUpn", value); }
        }
#nullable restore
#else
        public string DeviceAccountUpn
        {
            get { return BackingStore?.Get<string>("deviceAccountUpn"); }
            set { BackingStore?.Set("deviceAccountUpn", value); }
        }
#endif
        /// <summary>Surface Hub Device Friendly Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceFriendlyName
        {
            get { return BackingStore?.Get<string?>("deviceFriendlyName"); }
            set { BackingStore?.Set("deviceFriendlyName", value); }
        }
#nullable restore
#else
        public string DeviceFriendlyName
        {
            get { return BackingStore?.Get<string>("deviceFriendlyName"); }
            set { BackingStore?.Set("deviceFriendlyName", value); }
        }
#endif
        /// <summary>Display Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The enrollmentState property</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>("enrollmentState"); }
            set { BackingStore?.Set("enrollmentState", value); }
        }
        /// <summary>Group Tag of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupTag
        {
            get { return BackingStore?.Get<string?>("groupTag"); }
            set { BackingStore?.Set("groupTag", value); }
        }
#nullable restore
#else
        public string GroupTag
        {
            get { return BackingStore?.Get<string>("groupTag"); }
            set { BackingStore?.Set("groupTag", value); }
        }
#endif
        /// <summary>Deployment profile intended to be assigned to the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile? IntendedDeploymentProfile
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile?>("intendedDeploymentProfile"); }
            set { BackingStore?.Set("intendedDeploymentProfile", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile IntendedDeploymentProfile
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>("intendedDeploymentProfile"); }
            set { BackingStore?.Set("intendedDeploymentProfile", value); }
        }
#endif
        /// <summary>Intune Last Contacted Date Time of the Windows autopilot device.</summary>
        public DateTimeOffset? LastContactedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastContactedDateTime"); }
            set { BackingStore?.Set("lastContactedDateTime", value); }
        }
        /// <summary>Managed Device ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId
        {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId
        {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>Oem manufacturer of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer
        {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer
        {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>Model name of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model
        {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model
        {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>Product Key of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductKey
        {
            get { return BackingStore?.Get<string?>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#nullable restore
#else
        public string ProductKey
        {
            get { return BackingStore?.Get<string>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#endif
        /// <summary>Purchase Order Identifier of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurchaseOrderIdentifier
        {
            get { return BackingStore?.Get<string?>("purchaseOrderIdentifier"); }
            set { BackingStore?.Set("purchaseOrderIdentifier", value); }
        }
#nullable restore
#else
        public string PurchaseOrderIdentifier
        {
            get { return BackingStore?.Get<string>("purchaseOrderIdentifier"); }
            set { BackingStore?.Set("purchaseOrderIdentifier", value); }
        }
#endif
        /// <summary>Device remediation status, indicating whether or not hardware has been changed for an Autopilot-registered device.</summary>
        public Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceRemediationState? RemediationState
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceRemediationState?>("remediationState"); }
            set { BackingStore?.Set("remediationState", value); }
        }
        /// <summary>RemediationState set time of Autopilot device.</summary>
        public DateTimeOffset? RemediationStateLastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("remediationStateLastModifiedDateTime"); }
            set { BackingStore?.Set("remediationStateLastModifiedDateTime", value); }
        }
        /// <summary>Resource Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceName
        {
            get { return BackingStore?.Get<string?>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#nullable restore
#else
        public string ResourceName
        {
            get { return BackingStore?.Get<string>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#endif
        /// <summary>Serial number of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber
        {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber
        {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>SKU Number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuNumber
        {
            get { return BackingStore?.Get<string?>("skuNumber"); }
            set { BackingStore?.Set("skuNumber", value); }
        }
#nullable restore
#else
        public string SkuNumber
        {
            get { return BackingStore?.Get<string>("skuNumber"); }
            set { BackingStore?.Set("skuNumber", value); }
        }
#endif
        /// <summary>System Family</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemFamily
        {
            get { return BackingStore?.Get<string?>("systemFamily"); }
            set { BackingStore?.Set("systemFamily", value); }
        }
#nullable restore
#else
        public string SystemFamily
        {
            get { return BackingStore?.Get<string>("systemFamily"); }
            set { BackingStore?.Set("systemFamily", value); }
        }
#endif
        /// <summary>Userless enrollment block status, indicating whether the next device enrollment will be blocked.</summary>
        public Microsoft.Graph.Beta.Models.WindowsAutopilotUserlessEnrollmentStatus? UserlessEnrollmentStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAutopilotUserlessEnrollmentStatus?>("userlessEnrollmentStatus"); }
            set { BackingStore?.Set("userlessEnrollmentStatus", value); }
        }
        /// <summary>User Principal Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addressableUserName", n => { AddressableUserName = n.GetStringValue(); } },
                { "azureActiveDirectoryDeviceId", n => { AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                { "azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
                { "deploymentProfile", n => { DeploymentProfile = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>(Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue); } },
                { "deploymentProfileAssignedDateTime", n => { DeploymentProfileAssignedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deploymentProfileAssignmentDetailedStatus", n => { DeploymentProfileAssignmentDetailedStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentDetailedStatus>(); } },
                { "deploymentProfileAssignmentStatus", n => { DeploymentProfileAssignmentStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentStatus>(); } },
                { "deviceAccountPassword", n => { DeviceAccountPassword = n.GetStringValue(); } },
                { "deviceAccountUpn", n => { DeviceAccountUpn = n.GetStringValue(); } },
                { "deviceFriendlyName", n => { DeviceFriendlyName = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enrollmentState", n => { EnrollmentState = n.GetEnumValue<Microsoft.Graph.Beta.Models.EnrollmentState>(); } },
                { "groupTag", n => { GroupTag = n.GetStringValue(); } },
                { "intendedDeploymentProfile", n => { IntendedDeploymentProfile = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>(Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile.CreateFromDiscriminatorValue); } },
                { "lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "productKey", n => { ProductKey = n.GetStringValue(); } },
                { "purchaseOrderIdentifier", n => { PurchaseOrderIdentifier = n.GetStringValue(); } },
                { "remediationState", n => { RemediationState = n.GetEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceRemediationState>(); } },
                { "remediationStateLastModifiedDateTime", n => { RemediationStateLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "resourceName", n => { ResourceName = n.GetStringValue(); } },
                { "serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                { "skuNumber", n => { SkuNumber = n.GetStringValue(); } },
                { "systemFamily", n => { SystemFamily = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "userlessEnrollmentStatus", n => { UserlessEnrollmentStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotUserlessEnrollmentStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("azureActiveDirectoryDeviceId", AzureActiveDirectoryDeviceId);
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>("deploymentProfile", DeploymentProfile);
            writer.WriteDateTimeOffsetValue("deploymentProfileAssignedDateTime", DeploymentProfileAssignedDateTime);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentDetailedStatus>("deploymentProfileAssignmentDetailedStatus", DeploymentProfileAssignmentDetailedStatus);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotProfileAssignmentStatus>("deploymentProfileAssignmentStatus", DeploymentProfileAssignmentStatus);
            writer.WriteStringValue("deviceAccountPassword", DeviceAccountPassword);
            writer.WriteStringValue("deviceAccountUpn", DeviceAccountUpn);
            writer.WriteStringValue("deviceFriendlyName", DeviceFriendlyName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsAutopilotDeploymentProfile>("intendedDeploymentProfile", IntendedDeploymentProfile);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteStringValue("purchaseOrderIdentifier", PurchaseOrderIdentifier);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceRemediationState>("remediationState", RemediationState);
            writer.WriteDateTimeOffsetValue("remediationStateLastModifiedDateTime", RemediationStateLastModifiedDateTime);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("skuNumber", SkuNumber);
            writer.WriteStringValue("systemFamily", SystemFamily);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.WindowsAutopilotUserlessEnrollmentStatus>("userlessEnrollmentStatus", UserlessEnrollmentStatus);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
