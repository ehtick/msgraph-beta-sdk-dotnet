// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class InactiveGroupFinding : Microsoft.Graph.Beta.Models.Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actionSummary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ActionSummary? ActionSummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ActionSummary?>("actionSummary"); }
            set { BackingStore?.Set("actionSummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ActionSummary ActionSummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ActionSummary>("actionSummary"); }
            set { BackingStore?.Set("actionSummary", value); }
        }
#endif
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity? Group
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity Group
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>The permissionsCreepIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PermissionsCreepIndex? PermissionsCreepIndex
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsCreepIndex?>("permissionsCreepIndex"); }
            set { BackingStore?.Set("permissionsCreepIndex", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PermissionsCreepIndex PermissionsCreepIndex
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsCreepIndex>("permissionsCreepIndex"); }
            set { BackingStore?.Set("permissionsCreepIndex", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.InactiveGroupFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.InactiveGroupFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.InactiveGroupFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionSummary", n => { ActionSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.ActionSummary>(Microsoft.Graph.Beta.Models.ActionSummary.CreateFromDiscriminatorValue); } },
                { "group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity>(Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity.CreateFromDiscriminatorValue); } },
                { "permissionsCreepIndex", n => { PermissionsCreepIndex = n.GetObjectValue<Microsoft.Graph.Beta.Models.PermissionsCreepIndex>(Microsoft.Graph.Beta.Models.PermissionsCreepIndex.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ActionSummary>("actionSummary", ActionSummary);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity>("group", Group);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PermissionsCreepIndex>("permissionsCreepIndex", PermissionsCreepIndex);
        }
    }
}
