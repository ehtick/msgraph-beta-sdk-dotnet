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
    /// The type Site Source.
    /// </summary>
    public partial class SiteSource : DataSource
    {
    
        ///<summary>
        /// The SiteSource constructor
        ///</summary>
        public SiteSource()
        {
            this.ODataType = "microsoft.graph.ediscovery.siteSource";
        }

        /// <summary>
        /// Gets or sets site.
        /// The SharePoint site associated with the siteSource.
        /// </summary>
        [JsonPropertyName("site")]
        public Microsoft.Graph.Site Site { get; set; }
    
    }
}

