// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class GovernanceRoleSetting : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The rule settings that are evaluated when an administrator tries to add an eligible role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>? AdminEligibleSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>?>("adminEligibleSettings"); }
            set { BackingStore?.Set("adminEligibleSettings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting> AdminEligibleSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>>("adminEligibleSettings"); }
            set { BackingStore?.Set("adminEligibleSettings", value); }
        }
#endif
        /// <summary>The rule settings that are evaluated when an administrator tries to add a direct member role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>? AdminMemberSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>?>("adminMemberSettings"); }
            set { BackingStore?.Set("adminMemberSettings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting> AdminMemberSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>>("adminMemberSettings"); }
            set { BackingStore?.Set("adminMemberSettings", value); }
        }
#endif
        /// <summary>Read-only. Indicate if the roleSetting is a default roleSetting</summary>
        public bool? IsDefault
        {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>Read-only. The display name of the administrator who last updated the roleSetting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastUpdatedBy
        {
            get { return BackingStore?.Get<string?>("lastUpdatedBy"); }
            set { BackingStore?.Set("lastUpdatedBy", value); }
        }
#nullable restore
#else
        public string LastUpdatedBy
        {
            get { return BackingStore?.Get<string>("lastUpdatedBy"); }
            set { BackingStore?.Set("lastUpdatedBy", value); }
        }
#endif
        /// <summary>Read-only. The time when the role setting was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Read-only. The associated resource for this role setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.GovernanceResource? Resource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GovernanceResource?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.GovernanceResource Resource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GovernanceResource>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>Required. The id of the resource that the role setting is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId
        {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId
        {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>Read-only. The role definition that is enforced with this role setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.GovernanceRoleDefinition? RoleDefinition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GovernanceRoleDefinition?>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.GovernanceRoleDefinition RoleDefinition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#endif
        /// <summary>Required. The id of the role definition that the role setting is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId
        {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#nullable restore
#else
        public string RoleDefinitionId
        {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>The rule settings that are evaluated when a user tries to add an eligible role assignment. The setting is not supported for now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>? UserEligibleSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>?>("userEligibleSettings"); }
            set { BackingStore?.Set("userEligibleSettings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting> UserEligibleSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>>("userEligibleSettings"); }
            set { BackingStore?.Set("userEligibleSettings", value); }
        }
#endif
        /// <summary>The rule settings that are evaluated when a user tries to activate his role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>? UserMemberSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>?>("userMemberSettings"); }
            set { BackingStore?.Set("userMemberSettings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting> UserMemberSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>>("userMemberSettings"); }
            set { BackingStore?.Set("userMemberSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.GovernanceRoleSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.GovernanceRoleSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.GovernanceRoleSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "adminEligibleSettings", n => { AdminEligibleSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>(Microsoft.Graph.Beta.Models.GovernanceRuleSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                { "adminMemberSettings", n => { AdminMemberSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>(Microsoft.Graph.Beta.Models.GovernanceRuleSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isDefault", n => { IsDefault = n.GetBoolValue(); } },
                { "lastUpdatedBy", n => { LastUpdatedBy = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "resource", n => { Resource = n.GetObjectValue<Microsoft.Graph.Beta.Models.GovernanceResource>(Microsoft.Graph.Beta.Models.GovernanceResource.CreateFromDiscriminatorValue); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
                { "roleDefinition", n => { RoleDefinition = n.GetObjectValue<Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>(Microsoft.Graph.Beta.Models.GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                { "roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                { "userEligibleSettings", n => { UserEligibleSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>(Microsoft.Graph.Beta.Models.GovernanceRuleSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                { "userMemberSettings", n => { UserMemberSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>(Microsoft.Graph.Beta.Models.GovernanceRuleSetting.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>("adminEligibleSettings", AdminEligibleSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>("adminMemberSettings", AdminMemberSettings);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("lastUpdatedBy", LastUpdatedBy);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>("userEligibleSettings", UserEligibleSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceRuleSetting>("userMemberSettings", UserMemberSettings);
        }
    }
}
