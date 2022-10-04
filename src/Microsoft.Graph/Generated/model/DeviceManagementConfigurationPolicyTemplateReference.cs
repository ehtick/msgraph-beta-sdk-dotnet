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
    /// The type DeviceManagementConfigurationPolicyTemplateReference.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementConfigurationPolicyTemplateReference>))]
    public partial class DeviceManagementConfigurationPolicyTemplateReference
    {

        /// <summary>
        /// Gets or sets templateDisplayName.
        /// Template Display Name of the referenced template. This property is read-only.
        /// </summary>
        [JsonPropertyName("templateDisplayName")]
        public string TemplateDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets templateDisplayVersion.
        /// Template Display Version of the referenced Template. This property is read-only.
        /// </summary>
        [JsonPropertyName("templateDisplayVersion")]
        public string TemplateDisplayVersion { get; set; }
    
        /// <summary>
        /// Gets or sets templateFamily.
        /// Template Family of the referenced Template. This property is read-only. Possible values are: none, endpointSecurityAntivirus, endpointSecurityDiskEncryption, endpointSecurityFirewall, endpointSecurityEndpointDetectionAndResponse, endpointSecurityAttackSurfaceReduction, endpointSecurityAccountProtection, endpointSecurityApplicationControl, enrollmentConfiguration, baseline.
        /// </summary>
        [JsonPropertyName("templateFamily")]
        public DeviceManagementConfigurationTemplateFamily? TemplateFamily { get; set; }
    
        /// <summary>
        /// Gets or sets templateId.
        /// Template id
        /// </summary>
        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }
    
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
