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
    /// The type Onenote Entity Schema Object Model.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnenoteEntitySchemaObjectModel>))]
    public partial class OnenoteEntitySchemaObjectModel : OnenoteEntityBaseModel
    {
    
        ///<summary>
        /// The internal OnenoteEntitySchemaObjectModel constructor
        ///</summary>
        protected internal OnenoteEntitySchemaObjectModel()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
    }
}

