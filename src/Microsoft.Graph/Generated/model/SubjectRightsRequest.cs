// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Subject Rights Request.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SubjectRightsRequestObject>))]
    public partial class SubjectRightsRequestObject : Entity
    {
    
        /// <summary>
        /// Gets or sets assigned to.
        /// Identity that the request is assigned to.
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public Identity AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets closed date time.
        /// The date and time when the request was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("closedDateTime")]
        public DateTimeOffset? ClosedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets content query.
        /// KQL based content query that should be used for search. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.
        /// </summary>
        [JsonPropertyName("contentQuery")]
        public string ContentQuery { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Identity information for the entity that created the request.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time when the request was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets data subject.
        /// Information about the data subject.
        /// </summary>
        [JsonPropertyName("dataSubject")]
        public DataSubject DataSubject { get; set; }
    
        /// <summary>
        /// Gets or sets data subject type.
        /// The type of the data subject. Possible values are: customer, currentEmployee, formerEmployee, prospectiveEmployee, student, teacher, faculty, other, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("dataSubjectType")]
        public DataSubjectType? DataSubjectType { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description for the request.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the request.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// The external ID for the request that is immutable after creation and is used for tracking the request for the external system. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets history.
        /// Collection of history change events.
        /// </summary>
        [JsonPropertyName("history")]
        public IEnumerable<SubjectRightsRequestHistory> History { get; set; }
    
        /// <summary>
        /// Gets or sets include all versions.
        /// Include all versions of the documents. By default, the current copies of the documents will be returned. If SharePoint sites have versioning enabled, including all versions will include the historical copies of the documents. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.
        /// </summary>
        [JsonPropertyName("includeAllVersions")]
        public bool? IncludeAllVersions { get; set; }
    
        /// <summary>
        /// Gets or sets include authored content.
        /// Include content authored by the data subject. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.
        /// </summary>
        [JsonPropertyName("includeAuthoredContent")]
        public bool? IncludeAuthoredContent { get; set; }
    
        /// <summary>
        /// Gets or sets insight.
        /// Insight about the request.
        /// </summary>
        [JsonPropertyName("insight")]
        public SubjectRightsRequestDetail Insight { get; set; }
    
        /// <summary>
        /// Gets or sets internal due date time.
        /// The date and time when the request is internally due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("internalDueDateTime")]
        public DateTimeOffset? InternalDueDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// Identity information for the entity that last modified the request.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time when the request was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets mailboxlocations.
        /// </summary>
        [JsonPropertyName("mailboxlocations")]
        public SubjectRightsRequestMailboxLocation Mailboxlocations { get; set; }
    
        /// <summary>
        /// Gets or sets pause after estimate.
        /// Pause the request after estimate has finished. By default, the data estimate will run and then pause, allowing you to preview results and then select the option to retrieve data in the UI. You can set this property to false if you want it to perform the estimate and then automatically begin with the retrieval of the content. This property is defined only for APIs accessed using the /security query path and not the /privacy query path.
        /// </summary>
        [JsonPropertyName("pauseAfterEstimate")]
        public bool? PauseAfterEstimate { get; set; }
    
        /// <summary>
        /// Gets or sets regulations.
        /// List of regulations that this request will fulfill.
        /// </summary>
        [JsonPropertyName("regulations")]
        public IEnumerable<string> Regulations { get; set; }
    
        /// <summary>
        /// Gets or sets sitelocations.
        /// </summary>
        [JsonPropertyName("sitelocations")]
        public SubjectRightsRequestSiteLocation Sitelocations { get; set; }
    
        /// <summary>
        /// Gets or sets stages.
        /// Information about the different stages for the request.
        /// </summary>
        [JsonPropertyName("stages")]
        public IEnumerable<SubjectRightsRequestStageDetail> Stages { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the request. Possible values are: active, closed, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public SubjectRightsRequestStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The type of the request. Possible values are: export, delete, access, tagForAction, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("type")]
        public SubjectRightsRequestType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// List of notes associated with the request.
        /// </summary>
        [JsonPropertyName("notes")]
        public ISubjectRightsRequestNotesCollectionPage Notes { get; set; }

        /// <summary>
        /// Gets or sets notesNextLink.
        /// </summary>
        [JsonPropertyName("notes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string NotesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets team.
        /// Information about the Microsoft Teams team that was created for the request.
        /// </summary>
        [JsonPropertyName("team")]
        public Team Team { get; set; }
    
    }
}

