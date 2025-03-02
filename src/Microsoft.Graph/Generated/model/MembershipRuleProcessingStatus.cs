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
    /// The type MembershipRuleProcessingStatus.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MembershipRuleProcessingStatus>))]
    public partial class MembershipRuleProcessingStatus
    {

        /// <summary>
        /// Gets or sets errorMessage.
        /// Detailed error message if dynamic group processing ran into an error.  Optional. Read-only.
        /// </summary>
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Gets or sets lastMembershipUpdated.
        /// Most recent date and time when membership of a dynamic group was updated.  Optional. Read-only.
        /// </summary>
        [JsonPropertyName("lastMembershipUpdated")]
        public DateTimeOffset? LastMembershipUpdated { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Current status of a dynamic group processing. Possible values are: NotStarted, Running, Succeeded, Failed, and UnknownFutureValue.  Required. Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public MembershipRuleProcessingStatusDetails? Status { get; set; }
    
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
