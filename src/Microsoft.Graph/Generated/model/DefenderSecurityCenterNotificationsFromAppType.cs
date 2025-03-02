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
    /// The enum DefenderSecurityCenterNotificationsFromAppType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DefenderSecurityCenterNotificationsFromAppType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Block Noncritical Notifications
        /// </summary>
        BlockNoncriticalNotifications = 1,
	
        /// <summary>
        /// Block All Notifications
        /// </summary>
        BlockAllNotifications = 2,
	
    }
}
