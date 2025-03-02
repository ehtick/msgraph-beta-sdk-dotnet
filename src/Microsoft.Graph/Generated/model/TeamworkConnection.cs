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
    /// The type TeamworkConnection.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamworkConnection>))]
    public partial class TeamworkConnection
    {

        /// <summary>
        /// Gets or sets connectionStatus.
        /// Indicates whether a component/peripheral is connected/disconnected or its state is unknown. The possible values are: unknown, connected, disconnected, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("connectionStatus")]
        public TeamworkConnectionStatus? ConnectionStatus { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedDateTime.
        /// Time at which the state was last changed. For example, indicates connected since when the state is connected and disconnected since when the state is disconnected.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
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
