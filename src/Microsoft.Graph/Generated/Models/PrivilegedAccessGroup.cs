using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedAccessGroup : Entity, IParsable {
        /// <summary>The assignmentScheduleInstances property</summary>
        public List<PrivilegedAccessGroupAssignmentScheduleInstance> AssignmentScheduleInstances {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentScheduleInstance>>("assignmentScheduleInstances"); }
            set { BackingStore?.Set("assignmentScheduleInstances", value); }
        }
        /// <summary>The assignmentScheduleRequests property</summary>
        public List<PrivilegedAccessGroupAssignmentScheduleRequest> AssignmentScheduleRequests {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentScheduleRequest>>("assignmentScheduleRequests"); }
            set { BackingStore?.Set("assignmentScheduleRequests", value); }
        }
        /// <summary>The assignmentSchedules property</summary>
        public List<PrivilegedAccessGroupAssignmentSchedule> AssignmentSchedules {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupAssignmentSchedule>>("assignmentSchedules"); }
            set { BackingStore?.Set("assignmentSchedules", value); }
        }
        /// <summary>The eligibilityScheduleInstances property</summary>
        public List<PrivilegedAccessGroupEligibilityScheduleInstance> EligibilityScheduleInstances {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilityScheduleInstance>>("eligibilityScheduleInstances"); }
            set { BackingStore?.Set("eligibilityScheduleInstances", value); }
        }
        /// <summary>The eligibilityScheduleRequests property</summary>
        public List<PrivilegedAccessGroupEligibilityScheduleRequest> EligibilityScheduleRequests {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilityScheduleRequest>>("eligibilityScheduleRequests"); }
            set { BackingStore?.Set("eligibilityScheduleRequests", value); }
        }
        /// <summary>The eligibilitySchedules property</summary>
        public List<PrivilegedAccessGroupEligibilitySchedule> EligibilitySchedules {
            get { return BackingStore?.Get<List<PrivilegedAccessGroupEligibilitySchedule>>("eligibilitySchedules"); }
            set { BackingStore?.Set("eligibilitySchedules", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentScheduleInstances", n => { AssignmentScheduleInstances = n.GetCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleInstance>(PrivilegedAccessGroupAssignmentScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentScheduleRequests", n => { AssignmentScheduleRequests = n.GetCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleRequest>(PrivilegedAccessGroupAssignmentScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentSchedules", n => { AssignmentSchedules = n.GetCollectionOfObjectValues<PrivilegedAccessGroupAssignmentSchedule>(PrivilegedAccessGroupAssignmentSchedule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eligibilityScheduleInstances", n => { EligibilityScheduleInstances = n.GetCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleInstance>(PrivilegedAccessGroupEligibilityScheduleInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eligibilityScheduleRequests", n => { EligibilityScheduleRequests = n.GetCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleRequest>(PrivilegedAccessGroupEligibilityScheduleRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eligibilitySchedules", n => { EligibilitySchedules = n.GetCollectionOfObjectValues<PrivilegedAccessGroupEligibilitySchedule>(PrivilegedAccessGroupEligibilitySchedule.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleInstance>("assignmentScheduleInstances", AssignmentScheduleInstances);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupAssignmentScheduleRequest>("assignmentScheduleRequests", AssignmentScheduleRequests);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupAssignmentSchedule>("assignmentSchedules", AssignmentSchedules);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleInstance>("eligibilityScheduleInstances", EligibilityScheduleInstances);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupEligibilityScheduleRequest>("eligibilityScheduleRequests", EligibilityScheduleRequests);
            writer.WriteCollectionOfObjectValues<PrivilegedAccessGroupEligibilitySchedule>("eligibilitySchedules", EligibilitySchedules);
        }
    }
}
