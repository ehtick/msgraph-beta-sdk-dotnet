// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class NoMfaOnRoleActivationAlertIncident : Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertIncident, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the Microsoft Entra ID directory role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDisplayName
        {
            get { return BackingStore?.Get<string?>("roleDisplayName"); }
            set { BackingStore?.Set("roleDisplayName", value); }
        }
#nullable restore
#else
        public string RoleDisplayName
        {
            get { return BackingStore?.Get<string>("roleDisplayName"); }
            set { BackingStore?.Set("roleDisplayName", value); }
        }
#endif
        /// <summary>The globally unique identifier for a directory role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleTemplateId
        {
            get { return BackingStore?.Get<string?>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#nullable restore
#else
        public string RoleTemplateId
        {
            get { return BackingStore?.Get<string>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.NoMfaOnRoleActivationAlertIncident"/> and sets the default values.
        /// </summary>
        public NoMfaOnRoleActivationAlertIncident() : base()
        {
            OdataType = "#microsoft.graph.noMfaOnRoleActivationAlertIncident";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.NoMfaOnRoleActivationAlertIncident"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.NoMfaOnRoleActivationAlertIncident CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.NoMfaOnRoleActivationAlertIncident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "roleDisplayName", n => { RoleDisplayName = n.GetStringValue(); } },
                { "roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
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
            writer.WriteStringValue("roleDisplayName", RoleDisplayName);
            writer.WriteStringValue("roleTemplateId", RoleTemplateId);
        }
    }
}
