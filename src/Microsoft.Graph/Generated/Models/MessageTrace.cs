// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class MessageTrace : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The destinationIPAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationIPAddress
        {
            get { return BackingStore?.Get<string?>("destinationIPAddress"); }
            set { BackingStore?.Set("destinationIPAddress", value); }
        }
#nullable restore
#else
        public string DestinationIPAddress
        {
            get { return BackingStore?.Get<string>("destinationIPAddress"); }
            set { BackingStore?.Set("destinationIPAddress", value); }
        }
#endif
        /// <summary>The messageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageId
        {
            get { return BackingStore?.Get<string?>("messageId"); }
            set { BackingStore?.Set("messageId", value); }
        }
#nullable restore
#else
        public string MessageId
        {
            get { return BackingStore?.Get<string>("messageId"); }
            set { BackingStore?.Set("messageId", value); }
        }
#endif
        /// <summary>The receivedDateTime property</summary>
        public DateTimeOffset? ReceivedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTime"); }
            set { BackingStore?.Set("receivedDateTime", value); }
        }
        /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.MessageRecipient>? Recipients
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MessageRecipient>?>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.MessageRecipient> Recipients
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MessageRecipient>>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#endif
        /// <summary>The senderEmail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderEmail
        {
            get { return BackingStore?.Get<string?>("senderEmail"); }
            set { BackingStore?.Set("senderEmail", value); }
        }
#nullable restore
#else
        public string SenderEmail
        {
            get { return BackingStore?.Get<string>("senderEmail"); }
            set { BackingStore?.Set("senderEmail", value); }
        }
#endif
        /// <summary>The size property</summary>
        public int? Size
        {
            get { return BackingStore?.Get<int?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>The sourceIPAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceIPAddress
        {
            get { return BackingStore?.Get<string?>("sourceIPAddress"); }
            set { BackingStore?.Set("sourceIPAddress", value); }
        }
#nullable restore
#else
        public string SourceIPAddress
        {
            get { return BackingStore?.Get<string>("sourceIPAddress"); }
            set { BackingStore?.Set("sourceIPAddress", value); }
        }
#endif
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject
        {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject
        {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MessageTrace"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MessageTrace CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MessageTrace();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "destinationIPAddress", n => { DestinationIPAddress = n.GetStringValue(); } },
                { "messageId", n => { MessageId = n.GetStringValue(); } },
                { "receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                { "recipients", n => { Recipients = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MessageRecipient>(Microsoft.Graph.Beta.Models.MessageRecipient.CreateFromDiscriminatorValue)?.ToList(); } },
                { "senderEmail", n => { SenderEmail = n.GetStringValue(); } },
                { "size", n => { Size = n.GetIntValue(); } },
                { "sourceIPAddress", n => { SourceIPAddress = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
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
            writer.WriteStringValue("destinationIPAddress", DestinationIPAddress);
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MessageRecipient>("recipients", Recipients);
            writer.WriteStringValue("senderEmail", SenderEmail);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("sourceIPAddress", SourceIPAddress);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
