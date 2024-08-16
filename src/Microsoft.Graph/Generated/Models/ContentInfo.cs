// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ContentInfo : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The format property</summary>
        public Microsoft.Graph.Beta.Models.ContentFormat? Format
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContentFormat?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
        /// <summary>Identifier used for Azure Information Protection Analytics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier
        {
            get { return BackingStore?.Get<string?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
#nullable restore
#else
        public string Identifier
        {
            get { return BackingStore?.Get<string>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
#endif
        /// <summary>Existing Microsoft Purview Information Protection metadata is passed as key/value pairs, where the key is the MSIPLabelGUID_PropName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.KeyValuePair>? Metadata
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValuePair>?>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.KeyValuePair> Metadata
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValuePair>>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The state property</summary>
        public Microsoft.Graph.Beta.Models.ContentState? State
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContentState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ContentInfo"/> and sets the default values.
        /// </summary>
        public ContentInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ContentInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.ContentInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ContentInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "format", n => { Format = n.GetEnumValue<Microsoft.Graph.Beta.Models.ContentFormat>(); } },
                { "identifier", n => { Identifier = n.GetStringValue(); } },
                { "metadata", n => { Metadata = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>(Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<Microsoft.Graph.Beta.Models.ContentState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ContentFormat>("format", Format);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>("metadata", Metadata);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ContentState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
