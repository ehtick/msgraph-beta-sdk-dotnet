// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ResetPasscodeActionResult.
    /// </summary>
    public partial class ResetPasscodeActionResult : DeviceActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPasscodeActionResult"/> class.
        /// </summary>
        public ResetPasscodeActionResult()
        {
            this.ODataType = "microsoft.graph.resetPasscodeActionResult";
        }

        /// <summary>
        /// Gets or sets errorCode.
        /// RotateBitLockerKeys action error code. Valid values 0 to 2147483647
        /// </summary>
        [JsonPropertyName("errorCode")]
        public Int32? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets passcode.
        /// Newly generated passcode for the device
        /// </summary>
        [JsonPropertyName("passcode")]
        public string Passcode { get; set; }
    
    }
}
