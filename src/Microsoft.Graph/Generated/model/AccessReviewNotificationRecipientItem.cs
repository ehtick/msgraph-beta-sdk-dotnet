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
    /// The type AccessReviewNotificationRecipientItem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessReviewNotificationRecipientItem>))]
    public partial class AccessReviewNotificationRecipientItem
    {

        /// <summary>
        /// Gets or sets notificationRecipientScope.
        /// Determines the recipient of the notification email.
        /// </summary>
        [JsonPropertyName("notificationRecipientScope")]
        public AccessReviewNotificationRecipientScope NotificationRecipientScope { get; set; }
    
        /// <summary>
        /// Gets or sets notificationTemplateType.
        /// Indicates the type of access review email to be sent. Supported template type is CompletedAdditionalRecipients which sends review completion notifications to the recipients.
        /// </summary>
        [JsonPropertyName("notificationTemplateType")]
        public string NotificationTemplateType { get; set; }
    
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
