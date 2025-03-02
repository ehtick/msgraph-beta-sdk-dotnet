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
    /// The enum PrinterProcessingStateReason.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrinterProcessingStateReason
    {
    
        /// <summary>
        /// Paused
        /// </summary>
        Paused = 0,
	
        /// <summary>
        /// Media Jam
        /// </summary>
        MediaJam = 2,
	
        /// <summary>
        /// Media Needed
        /// </summary>
        MediaNeeded = 3,
	
        /// <summary>
        /// Media Low
        /// </summary>
        MediaLow = 4,
	
        /// <summary>
        /// Media Empty
        /// </summary>
        MediaEmpty = 5,
	
        /// <summary>
        /// Cover Open
        /// </summary>
        CoverOpen = 6,
	
        /// <summary>
        /// Interlock Open
        /// </summary>
        InterlockOpen = 7,
	
        /// <summary>
        /// Output Tray Missing
        /// </summary>
        OutputTrayMissing = 9,
	
        /// <summary>
        /// Output Area Full
        /// </summary>
        OutputAreaFull = 10,
	
        /// <summary>
        /// Marker Supply Low
        /// </summary>
        MarkerSupplyLow = 11,
	
        /// <summary>
        /// Marker Supply Empty
        /// </summary>
        MarkerSupplyEmpty = 12,
	
        /// <summary>
        /// Input Tray Missing
        /// </summary>
        InputTrayMissing = 13,
	
        /// <summary>
        /// Output Area Almost Full
        /// </summary>
        OutputAreaAlmostFull = 14,
	
        /// <summary>
        /// Marker Waste Almost Full
        /// </summary>
        MarkerWasteAlmostFull = 15,
	
        /// <summary>
        /// Marker Waste Full
        /// </summary>
        MarkerWasteFull = 16,
	
        /// <summary>
        /// Fuser Over Temp
        /// </summary>
        FuserOverTemp = 17,
	
        /// <summary>
        /// Fuser Under Temp
        /// </summary>
        FuserUnderTemp = 18,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 19,
	
        /// <summary>
        /// None
        /// </summary>
        None = 20,
	
        /// <summary>
        /// Moving To Paused
        /// </summary>
        MovingToPaused = 21,
	
        /// <summary>
        /// Shutdown
        /// </summary>
        Shutdown = 22,
	
        /// <summary>
        /// Connecting To Device
        /// </summary>
        ConnectingToDevice = 23,
	
        /// <summary>
        /// Timed Out
        /// </summary>
        TimedOut = 24,
	
        /// <summary>
        /// Stopping
        /// </summary>
        Stopping = 25,
	
        /// <summary>
        /// Stopped Partially
        /// </summary>
        StoppedPartially = 26,
	
        /// <summary>
        /// Toner Low
        /// </summary>
        TonerLow = 27,
	
        /// <summary>
        /// Toner Empty
        /// </summary>
        TonerEmpty = 28,
	
        /// <summary>
        /// Spool Area Full
        /// </summary>
        SpoolAreaFull = 29,
	
        /// <summary>
        /// Door Open
        /// </summary>
        DoorOpen = 30,
	
        /// <summary>
        /// Optical Photo Conductor Near End Of Life
        /// </summary>
        OpticalPhotoConductorNearEndOfLife = 31,
	
        /// <summary>
        /// Optical Photo Conductor Life Over
        /// </summary>
        OpticalPhotoConductorLifeOver = 32,
	
        /// <summary>
        /// Developer Low
        /// </summary>
        DeveloperLow = 33,
	
        /// <summary>
        /// Developer Empty
        /// </summary>
        DeveloperEmpty = 34,
	
        /// <summary>
        /// Interpreter Resource Unavailable
        /// </summary>
        InterpreterResourceUnavailable = 35,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 36,
	
    }
}
