// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceAppManagementRequestBuilder.
    /// </summary>
    public partial interface IDeviceAppManagementRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceAppManagementRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceAppManagementRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ManagedEBookCategories.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedEBookCategoriesCollectionRequestBuilder ManagedEBookCategories { get; }

        /// <summary>
        /// Gets the request builder for EnterpriseCodeSigningCertificates.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementEnterpriseCodeSigningCertificatesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementEnterpriseCodeSigningCertificatesCollectionRequestBuilder EnterpriseCodeSigningCertificates { get; }

        /// <summary>
        /// Gets the request builder for IosLobAppProvisioningConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementIosLobAppProvisioningConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementIosLobAppProvisioningConfigurationsCollectionRequestBuilder IosLobAppProvisioningConfigurations { get; }

        /// <summary>
        /// Gets the request builder for MobileAppCategories.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder MobileAppCategories { get; }

        /// <summary>
        /// Gets the request builder for MobileAppConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMobileAppConfigurationsCollectionRequestBuilder MobileAppConfigurations { get; }

        /// <summary>
        /// Gets the request builder for MobileApps.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMobileAppsCollectionRequestBuilder MobileApps { get; }

        /// <summary>
        /// Gets the request builder for SymantecCodeSigningCertificate.
        /// </summary>
        /// <returns>The <see cref="ISymantecCodeSigningCertificateRequestBuilder"/>.</returns>
        ISymantecCodeSigningCertificateRequestBuilder SymantecCodeSigningCertificate { get; }

        /// <summary>
        /// Gets the request builder for ManagedEBooks.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedEBooksCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedEBooksCollectionRequestBuilder ManagedEBooks { get; }

        /// <summary>
        /// Gets the request builder for PolicySets.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementPolicySetsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementPolicySetsCollectionRequestBuilder PolicySets { get; }

        /// <summary>
        /// Gets the request builder for VppTokens.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementVppTokensCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementVppTokensCollectionRequestBuilder VppTokens { get; }

        /// <summary>
        /// Gets the request builder for WindowsManagementApp.
        /// </summary>
        /// <returns>The <see cref="IWindowsManagementAppWithReferenceRequestBuilder"/>.</returns>
        IWindowsManagementAppWithReferenceRequestBuilder WindowsManagementApp { get; }

        /// <summary>
        /// Gets the request builder for AndroidManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder AndroidManagedAppProtections { get; }

        /// <summary>
        /// Gets the request builder for DefaultManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder DefaultManagedAppProtections { get; }

        /// <summary>
        /// Gets the request builder for IosManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder IosManagedAppProtections { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppPoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequestBuilder ManagedAppPolicies { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppRegistrations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppRegistrationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedAppRegistrationsCollectionRequestBuilder ManagedAppRegistrations { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder ManagedAppStatuses { get; }

        /// <summary>
        /// Gets the request builder for MdmWindowsInformationProtectionPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder MdmWindowsInformationProtectionPolicies { get; }

        /// <summary>
        /// Gets the request builder for TargetedManagedAppConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder TargetedManagedAppConfigurations { get; }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionDeviceRegistrations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsInformationProtectionDeviceRegistrationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementWindowsInformationProtectionDeviceRegistrationsCollectionRequestBuilder WindowsInformationProtectionDeviceRegistrations { get; }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionRequestBuilder WindowsInformationProtectionPolicies { get; }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionWipeActions.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementWindowsInformationProtectionWipeActionsCollectionRequestBuilder WindowsInformationProtectionWipeActions { get; }

        /// <summary>
        /// Gets the request builder for WindowsManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementWindowsManagedAppProtectionsCollectionRequestBuilder WindowsManagedAppProtections { get; }

        /// <summary>
        /// Gets the request builder for DeviceAppManagementTasks.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementDeviceAppManagementTasksCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementDeviceAppManagementTasksCollectionRequestBuilder DeviceAppManagementTasks { get; }

        /// <summary>
        /// Gets the request builder for WdacSupplementalPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWdacSupplementalPoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementWdacSupplementalPoliciesCollectionRequestBuilder WdacSupplementalPolicies { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceAppManagementSyncMicrosoftStoreForBusinessApps.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementSyncMicrosoftStoreForBusinessAppsRequestBuilder"/>.</returns>
        IDeviceAppManagementSyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps();
    
    }
}
