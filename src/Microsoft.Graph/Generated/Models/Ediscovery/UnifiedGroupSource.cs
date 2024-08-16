// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery
{
    #pragma warning disable CS1591
    public class UnifiedGroupSource : Microsoft.Graph.Beta.Models.Ediscovery.DataSource, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Group? Group
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Group Group
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>Specifies which sources are included in this group. Possible values are: mailbox, site.</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.SourceType? IncludedSources
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.SourceType?>("includedSources"); }
            set { BackingStore?.Set("includedSources", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource"/> and sets the default values.
        /// </summary>
        public UnifiedGroupSource() : base()
        {
            OdataType = "#microsoft.graph.ediscovery.unifiedGroupSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                { "includedSources", n => { IncludedSources = n.GetEnumValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceType>(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceType>("includedSources", IncludedSources);
        }
    }
}
