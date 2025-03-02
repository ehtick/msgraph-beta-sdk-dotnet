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
    /// The type Android Managed Store Account Enterprise Settings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidManagedStoreAccountEnterpriseSettings>))]
    public partial class AndroidManagedStoreAccountEnterpriseSettings : Entity
    {
    
        /// <summary>
        /// Gets or sets android device owner fully managed enrollment enabled.
        /// Company codes for AndroidManagedStoreAccountEnterpriseSettings
        /// </summary>
        [JsonPropertyName("androidDeviceOwnerFullyManagedEnrollmentEnabled")]
        public bool? AndroidDeviceOwnerFullyManagedEnrollmentEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets bind status.
        /// Bind status of the tenant with the Google EMM API. Possible values are: notBound, bound, boundAndValidated, unbinding.
        /// </summary>
        [JsonPropertyName("bindStatus")]
        public AndroidManagedStoreAccountBindStatus? BindStatus { get; set; }
    
        /// <summary>
        /// Gets or sets company codes.
        /// Company codes for AndroidManagedStoreAccountEnterpriseSettings
        /// </summary>
        [JsonPropertyName("companyCodes")]
        public IEnumerable<AndroidEnrollmentCompanyCode> CompanyCodes { get; set; }
    
        /// <summary>
        /// Gets or sets device owner management enabled.
        /// Indicates if this account is flighting for Android Device Owner Management with CloudDPC.
        /// </summary>
        [JsonPropertyName("deviceOwnerManagementEnabled")]
        public bool? DeviceOwnerManagementEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment target.
        /// Indicates which users can enroll devices in Android Enterprise device management. Possible values are: none, all, targeted, targetedAsEnrollmentRestrictions.
        /// </summary>
        [JsonPropertyName("enrollmentTarget")]
        public AndroidManagedStoreAccountEnrollmentTarget? EnrollmentTarget { get; set; }
    
        /// <summary>
        /// Gets or sets last app sync date time.
        /// Last completion time for app sync
        /// </summary>
        [JsonPropertyName("lastAppSyncDateTime")]
        public DateTimeOffset? LastAppSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last app sync status.
        /// Last application sync result. Possible values are: success, credentialsNotValid, androidForWorkApiError, managementServiceError, unknownError, none.
        /// </summary>
        [JsonPropertyName("lastAppSyncStatus")]
        public AndroidManagedStoreAccountAppSyncStatus? LastAppSyncStatus { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modification time for Android enterprise settings
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed google play initial scope tag ids.
        /// Initial scope tags for MGP apps
        /// </summary>
        [JsonPropertyName("managedGooglePlayInitialScopeTagIds")]
        public IEnumerable<string> ManagedGooglePlayInitialScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets owner organization name.
        /// Organization name used when onboarding Android Enterprise
        /// </summary>
        [JsonPropertyName("ownerOrganizationName")]
        public string OwnerOrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets owner user principal name.
        /// Owner UPN that created the enterprise
        /// </summary>
        [JsonPropertyName("ownerUserPrincipalName")]
        public string OwnerUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets target group ids.
        /// Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to 'Targeted'
        /// </summary>
        [JsonPropertyName("targetGroupIds")]
        public IEnumerable<string> TargetGroupIds { get; set; }
    
    }
}

