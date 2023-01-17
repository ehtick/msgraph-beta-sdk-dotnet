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
    /// The type Temporary Access Pass Authentication Method Configuration.
    /// </summary>
    public partial class TemporaryAccessPassAuthenticationMethodConfiguration : AuthenticationMethodConfiguration
    {
    
        ///<summary>
        /// The TemporaryAccessPassAuthenticationMethodConfiguration constructor
        ///</summary>
        public TemporaryAccessPassAuthenticationMethodConfiguration()
        {
            this.ODataType = "microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration";
        }

        /// <summary>
        /// Gets or sets default length.
        /// Default length in characters of a Temporary Access Pass object. Must be between 8 and 48 characters.
        /// </summary>
        [JsonPropertyName("defaultLength")]
        public Int32? DefaultLength { get; set; }
    
        /// <summary>
        /// Gets or sets default lifetime in minutes.
        /// Default lifetime in minutes for a Temporary Access Pass. Value can be any integer between the minimumLifetimeInMinutes and maximumLifetimeInMinutes.
        /// </summary>
        [JsonPropertyName("defaultLifetimeInMinutes")]
        public Int32? DefaultLifetimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets is usable once.
        /// If true, all the passes in the tenant will be restricted to one-time use. If false, passes in the tenant can be created to be either one-time use or reusable.
        /// </summary>
        [JsonPropertyName("isUsableOnce")]
        public bool? IsUsableOnce { get; set; }
    
        /// <summary>
        /// Gets or sets maximum lifetime in minutes.
        /// Maximum lifetime in minutes for any Temporary Access Pass created in the tenant. Value can be between 10 and 43200 minutes (equivalent to 30 days).
        /// </summary>
        [JsonPropertyName("maximumLifetimeInMinutes")]
        public Int32? MaximumLifetimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets minimum lifetime in minutes.
        /// Minimum lifetime in minutes for any Temporary Access Pass created in the tenant. Value can be between 10 and 43200 minutes (equivalent to 30 days).
        /// </summary>
        [JsonPropertyName("minimumLifetimeInMinutes")]
        public Int32? MinimumLifetimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets include targets.
        /// A collection of groups that are enabled to use the authentication method.
        /// </summary>
        [JsonPropertyName("includeTargets")]
        public ITemporaryAccessPassAuthenticationMethodConfigurationIncludeTargetsCollectionPage IncludeTargets { get; set; }

        /// <summary>
        /// Gets or sets includeTargetsNextLink.
        /// </summary>
        [JsonPropertyName("includeTargets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IncludeTargetsNextLink { get; set; }
    
    }
}

