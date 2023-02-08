using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.MicrosoftGraphSetPosition {
    public class SetPositionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The endCell property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? EndCell {
            get { return BackingStore?.Get<Json?>("endCell"); }
            set { BackingStore?.Set("endCell", value); }
        }
#nullable restore
#else
        public Json EndCell {
            get { return BackingStore?.Get<Json>("endCell"); }
            set { BackingStore?.Set("endCell", value); }
        }
#endif
        /// <summary>The startCell property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartCell {
            get { return BackingStore?.Get<Json?>("startCell"); }
            set { BackingStore?.Set("startCell", value); }
        }
#nullable restore
#else
        public Json StartCell {
            get { return BackingStore?.Get<Json>("startCell"); }
            set { BackingStore?.Set("startCell", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new setPositionPostRequestBody and sets the default values.
        /// </summary>
        public SetPositionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SetPositionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetPositionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endCell", n => { EndCell = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startCell", n => { StartCell = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("endCell", EndCell);
            writer.WriteObjectValue<Json>("startCell", StartCell);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
