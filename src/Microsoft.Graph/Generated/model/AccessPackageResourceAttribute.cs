// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AccessPackageResourceAttribute.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AccessPackageResourceAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPackageResourceAttribute"/> class.
        /// </summary>
        public AccessPackageResourceAttribute()
        {
            this.ODataType = "microsoft.graph.accessPackageResourceAttribute";
        }

        /// <summary>
        /// Gets or sets attributeDestination.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attributeDestination", Required = Newtonsoft.Json.Required.Default)]
        public AccessPackageResourceAttributeDestination AttributeDestination { get; set; }
    
        /// <summary>
        /// Gets or sets attributeName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attributeName", Required = Newtonsoft.Json.Required.Default)]
        public string AttributeName { get; set; }
    
        /// <summary>
        /// Gets or sets attributeSource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attributeSource", Required = Newtonsoft.Json.Required.Default)]
        public AccessPackageResourceAttributeSource AttributeSource { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
