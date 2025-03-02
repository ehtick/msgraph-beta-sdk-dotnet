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
    /// The enum ChatMessagePolicyViolationVerdictDetailsTypes.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum ChatMessagePolicyViolationVerdictDetailsTypes
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Allow False Positive Override
        /// </summary>
        AllowFalsePositiveOverride = 1,
	
        /// <summary>
        /// Allow Override Without Justification
        /// </summary>
        AllowOverrideWithoutJustification = 2,
	
        /// <summary>
        /// Allow Override With Justification
        /// </summary>
        AllowOverrideWithJustification = 4,
	
    }
}
