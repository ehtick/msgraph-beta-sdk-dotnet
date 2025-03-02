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
    /// The type DelegatedAdminAccessContainer.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DelegatedAdminAccessContainer>))]
    public partial class DelegatedAdminAccessContainer
    {

        /// <summary>
        /// Gets or sets accessContainerId.
        /// The identifier of the access container (for example, a security group). For 'securityGroup' access containers, this must be a valid ID of an Azure AD security group in the Microsoft partner's tenant.
        /// </summary>
        [JsonPropertyName("accessContainerId")]
        public string AccessContainerId { get; set; }
    
        /// <summary>
        /// Gets or sets accessContainerType.
        /// The type of access container (for example, security group) that will be assigned one or more roles through a delegated admin relationship. The possible values are: securityGroup, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("accessContainerType")]
        public DelegatedAdminAccessContainerType? AccessContainerType { get; set; }
    
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
