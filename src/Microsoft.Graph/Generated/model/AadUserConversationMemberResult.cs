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
    /// The type AadUserConversationMemberResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AadUserConversationMemberResult : ActionResultPart
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AadUserConversationMemberResult"/> class.
        /// </summary>
        public AadUserConversationMemberResult()
        {
            this.ODataType = "microsoft.graph.aadUserConversationMemberResult";
        }

        /// <summary>
        /// Gets or sets userId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
    }
}
