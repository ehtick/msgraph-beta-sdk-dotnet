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
    /// The type AccessReviewInstanceDecisionItemUserTarget.
    /// </summary>
    public partial class AccessReviewInstanceDecisionItemUserTarget : AccessReviewInstanceDecisionItemTarget
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewInstanceDecisionItemUserTarget"/> class.
        /// </summary>
        public AccessReviewInstanceDecisionItemUserTarget()
        {
            this.ODataType = "microsoft.graph.accessReviewInstanceDecisionItemUserTarget";
        }

        /// <summary>
        /// Gets or sets userDisplayName.
        /// The name of user.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// The identifier of user.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// The user principal name.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}
