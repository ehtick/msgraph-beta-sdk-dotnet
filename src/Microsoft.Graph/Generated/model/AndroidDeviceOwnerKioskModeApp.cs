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
    /// The type AndroidDeviceOwnerKioskModeApp.
    /// </summary>
    public partial class AndroidDeviceOwnerKioskModeApp : AndroidDeviceOwnerKioskModeFolderItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidDeviceOwnerKioskModeApp"/> class.
        /// </summary>
        public AndroidDeviceOwnerKioskModeApp()
        {
            this.ODataType = "microsoft.graph.androidDeviceOwnerKioskModeApp";
        }

        /// <summary>
        /// Gets or sets className.
        /// Class name of application
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; }
    
        /// <summary>
        /// Gets or sets package.
        /// Package name of application
        /// </summary>
        [JsonPropertyName("package")]
        public string Package { get; set; }
    
    }
}
