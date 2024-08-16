// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class DriveRestoreArtifact : Microsoft.Graph.Beta.Models.RestoreArtifactBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The new site identifier if destinationType is new, and the input site ID if the destinationType is inPlace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RestoredSiteId
        {
            get { return BackingStore?.Get<string?>("restoredSiteId"); }
            set { BackingStore?.Set("restoredSiteId", value); }
        }
#nullable restore
#else
        public string RestoredSiteId
        {
            get { return BackingStore?.Get<string>("restoredSiteId"); }
            set { BackingStore?.Set("restoredSiteId", value); }
        }
#endif
        /// <summary>The name of the restored site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RestoredSiteName
        {
            get { return BackingStore?.Get<string?>("restoredSiteName"); }
            set { BackingStore?.Set("restoredSiteName", value); }
        }
#nullable restore
#else
        public string RestoredSiteName
        {
            get { return BackingStore?.Get<string>("restoredSiteName"); }
            set { BackingStore?.Set("restoredSiteName", value); }
        }
#endif
        /// <summary>The web URL of the restored site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RestoredSiteWebUrl
        {
            get { return BackingStore?.Get<string?>("restoredSiteWebUrl"); }
            set { BackingStore?.Set("restoredSiteWebUrl", value); }
        }
#nullable restore
#else
        public string RestoredSiteWebUrl
        {
            get { return BackingStore?.Get<string>("restoredSiteWebUrl"); }
            set { BackingStore?.Set("restoredSiteWebUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DriveRestoreArtifact"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DriveRestoreArtifact CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DriveRestoreArtifact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "restoredSiteId", n => { RestoredSiteId = n.GetStringValue(); } },
                { "restoredSiteName", n => { RestoredSiteName = n.GetStringValue(); } },
                { "restoredSiteWebUrl", n => { RestoredSiteWebUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("restoredSiteId", RestoredSiteId);
        }
    }
}
