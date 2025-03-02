// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum QuarantineReason.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QuarantineReason
    {
    
        /// <summary>
        /// Encountered Base Escrow Threshold
        /// </summary>
        EncounteredBaseEscrowThreshold = 0,
	
        /// <summary>
        /// Encountered Total Escrow Threshold
        /// </summary>
        EncounteredTotalEscrowThreshold = 1,
	
        /// <summary>
        /// Encountered Escrow Proportion Threshold
        /// </summary>
        EncounteredEscrowProportionThreshold = 2,
	
        /// <summary>
        /// Encountered Quarantine Exception
        /// </summary>
        EncounteredQuarantineException = 4,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 8,
	
        /// <summary>
        /// Quarantined On Demand
        /// </summary>
        QuarantinedOnDemand = 16,
	
        /// <summary>
        /// Too Many Deletes
        /// </summary>
        TooManyDeletes = 32,
	
        /// <summary>
        /// Ingestion Interrupted
        /// </summary>
        IngestionInterrupted = 64,
	
    }
}
