// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.Ediscovery
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum CaseAction.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CaseAction
    {
    
        /// <summary>
        /// Content Export
        /// </summary>
        ContentExport = 0,
	
        /// <summary>
        /// Apply Tags
        /// </summary>
        ApplyTags = 1,
	
        /// <summary>
        /// Convert To Pdf
        /// </summary>
        ConvertToPdf = 2,
	
        /// <summary>
        /// Index
        /// </summary>
        Index = 3,
	
        /// <summary>
        /// Estimate Statistics
        /// </summary>
        EstimateStatistics = 4,
	
        /// <summary>
        /// Add To Review Set
        /// </summary>
        AddToReviewSet = 5,
	
        /// <summary>
        /// Hold Update
        /// </summary>
        HoldUpdate = 6,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 7,
	
        /// <summary>
        /// Purge Data
        /// </summary>
        PurgeData = 8,
	
    }
}
