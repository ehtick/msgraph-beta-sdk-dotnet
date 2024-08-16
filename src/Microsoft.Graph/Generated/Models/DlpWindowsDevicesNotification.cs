// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class DlpWindowsDevicesNotification : Microsoft.Graph.Beta.Models.DlpNotification, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The contentName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentName
        {
            get { return BackingStore?.Get<string?>("contentName"); }
            set { BackingStore?.Set("contentName", value); }
        }
#nullable restore
#else
        public string ContentName
        {
            get { return BackingStore?.Get<string>("contentName"); }
            set { BackingStore?.Set("contentName", value); }
        }
#endif
        /// <summary>The lastModfiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModfiedBy
        {
            get { return BackingStore?.Get<string?>("lastModfiedBy"); }
            set { BackingStore?.Set("lastModfiedBy", value); }
        }
#nullable restore
#else
        public string LastModfiedBy
        {
            get { return BackingStore?.Get<string>("lastModfiedBy"); }
            set { BackingStore?.Set("lastModfiedBy", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DlpWindowsDevicesNotification"/> and sets the default values.
        /// </summary>
        public DlpWindowsDevicesNotification() : base()
        {
            OdataType = "#microsoft.graph.dlpWindowsDevicesNotification";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DlpWindowsDevicesNotification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DlpWindowsDevicesNotification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DlpWindowsDevicesNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contentName", n => { ContentName = n.GetStringValue(); } },
                { "lastModfiedBy", n => { LastModfiedBy = n.GetStringValue(); } },
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
            writer.WriteStringValue("contentName", ContentName);
            writer.WriteStringValue("lastModfiedBy", LastModfiedBy);
        }
    }
}
