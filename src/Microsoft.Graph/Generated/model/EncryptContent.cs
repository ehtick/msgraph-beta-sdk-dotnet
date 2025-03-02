// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type EncryptContent.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EncryptContent>))]
    public partial class EncryptContent : LabelActionBase
    {

        ///<summary>
        /// The internal EncryptContent constructor
        ///</summary>
        protected internal EncryptContent()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets encryptWith.
        /// </summary>
        [JsonPropertyName("encryptWith")]
        public EncryptWith? EncryptWith { get; set; }
    
    }
}
