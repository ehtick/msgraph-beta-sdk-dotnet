// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Replace
{
    #pragma warning disable CS1591
    public class ReplacePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The newText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? NewText
        {
            get { return BackingStore?.Get<UntypedNode?>("newText"); }
            set { BackingStore?.Set("newText", value); }
        }
#nullable restore
#else
        public UntypedNode NewText
        {
            get { return BackingStore?.Get<UntypedNode>("newText"); }
            set { BackingStore?.Set("newText", value); }
        }
#endif
        /// <summary>The numChars property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? NumChars
        {
            get { return BackingStore?.Get<UntypedNode?>("numChars"); }
            set { BackingStore?.Set("numChars", value); }
        }
#nullable restore
#else
        public UntypedNode NumChars
        {
            get { return BackingStore?.Get<UntypedNode>("numChars"); }
            set { BackingStore?.Set("numChars", value); }
        }
#endif
        /// <summary>The oldText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? OldText
        {
            get { return BackingStore?.Get<UntypedNode?>("oldText"); }
            set { BackingStore?.Set("oldText", value); }
        }
#nullable restore
#else
        public UntypedNode OldText
        {
            get { return BackingStore?.Get<UntypedNode>("oldText"); }
            set { BackingStore?.Set("oldText", value); }
        }
#endif
        /// <summary>The startNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? StartNum
        {
            get { return BackingStore?.Get<UntypedNode?>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#nullable restore
#else
        public UntypedNode StartNum
        {
            get { return BackingStore?.Get<UntypedNode>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Replace.ReplacePostRequestBody"/> and sets the default values.
        /// </summary>
        public ReplacePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Replace.ReplacePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Replace.ReplacePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Replace.ReplacePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "newText", n => { NewText = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "numChars", n => { NumChars = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "oldText", n => { OldText = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "startNum", n => { StartNum = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("newText", NewText);
            writer.WriteObjectValue<UntypedNode>("numChars", NumChars);
            writer.WriteObjectValue<UntypedNode>("oldText", OldText);
            writer.WriteObjectValue<UntypedNode>("startNum", StartNum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
