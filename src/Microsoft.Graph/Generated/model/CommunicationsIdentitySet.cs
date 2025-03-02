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
    /// The type CommunicationsIdentitySet.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CommunicationsIdentitySet>))]
    public partial class CommunicationsIdentitySet : IdentitySet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationsIdentitySet"/> class.
        /// </summary>
        public CommunicationsIdentitySet()
        {
            this.ODataType = "microsoft.graph.communicationsIdentitySet";
        }

        /// <summary>
        /// Gets or sets applicationInstance.
        /// The application instance associated with this action.
        /// </summary>
        [JsonPropertyName("applicationInstance")]
        public Identity ApplicationInstance { get; set; }
    
        /// <summary>
        /// Gets or sets assertedIdentity.
        /// An identity the participant would like to present itself as to the other participants in the call.
        /// </summary>
        [JsonPropertyName("assertedIdentity")]
        public Identity AssertedIdentity { get; set; }
    
        /// <summary>
        /// Gets or sets azureCommunicationServicesUser.
        /// The Azure Communication Services user associated with this action.
        /// </summary>
        [JsonPropertyName("azureCommunicationServicesUser")]
        public Identity AzureCommunicationServicesUser { get; set; }
    
        /// <summary>
        /// Gets or sets encrypted.
        /// The encrypted user associated with this action.
        /// </summary>
        [JsonPropertyName("encrypted")]
        public Identity Encrypted { get; set; }
    
        /// <summary>
        /// Gets or sets endpointType.
        /// Type of endpoint the participant is using. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone and unknownFutureValue.
        /// </summary>
        [JsonPropertyName("endpointType")]
        public EndpointType? EndpointType { get; set; }
    
        /// <summary>
        /// Gets or sets guest.
        /// The guest user associated with this action.
        /// </summary>
        [JsonPropertyName("guest")]
        public Identity Guest { get; set; }
    
        /// <summary>
        /// Gets or sets onPremises.
        /// The Skype for Business On-Premises user associated with this action.
        /// </summary>
        [JsonPropertyName("onPremises")]
        public Identity OnPremises { get; set; }
    
        /// <summary>
        /// Gets or sets phone.
        /// Inherited from identitySet. The phone user associated with this action.
        /// </summary>
        [JsonPropertyName("phone")]
        public Identity Phone { get; set; }
    
    }
}
