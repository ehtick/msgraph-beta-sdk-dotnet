using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties of the minimum operating system required for an iOS mobile app.
    /// </summary>
    public class IosMinimumOperatingSystem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>When TRUE, only Version 10.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V10_0 {
            get { return BackingStore?.Get<bool?>("v10_0"); }
            set { BackingStore?.Set("v10_0", value); }
        }
        /// <summary>When TRUE, only Version 11.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V11_0 {
            get { return BackingStore?.Get<bool?>("v11_0"); }
            set { BackingStore?.Set("v11_0", value); }
        }
        /// <summary>When TRUE, only Version 12.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V12_0 {
            get { return BackingStore?.Get<bool?>("v12_0"); }
            set { BackingStore?.Set("v12_0", value); }
        }
        /// <summary>When TRUE, only Version 13.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V13_0 {
            get { return BackingStore?.Get<bool?>("v13_0"); }
            set { BackingStore?.Set("v13_0", value); }
        }
        /// <summary>When TRUE, only Version 14.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V14_0 {
            get { return BackingStore?.Get<bool?>("v14_0"); }
            set { BackingStore?.Set("v14_0", value); }
        }
        /// <summary>When TRUE, only Version 15.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V15_0 {
            get { return BackingStore?.Get<bool?>("v15_0"); }
            set { BackingStore?.Set("v15_0", value); }
        }
        /// <summary>When TRUE, only Version 8.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V8_0 {
            get { return BackingStore?.Get<bool?>("v8_0"); }
            set { BackingStore?.Set("v8_0", value); }
        }
        /// <summary>When TRUE, only Version 9.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V9_0 {
            get { return BackingStore?.Get<bool?>("v9_0"); }
            set { BackingStore?.Set("v9_0", value); }
        }
        /// <summary>
        /// Instantiates a new iosMinimumOperatingSystem and sets the default values.
        /// </summary>
        public IosMinimumOperatingSystem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IosMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"v10_0", n => { V10_0 = n.GetBoolValue(); } },
                {"v11_0", n => { V11_0 = n.GetBoolValue(); } },
                {"v12_0", n => { V12_0 = n.GetBoolValue(); } },
                {"v13_0", n => { V13_0 = n.GetBoolValue(); } },
                {"v14_0", n => { V14_0 = n.GetBoolValue(); } },
                {"v15_0", n => { V15_0 = n.GetBoolValue(); } },
                {"v8_0", n => { V8_0 = n.GetBoolValue(); } },
                {"v9_0", n => { V9_0 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_0", V10_0);
            writer.WriteBoolValue("v11_0", V11_0);
            writer.WriteBoolValue("v12_0", V12_0);
            writer.WriteBoolValue("v13_0", V13_0);
            writer.WriteBoolValue("v14_0", V14_0);
            writer.WriteBoolValue("v15_0", V15_0);
            writer.WriteBoolValue("v8_0", V8_0);
            writer.WriteBoolValue("v9_0", V9_0);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
