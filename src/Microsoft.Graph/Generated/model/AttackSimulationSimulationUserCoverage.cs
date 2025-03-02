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
    /// The type AttackSimulationSimulationUserCoverage.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AttackSimulationSimulationUserCoverage>))]
    public partial class AttackSimulationSimulationUserCoverage
    {

        /// <summary>
        /// Gets or sets attackSimulationUser.
        /// User in an attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("attackSimulationUser")]
        public AttackSimulationUser AttackSimulationUser { get; set; }
    
        /// <summary>
        /// Gets or sets clickCount.
        /// Number of link clicks in the received payloads by the user in attack simulation and training campaigns.
        /// </summary>
        [JsonPropertyName("clickCount")]
        public Int32? ClickCount { get; set; }
    
        /// <summary>
        /// Gets or sets compromisedCount.
        /// Number of compromising actions by the user in attack simulation and training campaigns.
        /// </summary>
        [JsonPropertyName("compromisedCount")]
        public Int32? CompromisedCount { get; set; }
    
        /// <summary>
        /// Gets or sets latestSimulationDateTime.
        /// Date and time of the latest attack simulation and training campaign that the user was included in.
        /// </summary>
        [JsonPropertyName("latestSimulationDateTime")]
        public DateTimeOffset? LatestSimulationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets simulationCount.
        /// Number of attack simulation and training campaigns that the user was included in.
        /// </summary>
        [JsonPropertyName("simulationCount")]
        public Int32? SimulationCount { get; set; }
    
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
