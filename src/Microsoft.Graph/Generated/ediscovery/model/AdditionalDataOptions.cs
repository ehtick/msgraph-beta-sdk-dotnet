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
    /// The enum AdditionalDataOptions.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum AdditionalDataOptions
    {
    
        /// <summary>
        /// All Versions
        /// </summary>
        AllVersions = 1,
	
        /// <summary>
        /// Linked Files
        /// </summary>
        LinkedFiles = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
