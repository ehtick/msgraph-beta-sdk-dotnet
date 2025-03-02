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
    /// The enum DeviceManagementConfigurationControlType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceManagementConfigurationControlType
    {
    
        /// <summary>
        /// Default
        /// </summary>
        Default = 0,
	
        /// <summary>
        /// Dropdown
        /// </summary>
        Dropdown = 1,
	
        /// <summary>
        /// Small Text Box
        /// </summary>
        SmallTextBox = 2,
	
        /// <summary>
        /// Large Text Box
        /// </summary>
        LargeTextBox = 3,
	
        /// <summary>
        /// Toggle
        /// </summary>
        Toggle = 4,
	
        /// <summary>
        /// Multiheader Grid
        /// </summary>
        MultiheaderGrid = 5,
	
        /// <summary>
        /// Context Pane
        /// </summary>
        ContextPane = 6,
	
    }
}
