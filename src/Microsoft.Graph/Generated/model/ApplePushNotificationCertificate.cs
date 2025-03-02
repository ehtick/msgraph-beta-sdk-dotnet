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
    /// The type Apple Push Notification Certificate.
    /// </summary>
    public partial class ApplePushNotificationCertificate : Entity
    {
    
        /// <summary>
        /// Gets or sets apple identifier.
        /// Apple Id of the account used to create the MDM push certificate.
        /// </summary>
        [JsonPropertyName("appleIdentifier")]
        public string AppleIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets certificate.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }
    
        /// <summary>
        /// Gets or sets certificate serial number.
        /// Certificate serial number. This property is read-only.
        /// </summary>
        [JsonPropertyName("certificateSerialNumber")]
        public string CertificateSerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets certificate upload failure reason.
        /// The reason the certificate upload failed.
        /// </summary>
        [JsonPropertyName("certificateUploadFailureReason")]
        public string CertificateUploadFailureReason { get; set; }
    
        /// <summary>
        /// Gets or sets certificate upload status.
        /// The certificate upload status.
        /// </summary>
        [JsonPropertyName("certificateUploadStatus")]
        public string CertificateUploadStatus { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The expiration date and time for Apple push notification certificate.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified date and time for Apple push notification certificate.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets topic identifier.
        /// Topic Id.
        /// </summary>
        [JsonPropertyName("topicIdentifier")]
        public string TopicIdentifier { get; set; }
    
    }
}

