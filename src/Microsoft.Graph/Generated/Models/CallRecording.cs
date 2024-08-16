// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CallRecording : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The unique identifier for the call that is related to this recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId
        {
            get { return BackingStore?.Get<string?>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#nullable restore
#else
        public string CallId
        {
            get { return BackingStore?.Get<string>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#endif
        /// <summary>The content of the recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content
        {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content
        {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The unique identifier that links the transcript with its corresponding recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentCorrelationId
        {
            get { return BackingStore?.Get<string?>("contentCorrelationId"); }
            set { BackingStore?.Set("contentCorrelationId", value); }
        }
#nullable restore
#else
        public string ContentCorrelationId
        {
            get { return BackingStore?.Get<string>("contentCorrelationId"); }
            set { BackingStore?.Set("contentCorrelationId", value); }
        }
#endif
        /// <summary>Date and time at which the recording was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Date and time at which the recording ends. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The unique identifier of the onlineMeeting related to this recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MeetingId
        {
            get { return BackingStore?.Get<string?>("meetingId"); }
            set { BackingStore?.Set("meetingId", value); }
        }
#nullable restore
#else
        public string MeetingId
        {
            get { return BackingStore?.Get<string>("meetingId"); }
            set { BackingStore?.Set("meetingId", value); }
        }
#endif
        /// <summary>The identity information of the organizer of the onlineMeeting related to this recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdentitySet? MeetingOrganizer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet?>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdentitySet MeetingOrganizer
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#endif
        /// <summary>The unique identifier of the organizer of the onlineMeeting related to this recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MeetingOrganizerId
        {
            get { return BackingStore?.Get<string?>("meetingOrganizerId"); }
            set { BackingStore?.Set("meetingOrganizerId", value); }
        }
#nullable restore
#else
        public string MeetingOrganizerId
        {
            get { return BackingStore?.Get<string>("meetingOrganizerId"); }
            set { BackingStore?.Set("meetingOrganizerId", value); }
        }
#endif
        /// <summary>The URL that can be used to access the content of the recording. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingContentUrl
        {
            get { return BackingStore?.Get<string?>("recordingContentUrl"); }
            set { BackingStore?.Set("recordingContentUrl", value); }
        }
#nullable restore
#else
        public string RecordingContentUrl
        {
            get { return BackingStore?.Get<string>("recordingContentUrl"); }
            set { BackingStore?.Set("recordingContentUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CallRecording"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.CallRecording CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CallRecording();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callId", n => { CallId = n.GetStringValue(); } },
                { "content", n => { Content = n.GetByteArrayValue(); } },
                { "contentCorrelationId", n => { ContentCorrelationId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "meetingId", n => { MeetingId = n.GetStringValue(); } },
                { "meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "meetingOrganizerId", n => { MeetingOrganizerId = n.GetStringValue(); } },
                { "recordingContentUrl", n => { RecordingContentUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("callId", CallId);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentCorrelationId", ContentCorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("meetingId", MeetingId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("meetingOrganizer", MeetingOrganizer);
            writer.WriteStringValue("meetingOrganizerId", MeetingOrganizerId);
            writer.WriteStringValue("recordingContentUrl", RecordingContentUrl);
        }
    }
}
