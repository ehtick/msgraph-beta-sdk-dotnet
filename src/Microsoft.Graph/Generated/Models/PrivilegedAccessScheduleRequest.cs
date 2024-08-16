// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PrivilegedAccessScheduleRequest : Microsoft.Graph.Beta.Models.Request, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the type of operation on the group membership or ownership assignment request. The possible values are: adminAssign, adminUpdate, adminRemove, selfActivate, selfDeactivate, adminExtend, adminRenew. adminAssign: For administrators to assign group membership or ownership to principals.adminRemove: For administrators to remove principals from group membership or ownership. adminUpdate: For administrators to change existing group membership or ownership assignments.adminExtend: For administrators to extend expiring assignments.adminRenew: For administrators to renew expired assignments.selfActivate: For principals to activate their assignments.selfDeactivate: For principals to deactivate their active assignments.</summary>
        public Microsoft.Graph.Beta.Models.ScheduleRequestActions? Action
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ScheduleRequestActions?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.</summary>
        public bool? IsValidationOnly
        {
            get { return BackingStore?.Get<bool?>("isValidationOnly"); }
            set { BackingStore?.Set("isValidationOnly", value); }
        }
        /// <summary>A message provided by users and administrators when create they create the privilegedAccessGroupAssignmentScheduleRequest object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification
        {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification
        {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>The period of the group membership or ownership assignment. Recurring schedules are currently unsupported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.RequestSchedule? ScheduleInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RequestSchedule?>("scheduleInfo"); }
            set { BackingStore?.Set("scheduleInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.RequestSchedule ScheduleInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RequestSchedule>("scheduleInfo"); }
            set { BackingStore?.Set("scheduleInfo", value); }
        }
#endif
        /// <summary>Ticket details linked to the group membership or ownership assignment request including details of the ticket number and ticket system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TicketInfo? TicketInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TicketInfo?>("ticketInfo"); }
            set { BackingStore?.Set("ticketInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TicketInfo TicketInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TicketInfo>("ticketInfo"); }
            set { BackingStore?.Set("ticketInfo", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.PrivilegedAccessScheduleRequest"/> and sets the default values.
        /// </summary>
        public PrivilegedAccessScheduleRequest() : base()
        {
            OdataType = "#microsoft.graph.privilegedAccessScheduleRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PrivilegedAccessScheduleRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.PrivilegedAccessScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.privilegedAccessGroupAssignmentScheduleRequest" => new Microsoft.Graph.Beta.Models.PrivilegedAccessGroupAssignmentScheduleRequest(),
                "#microsoft.graph.privilegedAccessGroupEligibilityScheduleRequest" => new Microsoft.Graph.Beta.Models.PrivilegedAccessGroupEligibilityScheduleRequest(),
                _ => new Microsoft.Graph.Beta.Models.PrivilegedAccessScheduleRequest(),
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
                { "action", n => { Action = n.GetEnumValue<Microsoft.Graph.Beta.Models.ScheduleRequestActions>(); } },
                { "isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.RequestSchedule>(Microsoft.Graph.Beta.Models.RequestSchedule.CreateFromDiscriminatorValue); } },
                { "ticketInfo", n => { TicketInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.TicketInfo>(Microsoft.Graph.Beta.Models.TicketInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ScheduleRequestActions>("action", Action);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RequestSchedule>("scheduleInfo", ScheduleInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}
