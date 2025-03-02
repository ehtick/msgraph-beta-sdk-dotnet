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
    /// The type Android For Work Mobile App Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidForWorkMobileAppConfiguration>))]
    public partial class AndroidForWorkMobileAppConfiguration : ManagedDeviceMobileAppConfiguration
    {
    
        ///<summary>
        /// The AndroidForWorkMobileAppConfiguration constructor
        ///</summary>
        public AndroidForWorkMobileAppConfiguration()
        {
            this.ODataType = "microsoft.graph.androidForWorkMobileAppConfiguration";
        }

        /// <summary>
        /// Gets or sets connected apps enabled.
        /// Setting to specify whether to allow ConnectedApps experience for this app.
        /// </summary>
        [JsonPropertyName("connectedAppsEnabled")]
        public bool? ConnectedAppsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets package id.
        /// Android For Work app configuration package id.
        /// </summary>
        [JsonPropertyName("packageId")]
        public string PackageId { get; set; }
    
        /// <summary>
        /// Gets or sets payload json.
        /// Android For Work app configuration JSON payload.
        /// </summary>
        [JsonPropertyName("payloadJson")]
        public string PayloadJson { get; set; }
    
        /// <summary>
        /// Gets or sets permission actions.
        /// List of Android app permissions and corresponding permission actions.
        /// </summary>
        [JsonPropertyName("permissionActions")]
        public IEnumerable<AndroidPermissionAction> PermissionActions { get; set; }
    
        /// <summary>
        /// Gets or sets profile applicability.
        /// Android Enterprise profile applicability (AndroidWorkProfile, DeviceOwner, or default (applies to both)). Possible values are: default, androidWorkProfile, androidDeviceOwner.
        /// </summary>
        [JsonPropertyName("profileApplicability")]
        public AndroidProfileApplicability? ProfileApplicability { get; set; }
    
    }
}

