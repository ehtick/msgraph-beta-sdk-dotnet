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
    /// The type Customer Payment Journal.
    /// </summary>
    public partial class CustomerPaymentJournal : Entity
    {
    
        /// <summary>
        /// Gets or sets balancing account id.
        /// </summary>
        [JsonPropertyName("balancingAccountId")]
        public Guid? BalancingAccountId { get; set; }
    
        /// <summary>
        /// Gets or sets balancing account number.
        /// </summary>
        [JsonPropertyName("balancingAccountNumber")]
        public string BalancingAccountNumber { get; set; }
    
        /// <summary>
        /// Gets or sets code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets account.
        /// </summary>
        [JsonPropertyName("account")]
        public Account Account { get; set; }
    
        /// <summary>
        /// Gets or sets customer payments.
        /// </summary>
        [JsonPropertyName("customerPayments")]
        public ICustomerPaymentJournalCustomerPaymentsCollectionPage CustomerPayments { get; set; }

        /// <summary>
        /// Gets or sets customerPaymentsNextLink.
        /// </summary>
        [JsonPropertyName("customerPayments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CustomerPaymentsNextLink { get; set; }
    
    }
}

