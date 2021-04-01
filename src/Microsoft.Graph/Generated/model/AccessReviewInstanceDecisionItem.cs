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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Access Review Instance Decision Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessReviewInstanceDecisionItem : Entity
    {
    
		///<summary>
		/// The AccessReviewInstanceDecisionItem constructor
		///</summary>
        public AccessReviewInstanceDecisionItem()
        {
            this.ODataType = "microsoft.graph.accessReviewInstanceDecisionItem";
        }
	
        /// <summary>
        /// Gets or sets access review id.
        /// The identifier of the accessReviewInstance parent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessReviewId", Required = Newtonsoft.Json.Required.Default)]
        public string AccessReviewId { get; set; }
    
        /// <summary>
        /// Gets or sets applied by.
        /// The identifier of the user who applied the decision.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedBy", Required = Newtonsoft.Json.Required.Default)]
        public UserIdentity AppliedBy { get; set; }
    
        /// <summary>
        /// Gets or sets applied date time.
        /// The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AppliedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets apply result.
        /// The result of applying the decision. Possible values: NotApplied, Success, Failed, NotFound, or NotSupported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applyResult", Required = Newtonsoft.Json.Required.Default)]
        public string ApplyResult { get; set; }
    
        /// <summary>
        /// Gets or sets decision.
        /// Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "decision", Required = Newtonsoft.Json.Required.Default)]
        public string Decision { get; set; }
    
        /// <summary>
        /// Gets or sets justification.
        /// The review decision justification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "justification", Required = Newtonsoft.Json.Required.Default)]
        public string Justification { get; set; }
    
        /// <summary>
        /// Gets or sets principal.
        /// Every decision item in an access review represents a principal's access to a resource. This property represents details of the principal. For example, if a decision item represents access of User 'Bob' to Group 'Sales' - The principal is 'Bob' and the resource is 'Sales'. Principals can be of two types - userIdentity and servicePrincipalIdentity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principal", Required = Newtonsoft.Json.Required.Default)]
        public Identity Principal { get; set; }
    
        /// <summary>
        /// Gets or sets principal link.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalLink", Required = Newtonsoft.Json.Required.Default)]
        public string PrincipalLink { get; set; }
    
        /// <summary>
        /// Gets or sets recommendation.
        /// A system-generated recommendation for the approval decision. Possible values: Approve, Deny, or NotAvailable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recommendation", Required = Newtonsoft.Json.Required.Default)]
        public string Recommendation { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Every decision item in an access review represents a principal's access to a resource. This property represents details of the resource. For example, if a decision item represents access of User 'Bob' to Group 'Sales' - The principal is Bob and the resource is 'Sales'. Resources can be of multiple types. See accessReviewInstanceDecisionItemResource
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public AccessReviewInstanceDecisionItemResource Resource { get; set; }
    
        /// <summary>
        /// Gets or sets resource link.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceLink", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceLink { get; set; }
    
        /// <summary>
        /// Gets or sets reviewed by.
        /// The identifier of the reviewer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewedBy", Required = Newtonsoft.Json.Required.Default)]
        public UserIdentity ReviewedBy { get; set; }
    
        /// <summary>
        /// Gets or sets reviewed date time.
        /// The timestamp when the review occurred.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReviewedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The target of this specific decision. Decision targets can be of different types – each one with its own specific properties. See accessReviewInstanceDecisionItemTarget.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target", Required = Newtonsoft.Json.Required.Default)]
        public AccessReviewInstanceDecisionItemTarget Target { get; set; }
    
    }
}

