using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics anomaly entity contains anomaly details.
    /// </summary>
    public class UserExperienceAnalyticsAnomaly : Entity, IParsable {
        /// <summary>Indicates the first occurrence date and time for the anomaly.</summary>
        public DateTimeOffset? AnomalyFirstOccurrenceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("anomalyFirstOccurrenceDateTime"); }
            set { BackingStore?.Set("anomalyFirstOccurrenceDateTime", value); }
        }
        /// <summary>The unique identifier of the anomaly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AnomalyId {
            get { return BackingStore?.Get<string?>("anomalyId"); }
            set { BackingStore?.Set("anomalyId", value); }
        }
#else
        public string AnomalyId {
            get { return BackingStore?.Get<string>("anomalyId"); }
            set { BackingStore?.Set("anomalyId", value); }
        }
#endif
        /// <summary>Indicates the latest occurrence date and time for the anomaly.</summary>
        public DateTimeOffset? AnomalyLatestOccurrenceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("anomalyLatestOccurrenceDateTime"); }
            set { BackingStore?.Set("anomalyLatestOccurrenceDateTime", value); }
        }
        /// <summary>The name of the anomaly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AnomalyName {
            get { return BackingStore?.Get<string?>("anomalyName"); }
            set { BackingStore?.Set("anomalyName", value); }
        }
#else
        public string AnomalyName {
            get { return BackingStore?.Get<string>("anomalyName"); }
            set { BackingStore?.Set("anomalyName", value); }
        }
#endif
        /// <summary>Indicates the category of the anomaly. Eg: anomaly type can be device, application, stop error, driver or other.</summary>
        public UserExperienceAnalyticsAnomalyType? AnomalyType {
            get { return BackingStore?.Get<UserExperienceAnalyticsAnomalyType?>("anomalyType"); }
            set { BackingStore?.Set("anomalyType", value); }
        }
        /// <summary>The name of the application or module that caused the anomaly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AssetName {
            get { return BackingStore?.Get<string?>("assetName"); }
            set { BackingStore?.Set("assetName", value); }
        }
#else
        public string AssetName {
            get { return BackingStore?.Get<string>("assetName"); }
            set { BackingStore?.Set("assetName", value); }
        }
#endif
        /// <summary>The publisher of the application or module that caused the anomaly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AssetPublisher {
            get { return BackingStore?.Get<string?>("assetPublisher"); }
            set { BackingStore?.Set("assetPublisher", value); }
        }
#else
        public string AssetPublisher {
            get { return BackingStore?.Get<string>("assetPublisher"); }
            set { BackingStore?.Set("assetPublisher", value); }
        }
#endif
        /// <summary>The version of the application or module that caused the anomaly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AssetVersion {
            get { return BackingStore?.Get<string?>("assetVersion"); }
            set { BackingStore?.Set("assetVersion", value); }
        }
#else
        public string AssetVersion {
            get { return BackingStore?.Get<string>("assetVersion"); }
            set { BackingStore?.Set("assetVersion", value); }
        }
#endif
        /// <summary>The unique identifier of the anomaly detection model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DetectionModelId {
            get { return BackingStore?.Get<string?>("detectionModelId"); }
            set { BackingStore?.Set("detectionModelId", value); }
        }
#else
        public string DetectionModelId {
            get { return BackingStore?.Get<string>("detectionModelId"); }
            set { BackingStore?.Set("detectionModelId", value); }
        }
#endif
        /// <summary>The number of devices impacted by the anomaly. Valid values -2147483648 to 2147483647</summary>
        public int? DeviceImpactedCount {
            get { return BackingStore?.Get<int?>("deviceImpactedCount"); }
            set { BackingStore?.Set("deviceImpactedCount", value); }
        }
        /// <summary>The unique identifier of the anomaly detection model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? IssueId {
            get { return BackingStore?.Get<string?>("issueId"); }
            set { BackingStore?.Set("issueId", value); }
        }
#else
        public string IssueId {
            get { return BackingStore?.Get<string>("issueId"); }
            set { BackingStore?.Set("issueId", value); }
        }
#endif
        /// <summary>Indicates the severity of the anomaly. Eg: anomaly severity can be high, medium, low, informational or other.</summary>
        public UserExperienceAnalyticsAnomalySeverity? Severity {
            get { return BackingStore?.Get<UserExperienceAnalyticsAnomalySeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>Indicates the state of the anomaly. Eg: anomaly severity can be new, active, disabled, removed or other.</summary>
        public UserExperienceAnalyticsAnomalyState? State {
            get { return BackingStore?.Get<UserExperienceAnalyticsAnomalyState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsAnomaly CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAnomaly();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"anomalyFirstOccurrenceDateTime", n => { AnomalyFirstOccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"anomalyId", n => { AnomalyId = n.GetStringValue(); } },
                {"anomalyLatestOccurrenceDateTime", n => { AnomalyLatestOccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"anomalyName", n => { AnomalyName = n.GetStringValue(); } },
                {"anomalyType", n => { AnomalyType = n.GetEnumValue<UserExperienceAnalyticsAnomalyType>(); } },
                {"assetName", n => { AssetName = n.GetStringValue(); } },
                {"assetPublisher", n => { AssetPublisher = n.GetStringValue(); } },
                {"assetVersion", n => { AssetVersion = n.GetStringValue(); } },
                {"detectionModelId", n => { DetectionModelId = n.GetStringValue(); } },
                {"deviceImpactedCount", n => { DeviceImpactedCount = n.GetIntValue(); } },
                {"issueId", n => { IssueId = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<UserExperienceAnalyticsAnomalySeverity>(); } },
                {"state", n => { State = n.GetEnumValue<UserExperienceAnalyticsAnomalyState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("anomalyFirstOccurrenceDateTime", AnomalyFirstOccurrenceDateTime);
            writer.WriteStringValue("anomalyId", AnomalyId);
            writer.WriteDateTimeOffsetValue("anomalyLatestOccurrenceDateTime", AnomalyLatestOccurrenceDateTime);
            writer.WriteStringValue("anomalyName", AnomalyName);
            writer.WriteEnumValue<UserExperienceAnalyticsAnomalyType>("anomalyType", AnomalyType);
            writer.WriteStringValue("assetName", AssetName);
            writer.WriteStringValue("assetPublisher", AssetPublisher);
            writer.WriteStringValue("assetVersion", AssetVersion);
            writer.WriteStringValue("detectionModelId", DetectionModelId);
            writer.WriteIntValue("deviceImpactedCount", DeviceImpactedCount);
            writer.WriteStringValue("issueId", IssueId);
            writer.WriteEnumValue<UserExperienceAnalyticsAnomalySeverity>("severity", Severity);
            writer.WriteEnumValue<UserExperienceAnalyticsAnomalyState>("state", State);
        }
    }
}
