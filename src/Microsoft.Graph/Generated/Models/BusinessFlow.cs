// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class BusinessFlow : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The customData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomData
        {
            get { return BackingStore?.Get<string?>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#nullable restore
#else
        public string CustomData
        {
            get { return BackingStore?.Get<string>("customData"); }
            set { BackingStore?.Set("customData", value); }
        }
#endif
        /// <summary>The deDuplicationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeDuplicationId
        {
            get { return BackingStore?.Get<string?>("deDuplicationId"); }
            set { BackingStore?.Set("deDuplicationId", value); }
        }
#nullable restore
#else
        public string DeDuplicationId
        {
            get { return BackingStore?.Get<string>("deDuplicationId"); }
            set { BackingStore?.Set("deDuplicationId", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
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
        /// <summary>The policy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.GovernancePolicy? Policy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GovernancePolicy?>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.GovernancePolicy Policy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GovernancePolicy>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#endif
        /// <summary>The policyTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyTemplateId
        {
            get { return BackingStore?.Get<string?>("policyTemplateId"); }
            set { BackingStore?.Set("policyTemplateId", value); }
        }
#nullable restore
#else
        public string PolicyTemplateId
        {
            get { return BackingStore?.Get<string>("policyTemplateId"); }
            set { BackingStore?.Set("policyTemplateId", value); }
        }
#endif
        /// <summary>The recordVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordVersion
        {
            get { return BackingStore?.Get<string?>("recordVersion"); }
            set { BackingStore?.Set("recordVersion", value); }
        }
#nullable restore
#else
        public string RecordVersion
        {
            get { return BackingStore?.Get<string>("recordVersion"); }
            set { BackingStore?.Set("recordVersion", value); }
        }
#endif
        /// <summary>The schemaId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchemaId
        {
            get { return BackingStore?.Get<string?>("schemaId"); }
            set { BackingStore?.Set("schemaId", value); }
        }
#nullable restore
#else
        public string SchemaId
        {
            get { return BackingStore?.Get<string>("schemaId"); }
            set { BackingStore?.Set("schemaId", value); }
        }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.BusinessFlowSettings? Settings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BusinessFlowSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.BusinessFlowSettings Settings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BusinessFlowSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.BusinessFlow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.BusinessFlow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.BusinessFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "customData", n => { CustomData = n.GetStringValue(); } },
                { "deDuplicationId", n => { DeDuplicationId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "policy", n => { Policy = n.GetObjectValue<Microsoft.Graph.Beta.Models.GovernancePolicy>(Microsoft.Graph.Beta.Models.GovernancePolicy.CreateFromDiscriminatorValue); } },
                { "policyTemplateId", n => { PolicyTemplateId = n.GetStringValue(); } },
                { "recordVersion", n => { RecordVersion = n.GetStringValue(); } },
                { "schemaId", n => { SchemaId = n.GetStringValue(); } },
                { "settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.BusinessFlowSettings>(Microsoft.Graph.Beta.Models.BusinessFlowSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("customData", CustomData);
            writer.WriteStringValue("deDuplicationId", DeDuplicationId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.GovernancePolicy>("policy", Policy);
            writer.WriteStringValue("policyTemplateId", PolicyTemplateId);
            writer.WriteStringValue("recordVersion", RecordVersion);
            writer.WriteStringValue("schemaId", SchemaId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BusinessFlowSettings>("settings", Settings);
        }
    }
}
