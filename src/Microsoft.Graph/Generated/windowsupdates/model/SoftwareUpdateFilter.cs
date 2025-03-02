// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SoftwareUpdateFilter.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<SoftwareUpdateFilter>))]
    public partial class SoftwareUpdateFilter : ContentFilter
    {

        ///<summary>
        /// The internal SoftwareUpdateFilter constructor
        ///</summary>
        protected internal SoftwareUpdateFilter()
        {
            // Don't allow initialization of abstract complex types
        }

    }
}
