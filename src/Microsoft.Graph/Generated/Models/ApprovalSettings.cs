using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ApprovalSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>One of SingleStage, Serial, Parallel, NoApproval (default). NoApproval is used when isApprovalRequired is false.</summary>
        public string ApprovalMode {
            get { return BackingStore?.Get<string>(nameof(ApprovalMode)); }
            set { BackingStore?.Set(nameof(ApprovalMode), value); }
        }
        /// <summary>If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.</summary>
        public List<ApprovalStage> ApprovalStages {
            get { return BackingStore?.Get<List<ApprovalStage>>(nameof(ApprovalStages)); }
            set { BackingStore?.Set(nameof(ApprovalStages), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether approval is required for requests in this policy.</summary>
        public bool? IsApprovalRequired {
            get { return BackingStore?.Get<bool?>(nameof(IsApprovalRequired)); }
            set { BackingStore?.Set(nameof(IsApprovalRequired), value); }
        }
        /// <summary>Indicates whether approval is required for a user to extend their assignment.</summary>
        public bool? IsApprovalRequiredForExtension {
            get { return BackingStore?.Get<bool?>(nameof(IsApprovalRequiredForExtension)); }
            set { BackingStore?.Set(nameof(IsApprovalRequiredForExtension), value); }
        }
        /// <summary>Indicates whether the requestor is required to supply a justification in their request.</summary>
        public bool? IsRequestorJustificationRequired {
            get { return BackingStore?.Get<bool?>(nameof(IsRequestorJustificationRequired)); }
            set { BackingStore?.Set(nameof(IsRequestorJustificationRequired), value); }
        }
        /// <summary>
        /// Instantiates a new approvalSettings and sets the default values.
        /// </summary>
        public ApprovalSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApprovalSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApprovalSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"approvalMode", n => { ApprovalMode = n.GetStringValue(); } },
                {"approvalStages", n => { ApprovalStages = n.GetCollectionOfObjectValues<ApprovalStage>(ApprovalStage.CreateFromDiscriminatorValue).ToList(); } },
                {"isApprovalRequired", n => { IsApprovalRequired = n.GetBoolValue(); } },
                {"isApprovalRequiredForExtension", n => { IsApprovalRequiredForExtension = n.GetBoolValue(); } },
                {"isRequestorJustificationRequired", n => { IsRequestorJustificationRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("approvalMode", ApprovalMode);
            writer.WriteCollectionOfObjectValues<ApprovalStage>("approvalStages", ApprovalStages);
            writer.WriteBoolValue("isApprovalRequired", IsApprovalRequired);
            writer.WriteBoolValue("isApprovalRequiredForExtension", IsApprovalRequiredForExtension);
            writer.WriteBoolValue("isRequestorJustificationRequired", IsRequestorJustificationRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
