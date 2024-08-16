// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class SharePointRestoreSession : Microsoft.Graph.Beta.Models.RestoreSessionBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of restore points and destination details that can be used to restore SharePoint sites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.SiteRestoreArtifact>? SiteRestoreArtifacts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SiteRestoreArtifact>?>("siteRestoreArtifacts"); }
            set { BackingStore?.Set("siteRestoreArtifacts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.SiteRestoreArtifact> SiteRestoreArtifacts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SiteRestoreArtifact>>("siteRestoreArtifacts"); }
            set { BackingStore?.Set("siteRestoreArtifacts", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.SharePointRestoreSession"/> and sets the default values.
        /// </summary>
        public SharePointRestoreSession() : base()
        {
            OdataType = "#microsoft.graph.sharePointRestoreSession";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SharePointRestoreSession"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.SharePointRestoreSession CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.SharePointRestoreSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "siteRestoreArtifacts", n => { SiteRestoreArtifacts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SiteRestoreArtifact>(Microsoft.Graph.Beta.Models.SiteRestoreArtifact.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SiteRestoreArtifact>("siteRestoreArtifacts", SiteRestoreArtifacts);
        }
    }
}
