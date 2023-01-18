using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosAzureAdSingleSignOnExtension : IosSingleSignOnExtension, IParsable {
        /// <summary>An optional list of additional bundle IDs allowed to use the AAD extension for single sign-on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? BundleIdAccessControlList {
            get { return BackingStore?.Get<List<string>?>("bundleIdAccessControlList"); }
            set { BackingStore?.Set("bundleIdAccessControlList", value); }
        }
#else
        public List<string> BundleIdAccessControlList {
            get { return BackingStore?.Get<List<string>>("bundleIdAccessControlList"); }
            set { BackingStore?.Set("bundleIdAccessControlList", value); }
        }
#endif
        /// <summary>Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<KeyTypedValuePair>? Configurations {
            get { return BackingStore?.Get<List<KeyTypedValuePair>?>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#else
        public List<KeyTypedValuePair> Configurations {
            get { return BackingStore?.Get<List<KeyTypedValuePair>>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#endif
        /// <summary>Enables or disables shared device mode.</summary>
        public bool? EnableSharedDeviceMode {
            get { return BackingStore?.Get<bool?>("enableSharedDeviceMode"); }
            set { BackingStore?.Set("enableSharedDeviceMode", value); }
        }
        /// <summary>
        /// Instantiates a new IosAzureAdSingleSignOnExtension and sets the default values.
        /// </summary>
        public IosAzureAdSingleSignOnExtension() : base() {
            OdataType = "#microsoft.graph.iosAzureAdSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosAzureAdSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosAzureAdSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bundleIdAccessControlList", n => { BundleIdAccessControlList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"configurations", n => { Configurations = n.GetCollectionOfObjectValues<KeyTypedValuePair>(KeyTypedValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enableSharedDeviceMode", n => { EnableSharedDeviceMode = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("bundleIdAccessControlList", BundleIdAccessControlList);
            writer.WriteCollectionOfObjectValues<KeyTypedValuePair>("configurations", Configurations);
            writer.WriteBoolValue("enableSharedDeviceMode", EnableSharedDeviceMode);
        }
    }
}
