// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Win32LobAppPowerShellScriptRule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Win32LobAppPowerShellScriptRule : Win32LobAppRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppPowerShellScriptRule"/> class.
        /// </summary>
        public Win32LobAppPowerShellScriptRule()
        {
            this.ODataType = "microsoft.graph.win32LobAppPowerShellScriptRule";
        }

        /// <summary>
        /// Gets or sets comparisonValue.
        /// The script output comparison value. Do not specify a value if the rule is used for detection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "comparisonValue", Required = Newtonsoft.Json.Required.Default)]
        public string ComparisonValue { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The display name for the rule. Do not specify this value if the rule is used for detection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforceSignatureCheck.
        /// A value indicating whether a signature check is enforced.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enforceSignatureCheck", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnforceSignatureCheck { get; set; }
    
        /// <summary>
        /// Gets or sets operationType.
        /// The script output comparison operation type. Use NotConfigured (the default value) if the rule is used for detection. Possible values are: notConfigured, string, dateTime, integer, float, version, boolean.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operationType", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppPowerShellScriptRuleOperationType? OperationType { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// The script output operator. Use NotConfigured (the default value) if the rule is used for detection. Possible values are: notConfigured, equal, notEqual, greaterThan, greaterThanOrEqual, lessThan, lessThanOrEqual.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operator", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppRuleOperator? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets runAs32Bit.
        /// A value indicating whether the script should run as 32-bit.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runAs32Bit", Required = Newtonsoft.Json.Required.Default)]
        public bool? RunAs32Bit { get; set; }
    
        /// <summary>
        /// Gets or sets runAsAccount.
        /// The execution context of the script. Do not specify this value if the rule is used for detection. Script detection rules will run in the same context as the associated app install context.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runAsAccount", Required = Newtonsoft.Json.Required.Default)]
        public RunAsAccountType? RunAsAccount { get; set; }
    
        /// <summary>
        /// Gets or sets scriptContent.
        /// The base64-encoded script content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scriptContent", Required = Newtonsoft.Json.Required.Default)]
        public string ScriptContent { get; set; }
    
    }
}
