// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Case.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<Case>))]
    public partial class Case : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets closed by.
        /// The user who closed the case.
        /// </summary>
        [JsonPropertyName("closedBy")]
        public Microsoft.Graph.IdentitySet ClosedBy { get; set; }
    
        /// <summary>
        /// Gets or sets closed date time.
        /// The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("closedDateTime")]
        public DateTimeOffset? ClosedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time when the entity was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The case description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The case name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// The external case number for customer reference.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// The last user who modified the entity.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The latest date and time when the case was modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The case status. Possible values are unknown, active, pendingDelete, closing, closed, and closedWithError. For details, see the following table.
        /// </summary>
        [JsonPropertyName("status")]
        public CaseStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets custodians.
        /// Returns a list of case custodian objects for this case.  Nullable.
        /// </summary>
        [JsonPropertyName("custodians")]
        public ICaseCustodiansCollectionPage Custodians { get; set; }

        /// <summary>
        /// Gets or sets custodiansNextLink.
        /// </summary>
        [JsonPropertyName("custodians@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CustodiansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets legal holds.
        /// Returns a list of case legalHold objects for this case.  Nullable.
        /// </summary>
        [JsonPropertyName("legalHolds")]
        public ICaseLegalHoldsCollectionPage LegalHolds { get; set; }

        /// <summary>
        /// Gets or sets legalHoldsNextLink.
        /// </summary>
        [JsonPropertyName("legalHolds@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string LegalHoldsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets noncustodial data sources.
        /// Returns a list of case noncustodialDataSource objects for this case.  Nullable.
        /// </summary>
        [JsonPropertyName("noncustodialDataSources")]
        public ICaseNoncustodialDataSourcesCollectionPage NoncustodialDataSources { get; set; }

        /// <summary>
        /// Gets or sets noncustodialDataSourcesNextLink.
        /// </summary>
        [JsonPropertyName("noncustodialDataSources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string NoncustodialDataSourcesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// Returns a list of case operation objects for this case. Nullable.
        /// </summary>
        [JsonPropertyName("operations")]
        public ICaseOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OperationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets review sets.
        /// Returns a list of reviewSet objects in the case. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("reviewSets")]
        public ICaseReviewSetsCollectionPage ReviewSets { get; set; }

        /// <summary>
        /// Gets or sets reviewSetsNextLink.
        /// </summary>
        [JsonPropertyName("reviewSets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ReviewSetsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [JsonPropertyName("settings")]
        public CaseSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets source collections.
        /// Returns a list of sourceCollection objects associated with this case.
        /// </summary>
        [JsonPropertyName("sourceCollections")]
        public ICaseSourceCollectionsCollectionPage SourceCollections { get; set; }

        /// <summary>
        /// Gets or sets sourceCollectionsNextLink.
        /// </summary>
        [JsonPropertyName("sourceCollections@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SourceCollectionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// Returns a list of tag objects associated to this case.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICaseTagsCollectionPage Tags { get; set; }

        /// <summary>
        /// Gets or sets tagsNextLink.
        /// </summary>
        [JsonPropertyName("tags@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TagsNextLink { get; set; }
    
    }
}

