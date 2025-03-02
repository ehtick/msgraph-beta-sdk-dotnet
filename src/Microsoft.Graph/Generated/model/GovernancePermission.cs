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
    /// The type GovernancePermission.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<GovernancePermission>))]
    public partial class GovernancePermission
    {

        /// <summary>
        /// Gets or sets accessLevel.
        /// The access level. Valid values: None, UserRead, AdminRead, and AdminReadWrite.
        /// </summary>
        [JsonPropertyName("accessLevel")]
        public string AccessLevel { get; set; }
    
        /// <summary>
        /// Gets or sets isActive.
        /// Indicate if the requestor has any active role assignment for the access level.
        /// </summary>
        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }
    
        /// <summary>
        /// Gets or sets isEligible.
        /// Indicate if the requestor has any eligible role assignment for the access level.
        /// </summary>
        [JsonPropertyName("isEligible")]
        public bool? IsEligible { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
