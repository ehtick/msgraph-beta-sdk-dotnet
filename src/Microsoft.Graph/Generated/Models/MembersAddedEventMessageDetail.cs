// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class MembersAddedEventMessageDetail : Microsoft.Graph.Beta.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdentitySet? Initiator
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdentitySet Initiator
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>List of members added.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TeamworkUserIdentity>? Members
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TeamworkUserIdentity>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TeamworkUserIdentity> Members
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TeamworkUserIdentity>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>The timestamp denoting how far back a conversation&apos;s history is shared with the conversation members.</summary>
        public DateTimeOffset? VisibleHistoryStartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("visibleHistoryStartDateTime"); }
            set { BackingStore?.Set("visibleHistoryStartDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.MembersAddedEventMessageDetail"/> and sets the default values.
        /// </summary>
        public MembersAddedEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.membersAddedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MembersAddedEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MembersAddedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MembersAddedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "initiator", n => { Initiator = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TeamworkUserIdentity>(Microsoft.Graph.Beta.Models.TeamworkUserIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                { "visibleHistoryStartDateTime", n => { VisibleHistoryStartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("initiator", Initiator);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TeamworkUserIdentity>("members", Members);
            writer.WriteDateTimeOffsetValue("visibleHistoryStartDateTime", VisibleHistoryStartDateTime);
        }
    }
}
