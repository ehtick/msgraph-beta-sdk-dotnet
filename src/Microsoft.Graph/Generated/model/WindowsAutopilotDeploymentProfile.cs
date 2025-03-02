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
    /// The type Windows Autopilot Deployment Profile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsAutopilotDeploymentProfile>))]
    public partial class WindowsAutopilotDeploymentProfile : Entity
    {
    
        ///<summary>
        /// The internal WindowsAutopilotDeploymentProfile constructor
        ///</summary>
        protected internal WindowsAutopilotDeploymentProfile()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Profile creation time
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the profile
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets device name template.
        /// The template used to name the AutoPilot Device. This can be a custom text and can also contain either the serial number of the device, or a randomly generated number. The total length of the text generated by the template can be no more than 15 characters.
        /// </summary>
        [JsonPropertyName("deviceNameTemplate")]
        public string DeviceNameTemplate { get; set; }
    
        /// <summary>
        /// Gets or sets device type.
        /// The AutoPilot device type that this profile is applicable to. Possible values are: windowsPc, surfaceHub2.
        /// </summary>
        [JsonPropertyName("deviceType")]
        public WindowsAutopilotDeviceType? DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the profile
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enable white glove.
        /// Enable Autopilot White Glove for the profile.
        /// </summary>
        [JsonPropertyName("enableWhiteGlove")]
        public bool? EnableWhiteGlove { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment status screen settings.
        /// Enrollment status screen setting
        /// </summary>
        [JsonPropertyName("enrollmentStatusScreenSettings")]
        public WindowsEnrollmentStatusScreenSettings EnrollmentStatusScreenSettings { get; set; }
    
        /// <summary>
        /// Gets or sets extract hardware hash.
        /// HardwareHash Extraction for the profile
        /// </summary>
        [JsonPropertyName("extractHardwareHash")]
        public bool? ExtractHardwareHash { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// Language configured on the device
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Profile last modified time
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets management service app id.
        /// AzureAD management app ID used during client device-based enrollment discovery
        /// </summary>
        [JsonPropertyName("managementServiceAppId")]
        public string ManagementServiceAppId { get; set; }
    
        /// <summary>
        /// Gets or sets out of box experience settings.
        /// Out of box experience setting
        /// </summary>
        [JsonPropertyName("outOfBoxExperienceSettings")]
        public OutOfBoxExperienceSettings OutOfBoxExperienceSettings { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// Scope tags for the profile.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets assigned devices.
        /// The list of assigned devices for the profile.
        /// </summary>
        [JsonPropertyName("assignedDevices")]
        public IWindowsAutopilotDeploymentProfileAssignedDevicesCollectionPage AssignedDevices { get; set; }

        /// <summary>
        /// Gets or sets assignedDevicesNextLink.
        /// </summary>
        [JsonPropertyName("assignedDevices@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignedDevicesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments for the profile.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IWindowsAutopilotDeploymentProfileAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
    }
}

