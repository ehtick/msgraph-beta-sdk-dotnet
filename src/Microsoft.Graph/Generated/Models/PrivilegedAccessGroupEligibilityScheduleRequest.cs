using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedAccessGroupEligibilityScheduleRequest : PrivilegedAccessScheduleRequest, IParsable {
        /// <summary>The accessId property</summary>
        public PrivilegedAccessGroupRelationships? AccessId {
            get { return BackingStore?.Get<PrivilegedAccessGroupRelationships?>("accessId"); }
            set { BackingStore?.Set("accessId", value); }
        }
        /// <summary>The group property</summary>
        public Microsoft.Graph.Beta.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
        /// <summary>The groupId property</summary>
        public string GroupId {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
        /// <summary>The principal property</summary>
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
        /// <summary>The principalId property</summary>
        public string PrincipalId {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
        /// <summary>The targetSchedule property</summary>
        public PrivilegedAccessGroupEligibilitySchedule TargetSchedule {
            get { return BackingStore?.Get<PrivilegedAccessGroupEligibilitySchedule>("targetSchedule"); }
            set { BackingStore?.Set("targetSchedule", value); }
        }
        /// <summary>The targetScheduleId property</summary>
        public string TargetScheduleId {
            get { return BackingStore?.Get<string>("targetScheduleId"); }
            set { BackingStore?.Set("targetScheduleId", value); }
        }
        /// <summary>
        /// Instantiates a new PrivilegedAccessGroupEligibilityScheduleRequest and sets the default values.
        /// </summary>
        public PrivilegedAccessGroupEligibilityScheduleRequest() : base() {
            OdataType = "#microsoft.graph.privilegedAccessGroupEligibilityScheduleRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessGroupEligibilityScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessGroupEligibilityScheduleRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessId", n => { AccessId = n.GetEnumValue<PrivilegedAccessGroupRelationships>(); } },
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"targetSchedule", n => { TargetSchedule = n.GetObjectValue<PrivilegedAccessGroupEligibilitySchedule>(PrivilegedAccessGroupEligibilitySchedule.CreateFromDiscriminatorValue); } },
                {"targetScheduleId", n => { TargetScheduleId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PrivilegedAccessGroupRelationships>("accessId", AccessId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<PrivilegedAccessGroupEligibilitySchedule>("targetSchedule", TargetSchedule);
            writer.WriteStringValue("targetScheduleId", TargetScheduleId);
        }
    }
}
