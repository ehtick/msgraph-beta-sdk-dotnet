// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class ImpactedMailboxAsset : Microsoft.Graph.Beta.Models.Security.ImpactedAsset, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier property</summary>
        public Microsoft.Graph.Beta.Models.Security.MailboxAssetIdentifier? Identifier
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.MailboxAssetIdentifier?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Security.ImpactedMailboxAsset"/> and sets the default values.
        /// </summary>
        public ImpactedMailboxAsset() : base()
        {
            OdataType = "#microsoft.graph.security.impactedMailboxAsset";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.ImpactedMailboxAsset"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.ImpactedMailboxAsset CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.ImpactedMailboxAsset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "identifier", n => { Identifier = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.MailboxAssetIdentifier>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.MailboxAssetIdentifier>("identifier", Identifier);
        }
    }
}
