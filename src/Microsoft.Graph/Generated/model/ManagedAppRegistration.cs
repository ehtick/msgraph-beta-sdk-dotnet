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
    /// The type Managed App Registration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ManagedAppRegistration>))]
    public partial class ManagedAppRegistration : Entity
    {
    
        ///<summary>
        /// The internal ManagedAppRegistration constructor
        ///</summary>
        protected internal ManagedAppRegistration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets app identifier.
        /// The app package Identifier
        /// </summary>
        [JsonPropertyName("appIdentifier")]
        public MobileAppIdentifier AppIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets application version.
        /// App version
        /// </summary>
        [JsonPropertyName("applicationVersion")]
        public string ApplicationVersion { get; set; }
    
        /// <summary>
        /// Gets or sets azure addevice id.
        /// The Azure Active Directory Device identifier of the host device. Value could be empty even when the host device is Azure Active Directory registered.
        /// </summary>
        [JsonPropertyName("azureADDeviceId")]
        public string AzureADDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time of creation
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device manufacturer.
        /// The device manufacturer for the current app registration
        /// </summary>
        [JsonPropertyName("deviceManufacturer")]
        public string DeviceManufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets device model.
        /// The device model for the current app registration
        /// </summary>
        [JsonPropertyName("deviceModel")]
        public string DeviceModel { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Host device name
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device tag.
        /// App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.
        /// </summary>
        [JsonPropertyName("deviceTag")]
        public string DeviceTag { get; set; }
    
        /// <summary>
        /// Gets or sets device type.
        /// Host device type
        /// </summary>
        [JsonPropertyName("deviceType")]
        public string DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets flagged reasons.
        /// Zero or more reasons an app registration is flagged. E.g. app running on rooted device
        /// </summary>
        [JsonPropertyName("flaggedReasons")]
        public IEnumerable<ManagedAppFlaggedReason> FlaggedReasons { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Date and time of last the app synced with management service.
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// The Managed Device identifier of the host device. Value could be empty even when the host device is managed.
        /// </summary>
        [JsonPropertyName("managedDeviceId")]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets management sdk version.
        /// App management SDK version
        /// </summary>
        [JsonPropertyName("managementSdkVersion")]
        public string ManagementSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets platform version.
        /// Operating System version
        /// </summary>
        [JsonPropertyName("platformVersion")]
        public string PlatformVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The user Id to who this app registration belongs.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the entity.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets applied policies.
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// </summary>
        [JsonPropertyName("appliedPolicies")]
        public IManagedAppRegistrationAppliedPoliciesCollectionPage AppliedPolicies { get; set; }

        /// <summary>
        /// Gets or sets appliedPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("appliedPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppliedPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets intended policies.
        /// Zero or more policies admin intended for the app as of now.
        /// </summary>
        [JsonPropertyName("intendedPolicies")]
        public IManagedAppRegistrationIntendedPoliciesCollectionPage IntendedPolicies { get; set; }

        /// <summary>
        /// Gets or sets intendedPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("intendedPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string IntendedPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// Zero or more long running operations triggered on the app registration.
        /// </summary>
        [JsonPropertyName("operations")]
        public IManagedAppRegistrationOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OperationsNextLink { get; set; }
    
    }
}

