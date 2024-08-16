// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Entity that stores the server log collection status.
    /// </summary>
    public class MicrosoftTunnelServerLogCollectionResponse : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The end time of the logs collected</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The time when the log collection is expired</summary>
        public DateTimeOffset? ExpiryDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expiryDateTime"); }
            set { BackingStore?.Set("expiryDateTime", value); }
        }
        /// <summary>The time when the log collection was requested</summary>
        public DateTimeOffset? RequestDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("requestDateTime"); }
            set { BackingStore?.Set("requestDateTime", value); }
        }
        /// <summary>ID of the server the log collection is requested upon</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerId
        {
            get { return BackingStore?.Get<string?>("serverId"); }
            set { BackingStore?.Set("serverId", value); }
        }
#nullable restore
#else
        public string ServerId
        {
            get { return BackingStore?.Get<string>("serverId"); }
            set { BackingStore?.Set("serverId", value); }
        }
#endif
        /// <summary>The size of the logs in bytes</summary>
        public long? SizeInBytes
        {
            get { return BackingStore?.Get<long?>("sizeInBytes"); }
            set { BackingStore?.Set("sizeInBytes", value); }
        }
        /// <summary>The start time of the logs collected</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Enum type that represent the status of log collection</summary>
        public Microsoft.Graph.Beta.Models.MicrosoftTunnelLogCollectionStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MicrosoftTunnelLogCollectionStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MicrosoftTunnelServerLogCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "expiryDateTime", n => { ExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                { "requestDateTime", n => { RequestDateTime = n.GetDateTimeOffsetValue(); } },
                { "serverId", n => { ServerId = n.GetStringValue(); } },
                { "sizeInBytes", n => { SizeInBytes = n.GetLongValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.MicrosoftTunnelLogCollectionStatus>(); } },
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
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("expiryDateTime", ExpiryDateTime);
            writer.WriteDateTimeOffsetValue("requestDateTime", RequestDateTime);
            writer.WriteStringValue("serverId", ServerId);
            writer.WriteLongValue("sizeInBytes", SizeInBytes);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.MicrosoftTunnelLogCollectionStatus>("status", Status);
        }
    }
}
