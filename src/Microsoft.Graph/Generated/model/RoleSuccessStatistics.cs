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
    /// The type RoleSuccessStatistics.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RoleSuccessStatistics>))]
    public partial class RoleSuccessStatistics
    {

        /// <summary>
        /// Gets or sets permanentFail.
        /// </summary>
        [JsonPropertyName("permanentFail")]
        public Int64? PermanentFail { get; set; }
    
        /// <summary>
        /// Gets or sets permanentSuccess.
        /// </summary>
        [JsonPropertyName("permanentSuccess")]
        public Int64? PermanentSuccess { get; set; }
    
        /// <summary>
        /// Gets or sets removeFail.
        /// </summary>
        [JsonPropertyName("removeFail")]
        public Int64? RemoveFail { get; set; }
    
        /// <summary>
        /// Gets or sets removeSuccess.
        /// </summary>
        [JsonPropertyName("removeSuccess")]
        public Int64? RemoveSuccess { get; set; }
    
        /// <summary>
        /// Gets or sets roleId.
        /// </summary>
        [JsonPropertyName("roleId")]
        public string RoleId { get; set; }
    
        /// <summary>
        /// Gets or sets roleName.
        /// </summary>
        [JsonPropertyName("roleName")]
        public string RoleName { get; set; }
    
        /// <summary>
        /// Gets or sets temporaryFail.
        /// </summary>
        [JsonPropertyName("temporaryFail")]
        public Int64? TemporaryFail { get; set; }
    
        /// <summary>
        /// Gets or sets temporarySuccess.
        /// </summary>
        [JsonPropertyName("temporarySuccess")]
        public Int64? TemporarySuccess { get; set; }
    
        /// <summary>
        /// Gets or sets unknownFail.
        /// </summary>
        [JsonPropertyName("unknownFail")]
        public Int64? UnknownFail { get; set; }
    
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
