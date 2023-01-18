using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnlineMeetingRestricted : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The contentSharingDisabled property</summary>
        public OnlineMeetingContentSharingDisabledReason? ContentSharingDisabled {
            get { return BackingStore?.Get<OnlineMeetingContentSharingDisabledReason?>("contentSharingDisabled"); }
            set { BackingStore?.Set("contentSharingDisabled", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The videoDisabled property</summary>
        public OnlineMeetingVideoDisabledReason? VideoDisabled {
            get { return BackingStore?.Get<OnlineMeetingVideoDisabledReason?>("videoDisabled"); }
            set { BackingStore?.Set("videoDisabled", value); }
        }
        /// <summary>
        /// Instantiates a new onlineMeetingRestricted and sets the default values.
        /// </summary>
        public OnlineMeetingRestricted() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnlineMeetingRestricted CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnlineMeetingRestricted();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contentSharingDisabled", n => { ContentSharingDisabled = n.GetEnumValue<OnlineMeetingContentSharingDisabledReason>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"videoDisabled", n => { VideoDisabled = n.GetEnumValue<OnlineMeetingVideoDisabledReason>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<OnlineMeetingContentSharingDisabledReason>("contentSharingDisabled", ContentSharingDisabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<OnlineMeetingVideoDisabledReason>("videoDisabled", VideoDisabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
