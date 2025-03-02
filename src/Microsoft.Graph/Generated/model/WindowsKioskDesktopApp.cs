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
    /// The type WindowsKioskDesktopApp.
    /// </summary>
    public partial class WindowsKioskDesktopApp : WindowsKioskAppBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsKioskDesktopApp"/> class.
        /// </summary>
        public WindowsKioskDesktopApp()
        {
            this.ODataType = "microsoft.graph.windowsKioskDesktopApp";
        }

        /// <summary>
        /// Gets or sets desktopApplicationId.
        /// Define the DesktopApplicationID of the app
        /// </summary>
        [JsonPropertyName("desktopApplicationId")]
        public string DesktopApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets desktopApplicationLinkPath.
        /// Define the DesktopApplicationLinkPath of the app
        /// </summary>
        [JsonPropertyName("desktopApplicationLinkPath")]
        public string DesktopApplicationLinkPath { get; set; }
    
        /// <summary>
        /// Gets or sets path.
        /// Define the path of a desktop app
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }
    
    }
}
