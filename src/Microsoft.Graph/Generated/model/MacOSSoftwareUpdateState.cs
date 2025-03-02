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
    /// The enum MacOSSoftwareUpdateState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MacOSSoftwareUpdateState
    {
    
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// Downloading
        /// </summary>
        Downloading = 1000,
	
        /// <summary>
        /// Downloaded
        /// </summary>
        Downloaded = 1001,
	
        /// <summary>
        /// Installing
        /// </summary>
        Installing = 1002,
	
        /// <summary>
        /// Idle
        /// </summary>
        Idle = 1003,
	
        /// <summary>
        /// Available
        /// </summary>
        Available = 1004,
	
        /// <summary>
        /// Scheduled
        /// </summary>
        Scheduled = 1005,
	
        /// <summary>
        /// Download Failed
        /// </summary>
        DownloadFailed = 2000,
	
        /// <summary>
        /// Download Insufficient Space
        /// </summary>
        DownloadInsufficientSpace = 2001,
	
        /// <summary>
        /// Download Insufficient Power
        /// </summary>
        DownloadInsufficientPower = 2002,
	
        /// <summary>
        /// Download Insufficient Network
        /// </summary>
        DownloadInsufficientNetwork = 2003,
	
        /// <summary>
        /// Install Insufficient Space
        /// </summary>
        InstallInsufficientSpace = 2004,
	
        /// <summary>
        /// Install Insufficient Power
        /// </summary>
        InstallInsufficientPower = 2005,
	
        /// <summary>
        /// Install Failed
        /// </summary>
        InstallFailed = 2006,
	
        /// <summary>
        /// Command Failed
        /// </summary>
        CommandFailed = 2007,
	
    }
}
