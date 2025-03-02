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
    /// The enum DirectoryDefinitionDiscoverabilities.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum DirectoryDefinitionDiscoverabilities
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Attribute Names
        /// </summary>
        AttributeNames = 1,
	
        /// <summary>
        /// Attribute Data Types
        /// </summary>
        AttributeDataTypes = 2,
	
        /// <summary>
        /// Attribute Read Only
        /// </summary>
        AttributeReadOnly = 4,
	
        /// <summary>
        /// Reference Attributes
        /// </summary>
        ReferenceAttributes = 8,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 16,
	
    }
}
