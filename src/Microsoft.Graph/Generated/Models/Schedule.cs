// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class Schedule : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether copied shifts should include the activities.</summary>
        public bool? ActivitiesIncludedWhenCopyingShiftsEnabled
        {
            get { return BackingStore?.Get<bool?>("activitiesIncludedWhenCopyingShiftsEnabled"); }
            set { BackingStore?.Set("activitiesIncludedWhenCopyingShiftsEnabled", value); }
        }
        /// <summary>The day notes in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DayNote>? DayNotes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DayNote>?>("dayNotes"); }
            set { BackingStore?.Set("dayNotes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DayNote> DayNotes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DayNote>>("dayNotes"); }
            set { BackingStore?.Set("dayNotes", value); }
        }
#endif
        /// <summary>Indicates whether the schedule is enabled for the team. Required.</summary>
        public bool? Enabled
        {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>Indicates whether approval is required by a manager of this schedule for cross location shift requests.</summary>
        public bool? IsCrossLocationShiftRequestApprovalRequired
        {
            get { return BackingStore?.Get<bool?>("isCrossLocationShiftRequestApprovalRequired"); }
            set { BackingStore?.Set("isCrossLocationShiftRequestApprovalRequired", value); }
        }
        /// <summary>Indicates whether the cross-location marketplace feature is enabled for this schedule.</summary>
        public bool? IsCrossLocationShiftsEnabled
        {
            get { return BackingStore?.Get<bool?>("isCrossLocationShiftsEnabled"); }
            set { BackingStore?.Set("isCrossLocationShiftsEnabled", value); }
        }
        /// <summary>The offer requests for shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.OfferShiftRequest>? OfferShiftRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OfferShiftRequest>?>("offerShiftRequests"); }
            set { BackingStore?.Set("offerShiftRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.OfferShiftRequest> OfferShiftRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OfferShiftRequest>>("offerShiftRequests"); }
            set { BackingStore?.Set("offerShiftRequests", value); }
        }
#endif
        /// <summary>Indicates whether offer shift requests are enabled for the schedule.</summary>
        public bool? OfferShiftRequestsEnabled
        {
            get { return BackingStore?.Get<bool?>("offerShiftRequestsEnabled"); }
            set { BackingStore?.Set("offerShiftRequestsEnabled", value); }
        }
        /// <summary>The open shift requests in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.OpenShiftChangeRequest>? OpenShiftChangeRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OpenShiftChangeRequest>?>("openShiftChangeRequests"); }
            set { BackingStore?.Set("openShiftChangeRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.OpenShiftChangeRequest> OpenShiftChangeRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OpenShiftChangeRequest>>("openShiftChangeRequests"); }
            set { BackingStore?.Set("openShiftChangeRequests", value); }
        }
#endif
        /// <summary>The set of open shifts in a scheduling group in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.OpenShift>? OpenShifts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OpenShift>?>("openShifts"); }
            set { BackingStore?.Set("openShifts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.OpenShift> OpenShifts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OpenShift>>("openShifts"); }
            set { BackingStore?.Set("openShifts", value); }
        }
#endif
        /// <summary>Indicates whether open shifts are enabled for the schedule.</summary>
        public bool? OpenShiftsEnabled
        {
            get { return BackingStore?.Get<bool?>("openShiftsEnabled"); }
            set { BackingStore?.Set("openShiftsEnabled", value); }
        }
        /// <summary>The status of the schedule provisioning. The possible values are notStarted, running, completed, failed.</summary>
        public Microsoft.Graph.Beta.Models.OperationStatus? ProvisionStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OperationStatus?>("provisionStatus"); }
            set { BackingStore?.Set("provisionStatus", value); }
        }
        /// <summary>Additional information about why schedule provisioning failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisionStatusCode
        {
            get { return BackingStore?.Get<string?>("provisionStatusCode"); }
            set { BackingStore?.Set("provisionStatusCode", value); }
        }
#nullable restore
#else
        public string ProvisionStatusCode
        {
            get { return BackingStore?.Get<string>("provisionStatusCode"); }
            set { BackingStore?.Set("provisionStatusCode", value); }
        }
#endif
        /// <summary>The logical grouping of users in the schedule (usually by role).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.SchedulingGroup>? SchedulingGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SchedulingGroup>?>("schedulingGroups"); }
            set { BackingStore?.Set("schedulingGroups", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.SchedulingGroup> SchedulingGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SchedulingGroup>>("schedulingGroups"); }
            set { BackingStore?.Set("schedulingGroups", value); }
        }
#endif
        /// <summary>The shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Shift>? Shifts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Shift>?>("shifts"); }
            set { BackingStore?.Set("shifts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Shift> Shifts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Shift>>("shifts"); }
            set { BackingStore?.Set("shifts", value); }
        }
#endif
        /// <summary>The definitions of the roles in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ShiftsRoleDefinition>? ShiftsRoleDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ShiftsRoleDefinition>?>("shiftsRoleDefinitions"); }
            set { BackingStore?.Set("shiftsRoleDefinitions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ShiftsRoleDefinition> ShiftsRoleDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ShiftsRoleDefinition>>("shiftsRoleDefinitions"); }
            set { BackingStore?.Set("shiftsRoleDefinitions", value); }
        }
#endif
        /// <summary>Indicates the start day of the week. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.</summary>
        public Microsoft.Graph.Beta.Models.DayOfWeekObject? StartDayOfWeek
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DayOfWeekObject?>("startDayOfWeek"); }
            set { BackingStore?.Set("startDayOfWeek", value); }
        }
        /// <summary>The swap requests for shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest>? SwapShiftsChangeRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest>?>("swapShiftsChangeRequests"); }
            set { BackingStore?.Set("swapShiftsChangeRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest> SwapShiftsChangeRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest>>("swapShiftsChangeRequests"); }
            set { BackingStore?.Set("swapShiftsChangeRequests", value); }
        }
#endif
        /// <summary>Indicates whether swap shifts requests are enabled for the schedule.</summary>
        public bool? SwapShiftsRequestsEnabled
        {
            get { return BackingStore?.Get<bool?>("swapShiftsRequestsEnabled"); }
            set { BackingStore?.Set("swapShiftsRequestsEnabled", value); }
        }
        /// <summary>The time cards in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TimeCard>? TimeCards
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeCard>?>("timeCards"); }
            set { BackingStore?.Set("timeCards", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TimeCard> TimeCards
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeCard>>("timeCards"); }
            set { BackingStore?.Set("timeCards", value); }
        }
#endif
        /// <summary>Indicates whether time clock is enabled for the schedule.</summary>
        public bool? TimeClockEnabled
        {
            get { return BackingStore?.Get<bool?>("timeClockEnabled"); }
            set { BackingStore?.Set("timeClockEnabled", value); }
        }
        /// <summary>The time clock location settings for this schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TimeClockSettings? TimeClockSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TimeClockSettings?>("timeClockSettings"); }
            set { BackingStore?.Set("timeClockSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TimeClockSettings TimeClockSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TimeClockSettings>("timeClockSettings"); }
            set { BackingStore?.Set("timeClockSettings", value); }
        }
#endif
        /// <summary>The set of reasons for a time off in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TimeOffReason>? TimeOffReasons
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeOffReason>?>("timeOffReasons"); }
            set { BackingStore?.Set("timeOffReasons", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TimeOffReason> TimeOffReasons
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeOffReason>>("timeOffReasons"); }
            set { BackingStore?.Set("timeOffReasons", value); }
        }
#endif
        /// <summary>The time off requests in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TimeOffRequest>? TimeOffRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeOffRequest>?>("timeOffRequests"); }
            set { BackingStore?.Set("timeOffRequests", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TimeOffRequest> TimeOffRequests
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeOffRequest>>("timeOffRequests"); }
            set { BackingStore?.Set("timeOffRequests", value); }
        }
#endif
        /// <summary>Indicates whether time off requests are enabled for the schedule.</summary>
        public bool? TimeOffRequestsEnabled
        {
            get { return BackingStore?.Get<bool?>("timeOffRequestsEnabled"); }
            set { BackingStore?.Set("timeOffRequestsEnabled", value); }
        }
        /// <summary>The instances of times off in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TimeOff>? TimesOff
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeOff>?>("timesOff"); }
            set { BackingStore?.Set("timesOff", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TimeOff> TimesOff
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TimeOff>>("timesOff"); }
            set { BackingStore?.Set("timesOff", value); }
        }
#endif
        /// <summary>Indicates the time zone of the schedule team using tz database format. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone
        {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public string TimeZone
        {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>The IDs for the workforce integrations associated with this schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WorkforceIntegrationIds
        {
            get { return BackingStore?.Get<List<string>?>("workforceIntegrationIds"); }
            set { BackingStore?.Set("workforceIntegrationIds", value); }
        }
#nullable restore
#else
        public List<string> WorkforceIntegrationIds
        {
            get { return BackingStore?.Get<List<string>>("workforceIntegrationIds"); }
            set { BackingStore?.Set("workforceIntegrationIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Schedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Schedule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Schedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activitiesIncludedWhenCopyingShiftsEnabled", n => { ActivitiesIncludedWhenCopyingShiftsEnabled = n.GetBoolValue(); } },
                { "dayNotes", n => { DayNotes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DayNote>(Microsoft.Graph.Beta.Models.DayNote.CreateFromDiscriminatorValue)?.ToList(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "isCrossLocationShiftRequestApprovalRequired", n => { IsCrossLocationShiftRequestApprovalRequired = n.GetBoolValue(); } },
                { "isCrossLocationShiftsEnabled", n => { IsCrossLocationShiftsEnabled = n.GetBoolValue(); } },
                { "offerShiftRequests", n => { OfferShiftRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OfferShiftRequest>(Microsoft.Graph.Beta.Models.OfferShiftRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "offerShiftRequestsEnabled", n => { OfferShiftRequestsEnabled = n.GetBoolValue(); } },
                { "openShiftChangeRequests", n => { OpenShiftChangeRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OpenShiftChangeRequest>(Microsoft.Graph.Beta.Models.OpenShiftChangeRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "openShifts", n => { OpenShifts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OpenShift>(Microsoft.Graph.Beta.Models.OpenShift.CreateFromDiscriminatorValue)?.ToList(); } },
                { "openShiftsEnabled", n => { OpenShiftsEnabled = n.GetBoolValue(); } },
                { "provisionStatus", n => { ProvisionStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.OperationStatus>(); } },
                { "provisionStatusCode", n => { ProvisionStatusCode = n.GetStringValue(); } },
                { "schedulingGroups", n => { SchedulingGroups = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SchedulingGroup>(Microsoft.Graph.Beta.Models.SchedulingGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                { "shifts", n => { Shifts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Shift>(Microsoft.Graph.Beta.Models.Shift.CreateFromDiscriminatorValue)?.ToList(); } },
                { "shiftsRoleDefinitions", n => { ShiftsRoleDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ShiftsRoleDefinition>(Microsoft.Graph.Beta.Models.ShiftsRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "startDayOfWeek", n => { StartDayOfWeek = n.GetEnumValue<Microsoft.Graph.Beta.Models.DayOfWeekObject>(); } },
                { "swapShiftsChangeRequests", n => { SwapShiftsChangeRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest>(Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "swapShiftsRequestsEnabled", n => { SwapShiftsRequestsEnabled = n.GetBoolValue(); } },
                { "timeCards", n => { TimeCards = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeCard>(Microsoft.Graph.Beta.Models.TimeCard.CreateFromDiscriminatorValue)?.ToList(); } },
                { "timeClockEnabled", n => { TimeClockEnabled = n.GetBoolValue(); } },
                { "timeClockSettings", n => { TimeClockSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.TimeClockSettings>(Microsoft.Graph.Beta.Models.TimeClockSettings.CreateFromDiscriminatorValue); } },
                { "timeOffReasons", n => { TimeOffReasons = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeOffReason>(Microsoft.Graph.Beta.Models.TimeOffReason.CreateFromDiscriminatorValue)?.ToList(); } },
                { "timeOffRequests", n => { TimeOffRequests = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeOffRequest>(Microsoft.Graph.Beta.Models.TimeOffRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                { "timeOffRequestsEnabled", n => { TimeOffRequestsEnabled = n.GetBoolValue(); } },
                { "timeZone", n => { TimeZone = n.GetStringValue(); } },
                { "timesOff", n => { TimesOff = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeOff>(Microsoft.Graph.Beta.Models.TimeOff.CreateFromDiscriminatorValue)?.ToList(); } },
                { "workforceIntegrationIds", n => { WorkforceIntegrationIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteBoolValue("activitiesIncludedWhenCopyingShiftsEnabled", ActivitiesIncludedWhenCopyingShiftsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DayNote>("dayNotes", DayNotes);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteBoolValue("isCrossLocationShiftRequestApprovalRequired", IsCrossLocationShiftRequestApprovalRequired);
            writer.WriteBoolValue("isCrossLocationShiftsEnabled", IsCrossLocationShiftsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OfferShiftRequest>("offerShiftRequests", OfferShiftRequests);
            writer.WriteBoolValue("offerShiftRequestsEnabled", OfferShiftRequestsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OpenShiftChangeRequest>("openShiftChangeRequests", OpenShiftChangeRequests);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OpenShift>("openShifts", OpenShifts);
            writer.WriteBoolValue("openShiftsEnabled", OpenShiftsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SchedulingGroup>("schedulingGroups", SchedulingGroups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Shift>("shifts", Shifts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ShiftsRoleDefinition>("shiftsRoleDefinitions", ShiftsRoleDefinitions);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.DayOfWeekObject>("startDayOfWeek", StartDayOfWeek);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest>("swapShiftsChangeRequests", SwapShiftsChangeRequests);
            writer.WriteBoolValue("swapShiftsRequestsEnabled", SwapShiftsRequestsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeCard>("timeCards", TimeCards);
            writer.WriteBoolValue("timeClockEnabled", TimeClockEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TimeClockSettings>("timeClockSettings", TimeClockSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeOffReason>("timeOffReasons", TimeOffReasons);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeOffRequest>("timeOffRequests", TimeOffRequests);
            writer.WriteBoolValue("timeOffRequestsEnabled", TimeOffRequestsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TimeOff>("timesOff", TimesOff);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteCollectionOfPrimitiveValues<string>("workforceIntegrationIds", WorkforceIntegrationIds);
        }
    }
}
