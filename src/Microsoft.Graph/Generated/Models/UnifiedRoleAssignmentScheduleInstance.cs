// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class UnifiedRoleAssignmentScheduleInstance : Microsoft.Graph.Beta.Models.UnifiedRoleScheduleInstanceBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If the request is from an eligible administrator to activate a role, this parameter shows the related eligible assignment for that activation. Otherwise, it&apos;s null. Supports $expand and $select nested in $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleInstance? ActivatedUsing
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleInstance?>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleInstance ActivatedUsing
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleInstance>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#endif
        /// <summary>The type of the assignment that can either be Assigned or Activated. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentType
        {
            get { return BackingStore?.Get<string?>("assignmentType"); }
            set { BackingStore?.Set("assignmentType", value); }
        }
#nullable restore
#else
        public string AssignmentType
        {
            get { return BackingStore?.Get<string>("assignmentType"); }
            set { BackingStore?.Set("assignmentType", value); }
        }
#endif
        /// <summary>The end date of the schedule instance.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>How the assignment is inherited. It can either be Inherited, Direct, or Group. It can further imply whether the unifiedRoleAssignmentSchedule can be managed by the caller. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberType
        {
            get { return BackingStore?.Get<string?>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
#nullable restore
#else
        public string MemberType
        {
            get { return BackingStore?.Get<string>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
#endif
        /// <summary>The identifier of the role assignment in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleAssignmentOriginId
        {
            get { return BackingStore?.Get<string?>("roleAssignmentOriginId"); }
            set { BackingStore?.Set("roleAssignmentOriginId", value); }
        }
#nullable restore
#else
        public string RoleAssignmentOriginId
        {
            get { return BackingStore?.Get<string>("roleAssignmentOriginId"); }
            set { BackingStore?.Set("roleAssignmentOriginId", value); }
        }
#endif
        /// <summary>The identifier of the unifiedRoleAssignmentSchedule object from which this instance was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleAssignmentScheduleId
        {
            get { return BackingStore?.Get<string?>("roleAssignmentScheduleId"); }
            set { BackingStore?.Set("roleAssignmentScheduleId", value); }
        }
#nullable restore
#else
        public string RoleAssignmentScheduleId
        {
            get { return BackingStore?.Get<string>("roleAssignmentScheduleId"); }
            set { BackingStore?.Set("roleAssignmentScheduleId", value); }
        }
#endif
        /// <summary>When this instance starts.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentScheduleInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activatedUsing", n => { ActivatedUsing = n.GetObjectValue<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleInstance>(Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleInstance.CreateFromDiscriminatorValue); } },
                { "assignmentType", n => { AssignmentType = n.GetStringValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "memberType", n => { MemberType = n.GetStringValue(); } },
                { "roleAssignmentOriginId", n => { RoleAssignmentOriginId = n.GetStringValue(); } },
                { "roleAssignmentScheduleId", n => { RoleAssignmentScheduleId = n.GetStringValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleInstance>("activatedUsing", ActivatedUsing);
            writer.WriteStringValue("assignmentType", AssignmentType);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteStringValue("roleAssignmentOriginId", RoleAssignmentOriginId);
            writer.WriteStringValue("roleAssignmentScheduleId", RoleAssignmentScheduleId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
