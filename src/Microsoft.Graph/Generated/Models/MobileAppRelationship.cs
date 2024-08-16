// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Describes a relationship between two mobile apps.
    /// </summary>
    public class MobileAppRelationship : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The target mobile app&apos;s display name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetDisplayName
        {
            get { return BackingStore?.Get<string?>("targetDisplayName"); }
            set { BackingStore?.Set("targetDisplayName", value); }
        }
#nullable restore
#else
        public string TargetDisplayName
        {
            get { return BackingStore?.Get<string>("targetDisplayName"); }
            set { BackingStore?.Set("targetDisplayName", value); }
        }
#endif
        /// <summary>The target mobile app&apos;s display version. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetDisplayVersion
        {
            get { return BackingStore?.Get<string?>("targetDisplayVersion"); }
            set { BackingStore?.Set("targetDisplayVersion", value); }
        }
#nullable restore
#else
        public string TargetDisplayVersion
        {
            get { return BackingStore?.Get<string>("targetDisplayVersion"); }
            set { BackingStore?.Set("targetDisplayVersion", value); }
        }
#endif
        /// <summary>The target mobile app&apos;s app id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetId
        {
            get { return BackingStore?.Get<string?>("targetId"); }
            set { BackingStore?.Set("targetId", value); }
        }
#nullable restore
#else
        public string TargetId
        {
            get { return BackingStore?.Get<string>("targetId"); }
            set { BackingStore?.Set("targetId", value); }
        }
#endif
        /// <summary>The target mobile app&apos;s publisher. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetPublisher
        {
            get { return BackingStore?.Get<string?>("targetPublisher"); }
            set { BackingStore?.Set("targetPublisher", value); }
        }
#nullable restore
#else
        public string TargetPublisher
        {
            get { return BackingStore?.Get<string>("targetPublisher"); }
            set { BackingStore?.Set("targetPublisher", value); }
        }
#endif
        /// <summary>Indicates whether the target of a relationship is the parent or the child in the relationship.</summary>
        public Microsoft.Graph.Beta.Models.MobileAppRelationshipType? TargetType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MobileAppRelationshipType?>("targetType"); }
            set { BackingStore?.Set("targetType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MobileAppRelationship"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MobileAppRelationship CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.mobileAppDependency" => new Microsoft.Graph.Beta.Models.MobileAppDependency(),
                "#microsoft.graph.mobileAppSupersedence" => new Microsoft.Graph.Beta.Models.MobileAppSupersedence(),
                _ => new Microsoft.Graph.Beta.Models.MobileAppRelationship(),
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
                { "targetDisplayName", n => { TargetDisplayName = n.GetStringValue(); } },
                { "targetDisplayVersion", n => { TargetDisplayVersion = n.GetStringValue(); } },
                { "targetId", n => { TargetId = n.GetStringValue(); } },
                { "targetPublisher", n => { TargetPublisher = n.GetStringValue(); } },
                { "targetType", n => { TargetType = n.GetEnumValue<Microsoft.Graph.Beta.Models.MobileAppRelationshipType>(); } },
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
            writer.WriteStringValue("targetId", TargetId);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.MobileAppRelationshipType>("targetType", TargetType);
        }
    }
}
