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
    /// The type Data Source Container.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<DataSourceContainer>))]
    public partial class DataSourceContainer : Microsoft.Graph.Entity
    {
    
        ///<summary>
        /// The internal DataSourceContainer constructor
        ///</summary>
        protected internal DataSourceContainer()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Created date and time of the dataSourceContainer entity.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the dataSourceContainer entity.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets hold status.
        /// </summary>
        [JsonPropertyName("holdStatus")]
        public DataSourceHoldStatus? HoldStatus { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified date and time of the dataSourceContainer.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets released date time.
        /// Date and time that the dataSourceContainer was released from the case.
        /// </summary>
        [JsonPropertyName("releasedDateTime")]
        public DateTimeOffset? ReleasedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Latest status of the dataSourceContainer. Possible values are: Active, Released.
        /// </summary>
        [JsonPropertyName("status")]
        public DataSourceContainerStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets last index operation.
        /// </summary>
        [JsonPropertyName("lastIndexOperation")]
        public CaseIndexOperation LastIndexOperation { get; set; }
    
    }
}

