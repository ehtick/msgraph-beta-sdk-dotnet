// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A complex type to represent the result of bulk driver action.
    /// </summary>
    public class BulkDriverActionResult : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of driver Ids where the action is failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FailedDriverIds {
            get { return BackingStore?.Get<List<string>?>("failedDriverIds"); }
            set { BackingStore?.Set("failedDriverIds", value); }
        }
#nullable restore
#else
        public List<string> FailedDriverIds {
            get { return BackingStore?.Get<List<string>>("failedDriverIds"); }
            set { BackingStore?.Set("failedDriverIds", value); }
        }
#endif
        /// <summary>List of driver Ids that are not found.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NotFoundDriverIds {
            get { return BackingStore?.Get<List<string>?>("notFoundDriverIds"); }
            set { BackingStore?.Set("notFoundDriverIds", value); }
        }
#nullable restore
#else
        public List<string> NotFoundDriverIds {
            get { return BackingStore?.Get<List<string>>("notFoundDriverIds"); }
            set { BackingStore?.Set("notFoundDriverIds", value); }
        }
#endif
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
        /// <summary>List of driver Ids where the action is successful.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SuccessfulDriverIds {
            get { return BackingStore?.Get<List<string>?>("successfulDriverIds"); }
            set { BackingStore?.Set("successfulDriverIds", value); }
        }
#nullable restore
#else
        public List<string> SuccessfulDriverIds {
            get { return BackingStore?.Get<List<string>>("successfulDriverIds"); }
            set { BackingStore?.Set("successfulDriverIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BulkDriverActionResult"/> and sets the default values.
        /// </summary>
        public BulkDriverActionResult()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BulkDriverActionResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BulkDriverActionResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkDriverActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"failedDriverIds", n => { FailedDriverIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notFoundDriverIds", n => { NotFoundDriverIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successfulDriverIds", n => { SuccessfulDriverIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("failedDriverIds", FailedDriverIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notFoundDriverIds", NotFoundDriverIds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("successfulDriverIds", SuccessfulDriverIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
