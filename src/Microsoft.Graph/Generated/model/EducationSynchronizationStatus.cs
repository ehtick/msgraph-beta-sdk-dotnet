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
    /// The enum EducationSynchronizationStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EducationSynchronizationStatus
    {
    
        /// <summary>
        /// Paused
        /// </summary>
        Paused = 0,
	
        /// <summary>
        /// In Progress
        /// </summary>
        InProgress = 1,
	
        /// <summary>
        /// Success
        /// </summary>
        Success = 2,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 3,
	
        /// <summary>
        /// Validation Error
        /// </summary>
        ValidationError = 4,
	
        /// <summary>
        /// Quarantined
        /// </summary>
        Quarantined = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
        /// <summary>
        /// Extracting
        /// </summary>
        Extracting = 7,
	
        /// <summary>
        /// Validating
        /// </summary>
        Validating = 8,
	
    }
}
