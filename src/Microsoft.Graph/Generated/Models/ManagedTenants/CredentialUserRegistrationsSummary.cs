// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants
{
    #pragma warning disable CS1591
    public class CredentialUserRegistrationsSummary : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>The number of users that are capable of performing multi-factor authentication or self service password reset. Optional. Read-only.</summary>
        public int? MfaAndSsprCapableUserCount
        {
            get { return BackingStore?.Get<int?>("mfaAndSsprCapableUserCount"); }
            set { BackingStore?.Set("mfaAndSsprCapableUserCount", value); }
        }
        /// <summary>The state of a conditional access policy that enforces multi-factor authentication. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MfaConditionalAccessPolicyState
        {
            get { return BackingStore?.Get<string?>("mfaConditionalAccessPolicyState"); }
            set { BackingStore?.Set("mfaConditionalAccessPolicyState", value); }
        }
#nullable restore
#else
        public string MfaConditionalAccessPolicyState
        {
            get { return BackingStore?.Get<string>("mfaConditionalAccessPolicyState"); }
            set { BackingStore?.Set("mfaConditionalAccessPolicyState", value); }
        }
#endif
        /// <summary>The number of users in the multi-factor authentication exclusion security group (Microsoft 365 Lighthouse - MFA exclusions). Optional. Read-only.</summary>
        public int? MfaExcludedUserCount
        {
            get { return BackingStore?.Get<int?>("mfaExcludedUserCount"); }
            set { BackingStore?.Set("mfaExcludedUserCount", value); }
        }
        /// <summary>The number of users registered for multi-factor authentication. Optional. Read-only.</summary>
        public int? MfaRegisteredUserCount
        {
            get { return BackingStore?.Get<int?>("mfaRegisteredUserCount"); }
            set { BackingStore?.Set("mfaRegisteredUserCount", value); }
        }
        /// <summary>A flag indicating whether Identity Security Defaults is enabled. Optional. Read-only.</summary>
        public bool? SecurityDefaultsEnabled
        {
            get { return BackingStore?.Get<bool?>("securityDefaultsEnabled"); }
            set { BackingStore?.Set("securityDefaultsEnabled", value); }
        }
        /// <summary>The number of users enabled for self service password reset. Optional. Read-only.</summary>
        public int? SsprEnabledUserCount
        {
            get { return BackingStore?.Get<int?>("ssprEnabledUserCount"); }
            set { BackingStore?.Set("ssprEnabledUserCount", value); }
        }
        /// <summary>The number of users registered for self service password reset. Optional. Read-only.</summary>
        public int? SsprRegisteredUserCount
        {
            get { return BackingStore?.Get<int?>("ssprRegisteredUserCount"); }
            set { BackingStore?.Set("ssprRegisteredUserCount", value); }
        }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName
        {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName
        {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The license type associated with the tenant; for example, AADFree, AADPremium1, AADPremium2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantLicenseType
        {
            get { return BackingStore?.Get<string?>("tenantLicenseType"); }
            set { BackingStore?.Set("tenantLicenseType", value); }
        }
#nullable restore
#else
        public string TenantLicenseType
        {
            get { return BackingStore?.Get<string>("tenantLicenseType"); }
            set { BackingStore?.Set("tenantLicenseType", value); }
        }
#endif
        /// <summary>The total number of users in the given managed tenant. Optional. Read-only.</summary>
        public int? TotalUserCount
        {
            get { return BackingStore?.Get<int?>("totalUserCount"); }
            set { BackingStore?.Set("totalUserCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ManagedTenants.CredentialUserRegistrationsSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ManagedTenants.CredentialUserRegistrationsSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ManagedTenants.CredentialUserRegistrationsSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                { "mfaAndSsprCapableUserCount", n => { MfaAndSsprCapableUserCount = n.GetIntValue(); } },
                { "mfaConditionalAccessPolicyState", n => { MfaConditionalAccessPolicyState = n.GetStringValue(); } },
                { "mfaExcludedUserCount", n => { MfaExcludedUserCount = n.GetIntValue(); } },
                { "mfaRegisteredUserCount", n => { MfaRegisteredUserCount = n.GetIntValue(); } },
                { "securityDefaultsEnabled", n => { SecurityDefaultsEnabled = n.GetBoolValue(); } },
                { "ssprEnabledUserCount", n => { SsprEnabledUserCount = n.GetIntValue(); } },
                { "ssprRegisteredUserCount", n => { SsprRegisteredUserCount = n.GetIntValue(); } },
                { "tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "tenantLicenseType", n => { TenantLicenseType = n.GetStringValue(); } },
                { "totalUserCount", n => { TotalUserCount = n.GetIntValue(); } },
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
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteIntValue("mfaAndSsprCapableUserCount", MfaAndSsprCapableUserCount);
            writer.WriteStringValue("mfaConditionalAccessPolicyState", MfaConditionalAccessPolicyState);
            writer.WriteIntValue("mfaExcludedUserCount", MfaExcludedUserCount);
            writer.WriteIntValue("mfaRegisteredUserCount", MfaRegisteredUserCount);
            writer.WriteBoolValue("securityDefaultsEnabled", SecurityDefaultsEnabled);
            writer.WriteIntValue("ssprEnabledUserCount", SsprEnabledUserCount);
            writer.WriteIntValue("ssprRegisteredUserCount", SsprRegisteredUserCount);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("tenantLicenseType", TenantLicenseType);
            writer.WriteIntValue("totalUserCount", TotalUserCount);
        }
    }
}
