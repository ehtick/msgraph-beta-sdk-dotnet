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
    /// The enum MacOSSoftwareUpdateScheduleType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MacOSSoftwareUpdateScheduleType
    {
    
        /// <summary>
        /// Always Update
        /// </summary>
        AlwaysUpdate = 0,
	
        /// <summary>
        /// Update During Time Windows
        /// </summary>
        UpdateDuringTimeWindows = 1,
	
        /// <summary>
        /// Update Outside Of Time Windows
        /// </summary>
        UpdateOutsideOfTimeWindows = 2,
	
    }
}
