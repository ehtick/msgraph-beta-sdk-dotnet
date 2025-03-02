// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum AutomaticUpdateMode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AutomaticUpdateMode
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Notify Download
        /// </summary>
        NotifyDownload = 1,
	
        /// <summary>
        /// Auto Install At Maintenance Time
        /// </summary>
        AutoInstallAtMaintenanceTime = 2,
	
        /// <summary>
        /// Auto Install And Reboot At Maintenance Time
        /// </summary>
        AutoInstallAndRebootAtMaintenanceTime = 3,
	
        /// <summary>
        /// Auto Install And Reboot At Scheduled Time
        /// </summary>
        AutoInstallAndRebootAtScheduledTime = 4,
	
        /// <summary>
        /// Auto Install And Reboot Without End User Control
        /// </summary>
        AutoInstallAndRebootWithoutEndUserControl = 5,
	
        /// <summary>
        /// Windows Default
        /// </summary>
        WindowsDefault = 6,
	
    }
}
