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
    /// The enum ExportFileStructure.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExportFileStructure
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Directory
        /// </summary>
        Directory = 1,
	
        /// <summary>
        /// Pst
        /// </summary>
        Pst = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
