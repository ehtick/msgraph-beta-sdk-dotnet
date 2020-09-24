// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type External Connection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ExternalConnection : Entity
    {
    
		///<summary>
		/// The ExternalConnection constructor
		///</summary>
        public ExternalConnection()
        {
            this.ODataType = "microsoft.graph.externalConnection";
        }
	
        /// <summary>
        /// Gets or sets configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configuration", Required = Newtonsoft.Json.Required.Default)]
        public Configuration Configuration { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public ConnectionState? State { get; set; }
    
        /// <summary>
        /// Gets or sets groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groups", Required = Newtonsoft.Json.Required.Default)]
        public IExternalConnectionGroupsCollectionPage Groups { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public IExternalConnectionItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public IExternalConnectionOperationsCollectionPage Operations { get; set; }
    
        /// <summary>
        /// Gets or sets schema.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schema", Required = Newtonsoft.Json.Required.Default)]
        public Schema Schema { get; set; }
    
    }
}

