// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkloadActionDeploymentStatus.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<WorkloadActionDeploymentStatus>))]
    public partial class WorkloadActionDeploymentStatus
    {

        /// <summary>
        /// Gets or sets actionId.
        /// The unique identifier for the workload action. Required. Read-only.
        /// </summary>
        [JsonPropertyName("actionId")]
        public string ActionId { get; set; }
    
        /// <summary>
        /// Gets or sets deployedPolicyId.
        /// The identifier of any policy that was created by applying the workload action. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("deployedPolicyId")]
        public string DeployedPolicyId { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// The detailed information for exceptions that occur when deploying the workload action. Optional. Required.
        /// </summary>
        [JsonPropertyName("error")]
        public Microsoft.Graph.GenericError Error { get; set; }
    
        /// <summary>
        /// Gets or sets excludeGroups.
        /// </summary>
        [JsonPropertyName("excludeGroups")]
        public IEnumerable<string> ExcludeGroups { get; set; }
    
        /// <summary>
        /// Gets or sets includeAllUsers.
        /// </summary>
        [JsonPropertyName("includeAllUsers")]
        public bool? IncludeAllUsers { get; set; }
    
        /// <summary>
        /// Gets or sets includeGroups.
        /// </summary>
        [JsonPropertyName("includeGroups")]
        public IEnumerable<string> IncludeGroups { get; set; }
    
        /// <summary>
        /// Gets or sets lastDeploymentDateTime.
        /// The date and time the workload action was last deployed. Optional.
        /// </summary>
        [JsonPropertyName("lastDeploymentDateTime")]
        public DateTimeOffset? LastDeploymentDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the workload action deployment. Possible values are: toAddress, completed, error, timeOut, inProgress, unknownFutureValue. Required. Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public WorkloadActionStatus? Status { get; set; }
    
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
