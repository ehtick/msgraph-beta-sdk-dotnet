using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageAssignmentRequest : Entity, IParsable {
        /// <summary>The access package associated with the accessPackageAssignmentRequest. An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackage? AccessPackage {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackage?>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackage AccessPackage {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage"); }
            set { BackingStore?.Set("accessPackage", value); }
        }
#endif
        /// <summary>For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.  For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.  Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackageAssignment? AccessPackageAssignment {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageAssignment?>("accessPackageAssignment"); }
            set { BackingStore?.Set("accessPackageAssignment", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackageAssignment AccessPackageAssignment {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageAssignment>("accessPackageAssignment"); }
            set { BackingStore?.Set("accessPackageAssignment", value); }
        }
#endif
        /// <summary>Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAnswer>? Answers {
            get { return BackingStore?.Get<List<AccessPackageAnswer>?>("answers"); }
            set { BackingStore?.Set("answers", value); }
        }
#nullable restore
#else
        public List<AccessPackageAnswer> Answers {
            get { return BackingStore?.Get<List<AccessPackageAnswer>>("answers"); }
            set { BackingStore?.Set("answers", value); }
        }
#endif
        /// <summary>The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CompletedDate {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDate"); }
            set { BackingStore?.Set("completedDate", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Information about all the custom extension calls that were made during the access package assignment request workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionCalloutInstance>? CustomExtensionCalloutInstances {
            get { return BackingStore?.Get<List<CustomExtensionCalloutInstance>?>("customExtensionCalloutInstances"); }
            set { BackingStore?.Set("customExtensionCalloutInstances", value); }
        }
#nullable restore
#else
        public List<CustomExtensionCalloutInstance> CustomExtensionCalloutInstances {
            get { return BackingStore?.Get<List<CustomExtensionCalloutInstance>>("customExtensionCalloutInstances"); }
            set { BackingStore?.Set("customExtensionCalloutInstances", value); }
        }
#endif
        /// <summary>A collection of custom workflow extension instances being run on an assignment request. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomExtensionHandlerInstance>? CustomExtensionHandlerInstances {
            get { return BackingStore?.Get<List<CustomExtensionHandlerInstance>?>("customExtensionHandlerInstances"); }
            set { BackingStore?.Set("customExtensionHandlerInstances", value); }
        }
#nullable restore
#else
        public List<CustomExtensionHandlerInstance> CustomExtensionHandlerInstances {
            get { return BackingStore?.Get<List<CustomExtensionHandlerInstance>>("customExtensionHandlerInstances"); }
            set { BackingStore?.Set("customExtensionHandlerInstances", value); }
        }
#endif
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>True if the request is not to be processed for assignment.</summary>
        public bool? IsValidationOnly {
            get { return BackingStore?.Get<bool?>("isValidationOnly"); }
            set { BackingStore?.Set("isValidationOnly", value); }
        }
        /// <summary>The requestor&apos;s supplied justification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageSubject? Requestor {
            get { return BackingStore?.Get<AccessPackageSubject?>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#nullable restore
#else
        public AccessPackageSubject Requestor {
            get { return BackingStore?.Get<AccessPackageSubject>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#endif
        /// <summary>One of PendingApproval, Canceled,  Denied, Delivering, Delivered, PartiallyDelivered, DeliveryFailed, Submitted or Scheduled. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestState {
            get { return BackingStore?.Get<string?>("requestState"); }
            set { BackingStore?.Set("requestState", value); }
        }
#nullable restore
#else
        public string RequestState {
            get { return BackingStore?.Get<string>("requestState"); }
            set { BackingStore?.Set("requestState", value); }
        }
#endif
        /// <summary>More information on the request processing status. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestStatus {
            get { return BackingStore?.Get<string?>("requestStatus"); }
            set { BackingStore?.Set("requestStatus", value); }
        }
#nullable restore
#else
        public string RequestStatus {
            get { return BackingStore?.Get<string>("requestStatus"); }
            set { BackingStore?.Set("requestStatus", value); }
        }
#endif
        /// <summary>One of UserAdd, UserExtend, UserUpdate, UserRemove, AdminAdd, AdminRemove or SystemRemove. A request from the user themselves would have requestType of UserAdd, UserUpdate or UserRemove. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestType {
            get { return BackingStore?.Get<string?>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
#nullable restore
#else
        public string RequestType {
            get { return BackingStore?.Get<string>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
#endif
        /// <summary>The range of dates that access is to be assigned to the requestor. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestSchedule? Schedule {
            get { return BackingStore?.Get<RequestSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public RequestSchedule Schedule {
            get { return BackingStore?.Get<RequestSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>The details of the verifiable credential that was presented by the requestor, such as the issuer and claims. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VerifiedCredentialData>? VerifiedCredentialsData {
            get { return BackingStore?.Get<List<VerifiedCredentialData>?>("verifiedCredentialsData"); }
            set { BackingStore?.Set("verifiedCredentialsData", value); }
        }
#nullable restore
#else
        public List<VerifiedCredentialData> VerifiedCredentialsData {
            get { return BackingStore?.Get<List<VerifiedCredentialData>>("verifiedCredentialsData"); }
            set { BackingStore?.Set("verifiedCredentialsData", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackage", n => { AccessPackage = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>(Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                {"accessPackageAssignment", n => { AccessPackageAssignment = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageAssignment>(Microsoft.Graph.Beta.Models.AccessPackageAssignment.CreateFromDiscriminatorValue); } },
                {"answers", n => { Answers = n.GetCollectionOfObjectValues<AccessPackageAnswer>(AccessPackageAnswer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"completedDate", n => { CompletedDate = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customExtensionCalloutInstances", n => { CustomExtensionCalloutInstances = n.GetCollectionOfObjectValues<CustomExtensionCalloutInstance>(CustomExtensionCalloutInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customExtensionHandlerInstances", n => { CustomExtensionHandlerInstances = n.GetCollectionOfObjectValues<CustomExtensionHandlerInstance>(CustomExtensionHandlerInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"requestor", n => { Requestor = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"requestState", n => { RequestState = n.GetStringValue(); } },
                {"requestStatus", n => { RequestStatus = n.GetStringValue(); } },
                {"requestType", n => { RequestType = n.GetStringValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                {"verifiedCredentialsData", n => { VerifiedCredentialsData = n.GetCollectionOfObjectValues<VerifiedCredentialData>(VerifiedCredentialData.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageAssignment>("accessPackageAssignment", AccessPackageAssignment);
            writer.WriteCollectionOfObjectValues<AccessPackageAnswer>("answers", Answers);
            writer.WriteDateTimeOffsetValue("completedDate", CompletedDate);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomExtensionCalloutInstance>("customExtensionCalloutInstances", CustomExtensionCalloutInstances);
            writer.WriteCollectionOfObjectValues<CustomExtensionHandlerInstance>("customExtensionHandlerInstances", CustomExtensionHandlerInstances);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<AccessPackageSubject>("requestor", Requestor);
            writer.WriteStringValue("requestState", RequestState);
            writer.WriteStringValue("requestStatus", RequestStatus);
            writer.WriteStringValue("requestType", RequestType);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
            writer.WriteCollectionOfObjectValues<VerifiedCredentialData>("verifiedCredentialsData", VerifiedCredentialsData);
        }
    }
}
