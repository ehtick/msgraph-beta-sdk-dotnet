// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class UnifiedRoleManagementPolicyRule : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Not implemented. Defines details of scope that&apos;s targeted by role management policy rule. The details can include the principal type, the role assignment type, and actions affecting a role. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRuleTarget? Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRuleTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRuleTarget Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRuleTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.unifiedRoleManagementPolicyApprovalRule" => new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyApprovalRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyAuthenticationContextRule" => new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyAuthenticationContextRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyEnablementRule" => new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyEnablementRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyExpirationRule" => new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyExpirationRule(),
                "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule" => new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyNotificationRule(),
                _ => new Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRule(),
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
                { "target", n => { Target = n.GetObjectValue<Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRuleTarget>(Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRuleTarget.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UnifiedRoleManagementPolicyRuleTarget>("target", Target);
        }
    }
}
