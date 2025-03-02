// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Updatable Asset.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<UpdatableAsset>))]
    public partial class UpdatableAsset : Microsoft.Graph.Entity
    {
    
        ///<summary>
        /// The internal UpdatableAsset constructor
        ///</summary>
        protected internal UpdatableAsset()
        {
            // Don't allow initialization of abstract entity types
        }
    
    }
}

