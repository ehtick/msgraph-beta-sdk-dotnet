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
    /// The enum DetectedAppPlatformType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DetectedAppPlatformType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Windows
        /// </summary>
        Windows = 1,
	
        /// <summary>
        /// Windows Mobile
        /// </summary>
        WindowsMobile = 2,
	
        /// <summary>
        /// Windows Holographic
        /// </summary>
        WindowsHolographic = 3,
	
        /// <summary>
        /// Ios
        /// </summary>
        Ios = 4,
	
        /// <summary>
        /// Mac OS
        /// </summary>
        MacOS = 5,
	
        /// <summary>
        /// Chrome OS
        /// </summary>
        ChromeOS = 6,
	
        /// <summary>
        /// Android OSP
        /// </summary>
        AndroidOSP = 7,
	
        /// <summary>
        /// Android Device Administrator
        /// </summary>
        AndroidDeviceAdministrator = 8,
	
        /// <summary>
        /// Android Work Profile
        /// </summary>
        AndroidWorkProfile = 9,
	
        /// <summary>
        /// Android Dedicated And Fully Managed
        /// </summary>
        AndroidDedicatedAndFullyManaged = 10,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 11,
	
    }
}
