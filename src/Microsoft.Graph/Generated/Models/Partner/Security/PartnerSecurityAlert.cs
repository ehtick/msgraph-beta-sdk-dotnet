// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Partner.Security
{
    #pragma warning disable CS1591
    public class PartnerSecurityAlert : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the activity by a partner and includes details of state transitions, who performed them, and when they occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Partner.Security.ActivityLog>? ActivityLogs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Partner.Security.ActivityLog>?>("activityLogs"); }
            set { BackingStore?.Set("activityLogs", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Partner.Security.ActivityLog> ActivityLogs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Partner.Security.ActivityLog>>("activityLogs"); }
            set { BackingStore?.Set("activityLogs", value); }
        }
#endif
        /// <summary>A bag of name-value pairs that contain more details about an alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Partner.Security.AdditionalDataDictionary? AdditionalDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Partner.Security.AdditionalDataDictionary?>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Partner.Security.AdditionalDataDictionary AdditionalDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Partner.Security.AdditionalDataDictionary>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#endif
        /// <summary>Contains details of the resources affected by the security alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Partner.Security.AffectedResource>? AffectedResources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Partner.Security.AffectedResource>?>("affectedResources"); }
            set { BackingStore?.Set("affectedResources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Partner.Security.AffectedResource> AffectedResources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Partner.Security.AffectedResource>>("affectedResources"); }
            set { BackingStore?.Set("affectedResources", value); }
        }
#endif
        /// <summary>The type of vulnerability that impacts the customer due to this alert. For more information, see Security alerts reference guide.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertType
        {
            get { return BackingStore?.Get<string?>("alertType"); }
            set { BackingStore?.Set("alertType", value); }
        }
#nullable restore
#else
        public string AlertType
        {
            get { return BackingStore?.Get<string>("alertType"); }
            set { BackingStore?.Set("alertType", value); }
        }
#endif
        /// <summary>The modern offer category ID of the subscription.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogOfferId
        {
            get { return BackingStore?.Get<string?>("catalogOfferId"); }
            set { BackingStore?.Set("catalogOfferId", value); }
        }
#nullable restore
#else
        public string CatalogOfferId
        {
            get { return BackingStore?.Get<string>("catalogOfferId"); }
            set { BackingStore?.Set("catalogOfferId", value); }
        }
#endif
        /// <summary>The confidenceLevel property</summary>
        public Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertConfidence? ConfidenceLevel
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertConfidence?>("confidenceLevel"); }
            set { BackingStore?.Set("confidenceLevel", value); }
        }
        /// <summary>The impacted customer tenant associated with the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerTenantId
        {
            get { return BackingStore?.Get<string?>("customerTenantId"); }
            set { BackingStore?.Set("customerTenantId", value); }
        }
#nullable restore
#else
        public string CustomerTenantId
        {
            get { return BackingStore?.Get<string>("customerTenantId"); }
            set { BackingStore?.Set("customerTenantId", value); }
        }
#endif
        /// <summary>The description for each alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Time when the alert was detected or created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? DetectedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("detectedDateTime"); }
            set { BackingStore?.Set("detectedDateTime", value); }
        }
        /// <summary>The display name of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Time of the first activity associated with the alert. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstObservedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstObservedDateTime"); }
            set { BackingStore?.Set("firstObservedDateTime", value); }
        }
        /// <summary>Indicates whether an alert is a test alert.</summary>
        public bool? IsTest
        {
            get { return BackingStore?.Get<bool?>("isTest"); }
            set { BackingStore?.Set("isTest", value); }
        }
        /// <summary>Time of the latest activity associated with the alert. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastObservedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastObservedDateTime"); }
            set { BackingStore?.Set("lastObservedDateTime", value); }
        }
        /// <summary>The UPN of the partner user who resolved the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResolvedBy
        {
            get { return BackingStore?.Get<string?>("resolvedBy"); }
            set { BackingStore?.Set("resolvedBy", value); }
        }
#nullable restore
#else
        public string ResolvedBy
        {
            get { return BackingStore?.Get<string>("resolvedBy"); }
            set { BackingStore?.Set("resolvedBy", value); }
        }
#endif
        /// <summary>Time when the alert was resolved. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ResolvedOnDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("resolvedOnDateTime"); }
            set { BackingStore?.Set("resolvedOnDateTime", value); }
        }
        /// <summary>The reason provided by the partner for addressing the alert. The possible values are: legitimate, ignore, fraud, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertResolvedReason? ResolvedReason
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertResolvedReason?>("resolvedReason"); }
            set { BackingStore?.Set("resolvedReason", value); }
        }
        /// <summary>The severity property</summary>
        public Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertSeverity? Severity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status property</summary>
        public Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The subscription associated with the alert for the customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId
        {
            get { return BackingStore?.Get<string?>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#nullable restore
#else
        public string SubscriptionId
        {
            get { return BackingStore?.Get<string>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#endif
        /// <summary>The value-added reseller tenant associated with the partner tenant and customer tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueAddedResellerTenantId
        {
            get { return BackingStore?.Get<string?>("valueAddedResellerTenantId"); }
            set { BackingStore?.Set("valueAddedResellerTenantId", value); }
        }
#nullable restore
#else
        public string ValueAddedResellerTenantId
        {
            get { return BackingStore?.Get<string>("valueAddedResellerTenantId"); }
            set { BackingStore?.Set("valueAddedResellerTenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Partner.Security.PartnerSecurityAlert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Partner.Security.PartnerSecurityAlert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Partner.Security.PartnerSecurityAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activityLogs", n => { ActivityLogs = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Partner.Security.ActivityLog>(Microsoft.Graph.Beta.Models.Partner.Security.ActivityLog.CreateFromDiscriminatorValue)?.ToList(); } },
                { "additionalDetails", n => { AdditionalDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.Partner.Security.AdditionalDataDictionary>(Microsoft.Graph.Beta.Models.Partner.Security.AdditionalDataDictionary.CreateFromDiscriminatorValue); } },
                { "affectedResources", n => { AffectedResources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Partner.Security.AffectedResource>(Microsoft.Graph.Beta.Models.Partner.Security.AffectedResource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "alertType", n => { AlertType = n.GetStringValue(); } },
                { "catalogOfferId", n => { CatalogOfferId = n.GetStringValue(); } },
                { "confidenceLevel", n => { ConfidenceLevel = n.GetEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertConfidence>(); } },
                { "customerTenantId", n => { CustomerTenantId = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detectedDateTime", n => { DetectedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "firstObservedDateTime", n => { FirstObservedDateTime = n.GetDateTimeOffsetValue(); } },
                { "isTest", n => { IsTest = n.GetBoolValue(); } },
                { "lastObservedDateTime", n => { LastObservedDateTime = n.GetDateTimeOffsetValue(); } },
                { "resolvedBy", n => { ResolvedBy = n.GetStringValue(); } },
                { "resolvedOnDateTime", n => { ResolvedOnDateTime = n.GetDateTimeOffsetValue(); } },
                { "resolvedReason", n => { ResolvedReason = n.GetEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertResolvedReason>(); } },
                { "severity", n => { Severity = n.GetEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertStatus>(); } },
                { "subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                { "valueAddedResellerTenantId", n => { ValueAddedResellerTenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Partner.Security.ActivityLog>("activityLogs", ActivityLogs);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Partner.Security.AdditionalDataDictionary>("additionalDetails", AdditionalDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Partner.Security.AffectedResource>("affectedResources", AffectedResources);
            writer.WriteStringValue("alertType", AlertType);
            writer.WriteStringValue("catalogOfferId", CatalogOfferId);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertConfidence>("confidenceLevel", ConfidenceLevel);
            writer.WriteStringValue("customerTenantId", CustomerTenantId);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("detectedDateTime", DetectedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("firstObservedDateTime", FirstObservedDateTime);
            writer.WriteBoolValue("isTest", IsTest);
            writer.WriteDateTimeOffsetValue("lastObservedDateTime", LastObservedDateTime);
            writer.WriteStringValue("resolvedBy", ResolvedBy);
            writer.WriteDateTimeOffsetValue("resolvedOnDateTime", ResolvedOnDateTime);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertResolvedReason>("resolvedReason", ResolvedReason);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertSeverity>("severity", Severity);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Partner.Security.SecurityAlertStatus>("status", Status);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("valueAddedResellerTenantId", ValueAddedResellerTenantId);
        }
    }
}
