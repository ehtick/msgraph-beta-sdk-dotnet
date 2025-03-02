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
    /// The type WinGetAppAssignmentSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WinGetAppAssignmentSettings>))]
    public partial class WinGetAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinGetAppAssignmentSettings"/> class.
        /// </summary>
        public WinGetAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.winGetAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets installTimeSettings.
        /// The install time settings to apply for this app assignment.
        /// </summary>
        [JsonPropertyName("installTimeSettings")]
        public WinGetAppInstallTimeSettings InstallTimeSettings { get; set; }
    
        /// <summary>
        /// Gets or sets notifications.
        /// The notification status for this app assignment. Possible values are: showAll, showReboot, hideAll, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("notifications")]
        public WinGetAppNotification? Notifications { get; set; }
    
        /// <summary>
        /// Gets or sets restartSettings.
        /// The reboot settings to apply for this app assignment.
        /// </summary>
        [JsonPropertyName("restartSettings")]
        public WinGetAppRestartSettings RestartSettings { get; set; }
    
    }
}
