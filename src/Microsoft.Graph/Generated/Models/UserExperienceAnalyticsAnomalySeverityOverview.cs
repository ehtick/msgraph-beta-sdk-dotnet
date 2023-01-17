using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics anomaly severity overview entity contains the count information for each severity of anomaly.
    /// </summary>
    public class UserExperienceAnalyticsAnomalySeverityOverview : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates count of high severity anomalies which have been detected. Valid values -2147483648 to 2147483647</summary>
        public int? HighSeverityAnomalyCount {
            get { return BackingStore?.Get<int?>("highSeverityAnomalyCount"); }
            set { BackingStore?.Set("highSeverityAnomalyCount", value); }
        }
        /// <summary>Indicates count of informational severity anomalies which have been detected. Valid values -2147483648 to 2147483647</summary>
        public int? InformationalSeverityAnomalyCount {
            get { return BackingStore?.Get<int?>("informationalSeverityAnomalyCount"); }
            set { BackingStore?.Set("informationalSeverityAnomalyCount", value); }
        }
        /// <summary>Indicates count of low severity anomalies which have been detected. Valid values -2147483648 to 2147483647</summary>
        public int? LowSeverityAnomalyCount {
            get { return BackingStore?.Get<int?>("lowSeverityAnomalyCount"); }
            set { BackingStore?.Set("lowSeverityAnomalyCount", value); }
        }
        /// <summary>Indicates count of medium severity anomalies which have been detected. Valid values -2147483648 to 2147483647</summary>
        public int? MediumSeverityAnomalyCount {
            get { return BackingStore?.Get<int?>("mediumSeverityAnomalyCount"); }
            set { BackingStore?.Set("mediumSeverityAnomalyCount", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsAnomalySeverityOverview and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsAnomalySeverityOverview() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceAnalyticsAnomalySeverityOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAnomalySeverityOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"highSeverityAnomalyCount", n => { HighSeverityAnomalyCount = n.GetIntValue(); } },
                {"informationalSeverityAnomalyCount", n => { InformationalSeverityAnomalyCount = n.GetIntValue(); } },
                {"lowSeverityAnomalyCount", n => { LowSeverityAnomalyCount = n.GetIntValue(); } },
                {"mediumSeverityAnomalyCount", n => { MediumSeverityAnomalyCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("highSeverityAnomalyCount", HighSeverityAnomalyCount);
            writer.WriteIntValue("informationalSeverityAnomalyCount", InformationalSeverityAnomalyCount);
            writer.WriteIntValue("lowSeverityAnomalyCount", LowSeverityAnomalyCount);
            writer.WriteIntValue("mediumSeverityAnomalyCount", MediumSeverityAnomalyCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
