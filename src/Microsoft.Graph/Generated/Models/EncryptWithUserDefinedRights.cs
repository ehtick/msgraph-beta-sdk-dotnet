using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EncryptWithUserDefinedRights : EncryptContent, IParsable {
        /// <summary>The allowAdHocPermissions property</summary>
        public bool? AllowAdHocPermissions {
            get { return BackingStore?.Get<bool?>("allowAdHocPermissions"); }
            set { BackingStore?.Set("allowAdHocPermissions", value); }
        }
        /// <summary>The allowMailForwarding property</summary>
        public bool? AllowMailForwarding {
            get { return BackingStore?.Get<bool?>("allowMailForwarding"); }
            set { BackingStore?.Set("allowMailForwarding", value); }
        }
        /// <summary>The decryptionRightsManagementTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DecryptionRightsManagementTemplateId {
            get { return BackingStore?.Get<string?>("decryptionRightsManagementTemplateId"); }
            set { BackingStore?.Set("decryptionRightsManagementTemplateId", value); }
        }
#else
        public string DecryptionRightsManagementTemplateId {
            get { return BackingStore?.Get<string>("decryptionRightsManagementTemplateId"); }
            set { BackingStore?.Set("decryptionRightsManagementTemplateId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new EncryptWithUserDefinedRights and sets the default values.
        /// </summary>
        public EncryptWithUserDefinedRights() : base() {
            OdataType = "#microsoft.graph.encryptWithUserDefinedRights";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EncryptWithUserDefinedRights CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EncryptWithUserDefinedRights();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAdHocPermissions", n => { AllowAdHocPermissions = n.GetBoolValue(); } },
                {"allowMailForwarding", n => { AllowMailForwarding = n.GetBoolValue(); } },
                {"decryptionRightsManagementTemplateId", n => { DecryptionRightsManagementTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAdHocPermissions", AllowAdHocPermissions);
            writer.WriteBoolValue("allowMailForwarding", AllowMailForwarding);
            writer.WriteStringValue("decryptionRightsManagementTemplateId", DecryptionRightsManagementTemplateId);
        }
    }
}
