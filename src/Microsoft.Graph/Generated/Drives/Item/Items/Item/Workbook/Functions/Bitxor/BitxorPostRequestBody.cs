// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Bitxor
{
    #pragma warning disable CS1591
    public class BitxorPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The number1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Number1
        {
            get { return BackingStore?.Get<UntypedNode?>("number1"); }
            set { BackingStore?.Set("number1", value); }
        }
#nullable restore
#else
        public UntypedNode Number1
        {
            get { return BackingStore?.Get<UntypedNode>("number1"); }
            set { BackingStore?.Set("number1", value); }
        }
#endif
        /// <summary>The number2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Number2
        {
            get { return BackingStore?.Get<UntypedNode?>("number2"); }
            set { BackingStore?.Set("number2", value); }
        }
#nullable restore
#else
        public UntypedNode Number2
        {
            get { return BackingStore?.Get<UntypedNode>("number2"); }
            set { BackingStore?.Set("number2", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Bitxor.BitxorPostRequestBody"/> and sets the default values.
        /// </summary>
        public BitxorPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Bitxor.BitxorPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Bitxor.BitxorPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Bitxor.BitxorPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "number1", n => { Number1 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "number2", n => { Number2 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("number1", Number1);
            writer.WriteObjectValue<UntypedNode>("number2", Number2);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
