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
    /// The type MacOsLobAppAssignmentSettings.
    /// </summary>
    public partial class MacOsLobAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacOsLobAppAssignmentSettings"/> class.
        /// </summary>
        public MacOsLobAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.macOsLobAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets uninstallOnDeviceRemoval.
        /// Whether or not to uninstall the app when device is removed from Intune.
        /// </summary>
        [JsonPropertyName("uninstallOnDeviceRemoval")]
        public bool? UninstallOnDeviceRemoval { get; set; }
    
    }
}
