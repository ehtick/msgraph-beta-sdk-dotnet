// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Ediscovery Noncustodial Data Source.
    /// </summary>
    public partial class EdiscoveryNoncustodialDataSource : DataSourceContainer
    {
    
        ///<summary>
        /// The EdiscoveryNoncustodialDataSource constructor
        ///</summary>
        public EdiscoveryNoncustodialDataSource()
        {
            this.ODataType = "microsoft.graph.security.ediscoveryNoncustodialDataSource";
        }

        /// <summary>
        /// Gets or sets data source.
        /// User source or SharePoint site data source as non-custodial data source.
        /// </summary>
        [JsonPropertyName("dataSource")]
        public DataSource DataSource { get; set; }
    
        /// <summary>
        /// Gets or sets last index operation.
        /// Operation entity that represents the latest indexing for the non-custodial data source.
        /// </summary>
        [JsonPropertyName("lastIndexOperation")]
        public EdiscoveryIndexOperation LastIndexOperation { get; set; }
    
    }
}

