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
    /// The type Microsoft Store For Business Contained App.
    /// </summary>
    public partial class MicrosoftStoreForBusinessContainedApp : MobileContainedApp
    {
    
        ///<summary>
        /// The MicrosoftStoreForBusinessContainedApp constructor
        ///</summary>
        public MicrosoftStoreForBusinessContainedApp()
        {
            this.ODataType = "microsoft.graph.microsoftStoreForBusinessContainedApp";
        }

        /// <summary>
        /// Gets or sets app user model id.
        /// The app user model ID of the contained app of a MicrosoftStoreForBusinessApp.
        /// </summary>
        [JsonPropertyName("appUserModelId")]
        public string AppUserModelId { get; set; }
    
    }
}

