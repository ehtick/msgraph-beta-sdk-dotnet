using Microsoft.Graph.Beta.Models.IdentityGovernance;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceCreateNewVersion {
    public class CreateNewVersionPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The workflow property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow? Workflow {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow?>("workflow"); }
            set { BackingStore?.Set("workflow", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow Workflow {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow>("workflow"); }
            set { BackingStore?.Set("workflow", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new createNewVersionPostRequestBody and sets the default values.
        /// </summary>
        public CreateNewVersionPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateNewVersionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateNewVersionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"workflow", n => { Workflow = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow>(Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.Workflow>("workflow", Workflow);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
