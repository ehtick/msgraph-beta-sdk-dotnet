// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class SubjectRightsRequestDetail : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of items that are excluded from the request.</summary>
        public long? ExcludedItemCount {
            get { return BackingStore?.Get<long?>("excludedItemCount"); }
            set { BackingStore?.Set("excludedItemCount", value); }
        }
        /// <summary>Count of items per insight.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? InsightCounts {
            get { return BackingStore?.Get<List<KeyValuePair>?>("insightCounts"); }
            set { BackingStore?.Set("insightCounts", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> InsightCounts {
            get { return BackingStore?.Get<List<KeyValuePair>>("insightCounts"); }
            set { BackingStore?.Set("insightCounts", value); }
        }
#endif
        /// <summary>Count of items found.</summary>
        public long? ItemCount {
            get { return BackingStore?.Get<long?>("itemCount"); }
            set { BackingStore?.Set("itemCount", value); }
        }
        /// <summary>Count of item that need review.</summary>
        public long? ItemNeedReview {
            get { return BackingStore?.Get<long?>("itemNeedReview"); }
            set { BackingStore?.Set("itemNeedReview", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Count of items per product, such as Exchange, SharePoint, OneDrive, and Teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? ProductItemCounts {
            get { return BackingStore?.Get<List<KeyValuePair>?>("productItemCounts"); }
            set { BackingStore?.Set("productItemCounts", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> ProductItemCounts {
            get { return BackingStore?.Get<List<KeyValuePair>>("productItemCounts"); }
            set { BackingStore?.Set("productItemCounts", value); }
        }
#endif
        /// <summary>Count of items signed off by the administrator.</summary>
        public long? SignedOffItemCount {
            get { return BackingStore?.Get<long?>("signedOffItemCount"); }
            set { BackingStore?.Set("signedOffItemCount", value); }
        }
        /// <summary>Total item size in bytes.</summary>
        public long? TotalItemSize {
            get { return BackingStore?.Get<long?>("totalItemSize"); }
            set { BackingStore?.Set("totalItemSize", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="SubjectRightsRequestDetail"/> and sets the default values.
        /// </summary>
        public SubjectRightsRequestDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SubjectRightsRequestDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubjectRightsRequestDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"excludedItemCount", n => { ExcludedItemCount = n.GetLongValue(); } },
                {"insightCounts", n => { InsightCounts = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"itemCount", n => { ItemCount = n.GetLongValue(); } },
                {"itemNeedReview", n => { ItemNeedReview = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"productItemCounts", n => { ProductItemCounts = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"signedOffItemCount", n => { SignedOffItemCount = n.GetLongValue(); } },
                {"totalItemSize", n => { TotalItemSize = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("excludedItemCount", ExcludedItemCount);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("insightCounts", InsightCounts);
            writer.WriteLongValue("itemCount", ItemCount);
            writer.WriteLongValue("itemNeedReview", ItemNeedReview);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("productItemCounts", ProductItemCounts);
            writer.WriteLongValue("signedOffItemCount", SignedOffItemCount);
            writer.WriteLongValue("totalItemSize", TotalItemSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
