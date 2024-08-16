// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class UnifiedRoleManagementAlertConfiguration : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The definition of the alert that contains its description, impact, and measures to mitigate or prevent it. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertDefinition? AlertDefinition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertDefinition?>("alertDefinition"); }
            set { BackingStore?.Set("alertDefinition", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertDefinition AlertDefinition
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertDefinition>("alertDefinition"); }
            set { BackingStore?.Set("alertDefinition", value); }
        }
#endif
        /// <summary>The identifier of an alert definition. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertDefinitionId
        {
            get { return BackingStore?.Get<string?>("alertDefinitionId"); }
            set { BackingStore?.Set("alertDefinitionId", value); }
        }
#nullable restore
#else
        public string AlertDefinitionId
        {
            get { return BackingStore?.Get<string>("alertDefinitionId"); }
            set { BackingStore?.Set("alertDefinitionId", value); }
        }
#endif
        /// <summary>true if the alert is enabled. Setting it to false disables PIM scanning the tenant to identify instances that trigger the alert.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>The identifier of the scope to which the alert is related. Only / is supported to represent the tenant scope. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeId
        {
            get { return BackingStore?.Get<string?>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#nullable restore
#else
        public string ScopeId
        {
            get { return BackingStore?.Get<string>("scopeId"); }
            set { BackingStore?.Set("scopeId", value); }
        }
#endif
        /// <summary>The type of scope where the alert is created. DirectoryRole is the only currently supported scope type for Microsoft Entra roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScopeType
        {
            get { return BackingStore?.Get<string?>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#nullable restore
#else
        public string ScopeType
        {
            get { return BackingStore?.Get<string>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.invalidLicenseAlertConfiguration" => new Microsoft.Graph.Beta.Models.InvalidLicenseAlertConfiguration(),
                "#microsoft.graph.noMfaOnRoleActivationAlertConfiguration" => new Microsoft.Graph.Beta.Models.NoMfaOnRoleActivationAlertConfiguration(),
                "#microsoft.graph.redundantAssignmentAlertConfiguration" => new Microsoft.Graph.Beta.Models.RedundantAssignmentAlertConfiguration(),
                "#microsoft.graph.rolesAssignedOutsidePrivilegedIdentityManagementAlertConfiguration" => new Microsoft.Graph.Beta.Models.RolesAssignedOutsidePrivilegedIdentityManagementAlertConfiguration(),
                "#microsoft.graph.sequentialActivationRenewalsAlertConfiguration" => new Microsoft.Graph.Beta.Models.SequentialActivationRenewalsAlertConfiguration(),
                "#microsoft.graph.staleSignInAlertConfiguration" => new Microsoft.Graph.Beta.Models.StaleSignInAlertConfiguration(),
                "#microsoft.graph.tooManyGlobalAdminsAssignedToTenantAlertConfiguration" => new Microsoft.Graph.Beta.Models.TooManyGlobalAdminsAssignedToTenantAlertConfiguration(),
                _ => new Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alertDefinition", n => { AlertDefinition = n.GetObjectValue<Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertDefinition>(Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertDefinition.CreateFromDiscriminatorValue); } },
                { "alertDefinitionId", n => { AlertDefinitionId = n.GetStringValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "scopeId", n => { ScopeId = n.GetStringValue(); } },
                { "scopeType", n => { ScopeType = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertDefinition>("alertDefinition", AlertDefinition);
            writer.WriteStringValue("alertDefinitionId", AlertDefinitionId);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
