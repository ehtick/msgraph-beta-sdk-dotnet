using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MembershipRuleProcessingStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Detailed error message if dynamic group processing ran into an error.  Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ErrorMessage {
            get { return BackingStore?.Get<string?>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
#else
        public string ErrorMessage {
            get { return BackingStore?.Get<string>("errorMessage"); }
            set { BackingStore?.Set("errorMessage", value); }
        }
#endif
        /// <summary>Most recent date and time when membership of a dynamic group was updated.  Optional. Read-only.</summary>
        public DateTimeOffset? LastMembershipUpdated {
            get { return BackingStore?.Get<DateTimeOffset?>("lastMembershipUpdated"); }
            set { BackingStore?.Set("lastMembershipUpdated", value); }
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
        /// <summary>Current status of a dynamic group processing. Possible values are: NotStarted, Running, Succeeded, Failed, and UnknownFutureValue.  Required. Read-only.</summary>
        public MembershipRuleProcessingStatusDetails? Status {
            get { return BackingStore?.Get<MembershipRuleProcessingStatusDetails?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new membershipRuleProcessingStatus and sets the default values.
        /// </summary>
        public MembershipRuleProcessingStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MembershipRuleProcessingStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MembershipRuleProcessingStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"errorMessage", n => { ErrorMessage = n.GetStringValue(); } },
                {"lastMembershipUpdated", n => { LastMembershipUpdated = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<MembershipRuleProcessingStatusDetails>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("errorMessage", ErrorMessage);
            writer.WriteDateTimeOffsetValue("lastMembershipUpdated", LastMembershipUpdated);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<MembershipRuleProcessingStatusDetails>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
