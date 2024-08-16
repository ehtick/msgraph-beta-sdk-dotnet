// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Hlookup
{
    #pragma warning disable CS1591
    public class HlookupPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The lookupValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? LookupValue
        {
            get { return BackingStore?.Get<UntypedNode?>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#nullable restore
#else
        public UntypedNode LookupValue
        {
            get { return BackingStore?.Get<UntypedNode>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#endif
        /// <summary>The rangeLookup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? RangeLookup
        {
            get { return BackingStore?.Get<UntypedNode?>("rangeLookup"); }
            set { BackingStore?.Set("rangeLookup", value); }
        }
#nullable restore
#else
        public UntypedNode RangeLookup
        {
            get { return BackingStore?.Get<UntypedNode>("rangeLookup"); }
            set { BackingStore?.Set("rangeLookup", value); }
        }
#endif
        /// <summary>The rowIndexNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? RowIndexNum
        {
            get { return BackingStore?.Get<UntypedNode?>("rowIndexNum"); }
            set { BackingStore?.Set("rowIndexNum", value); }
        }
#nullable restore
#else
        public UntypedNode RowIndexNum
        {
            get { return BackingStore?.Get<UntypedNode>("rowIndexNum"); }
            set { BackingStore?.Set("rowIndexNum", value); }
        }
#endif
        /// <summary>The tableArray property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? TableArray
        {
            get { return BackingStore?.Get<UntypedNode?>("tableArray"); }
            set { BackingStore?.Set("tableArray", value); }
        }
#nullable restore
#else
        public UntypedNode TableArray
        {
            get { return BackingStore?.Get<UntypedNode>("tableArray"); }
            set { BackingStore?.Set("tableArray", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Hlookup.HlookupPostRequestBody"/> and sets the default values.
        /// </summary>
        public HlookupPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Hlookup.HlookupPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Hlookup.HlookupPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.Hlookup.HlookupPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "lookupValue", n => { LookupValue = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "rangeLookup", n => { RangeLookup = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "rowIndexNum", n => { RowIndexNum = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "tableArray", n => { TableArray = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("lookupValue", LookupValue);
            writer.WriteObjectValue<UntypedNode>("rangeLookup", RangeLookup);
            writer.WriteObjectValue<UntypedNode>("rowIndexNum", RowIndexNum);
            writer.WriteObjectValue<UntypedNode>("tableArray", TableArray);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
