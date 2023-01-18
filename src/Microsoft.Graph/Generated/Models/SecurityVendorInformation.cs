using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SecurityVendorInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Provider {
            get { return BackingStore?.Get<string?>("provider"); }
            set { BackingStore?.Set("provider", value); }
        }
#else
        public string Provider {
            get { return BackingStore?.Get<string>("provider"); }
            set { BackingStore?.Set("provider", value); }
        }
#endif
        /// <summary>Version of the provider or subprovider, if it exists, that generated the alert. Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ProviderVersion {
            get { return BackingStore?.Get<string?>("providerVersion"); }
            set { BackingStore?.Set("providerVersion", value); }
        }
#else
        public string ProviderVersion {
            get { return BackingStore?.Get<string>("providerVersion"); }
            set { BackingStore?.Set("providerVersion", value); }
        }
#endif
        /// <summary>Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SubProvider {
            get { return BackingStore?.Get<string?>("subProvider"); }
            set { BackingStore?.Set("subProvider", value); }
        }
#else
        public string SubProvider {
            get { return BackingStore?.Get<string>("subProvider"); }
            set { BackingStore?.Set("subProvider", value); }
        }
#endif
        /// <summary>Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Vendor {
            get { return BackingStore?.Get<string?>("vendor"); }
            set { BackingStore?.Set("vendor", value); }
        }
#else
        public string Vendor {
            get { return BackingStore?.Get<string>("vendor"); }
            set { BackingStore?.Set("vendor", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new securityVendorInformation and sets the default values.
        /// </summary>
        public SecurityVendorInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecurityVendorInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityVendorInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"providerVersion", n => { ProviderVersion = n.GetStringValue(); } },
                {"subProvider", n => { SubProvider = n.GetStringValue(); } },
                {"vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("providerVersion", ProviderVersion);
            writer.WriteStringValue("subProvider", SubProvider);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
