using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ServicePrincipalRiskDetection : Entity, IParsable {
        /// <summary>Indicates the activity type the detected risk is linked to.  The possible values are: signin, unknownFutureValue, servicePrincipal. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: servicePrincipal.</summary>
        public ActivityType? Activity { get; set; }
        /// <summary>Date and time when the risky activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>Additional information associated with the risk detection. This string value is represented as a JSON object with the quotations escaped.</summary>
        public string AdditionalInfo { get; set; }
        /// <summary>The unique identifier for the associated application.</summary>
        public string AppId { get; set; }
        /// <summary>Correlation ID of the sign-in activity associated with the risk detection. This property is null if the risk detection is not associated with a sign-in activity.</summary>
        public string CorrelationId { get; set; }
        /// <summary>Date and time when the risk was detected. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DetectedDateTime { get; set; }
        /// <summary>Timing of the detected risk , whether real-time or offline). The possible values are: notDefined, realtime, nearRealtime, offline, unknownFutureValue.</summary>
        public RiskDetectionTimingType? DetectionTimingType { get; set; }
        /// <summary>Provides the IP address of the client from where the risk occurred.</summary>
        public string IpAddress { get; set; }
        /// <summary>The unique identifier (GUID) for the key credential associated with the risk detection.</summary>
        public List<string> KeyIds { get; set; }
        /// <summary>Date and time when the risk detection was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>Location from where the sign-in was initiated.</summary>
        public SignInLocation Location { get; set; }
        /// <summary>Request identifier of the sign-in activity associated with the risk detection. This property is null if the risk detection is not associated with a sign-in activity. Supports $filter (eq).</summary>
        public string RequestId { get; set; }
        /// <summary>Details of the detected risk. Note: Details for this property are only available for Azure AD Premium P2 customers. P1 customers will be returned hidden. The possible values are: none, hidden, unknownFutureValue, adminConfirmedServicePrincipalCompromised, adminDismissedAllRiskForServicePrincipal. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: adminConfirmedServicePrincipalCompromised , adminDismissedAllRiskForServicePrincipal.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RiskDetail? RiskDetail { get; set; }
        /// <summary>The type of risk event detected. The possible values are:  investigationsThreatIntelligence, generic, adminConfirmedServicePrincipalCompromised, suspiciousSignins, leakedCredentials, unknownFutureValue. Supports $filter (eq).</summary>
        public string RiskEventType { get; set; }
        /// <summary>Level of the detected risk. Note: Details for this property are only available for Azure AD Premium P2 customers. P1 customers will be returned hidden. The possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RiskLevel? RiskLevel { get; set; }
        /// <summary>The state of a detected risky service principal or sign-in activity. The possible values are: none, dismissed, atRisk, confirmedCompromised, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RiskState? RiskState { get; set; }
        /// <summary>The display name for the service principal.</summary>
        public string ServicePrincipalDisplayName { get; set; }
        /// <summary>The unique identifier for the service principal. Supports $filter (eq).</summary>
        public string ServicePrincipalId { get; set; }
        /// <summary>Source of the risk detection. For example, identityProtection.</summary>
        public string Source { get; set; }
        /// <summary>Indicates the type of token issuer for the detected sign-in risk. The possible values are: AzureAD, UnknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TokenIssuerType? TokenIssuerType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ServicePrincipalRiskDetection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalRiskDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activity", (o,n) => { (o as ServicePrincipalRiskDetection).Activity = n.GetEnumValue<ActivityType>(); } },
                {"activityDateTime", (o,n) => { (o as ServicePrincipalRiskDetection).ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"additionalInfo", (o,n) => { (o as ServicePrincipalRiskDetection).AdditionalInfo = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as ServicePrincipalRiskDetection).AppId = n.GetStringValue(); } },
                {"correlationId", (o,n) => { (o as ServicePrincipalRiskDetection).CorrelationId = n.GetStringValue(); } },
                {"detectedDateTime", (o,n) => { (o as ServicePrincipalRiskDetection).DetectedDateTime = n.GetDateTimeOffsetValue(); } },
                {"detectionTimingType", (o,n) => { (o as ServicePrincipalRiskDetection).DetectionTimingType = n.GetEnumValue<RiskDetectionTimingType>(); } },
                {"ipAddress", (o,n) => { (o as ServicePrincipalRiskDetection).IpAddress = n.GetStringValue(); } },
                {"keyIds", (o,n) => { (o as ServicePrincipalRiskDetection).KeyIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as ServicePrincipalRiskDetection).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"location", (o,n) => { (o as ServicePrincipalRiskDetection).Location = n.GetObjectValue<SignInLocation>(SignInLocation.CreateFromDiscriminatorValue); } },
                {"requestId", (o,n) => { (o as ServicePrincipalRiskDetection).RequestId = n.GetStringValue(); } },
                {"riskDetail", (o,n) => { (o as ServicePrincipalRiskDetection).RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventType", (o,n) => { (o as ServicePrincipalRiskDetection).RiskEventType = n.GetStringValue(); } },
                {"riskLevel", (o,n) => { (o as ServicePrincipalRiskDetection).RiskLevel = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", (o,n) => { (o as ServicePrincipalRiskDetection).RiskState = n.GetEnumValue<RiskState>(); } },
                {"servicePrincipalDisplayName", (o,n) => { (o as ServicePrincipalRiskDetection).ServicePrincipalDisplayName = n.GetStringValue(); } },
                {"servicePrincipalId", (o,n) => { (o as ServicePrincipalRiskDetection).ServicePrincipalId = n.GetStringValue(); } },
                {"source", (o,n) => { (o as ServicePrincipalRiskDetection).Source = n.GetStringValue(); } },
                {"tokenIssuerType", (o,n) => { (o as ServicePrincipalRiskDetection).TokenIssuerType = n.GetEnumValue<TokenIssuerType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ActivityType>("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("additionalInfo", AdditionalInfo);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("detectedDateTime", DetectedDateTime);
            writer.WriteEnumValue<RiskDetectionTimingType>("detectionTimingType", DetectionTimingType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("keyIds", KeyIds);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteObjectValue<SignInLocation>("location", Location);
            writer.WriteStringValue("requestId", RequestId);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteStringValue("riskEventType", RiskEventType);
            writer.WriteEnumValue<RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteStringValue("servicePrincipalDisplayName", ServicePrincipalDisplayName);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<TokenIssuerType>("tokenIssuerType", TokenIssuerType);
        }
    }
}
