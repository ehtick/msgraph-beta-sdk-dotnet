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
    /// The type Item Email.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ItemEmail>))]
    public partial class ItemEmail : ItemFacet
    {
    
        ///<summary>
        /// The ItemEmail constructor
        ///</summary>
        public ItemEmail()
        {
            this.ODataType = "microsoft.graph.itemEmail";
        }

        /// <summary>
        /// Gets or sets address.
        /// The email address itself.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name or label a user has associated with a particular email address.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The type of email address. Possible values are: unknown, work, personal, main, other.
        /// </summary>
        [JsonPropertyName("type")]
        public EmailType? Type { get; set; }
    
    }
}

