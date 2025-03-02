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
    /// The type DeviceComplianceScriptError.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceComplianceScriptError>))]
    public partial class DeviceComplianceScriptError
    {

        /// <summary>
        /// Gets or sets code.
        /// Error code. Possible values are: none, jsonFileInvalid, jsonFileMissing, jsonFileTooLarge, rulesMissing, duplicateRules, tooManyRulesSpecified, operatorMissing, operatorNotSupported, datatypeMissing, datatypeNotSupported, operatorDataTypeCombinationNotSupported, moreInfoUriMissing, moreInfoUriInvalid, moreInfoUriTooLarge, descriptionMissing, descriptionInvalid, descriptionTooLarge, titleMissing, titleInvalid, titleTooLarge, operandMissing, operandInvalid, operandTooLarge, settingNameMissing, settingNameInvalid, settingNameTooLarge, englishLocaleMissing, duplicateLocales, unrecognizedLocale, unknown, remediationStringsMissing.
        /// </summary>
        [JsonPropertyName("code")]
        public Code? Code { get; set; }
    
        /// <summary>
        /// Gets or sets deviceComplianceScriptRulesValidationError.
        /// Error code. Possible values are: none, jsonFileInvalid, jsonFileMissing, jsonFileTooLarge, rulesMissing, duplicateRules, tooManyRulesSpecified, operatorMissing, operatorNotSupported, datatypeMissing, datatypeNotSupported, operatorDataTypeCombinationNotSupported, moreInfoUriMissing, moreInfoUriInvalid, moreInfoUriTooLarge, descriptionMissing, descriptionInvalid, descriptionTooLarge, titleMissing, titleInvalid, titleTooLarge, operandMissing, operandInvalid, operandTooLarge, settingNameMissing, settingNameInvalid, settingNameTooLarge, englishLocaleMissing, duplicateLocales, unrecognizedLocale, unknown, remediationStringsMissing.
        /// </summary>
        [JsonPropertyName("deviceComplianceScriptRulesValidationError")]
        public DeviceComplianceScriptRulesValidationError? DeviceComplianceScriptRulesValidationError { get; set; }
    
        /// <summary>
        /// Gets or sets message.
        /// Error message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
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
