// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.DeviceManagementNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum NotificationChannelType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NotificationChannelType
    {
    
        /// <summary>
        /// Portal
        /// </summary>
        Portal = 0,
	
        /// <summary>
        /// Email
        /// </summary>
        Email = 1,
	
        /// <summary>
        /// Phone Call
        /// </summary>
        PhoneCall = 2,
	
        /// <summary>
        /// Sms
        /// </summary>
        Sms = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 999,
	
    }
}
