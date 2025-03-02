// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Simulation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Simulation>))]
    public partial class Simulation : Entity
    {
    
        /// <summary>
        /// Gets or sets attack technique.
        /// The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue. For more information on the types of social engineering attack techniques, see simulations.
        /// </summary>
        [JsonPropertyName("attackTechnique")]
        public SimulationAttackTechnique? AttackTechnique { get; set; }
    
        /// <summary>
        /// Gets or sets attack type.
        /// Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("attackType")]
        public SimulationAttackType? AttackType { get; set; }
    
        /// <summary>
        /// Gets or sets automation id.
        /// Unique identifier for the attack simulation automation.
        /// </summary>
        [JsonPropertyName("automationId")]
        public string AutomationId { get; set; }
    
        /// <summary>
        /// Gets or sets completion date time.
        /// Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("completionDateTime")]
        public DateTimeOffset? CompletionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Identity of the user who created the attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public EmailIdentity CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time of creation of the attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the attack simulation and training campaign. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets duration in days.
        /// Simulation duration in days.
        /// </summary>
        [JsonPropertyName("durationInDays")]
        public Int32? DurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets excluded account target.
        /// Users excluded from the simulation.
        /// </summary>
        [JsonPropertyName("excludedAccountTarget")]
        public AccountTargetContent ExcludedAccountTarget { get; set; }
    
        /// <summary>
        /// Gets or sets included account target.
        /// Users targeted in the simulation.
        /// </summary>
        [JsonPropertyName("includedAccountTarget")]
        public AccountTargetContent IncludedAccountTarget { get; set; }
    
        /// <summary>
        /// Gets or sets is automated.
        /// Flag that represents if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("isAutomated")]
        public bool? IsAutomated { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// Identity of the user who most recently modified the attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public EmailIdentity LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Date and time of the most recent modification of the attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets launch date time.
        /// Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("launchDateTime")]
        public DateTimeOffset? LaunchDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets payload delivery platform.
        /// Method of delivery of the phishing payload used in the attack simulation and training campaign. Possible values are: unknown, sms, email, teams, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("payloadDeliveryPlatform")]
        public PayloadDeliveryPlatform? PayloadDeliveryPlatform { get; set; }
    
        /// <summary>
        /// Gets or sets report.
        /// Report of the attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("report")]
        public SimulationReport Report { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, draft, running, scheduled, succeeded, failed, cancelled, excluded, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public SimulationStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets payload.
        /// The payload associated with a simulation during its creation.
        /// </summary>
        [JsonPropertyName("payload")]
        public Payload Payload { get; set; }
    
    }
}

