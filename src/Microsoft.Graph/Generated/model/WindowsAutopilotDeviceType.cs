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
    /// The enum WindowsAutopilotDeviceType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsAutopilotDeviceType
    {
    
        /// <summary>
        /// Windows Pc
        /// </summary>
        WindowsPc = 0,
	
        /// <summary>
        /// Surface Hub2
        /// </summary>
        SurfaceHub2 = 1,
	
        /// <summary>
        /// Holo Lens
        /// </summary>
        HoloLens = 2,
	
        /// <summary>
        /// Surface Hub2S
        /// </summary>
        SurfaceHub2S = 3,
	
        /// <summary>
        /// Virtual Machine
        /// </summary>
        VirtualMachine = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 99,
	
    }
}
