// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.Mirr
{
    #pragma warning disable CS1591
    public class MirrPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The financeRate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FinanceRate
        {
            get { return BackingStore?.Get<UntypedNode?>("financeRate"); }
            set { BackingStore?.Set("financeRate", value); }
        }
#nullable restore
#else
        public UntypedNode FinanceRate
        {
            get { return BackingStore?.Get<UntypedNode>("financeRate"); }
            set { BackingStore?.Set("financeRate", value); }
        }
#endif
        /// <summary>The reinvestRate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ReinvestRate
        {
            get { return BackingStore?.Get<UntypedNode?>("reinvestRate"); }
            set { BackingStore?.Set("reinvestRate", value); }
        }
#nullable restore
#else
        public UntypedNode ReinvestRate
        {
            get { return BackingStore?.Get<UntypedNode>("reinvestRate"); }
            set { BackingStore?.Set("reinvestRate", value); }
        }
#endif
        /// <summary>The values property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Values
        {
            get { return BackingStore?.Get<UntypedNode?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public UntypedNode Values
        {
            get { return BackingStore?.Get<UntypedNode>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.Mirr.MirrPostRequestBody"/> and sets the default values.
        /// </summary>
        public MirrPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.Mirr.MirrPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.Mirr.MirrPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.Mirr.MirrPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "financeRate", n => { FinanceRate = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "reinvestRate", n => { ReinvestRate = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "values", n => { Values = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("financeRate", FinanceRate);
            writer.WriteObjectValue<UntypedNode>("reinvestRate", ReinvestRate);
            writer.WriteObjectValue<UntypedNode>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
