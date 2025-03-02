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
    /// The type Mobile App Troubleshooting Event.
    /// </summary>
    public partial class MobileAppTroubleshootingEvent : DeviceManagementTroubleshootingEvent
    {
    
        ///<summary>
        /// The MobileAppTroubleshootingEvent constructor
        ///</summary>
        public MobileAppTroubleshootingEvent()
        {
            this.ODataType = "microsoft.graph.mobileAppTroubleshootingEvent";
        }

        /// <summary>
        /// Gets or sets application id.
        /// Intune application identifier.
        /// </summary>
        [JsonPropertyName("applicationId")]
        public string ApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets history.
        /// Intune Mobile Application Troubleshooting History Item
        /// </summary>
        [JsonPropertyName("history")]
        public IEnumerable<MobileAppTroubleshootingHistoryItem> History { get; set; }
    
        /// <summary>
        /// Gets or sets managed device identifier.
        /// Device identifier created or collected by Intune.
        /// </summary>
        [JsonPropertyName("managedDeviceIdentifier")]
        public string ManagedDeviceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Identifier for the user that tried to enroll the device.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets app log collection requests.
        /// The collection property of AppLogUploadRequest.
        /// </summary>
        [JsonPropertyName("appLogCollectionRequests")]
        public IMobileAppTroubleshootingEventAppLogCollectionRequestsCollectionPage AppLogCollectionRequests { get; set; }

        /// <summary>
        /// Gets or sets appLogCollectionRequestsNextLink.
        /// </summary>
        [JsonPropertyName("appLogCollectionRequests@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppLogCollectionRequestsNextLink { get; set; }
    
    }
}

