// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Communications.Calls.Item.SendDtmfTones {
    public class SendDtmfTonesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The clientContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientContext {
            get { return BackingStore?.Get<string?>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#nullable restore
#else
        public string ClientContext {
            get { return BackingStore?.Get<string>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#endif
        /// <summary>The delayBetweenTonesMs property</summary>
        public int? DelayBetweenTonesMs {
            get { return BackingStore?.Get<int?>("delayBetweenTonesMs"); }
            set { BackingStore?.Set("delayBetweenTonesMs", value); }
        }
        /// <summary>The tones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Tone?>? Tones {
            get { return BackingStore?.Get<List<Tone?>?>("tones"); }
            set { BackingStore?.Set("tones", value); }
        }
#nullable restore
#else
        public List<Tone?> Tones {
            get { return BackingStore?.Get<List<Tone?>>("tones"); }
            set { BackingStore?.Set("tones", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new sendDtmfTonesPostRequestBody and sets the default values.
        /// </summary>
        public SendDtmfTonesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SendDtmfTonesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendDtmfTonesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientContext", n => { ClientContext = n.GetStringValue(); } },
                {"delayBetweenTonesMs", n => { DelayBetweenTonesMs = n.GetIntValue(); } },
                {"tones", n => { Tones = n.GetCollectionOfEnumValues<Tone>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteIntValue("delayBetweenTonesMs", DelayBetweenTonesMs);
            writer.WriteCollectionOfEnumValues<Tone>("tones", Tones);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
