using Microsoft.Graph.Beta.DeviceManagement.AdvancedThreatProtectionOnboardingStateSummary;
using Microsoft.Graph.Beta.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles;
using Microsoft.Graph.Beta.DeviceManagement.AndroidForWorkAppConfigurationSchemas;
using Microsoft.Graph.Beta.DeviceManagement.AndroidForWorkEnrollmentProfiles;
using Microsoft.Graph.Beta.DeviceManagement.AndroidForWorkSettings;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings;
using Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAppConfigurationSchemas;
using Microsoft.Graph.Beta.DeviceManagement.ApplePushNotificationCertificate;
using Microsoft.Graph.Beta.DeviceManagement.AppleUserInitiatedEnrollmentProfiles;
using Microsoft.Graph.Beta.DeviceManagement.AssignmentFilters;
using Microsoft.Graph.Beta.DeviceManagement.AuditEvents;
using Microsoft.Graph.Beta.DeviceManagement.AutopilotEvents;
using Microsoft.Graph.Beta.DeviceManagement.CartToClassAssociations;
using Microsoft.Graph.Beta.DeviceManagement.Categories;
using Microsoft.Graph.Beta.DeviceManagement.CertificateConnectorDetails;
using Microsoft.Graph.Beta.DeviceManagement.ChromeOSOnboardingSettings;
using Microsoft.Graph.Beta.DeviceManagement.CloudPCConnectivityIssues;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices;
using Microsoft.Graph.Beta.DeviceManagement.ComanagementEligibleDevices;
using Microsoft.Graph.Beta.DeviceManagement.ComplianceCategories;
using Microsoft.Graph.Beta.DeviceManagement.ComplianceManagementPartners;
using Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies;
using Microsoft.Graph.Beta.DeviceManagement.ComplianceSettings;
using Microsoft.Graph.Beta.DeviceManagement.ConditionalAccessSettings;
using Microsoft.Graph.Beta.DeviceManagement.ConfigManagerCollections;
using Microsoft.Graph.Beta.DeviceManagement.ConfigurationCategories;
using Microsoft.Graph.Beta.DeviceManagement.ConfigurationPolicies;
using Microsoft.Graph.Beta.DeviceManagement.ConfigurationPolicyTemplates;
using Microsoft.Graph.Beta.DeviceManagement.ConfigurationSettings;
using Microsoft.Graph.Beta.DeviceManagement.DataSharingConsents;
using Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings;
using Microsoft.Graph.Beta.DeviceManagement.DerivedCredentials;
using Microsoft.Graph.Beta.DeviceManagement.DetectedApps;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCategories;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicySettingStateSummaries;
using Microsoft.Graph.Beta.DeviceManagement.DeviceComplianceScripts;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurationConflictSummary;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurationDeviceStateSummaries;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurationRestrictedAppsViolations;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurationsAllManagedDeviceCertificateStates;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurationUserStateSummaries;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCustomAttributeShellScripts;
using Microsoft.Graph.Beta.DeviceManagement.DeviceEnrollmentConfigurations;
using Microsoft.Graph.Beta.DeviceManagement.DeviceHealthScripts;
using Microsoft.Graph.Beta.DeviceManagement.DeviceManagementPartners;
using Microsoft.Graph.Beta.DeviceManagement.DeviceManagementScripts;
using Microsoft.Graph.Beta.DeviceManagement.DeviceShellScripts;
using Microsoft.Graph.Beta.DeviceManagement.DomainJoinConnectors;
using Microsoft.Graph.Beta.DeviceManagement.EmbeddedSIMActivationCodePools;
using Microsoft.Graph.Beta.DeviceManagement.EnableAndroidDeviceAdministratorEnrollment;
using Microsoft.Graph.Beta.DeviceManagement.EnableLegacyPcManagement;
using Microsoft.Graph.Beta.DeviceManagement.EnableUnlicensedAdminstrators;
using Microsoft.Graph.Beta.DeviceManagement.EvaluateAssignmentFilter;
using Microsoft.Graph.Beta.DeviceManagement.ExchangeConnectors;
using Microsoft.Graph.Beta.DeviceManagement.ExchangeOnPremisesPolicies;
using Microsoft.Graph.Beta.DeviceManagement.ExchangeOnPremisesPolicy;
using Microsoft.Graph.Beta.DeviceManagement.GetAssignedRoleDetails;
using Microsoft.Graph.Beta.DeviceManagement.GetAssignmentFiltersStatusDetails;
using Microsoft.Graph.Beta.DeviceManagement.GetComanagedDevicesSummary;
using Microsoft.Graph.Beta.DeviceManagement.GetComanagementEligibleDevicesSummary;
using Microsoft.Graph.Beta.DeviceManagement.GetEffectivePermissions;
using Microsoft.Graph.Beta.DeviceManagement.GetEffectivePermissionsWithScope;
using Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds;
using Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByResourceWithResource;
using Microsoft.Graph.Beta.DeviceManagement.GetSuggestedEnrollmentLimitWithEnrollmentType;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyCategories;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyConfigurations;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyDefinitionFiles;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyDefinitions;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyObjectFiles;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyUploadedDefinitionFiles;
using Microsoft.Graph.Beta.DeviceManagement.ImportedDeviceIdentities;
using Microsoft.Graph.Beta.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities;
using Microsoft.Graph.Beta.DeviceManagement.Intents;
using Microsoft.Graph.Beta.DeviceManagement.IntuneBrandingProfiles;
using Microsoft.Graph.Beta.DeviceManagement.IosUpdateStatuses;
using Microsoft.Graph.Beta.DeviceManagement.MacOSSoftwareUpdateAccountSummaries;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDeviceEncryptionStates;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDeviceOverview;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices;
using Microsoft.Graph.Beta.DeviceManagement.MicrosoftTunnelConfigurations;
using Microsoft.Graph.Beta.DeviceManagement.MicrosoftTunnelHealthThresholds;
using Microsoft.Graph.Beta.DeviceManagement.MicrosoftTunnelServerLogCollectionResponses;
using Microsoft.Graph.Beta.DeviceManagement.MicrosoftTunnelSites;
using Microsoft.Graph.Beta.DeviceManagement.MobileAppTroubleshootingEvents;
using Microsoft.Graph.Beta.DeviceManagement.MobileThreatDefenseConnectors;
using Microsoft.Graph.Beta.DeviceManagement.Monitoring;
using Microsoft.Graph.Beta.DeviceManagement.NdesConnectors;
using Microsoft.Graph.Beta.DeviceManagement.NotificationMessageTemplates;
using Microsoft.Graph.Beta.DeviceManagement.OemWarrantyInformationOnboarding;
using Microsoft.Graph.Beta.DeviceManagement.RemoteActionAudits;
using Microsoft.Graph.Beta.DeviceManagement.RemoteAssistancePartners;
using Microsoft.Graph.Beta.DeviceManagement.RemoteAssistanceSettings;
using Microsoft.Graph.Beta.DeviceManagement.Reports;
using Microsoft.Graph.Beta.DeviceManagement.ResourceAccessProfiles;
using Microsoft.Graph.Beta.DeviceManagement.ResourceOperations;
using Microsoft.Graph.Beta.DeviceManagement.ReusablePolicySettings;
using Microsoft.Graph.Beta.DeviceManagement.ReusableSettings;
using Microsoft.Graph.Beta.DeviceManagement.RoleAssignments;
using Microsoft.Graph.Beta.DeviceManagement.RoleDefinitions;
using Microsoft.Graph.Beta.DeviceManagement.RoleScopeTags;
using Microsoft.Graph.Beta.DeviceManagement.ScopedForResourceWithResource;
using Microsoft.Graph.Beta.DeviceManagement.SendCustomNotificationToCompanyPortal;
using Microsoft.Graph.Beta.DeviceManagement.SettingDefinitions;
using Microsoft.Graph.Beta.DeviceManagement.SoftwareUpdateStatusSummary;
using Microsoft.Graph.Beta.DeviceManagement.TelecomExpenseManagementPartners;
using Microsoft.Graph.Beta.DeviceManagement.Templates;
using Microsoft.Graph.Beta.DeviceManagement.TemplateSettings;
using Microsoft.Graph.Beta.DeviceManagement.TenantAttachRBAC;
using Microsoft.Graph.Beta.DeviceManagement.TermsAndConditions;
using Microsoft.Graph.Beta.DeviceManagement.TroubleshootingEvents;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAnomaly;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAnomalyDevice;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthDeviceModelPerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthDevicePerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthDevicePerformanceDetails;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthOSVersionPerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsAppHealthOverview;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBaselines;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthAppImpact;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthCapacityDetails;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthDeviceAppImpact;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthDevicePerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthModelPerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthOsPerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsBatteryHealthRuntimeDetails;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsCategories;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceMetricHistory;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDevicePerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceScope;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceScopes;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceScores;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceStartupHistory;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceStartupProcesses;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceStartupProcessPerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDevicesWithoutCloudIdentity;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsDeviceTimelineEvents;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsImpactingProcess;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsMetricHistory;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsModelScores;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsNotAutopilotReadyDevice;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsOverview;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsRemoteConnection;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsResourcePerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsScoreHistory;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsSummarizedDeviceScopes;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsSummarizeWorkFromAnywhereDevices;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereMetrics;
using Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereModelPerformance;
using Microsoft.Graph.Beta.DeviceManagement.UserPfxCertificates;
using Microsoft.Graph.Beta.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeploymentProfiles;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotSettings;
using Microsoft.Graph.Beta.DeviceManagement.WindowsDriverUpdateProfiles;
using Microsoft.Graph.Beta.DeviceManagement.WindowsFeatureUpdateProfiles;
using Microsoft.Graph.Beta.DeviceManagement.WindowsInformationProtectionAppLearningSummaries;
using Microsoft.Graph.Beta.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using Microsoft.Graph.Beta.DeviceManagement.WindowsMalwareInformation;
using Microsoft.Graph.Beta.DeviceManagement.WindowsQualityUpdateProfiles;
using Microsoft.Graph.Beta.DeviceManagement.WindowsUpdateCatalogItems;
using Microsoft.Graph.Beta.DeviceManagement.ZebraFotaArtifacts;
using Microsoft.Graph.Beta.DeviceManagement.ZebraFotaConnector;
using Microsoft.Graph.Beta.DeviceManagement.ZebraFotaDeployments;
using Microsoft.Graph.Beta.Models.DeviceManagement;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceManagement {
    /// <summary>
    /// Provides operations to manage the deviceManagement singleton.
    /// </summary>
    public class DeviceManagementRequestBuilder {
        /// <summary>Provides operations to manage the advancedThreatProtectionOnboardingStateSummary property of the microsoft.graph.deviceManagement entity.</summary>
        public AdvancedThreatProtectionOnboardingStateSummaryRequestBuilder AdvancedThreatProtectionOnboardingStateSummary { get =>
            new AdvancedThreatProtectionOnboardingStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the androidDeviceOwnerEnrollmentProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public AndroidDeviceOwnerEnrollmentProfilesRequestBuilder AndroidDeviceOwnerEnrollmentProfiles { get =>
            new AndroidDeviceOwnerEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the androidForWorkAppConfigurationSchemas property of the microsoft.graph.deviceManagement entity.</summary>
        public AndroidForWorkAppConfigurationSchemasRequestBuilder AndroidForWorkAppConfigurationSchemas { get =>
            new AndroidForWorkAppConfigurationSchemasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the androidForWorkEnrollmentProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public AndroidForWorkEnrollmentProfilesRequestBuilder AndroidForWorkEnrollmentProfiles { get =>
            new AndroidForWorkEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the androidForWorkSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public AndroidForWorkSettingsRequestBuilder AndroidForWorkSettings { get =>
            new AndroidForWorkSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the androidManagedStoreAccountEnterpriseSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder AndroidManagedStoreAccountEnterpriseSettings { get =>
            new AndroidManagedStoreAccountEnterpriseSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the androidManagedStoreAppConfigurationSchemas property of the microsoft.graph.deviceManagement entity.</summary>
        public AndroidManagedStoreAppConfigurationSchemasRequestBuilder AndroidManagedStoreAppConfigurationSchemas { get =>
            new AndroidManagedStoreAppConfigurationSchemasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the applePushNotificationCertificate property of the microsoft.graph.deviceManagement entity.</summary>
        public ApplePushNotificationCertificateRequestBuilder ApplePushNotificationCertificate { get =>
            new ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appleUserInitiatedEnrollmentProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public AppleUserInitiatedEnrollmentProfilesRequestBuilder AppleUserInitiatedEnrollmentProfiles { get =>
            new AppleUserInitiatedEnrollmentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignmentFilters property of the microsoft.graph.deviceManagement entity.</summary>
        public AssignmentFiltersRequestBuilder AssignmentFilters { get =>
            new AssignmentFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the auditEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the autopilotEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public AutopilotEventsRequestBuilder AutopilotEvents { get =>
            new AutopilotEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cartToClassAssociations property of the microsoft.graph.deviceManagement entity.</summary>
        public CartToClassAssociationsRequestBuilder CartToClassAssociations { get =>
            new CartToClassAssociationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the categories property of the microsoft.graph.deviceManagement entity.</summary>
        public CategoriesRequestBuilder Categories { get =>
            new CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the certificateConnectorDetails property of the microsoft.graph.deviceManagement entity.</summary>
        public CertificateConnectorDetailsRequestBuilder CertificateConnectorDetails { get =>
            new CertificateConnectorDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the chromeOSOnboardingSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public ChromeOSOnboardingSettingsRequestBuilder ChromeOSOnboardingSettings { get =>
            new ChromeOSOnboardingSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPCConnectivityIssues property of the microsoft.graph.deviceManagement entity.</summary>
        public CloudPCConnectivityIssuesRequestBuilder CloudPCConnectivityIssues { get =>
            new CloudPCConnectivityIssuesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the comanagedDevices property of the microsoft.graph.deviceManagement entity.</summary>
        public ComanagedDevicesRequestBuilder ComanagedDevices { get =>
            new ComanagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the comanagementEligibleDevices property of the microsoft.graph.deviceManagement entity.</summary>
        public ComanagementEligibleDevicesRequestBuilder ComanagementEligibleDevices { get =>
            new ComanagementEligibleDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the complianceCategories property of the microsoft.graph.deviceManagement entity.</summary>
        public ComplianceCategoriesRequestBuilder ComplianceCategories { get =>
            new ComplianceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the complianceManagementPartners property of the microsoft.graph.deviceManagement entity.</summary>
        public ComplianceManagementPartnersRequestBuilder ComplianceManagementPartners { get =>
            new ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the compliancePolicies property of the microsoft.graph.deviceManagement entity.</summary>
        public CompliancePoliciesRequestBuilder CompliancePolicies { get =>
            new CompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the complianceSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public ComplianceSettingsRequestBuilder ComplianceSettings { get =>
            new ComplianceSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the conditionalAccessSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public ConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get =>
            new ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the configManagerCollections property of the microsoft.graph.deviceManagement entity.</summary>
        public ConfigManagerCollectionsRequestBuilder ConfigManagerCollections { get =>
            new ConfigManagerCollectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the configurationCategories property of the microsoft.graph.deviceManagement entity.</summary>
        public ConfigurationCategoriesRequestBuilder ConfigurationCategories { get =>
            new ConfigurationCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the configurationPolicies property of the microsoft.graph.deviceManagement entity.</summary>
        public ConfigurationPoliciesRequestBuilder ConfigurationPolicies { get =>
            new ConfigurationPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the configurationPolicyTemplates property of the microsoft.graph.deviceManagement entity.</summary>
        public ConfigurationPolicyTemplatesRequestBuilder ConfigurationPolicyTemplates { get =>
            new ConfigurationPolicyTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the configurationSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public ConfigurationSettingsRequestBuilder ConfigurationSettings { get =>
            new ConfigurationSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dataSharingConsents property of the microsoft.graph.deviceManagement entity.</summary>
        public DataSharingConsentsRequestBuilder DataSharingConsents { get =>
            new DataSharingConsentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the depOnboardingSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public DepOnboardingSettingsRequestBuilder DepOnboardingSettings { get =>
            new DepOnboardingSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the derivedCredentials property of the microsoft.graph.deviceManagement entity.</summary>
        public DerivedCredentialsRequestBuilder DerivedCredentials { get =>
            new DerivedCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the detectedApps property of the microsoft.graph.deviceManagement entity.</summary>
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCategories property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCategoriesRequestBuilder DeviceCategories { get =>
            new DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicies property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCompliancePoliciesRequestBuilder DeviceCompliancePolicies { get =>
            new DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicyDeviceStateSummary property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get =>
            new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicySettingStateSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceComplianceScripts property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceComplianceScriptsRequestBuilder DeviceComplianceScripts { get =>
            new DeviceComplianceScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationConflictSummary property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationConflictSummaryRequestBuilder DeviceConfigurationConflictSummary { get =>
            new DeviceConfigurationConflictSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationDeviceStateSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationDeviceStateSummariesRequestBuilder DeviceConfigurationDeviceStateSummaries { get =>
            new DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationRestrictedAppsViolations property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationRestrictedAppsViolationsRequestBuilder DeviceConfigurationRestrictedAppsViolations { get =>
            new DeviceConfigurationRestrictedAppsViolationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurations property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationsRequestBuilder DeviceConfigurations { get =>
            new DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationsAllManagedDeviceCertificateStates property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationsAllManagedDeviceCertificateStatesRequestBuilder DeviceConfigurationsAllManagedDeviceCertificateStates { get =>
            new DeviceConfigurationsAllManagedDeviceCertificateStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationUserStateSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationUserStateSummariesRequestBuilder DeviceConfigurationUserStateSummaries { get =>
            new DeviceConfigurationUserStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCustomAttributeShellScripts property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCustomAttributeShellScriptsRequestBuilder DeviceCustomAttributeShellScripts { get =>
            new DeviceCustomAttributeShellScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceEnrollmentConfigurations property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceHealthScripts property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceHealthScriptsRequestBuilder DeviceHealthScripts { get =>
            new DeviceHealthScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceManagementPartners property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceManagementPartnersRequestBuilder DeviceManagementPartners { get =>
            new DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceManagementScripts property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceManagementScriptsRequestBuilder DeviceManagementScripts { get =>
            new DeviceManagementScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceShellScripts property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceShellScriptsRequestBuilder DeviceShellScripts { get =>
            new DeviceShellScriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the domainJoinConnectors property of the microsoft.graph.deviceManagement entity.</summary>
        public DomainJoinConnectorsRequestBuilder DomainJoinConnectors { get =>
            new DomainJoinConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the embeddedSIMActivationCodePools property of the microsoft.graph.deviceManagement entity.</summary>
        public EmbeddedSIMActivationCodePoolsRequestBuilder EmbeddedSIMActivationCodePools { get =>
            new EmbeddedSIMActivationCodePoolsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enableAndroidDeviceAdministratorEnrollment method.</summary>
        public EnableAndroidDeviceAdministratorEnrollmentRequestBuilder EnableAndroidDeviceAdministratorEnrollment { get =>
            new EnableAndroidDeviceAdministratorEnrollmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enableLegacyPcManagement method.</summary>
        public EnableLegacyPcManagementRequestBuilder EnableLegacyPcManagement { get =>
            new EnableLegacyPcManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enableUnlicensedAdminstrators method.</summary>
        public EnableUnlicensedAdminstratorsRequestBuilder EnableUnlicensedAdminstrators { get =>
            new EnableUnlicensedAdminstratorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the evaluateAssignmentFilter method.</summary>
        public EvaluateAssignmentFilterRequestBuilder EvaluateAssignmentFilter { get =>
            new EvaluateAssignmentFilterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exchangeConnectors property of the microsoft.graph.deviceManagement entity.</summary>
        public ExchangeConnectorsRequestBuilder ExchangeConnectors { get =>
            new ExchangeConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exchangeOnPremisesPolicies property of the microsoft.graph.deviceManagement entity.</summary>
        public ExchangeOnPremisesPoliciesRequestBuilder ExchangeOnPremisesPolicies { get =>
            new ExchangeOnPremisesPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exchangeOnPremisesPolicy property of the microsoft.graph.deviceManagement entity.</summary>
        public ExchangeOnPremisesPolicyRequestBuilder ExchangeOnPremisesPolicy { get =>
            new ExchangeOnPremisesPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAssignmentFiltersStatusDetails method.</summary>
        public GetAssignmentFiltersStatusDetailsRequestBuilder GetAssignmentFiltersStatusDetails { get =>
            new GetAssignmentFiltersStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupPolicyCategories property of the microsoft.graph.deviceManagement entity.</summary>
        public GroupPolicyCategoriesRequestBuilder GroupPolicyCategories { get =>
            new GroupPolicyCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupPolicyConfigurations property of the microsoft.graph.deviceManagement entity.</summary>
        public GroupPolicyConfigurationsRequestBuilder GroupPolicyConfigurations { get =>
            new GroupPolicyConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupPolicyDefinitionFiles property of the microsoft.graph.deviceManagement entity.</summary>
        public GroupPolicyDefinitionFilesRequestBuilder GroupPolicyDefinitionFiles { get =>
            new GroupPolicyDefinitionFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupPolicyDefinitions property of the microsoft.graph.deviceManagement entity.</summary>
        public GroupPolicyDefinitionsRequestBuilder GroupPolicyDefinitions { get =>
            new GroupPolicyDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupPolicyMigrationReports property of the microsoft.graph.deviceManagement entity.</summary>
        public GroupPolicyMigrationReportsRequestBuilder GroupPolicyMigrationReports { get =>
            new GroupPolicyMigrationReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupPolicyObjectFiles property of the microsoft.graph.deviceManagement entity.</summary>
        public GroupPolicyObjectFilesRequestBuilder GroupPolicyObjectFiles { get =>
            new GroupPolicyObjectFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the groupPolicyUploadedDefinitionFiles property of the microsoft.graph.deviceManagement entity.</summary>
        public GroupPolicyUploadedDefinitionFilesRequestBuilder GroupPolicyUploadedDefinitionFiles { get =>
            new GroupPolicyUploadedDefinitionFilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the importedDeviceIdentities property of the microsoft.graph.deviceManagement entity.</summary>
        public ImportedDeviceIdentitiesRequestBuilder ImportedDeviceIdentities { get =>
            new ImportedDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the importedWindowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.</summary>
        public ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder ImportedWindowsAutopilotDeviceIdentities { get =>
            new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intents property of the microsoft.graph.deviceManagement entity.</summary>
        public IntentsRequestBuilder Intents { get =>
            new IntentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intuneBrandingProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public IntuneBrandingProfilesRequestBuilder IntuneBrandingProfiles { get =>
            new IntuneBrandingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the iosUpdateStatuses property of the microsoft.graph.deviceManagement entity.</summary>
        public IosUpdateStatusesRequestBuilder IosUpdateStatuses { get =>
            new IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the macOSSoftwareUpdateAccountSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public MacOSSoftwareUpdateAccountSummariesRequestBuilder MacOSSoftwareUpdateAccountSummaries { get =>
            new MacOSSoftwareUpdateAccountSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDeviceEncryptionStates property of the microsoft.graph.deviceManagement entity.</summary>
        public ManagedDeviceEncryptionStatesRequestBuilder ManagedDeviceEncryptionStates { get =>
            new ManagedDeviceEncryptionStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDeviceOverview property of the microsoft.graph.deviceManagement entity.</summary>
        public ManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get =>
            new ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.deviceManagement entity.</summary>
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoftTunnelConfigurations property of the microsoft.graph.deviceManagement entity.</summary>
        public MicrosoftTunnelConfigurationsRequestBuilder MicrosoftTunnelConfigurations { get =>
            new MicrosoftTunnelConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoftTunnelHealthThresholds property of the microsoft.graph.deviceManagement entity.</summary>
        public MicrosoftTunnelHealthThresholdsRequestBuilder MicrosoftTunnelHealthThresholds { get =>
            new MicrosoftTunnelHealthThresholdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoftTunnelServerLogCollectionResponses property of the microsoft.graph.deviceManagement entity.</summary>
        public MicrosoftTunnelServerLogCollectionResponsesRequestBuilder MicrosoftTunnelServerLogCollectionResponses { get =>
            new MicrosoftTunnelServerLogCollectionResponsesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoftTunnelSites property of the microsoft.graph.deviceManagement entity.</summary>
        public MicrosoftTunnelSitesRequestBuilder MicrosoftTunnelSites { get =>
            new MicrosoftTunnelSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileAppTroubleshootingEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public MobileAppTroubleshootingEventsRequestBuilder MobileAppTroubleshootingEvents { get =>
            new MobileAppTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileThreatDefenseConnectors property of the microsoft.graph.deviceManagement entity.</summary>
        public MobileThreatDefenseConnectorsRequestBuilder MobileThreatDefenseConnectors { get =>
            new MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monitoring property of the microsoft.graph.deviceManagement entity.</summary>
        public MonitoringRequestBuilder Monitoring { get =>
            new MonitoringRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ndesConnectors property of the microsoft.graph.deviceManagement entity.</summary>
        public NdesConnectorsRequestBuilder NdesConnectors { get =>
            new NdesConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the notificationMessageTemplates property of the microsoft.graph.deviceManagement entity.</summary>
        public NotificationMessageTemplatesRequestBuilder NotificationMessageTemplates { get =>
            new NotificationMessageTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the oemWarrantyInformationOnboarding property of the microsoft.graph.deviceManagement entity.</summary>
        public OemWarrantyInformationOnboardingRequestBuilder OemWarrantyInformationOnboarding { get =>
            new OemWarrantyInformationOnboardingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Provides operations to manage the remoteActionAudits property of the microsoft.graph.deviceManagement entity.</summary>
        public RemoteActionAuditsRequestBuilder RemoteActionAudits { get =>
            new RemoteActionAuditsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the remoteAssistancePartners property of the microsoft.graph.deviceManagement entity.</summary>
        public RemoteAssistancePartnersRequestBuilder RemoteAssistancePartners { get =>
            new RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the remoteAssistanceSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public RemoteAssistanceSettingsRequestBuilder RemoteAssistanceSettings { get =>
            new RemoteAssistanceSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the resourceAccessProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public ResourceAccessProfilesRequestBuilder ResourceAccessProfiles { get =>
            new ResourceAccessProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resourceOperations property of the microsoft.graph.deviceManagement entity.</summary>
        public ResourceOperationsRequestBuilder ResourceOperations { get =>
            new ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reusablePolicySettings property of the microsoft.graph.deviceManagement entity.</summary>
        public ReusablePolicySettingsRequestBuilder ReusablePolicySettings { get =>
            new ReusablePolicySettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reusableSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public ReusableSettingsRequestBuilder ReusableSettings { get =>
            new ReusableSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignments property of the microsoft.graph.deviceManagement entity.</summary>
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleDefinitions property of the microsoft.graph.deviceManagement entity.</summary>
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleScopeTags property of the microsoft.graph.deviceManagement entity.</summary>
        public RoleScopeTagsRequestBuilder RoleScopeTags { get =>
            new RoleScopeTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendCustomNotificationToCompanyPortal method.</summary>
        public SendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal { get =>
            new SendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settingDefinitions property of the microsoft.graph.deviceManagement entity.</summary>
        public SettingDefinitionsRequestBuilder SettingDefinitions { get =>
            new SettingDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the softwareUpdateStatusSummary property of the microsoft.graph.deviceManagement entity.</summary>
        public SoftwareUpdateStatusSummaryRequestBuilder SoftwareUpdateStatusSummary { get =>
            new SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the telecomExpenseManagementPartners property of the microsoft.graph.deviceManagement entity.</summary>
        public TelecomExpenseManagementPartnersRequestBuilder TelecomExpenseManagementPartners { get =>
            new TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the templates property of the microsoft.graph.deviceManagement entity.</summary>
        public TemplatesRequestBuilder Templates { get =>
            new TemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the templateSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public TemplateSettingsRequestBuilder TemplateSettings { get =>
            new TemplateSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenantAttachRBAC property of the microsoft.graph.deviceManagement entity.</summary>
        public TenantAttachRBACRequestBuilder TenantAttachRBAC { get =>
            new TenantAttachRBACRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termsAndConditions property of the microsoft.graph.deviceManagement entity.</summary>
        public TermsAndConditionsRequestBuilder TermsAndConditions { get =>
            new TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the troubleshootingEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public TroubleshootingEventsRequestBuilder TroubleshootingEvents { get =>
            new TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAnomaly property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAnomalyRequestBuilder UserExperienceAnalyticsAnomaly { get =>
            new UserExperienceAnalyticsAnomalyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAnomalyDevice property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAnomalyDeviceRequestBuilder UserExperienceAnalyticsAnomalyDevice { get =>
            new UserExperienceAnalyticsAnomalyDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformance { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersion { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthDeviceModelPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder UserExperienceAnalyticsAppHealthDeviceModelPerformance { get =>
            new UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthDevicePerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformance { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthDevicePerformanceDetails property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformanceDetails { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthOSVersionPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder UserExperienceAnalyticsAppHealthOSVersionPerformance { get =>
            new UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthOverview property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthOverviewRequestBuilder UserExperienceAnalyticsAppHealthOverview { get =>
            new UserExperienceAnalyticsAppHealthOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBaselines property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBaselinesRequestBuilder UserExperienceAnalyticsBaselines { get =>
            new UserExperienceAnalyticsBaselinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthAppImpact property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthAppImpactRequestBuilder UserExperienceAnalyticsBatteryHealthAppImpact { get =>
            new UserExperienceAnalyticsBatteryHealthAppImpactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthCapacityDetails property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthCapacityDetailsRequestBuilder UserExperienceAnalyticsBatteryHealthCapacityDetails { get =>
            new UserExperienceAnalyticsBatteryHealthCapacityDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthDeviceAppImpact property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthDeviceAppImpactRequestBuilder UserExperienceAnalyticsBatteryHealthDeviceAppImpact { get =>
            new UserExperienceAnalyticsBatteryHealthDeviceAppImpactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthDevicePerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthDevicePerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthDevicePerformance { get =>
            new UserExperienceAnalyticsBatteryHealthDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthDeviceRuntimeHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryRequestBuilder UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory { get =>
            new UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthModelPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthModelPerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthModelPerformance { get =>
            new UserExperienceAnalyticsBatteryHealthModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthOsPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthOsPerformanceRequestBuilder UserExperienceAnalyticsBatteryHealthOsPerformance { get =>
            new UserExperienceAnalyticsBatteryHealthOsPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBatteryHealthRuntimeDetails property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBatteryHealthRuntimeDetailsRequestBuilder UserExperienceAnalyticsBatteryHealthRuntimeDetails { get =>
            new UserExperienceAnalyticsBatteryHealthRuntimeDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsCategories property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsCategoriesRequestBuilder UserExperienceAnalyticsCategories { get =>
            new UserExperienceAnalyticsCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceMetricHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceMetricHistoryRequestBuilder UserExperienceAnalyticsDeviceMetricHistory { get =>
            new UserExperienceAnalyticsDeviceMetricHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDevicePerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDevicePerformanceRequestBuilder UserExperienceAnalyticsDevicePerformance { get =>
            new UserExperienceAnalyticsDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceScope property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceScopeRequestBuilder UserExperienceAnalyticsDeviceScope { get =>
            new UserExperienceAnalyticsDeviceScopeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceScopes property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceScopesRequestBuilder UserExperienceAnalyticsDeviceScopes { get =>
            new UserExperienceAnalyticsDeviceScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceScores property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceScoresRequestBuilder UserExperienceAnalyticsDeviceScores { get =>
            new UserExperienceAnalyticsDeviceScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceStartupHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder UserExperienceAnalyticsDeviceStartupHistory { get =>
            new UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceStartupProcesses property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder UserExperienceAnalyticsDeviceStartupProcesses { get =>
            new UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceStartupProcessPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder UserExperienceAnalyticsDeviceStartupProcessPerformance { get =>
            new UserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDevicesWithoutCloudIdentity property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDevicesWithoutCloudIdentityRequestBuilder UserExperienceAnalyticsDevicesWithoutCloudIdentity { get =>
            new UserExperienceAnalyticsDevicesWithoutCloudIdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceTimelineEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceTimelineEventsRequestBuilder UserExperienceAnalyticsDeviceTimelineEvents { get =>
            new UserExperienceAnalyticsDeviceTimelineEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsImpactingProcess property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsImpactingProcessRequestBuilder UserExperienceAnalyticsImpactingProcess { get =>
            new UserExperienceAnalyticsImpactingProcessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsMetricHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsMetricHistoryRequestBuilder UserExperienceAnalyticsMetricHistory { get =>
            new UserExperienceAnalyticsMetricHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsModelScores property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsModelScoresRequestBuilder UserExperienceAnalyticsModelScores { get =>
            new UserExperienceAnalyticsModelScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsNotAutopilotReadyDevice property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder UserExperienceAnalyticsNotAutopilotReadyDevice { get =>
            new UserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsOverview property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsOverviewRequestBuilder UserExperienceAnalyticsOverview { get =>
            new UserExperienceAnalyticsOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsRemoteConnection property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsRemoteConnectionRequestBuilder UserExperienceAnalyticsRemoteConnection { get =>
            new UserExperienceAnalyticsRemoteConnectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsResourcePerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsResourcePerformanceRequestBuilder UserExperienceAnalyticsResourcePerformance { get =>
            new UserExperienceAnalyticsResourcePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsScoreHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsScoreHistoryRequestBuilder UserExperienceAnalyticsScoreHistory { get =>
            new UserExperienceAnalyticsScoreHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric { get =>
            new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsWorkFromAnywhereMetrics property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder UserExperienceAnalyticsWorkFromAnywhereMetrics { get =>
            new UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsWorkFromAnywhereModelPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder UserExperienceAnalyticsWorkFromAnywhereModelPerformance { get =>
            new UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userPfxCertificates property of the microsoft.graph.deviceManagement entity.</summary>
        public UserPfxCertificatesRequestBuilder UserPfxCertificates { get =>
            new UserPfxCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the virtualEndpoint property of the microsoft.graph.deviceManagement entity.</summary>
        public VirtualEndpointRequestBuilder VirtualEndpoint { get =>
            new VirtualEndpointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsAutopilotDeploymentProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsAutopilotDeploymentProfilesRequestBuilder WindowsAutopilotDeploymentProfiles { get =>
            new WindowsAutopilotDeploymentProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsAutopilotDeviceIdentitiesRequestBuilder WindowsAutopilotDeviceIdentities { get =>
            new WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsAutopilotSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsAutopilotSettingsRequestBuilder WindowsAutopilotSettings { get =>
            new WindowsAutopilotSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsDriverUpdateProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsDriverUpdateProfilesRequestBuilder WindowsDriverUpdateProfiles { get =>
            new WindowsDriverUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsFeatureUpdateProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsFeatureUpdateProfilesRequestBuilder WindowsFeatureUpdateProfiles { get =>
            new WindowsFeatureUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionAppLearningSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsInformationProtectionAppLearningSummariesRequestBuilder WindowsInformationProtectionAppLearningSummaries { get =>
            new WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionNetworkLearningSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsInformationProtectionNetworkLearningSummariesRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get =>
            new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsMalwareInformation property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsMalwareInformationRequestBuilder WindowsMalwareInformation { get =>
            new WindowsMalwareInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsQualityUpdateProfiles property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsQualityUpdateProfilesRequestBuilder WindowsQualityUpdateProfiles { get =>
            new WindowsQualityUpdateProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsUpdateCatalogItems property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsUpdateCatalogItemsRequestBuilder WindowsUpdateCatalogItems { get =>
            new WindowsUpdateCatalogItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the zebraFotaArtifacts property of the microsoft.graph.deviceManagement entity.</summary>
        public ZebraFotaArtifactsRequestBuilder ZebraFotaArtifacts { get =>
            new ZebraFotaArtifactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the zebraFotaConnector property of the microsoft.graph.deviceManagement entity.</summary>
        public ZebraFotaConnectorRequestBuilder ZebraFotaConnector { get =>
            new ZebraFotaConnectorRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the zebraFotaDeployments property of the microsoft.graph.deviceManagement entity.</summary>
        public ZebraFotaDeploymentsRequestBuilder ZebraFotaDeployments { get =>
            new ZebraFotaDeploymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Provides operations to call the getAssignedRoleDetails method.
        /// </summary>
        public GetAssignedRoleDetailsRequestBuilder GetAssignedRoleDetails() {
            return new GetAssignedRoleDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Get deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement> GetAsync(Action<DeviceManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement>(requestInfo, Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getComanagedDevicesSummary method.
        /// </summary>
        public GetComanagedDevicesSummaryRequestBuilder GetComanagedDevicesSummary() {
            return new GetComanagedDevicesSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getComanagementEligibleDevicesSummary method.
        /// </summary>
        public GetComanagementEligibleDevicesSummaryRequestBuilder GetComanagementEligibleDevicesSummary() {
            return new GetComanagementEligibleDevicesSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// </summary>
        public GetEffectivePermissionsRequestBuilder GetEffectivePermissions() {
            return new GetEffectivePermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// </summary>
        /// <param name="scope">Usage: scope=&apos;{scope}&apos;</param>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Provides operations to call the getRoleScopeTagsByIds method.
        /// </summary>
        /// <param name="ids">Usage: ids={ids}</param>
        public GetRoleScopeTagsByIdsWithIdsRequestBuilder GetRoleScopeTagsByIdsWithIds(string ids) {
            if(string.IsNullOrEmpty(ids)) throw new ArgumentNullException(nameof(ids));
            return new GetRoleScopeTagsByIdsWithIdsRequestBuilder(PathParameters, RequestAdapter, ids);
        }
        /// <summary>
        /// Provides operations to call the getRoleScopeTagsByResource method.
        /// </summary>
        /// <param name="resource">Usage: resource=&apos;{resource}&apos;</param>
        public GetRoleScopeTagsByResourceWithResourceRequestBuilder GetRoleScopeTagsByResourceWithResource(string resource) {
            if(string.IsNullOrEmpty(resource)) throw new ArgumentNullException(nameof(resource));
            return new GetRoleScopeTagsByResourceWithResourceRequestBuilder(PathParameters, RequestAdapter, resource);
        }
        /// <summary>
        /// Provides operations to call the getSuggestedEnrollmentLimit method.
        /// </summary>
        /// <param name="enrollmentType">Usage: enrollmentType=&apos;{enrollmentType}&apos;</param>
        public GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder GetSuggestedEnrollmentLimitWithEnrollmentType(string enrollmentType) {
            if(string.IsNullOrEmpty(enrollmentType)) throw new ArgumentNullException(nameof(enrollmentType));
            return new GetSuggestedEnrollmentLimitWithEnrollmentTypeRequestBuilder(PathParameters, RequestAdapter, enrollmentType);
        }
        /// <summary>
        /// Update deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement> PatchAsync(Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement>(requestInfo, Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the scopedForResource method.
        /// </summary>
        /// <param name="resource">Usage: resource=&apos;{resource}&apos;</param>
        public ScopedForResourceWithResourceRequestBuilder ScopedForResourceWithResource(string resource) {
            if(string.IsNullOrEmpty(resource)) throw new ArgumentNullException(nameof(resource));
            return new ScopedForResourceWithResourceRequestBuilder(PathParameters, RequestAdapter, resource);
        }
        /// <summary>
        /// Get deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation ToGetRequestInformation(Action<DeviceManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.DeviceManagement.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the userExperienceAnalyticsSummarizedDeviceScopes method.
        /// </summary>
        public UserExperienceAnalyticsSummarizedDeviceScopesRequestBuilder UserExperienceAnalyticsSummarizedDeviceScopes() {
            return new UserExperienceAnalyticsSummarizedDeviceScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the userExperienceAnalyticsSummarizeWorkFromAnywhereDevices method.
        /// </summary>
        public UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder UserExperienceAnalyticsSummarizeWorkFromAnywhereDevices() {
            return new UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the verifyWindowsEnrollmentAutoDiscovery method.
        /// </summary>
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>
        /// Get deviceManagement
        /// </summary>
        public class DeviceManagementRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
