// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WindowsAutopilotDeviceIdentityAssignResourceAccountToDeviceRequestBody.
    /// </summary>
    public partial class WindowsAutopilotDeviceIdentityAssignResourceAccountToDeviceRequestBody
    {
    
        /// <summary>
        /// Gets or sets UserPrincipalName.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets AddressableUserName.
        /// </summary>
        [JsonPropertyName("addressableUserName")]
        public string AddressableUserName { get; set; }
    
        /// <summary>
        /// Gets or sets ResourceAccountName.
        /// </summary>
        [JsonPropertyName("resourceAccountName")]
        public string ResourceAccountName { get; set; }
    
    }
}
