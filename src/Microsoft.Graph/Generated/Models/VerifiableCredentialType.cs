using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VerifiableCredentialType : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The type of credential issued, for example, BusinessCardCredential.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CredentialType {
            get { return BackingStore?.Get<string?>("credentialType"); }
            set { BackingStore?.Set("credentialType", value); }
        }
#nullable restore
#else
        public string CredentialType {
            get { return BackingStore?.Get<string>("credentialType"); }
            set { BackingStore?.Set("credentialType", value); }
        }
#endif
        /// <summary>List of the accepted issuers authority as identified by the Microsoft Entra Verified ID service, for example, did:ion:EiAlrenrtD3Lsw0GlbzS1O2YFdy3Xtu8yo35W/&lt;SNIP/&gt;....</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Issuers {
            get { return BackingStore?.Get<List<string>?>("issuers"); }
            set { BackingStore?.Set("issuers", value); }
        }
#nullable restore
#else
        public List<string> Issuers {
            get { return BackingStore?.Get<List<string>>("issuers"); }
            set { BackingStore?.Set("issuers", value); }
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
        /// <summary>
        /// Instantiates a new verifiableCredentialType and sets the default values.
        /// </summary>
        public VerifiableCredentialType() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VerifiableCredentialType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifiableCredentialType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"credentialType", n => { CredentialType = n.GetStringValue(); } },
                {"issuers", n => { Issuers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("credentialType", CredentialType);
            writer.WriteCollectionOfPrimitiveValues<string>("issuers", Issuers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
