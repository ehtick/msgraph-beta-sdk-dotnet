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
    /// The type Device Enrollment Notification Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceEnrollmentNotificationConfiguration>))]
    public partial class DeviceEnrollmentNotificationConfiguration : DeviceEnrollmentConfiguration
    {
    
        ///<summary>
        /// The DeviceEnrollmentNotificationConfiguration constructor
        ///</summary>
        public DeviceEnrollmentNotificationConfiguration()
        {
            this.ODataType = "microsoft.graph.deviceEnrollmentNotificationConfiguration";
        }

        /// <summary>
        /// Gets or sets branding options.
        /// Branding Options for the Enrollment Notification. Possible values are: none, includeCompanyLogo, includeCompanyName, includeContactInformation, includeCompanyPortalLink, includeDeviceDetails, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("brandingOptions")]
        public EnrollmentNotificationBrandingOptions? BrandingOptions { get; set; }
    
        /// <summary>
        /// Gets or sets default locale.
        /// DefaultLocale for the Enrollment Notification
        /// </summary>
        [JsonPropertyName("defaultLocale")]
        public string DefaultLocale { get; set; }
    
        /// <summary>
        /// Gets or sets notification message template id.
        /// Notification Message Template Id
        /// </summary>
        [JsonPropertyName("notificationMessageTemplateId")]
        public Guid? NotificationMessageTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets notification templates.
        /// The list of notification data -
        /// </summary>
        [JsonPropertyName("notificationTemplates")]
        public IEnumerable<string> NotificationTemplates { get; set; }
    
        /// <summary>
        /// Gets or sets platform type.
        /// Platform type of the Enrollment Notification. Possible values are: allPlatforms, ios, windows, windowsPhone, android, androidForWork, mac, linux, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("platformType")]
        public EnrollmentRestrictionPlatformType? PlatformType { get; set; }
    
        /// <summary>
        /// Gets or sets template type.
        /// Template type of the Enrollment Notification. Possible values are: email, push, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("templateType")]
        public EnrollmentNotificationTemplateType? TemplateType { get; set; }
    
    }
}

