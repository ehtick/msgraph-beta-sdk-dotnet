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
    /// The type Policy Set.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PolicySet>))]
    public partial class PolicySet : Entity
    {
    
        /// <summary>
        /// Gets or sets created date time.
        /// Creation time of the PolicySet.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the PolicySet.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// DisplayName of the PolicySet.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// Error code if any occured. Possible values are: noError, unauthorized, notFound, deleted.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public ErrorCode? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets guided deployment tags.
        /// Tags of the guided deployment
        /// </summary>
        [JsonPropertyName("guidedDeploymentTags")]
        public IEnumerable<string> GuidedDeploymentTags { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified time of the PolicySet.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tags.
        /// RoleScopeTags of the PolicySet
        /// </summary>
        [JsonPropertyName("roleScopeTags")]
        public IEnumerable<string> RoleScopeTags { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Validation/assignment status of the PolicySet. Possible values are: unknown, validating, partialSuccess, success, error, notAssigned.
        /// </summary>
        [JsonPropertyName("status")]
        public PolicySetStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Assignments of the PolicySet.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IPolicySetAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// Items of the PolicySet with maximum count 100.
        /// </summary>
        [JsonPropertyName("items")]
        public IPolicySetItemsCollectionPage Items { get; set; }

        /// <summary>
        /// Gets or sets itemsNextLink.
        /// </summary>
        [JsonPropertyName("items@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ItemsNextLink { get; set; }
    
    }
}

