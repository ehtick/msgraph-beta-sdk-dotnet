// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Event representing an general failure.
    /// </summary>
    public class DeviceManagementTroubleshootingEvent : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>A set of string key and string value pairs which provides additional information on the Troubleshooting event</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.KeyValuePair>? AdditionalInformation
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValuePair>?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.KeyValuePair> AdditionalInformation
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValuePair>>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>Id used for tracing the failure in the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId
        {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId
        {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Event Name corresponding to the Troubleshooting Event. It is an Optional field</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventName
        {
            get { return BackingStore?.Get<string?>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#nullable restore
#else
        public string EventName
        {
            get { return BackingStore?.Get<string>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#endif
        /// <summary>Object containing detailed information about the error and its remediation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingErrorDetails? TroubleshootingErrorDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingErrorDetails?>("troubleshootingErrorDetails"); }
            set { BackingStore?.Set("troubleshootingErrorDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingErrorDetails TroubleshootingErrorDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails"); }
            set { BackingStore?.Set("troubleshootingErrorDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.appleVppTokenTroubleshootingEvent" => new Microsoft.Graph.Beta.Models.AppleVppTokenTroubleshootingEvent(),
                "#microsoft.graph.enrollmentTroubleshootingEvent" => new Microsoft.Graph.Beta.Models.EnrollmentTroubleshootingEvent(),
                "#microsoft.graph.mobileAppTroubleshootingEvent" => new Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent(),
                _ => new Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalInformation", n => { AdditionalInformation = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>(Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                { "eventName", n => { EventName = n.GetStringValue(); } },
                { "troubleshootingErrorDetails", n => { TroubleshootingErrorDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingErrorDetails>(Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingErrorDetails.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValuePair>("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails", TroubleshootingErrorDetails);
        }
    }
}
