// <auto-generated/>
using Microsoft.Graph.Beta.Models.CallRecords;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Identity : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The display name of the identity. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The identifier of the identity. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
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
        /// Instantiates a new identity and sets the default values.
        /// </summary>
        public Identity() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Identity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.auditUserIdentity" => new AuditUserIdentity(),
                "#microsoft.graph.azureCommunicationServicesUserIdentity" => new AzureCommunicationServicesUserIdentity(),
                "#microsoft.graph.callRecords.userIdentity" => new Microsoft.Graph.Beta.Models.CallRecords.UserIdentity(),
                "#microsoft.graph.communicationsApplicationIdentity" => new CommunicationsApplicationIdentity(),
                "#microsoft.graph.communicationsApplicationInstanceIdentity" => new CommunicationsApplicationInstanceIdentity(),
                "#microsoft.graph.communicationsEncryptedIdentity" => new CommunicationsEncryptedIdentity(),
                "#microsoft.graph.communicationsGuestIdentity" => new CommunicationsGuestIdentity(),
                "#microsoft.graph.communicationsPhoneIdentity" => new CommunicationsPhoneIdentity(),
                "#microsoft.graph.communicationsUserIdentity" => new CommunicationsUserIdentity(),
                "#microsoft.graph.emailIdentity" => new EmailIdentity(),
                "#microsoft.graph.initiator" => new Initiator(),
                "#microsoft.graph.programResource" => new ProgramResource(),
                "#microsoft.graph.provisionedIdentity" => new ProvisionedIdentity(),
                "#microsoft.graph.provisioningServicePrincipal" => new ProvisioningServicePrincipal(),
                "#microsoft.graph.provisioningSystem" => new ProvisioningSystem(),
                "#microsoft.graph.security.submissionUserIdentity" => new SubmissionUserIdentity(),
                "#microsoft.graph.servicePrincipalIdentity" => new ServicePrincipalIdentity(),
                "#microsoft.graph.sharePointIdentity" => new SharePointIdentity(),
                "#microsoft.graph.teamworkApplicationIdentity" => new TeamworkApplicationIdentity(),
                "#microsoft.graph.teamworkConversationIdentity" => new TeamworkConversationIdentity(),
                "#microsoft.graph.teamworkTagIdentity" => new TeamworkTagIdentity(),
                "#microsoft.graph.teamworkUserIdentity" => new TeamworkUserIdentity(),
                "#microsoft.graph.userIdentity" => new UserIdentity(),
                _ => new Identity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
