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
    /// The enum EnrollmentRestrictionPlatformType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnrollmentRestrictionPlatformType
    {
    
        /// <summary>
        /// All Platforms
        /// </summary>
        AllPlatforms = 0,
	
        /// <summary>
        /// Ios
        /// </summary>
        Ios = 1,
	
        /// <summary>
        /// Windows
        /// </summary>
        Windows = 2,
	
        /// <summary>
        /// Windows Phone
        /// </summary>
        WindowsPhone = 3,
	
        /// <summary>
        /// Android
        /// </summary>
        Android = 4,
	
        /// <summary>
        /// Android For Work
        /// </summary>
        AndroidForWork = 5,
	
        /// <summary>
        /// Mac
        /// </summary>
        Mac = 7,
	
        /// <summary>
        /// Linux
        /// </summary>
        Linux = 8,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 9,
	
    }
}
