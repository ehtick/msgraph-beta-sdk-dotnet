// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityClient.cs.tt

namespace Microsoft.Graph
{

    /// <summary>
    /// The interface IGraphServiceClient.
    /// </summary>
    public partial interface IGraphServiceClient : IBaseClient
    {
    
        /// <summary>
        /// Gets the GraphServiceInvitations request builder.
        /// </summary>
        IGraphServiceInvitationsCollectionRequestBuilder Invitations { get; }
    
        /// <summary>
        /// Gets the GraphServiceUsers request builder.
        /// </summary>
        IGraphServiceUsersCollectionRequestBuilder Users { get; }
    
        /// <summary>
        /// Gets the GraphServiceActivitystatistics request builder.
        /// </summary>
        IGraphServiceActivitystatisticsCollectionRequestBuilder Activitystatistics { get; }
    
        /// <summary>
        /// Gets the GraphServiceApplicationTemplates request builder.
        /// </summary>
        IGraphServiceApplicationTemplatesCollectionRequestBuilder ApplicationTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceServicePrincipals request builder.
        /// </summary>
        IGraphServiceServicePrincipalsCollectionRequestBuilder ServicePrincipals { get; }
    
        /// <summary>
        /// Gets the GraphServiceBookingBusinesses request builder.
        /// </summary>
        IGraphServiceBookingBusinessesCollectionRequestBuilder BookingBusinesses { get; }
    
        /// <summary>
        /// Gets the GraphServiceBookingCurrencies request builder.
        /// </summary>
        IGraphServiceBookingCurrenciesCollectionRequestBuilder BookingCurrencies { get; }
    
        /// <summary>
        /// Gets the GraphServiceIdentityProviders request builder.
        /// </summary>
        IGraphServiceIdentityProvidersCollectionRequestBuilder IdentityProviders { get; }
    
        /// <summary>
        /// Gets the GraphServiceAdministrativeUnits request builder.
        /// </summary>
        IGraphServiceAdministrativeUnitsCollectionRequestBuilder AdministrativeUnits { get; }
    
        /// <summary>
        /// Gets the GraphServiceAllowedDataLocations request builder.
        /// </summary>
        IGraphServiceAllowedDataLocationsCollectionRequestBuilder AllowedDataLocations { get; }
    
        /// <summary>
        /// Gets the GraphServiceApplications request builder.
        /// </summary>
        IGraphServiceApplicationsCollectionRequestBuilder Applications { get; }
    
        /// <summary>
        /// Gets the GraphServiceAppRoleAssignments request builder.
        /// </summary>
        IGraphServiceAppRoleAssignmentsCollectionRequestBuilder AppRoleAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceCertificateBasedAuthConfiguration request builder.
        /// </summary>
        IGraphServiceCertificateBasedAuthConfigurationCollectionRequestBuilder CertificateBasedAuthConfiguration { get; }
    
        /// <summary>
        /// Gets the GraphServiceContacts request builder.
        /// </summary>
        IGraphServiceContactsCollectionRequestBuilder Contacts { get; }
    
        /// <summary>
        /// Gets the GraphServiceContracts request builder.
        /// </summary>
        IGraphServiceContractsCollectionRequestBuilder Contracts { get; }
    
        /// <summary>
        /// Gets the GraphServiceDevices request builder.
        /// </summary>
        IGraphServiceDevicesCollectionRequestBuilder Devices { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryObjects request builder.
        /// </summary>
        IGraphServiceDirectoryObjectsCollectionRequestBuilder DirectoryObjects { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoles request builder.
        /// </summary>
        IGraphServiceDirectoryRolesCollectionRequestBuilder DirectoryRoles { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoleTemplates request builder.
        /// </summary>
        IGraphServiceDirectoryRoleTemplatesCollectionRequestBuilder DirectoryRoleTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectorySettingTemplates request builder.
        /// </summary>
        IGraphServiceDirectorySettingTemplatesCollectionRequestBuilder DirectorySettingTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceDomainDnsRecords request builder.
        /// </summary>
        IGraphServiceDomainDnsRecordsCollectionRequestBuilder DomainDnsRecords { get; }
    
        /// <summary>
        /// Gets the GraphServiceDomains request builder.
        /// </summary>
        IGraphServiceDomainsCollectionRequestBuilder Domains { get; }
    
        /// <summary>
        /// Gets the GraphServiceGroups request builder.
        /// </summary>
        IGraphServiceGroupsCollectionRequestBuilder Groups { get; }
    
        /// <summary>
        /// Gets the GraphServiceOauth2PermissionGrants request builder.
        /// </summary>
        IGraphServiceOauth2PermissionGrantsCollectionRequestBuilder Oauth2PermissionGrants { get; }
    
        /// <summary>
        /// Gets the GraphServiceOrganization request builder.
        /// </summary>
        IGraphServiceOrganizationCollectionRequestBuilder Organization { get; }
    
        /// <summary>
        /// Gets the GraphServicePermissionGrants request builder.
        /// </summary>
        IGraphServicePermissionGrantsCollectionRequestBuilder PermissionGrants { get; }
    
        /// <summary>
        /// Gets the GraphServiceScopedRoleMemberships request builder.
        /// </summary>
        IGraphServiceScopedRoleMembershipsCollectionRequestBuilder ScopedRoleMemberships { get; }
    
        /// <summary>
        /// Gets the GraphServiceSettings request builder.
        /// </summary>
        IGraphServiceSettingsCollectionRequestBuilder Settings { get; }
    
        /// <summary>
        /// Gets the GraphServiceSubscribedSkus request builder.
        /// </summary>
        IGraphServiceSubscribedSkusCollectionRequestBuilder SubscribedSkus { get; }
    
        /// <summary>
        /// Gets the GraphServiceWorkbooks request builder.
        /// </summary>
        IGraphServiceWorkbooksCollectionRequestBuilder Workbooks { get; }
    
        /// <summary>
        /// Gets the GraphServicePlaces request builder.
        /// </summary>
        IGraphServicePlacesCollectionRequestBuilder Places { get; }
    
        /// <summary>
        /// Gets the GraphServiceDrives request builder.
        /// </summary>
        IGraphServiceDrivesCollectionRequestBuilder Drives { get; }
    
        /// <summary>
        /// Gets the GraphServiceShares request builder.
        /// </summary>
        IGraphServiceSharesCollectionRequestBuilder Shares { get; }
    
        /// <summary>
        /// Gets the GraphServiceSites request builder.
        /// </summary>
        IGraphServiceSitesCollectionRequestBuilder Sites { get; }
    
        /// <summary>
        /// Gets the GraphServiceSchemaExtensions request builder.
        /// </summary>
        IGraphServiceSchemaExtensionsCollectionRequestBuilder SchemaExtensions { get; }
    
        /// <summary>
        /// Gets the GraphServiceConnectorGroups request builder.
        /// </summary>
        IGraphServiceConnectorGroupsCollectionRequestBuilder ConnectorGroups { get; }
    
        /// <summary>
        /// Gets the GraphServiceConnectors request builder.
        /// </summary>
        IGraphServiceConnectorsCollectionRequestBuilder Connectors { get; }
    
        /// <summary>
        /// Gets the GraphServiceOnPremisesPublishingProfiles request builder.
        /// </summary>
        IGraphServiceOnPremisesPublishingProfilesCollectionRequestBuilder OnPremisesPublishingProfiles { get; }
    
        /// <summary>
        /// Gets the GraphServiceGroupLifecyclePolicies request builder.
        /// </summary>
        IGraphServiceGroupLifecyclePoliciesCollectionRequestBuilder GroupLifecyclePolicies { get; }
    
        /// <summary>
        /// Gets the GraphServiceFilterOperators request builder.
        /// </summary>
        IGraphServiceFilterOperatorsCollectionRequestBuilder FilterOperators { get; }
    
        /// <summary>
        /// Gets the GraphServiceFunctions request builder.
        /// </summary>
        IGraphServiceFunctionsCollectionRequestBuilder Functions { get; }
    
        /// <summary>
        /// Gets the GraphServiceAccessReviewDecisions request builder.
        /// </summary>
        IGraphServiceAccessReviewDecisionsCollectionRequestBuilder AccessReviewDecisions { get; }
    
        /// <summary>
        /// Gets the GraphServiceAccessReviews request builder.
        /// </summary>
        IGraphServiceAccessReviewsCollectionRequestBuilder AccessReviews { get; }
    
        /// <summary>
        /// Gets the GraphServiceApprovalWorkflowProviders request builder.
        /// </summary>
        IGraphServiceApprovalWorkflowProvidersCollectionRequestBuilder ApprovalWorkflowProviders { get; }
    
        /// <summary>
        /// Gets the GraphServiceBusinessFlowTemplates request builder.
        /// </summary>
        IGraphServiceBusinessFlowTemplatesCollectionRequestBuilder BusinessFlowTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceProgramControls request builder.
        /// </summary>
        IGraphServiceProgramControlsCollectionRequestBuilder ProgramControls { get; }
    
        /// <summary>
        /// Gets the GraphServiceProgramControlTypes request builder.
        /// </summary>
        IGraphServiceProgramControlTypesCollectionRequestBuilder ProgramControlTypes { get; }
    
        /// <summary>
        /// Gets the GraphServicePrograms request builder.
        /// </summary>
        IGraphServiceProgramsCollectionRequestBuilder Programs { get; }
    
        /// <summary>
        /// Gets the GraphServiceAgreementAcceptances request builder.
        /// </summary>
        IGraphServiceAgreementAcceptancesCollectionRequestBuilder AgreementAcceptances { get; }
    
        /// <summary>
        /// Gets the GraphServiceAgreements request builder.
        /// </summary>
        IGraphServiceAgreementsCollectionRequestBuilder Agreements { get; }
    
        /// <summary>
        /// Gets the GraphServiceRiskDetections request builder.
        /// </summary>
        IGraphServiceRiskDetectionsCollectionRequestBuilder RiskDetections { get; }
    
        /// <summary>
        /// Gets the GraphServiceRiskyUsers request builder.
        /// </summary>
        IGraphServiceRiskyUsersCollectionRequestBuilder RiskyUsers { get; }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceResources request builder.
        /// </summary>
        IGraphServiceGovernanceResourcesCollectionRequestBuilder GovernanceResources { get; }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleAssignmentRequests request builder.
        /// </summary>
        IGraphServiceGovernanceRoleAssignmentRequestsCollectionRequestBuilder GovernanceRoleAssignmentRequests { get; }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleAssignments request builder.
        /// </summary>
        IGraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder GovernanceRoleAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleDefinitions request builder.
        /// </summary>
        IGraphServiceGovernanceRoleDefinitionsCollectionRequestBuilder GovernanceRoleDefinitions { get; }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceRoleSettings request builder.
        /// </summary>
        IGraphServiceGovernanceRoleSettingsCollectionRequestBuilder GovernanceRoleSettings { get; }
    
        /// <summary>
        /// Gets the GraphServiceGovernanceSubjects request builder.
        /// </summary>
        IGraphServiceGovernanceSubjectsCollectionRequestBuilder GovernanceSubjects { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedAccess request builder.
        /// </summary>
        IGraphServicePrivilegedAccessCollectionRequestBuilder PrivilegedAccess { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedApproval request builder.
        /// </summary>
        IGraphServicePrivilegedApprovalCollectionRequestBuilder PrivilegedApproval { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedOperationEvents request builder.
        /// </summary>
        IGraphServicePrivilegedOperationEventsCollectionRequestBuilder PrivilegedOperationEvents { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoleAssignmentRequests request builder.
        /// </summary>
        IGraphServicePrivilegedRoleAssignmentRequestsCollectionRequestBuilder PrivilegedRoleAssignmentRequests { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoleAssignments request builder.
        /// </summary>
        IGraphServicePrivilegedRoleAssignmentsCollectionRequestBuilder PrivilegedRoleAssignments { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedRoles request builder.
        /// </summary>
        IGraphServicePrivilegedRolesCollectionRequestBuilder PrivilegedRoles { get; }
    
        /// <summary>
        /// Gets the GraphServicePrivilegedSignupStatus request builder.
        /// </summary>
        IGraphServicePrivilegedSignupStatusCollectionRequestBuilder PrivilegedSignupStatus { get; }
    
        /// <summary>
        /// Gets the GraphServiceCommands request builder.
        /// </summary>
        IGraphServiceCommandsCollectionRequestBuilder Commands { get; }
    
        /// <summary>
        /// Gets the GraphServicePayloadResponse request builder.
        /// </summary>
        IGraphServicePayloadResponseCollectionRequestBuilder PayloadResponse { get; }
    
        /// <summary>
        /// Gets the GraphServiceDataPolicyOperations request builder.
        /// </summary>
        IGraphServiceDataPolicyOperationsCollectionRequestBuilder DataPolicyOperations { get; }
    
        /// <summary>
        /// Gets the GraphServiceSubscriptions request builder.
        /// </summary>
        IGraphServiceSubscriptionsCollectionRequestBuilder Subscriptions { get; }
    
        /// <summary>
        /// Gets the GraphServiceConnections request builder.
        /// </summary>
        IGraphServiceConnectionsCollectionRequestBuilder Connections { get; }
    
        /// <summary>
        /// Gets the GraphServiceChats request builder.
        /// </summary>
        IGraphServiceChatsCollectionRequestBuilder Chats { get; }
    
        /// <summary>
        /// Gets the GraphServiceTeams request builder.
        /// </summary>
        IGraphServiceTeamsCollectionRequestBuilder Teams { get; }
    
        /// <summary>
        /// Gets the GraphServiceTeamsTemplates request builder.
        /// </summary>
        IGraphServiceTeamsTemplatesCollectionRequestBuilder TeamsTemplates { get; }
    
        /// <summary>
        /// Gets the GraphServiceAuditLogs request builder.
        /// </summary>
        IAuditLogRootRequestBuilder AuditLogs { get; }
    
        /// <summary>
        /// Gets the GraphServiceReports request builder.
        /// </summary>
        IReportRootRequestBuilder Reports { get; }
    
        /// <summary>
        /// Gets the GraphServiceBitlocker request builder.
        /// </summary>
        IBitlockerRequestBuilder Bitlocker { get; }
    
        /// <summary>
        /// Gets the GraphServiceCompliance request builder.
        /// </summary>
        IComplianceRequestBuilder Compliance { get; }
    
        /// <summary>
        /// Gets the GraphServiceIdentity request builder.
        /// </summary>
        IIdentityContainerRequestBuilder Identity { get; }
    
        /// <summary>
        /// Gets the GraphServiceTrustFramework request builder.
        /// </summary>
        ITrustFrameworkRequestBuilder TrustFramework { get; }
    
        /// <summary>
        /// Gets the GraphServiceDataClassification request builder.
        /// </summary>
        IDataClassificationServiceRequestBuilder DataClassification { get; }
    
        /// <summary>
        /// Gets the GraphServiceInformationProtection request builder.
        /// </summary>
        IInformationProtectionRequestBuilder InformationProtection { get; }
    
        /// <summary>
        /// Gets the GraphServiceBranding request builder.
        /// </summary>
        IOrganizationalBrandingRequestBuilder Branding { get; }
    
        /// <summary>
        /// Gets the GraphServiceDirectory request builder.
        /// </summary>
        IDirectoryRequestBuilder Directory { get; }
    
        /// <summary>
        /// Gets the GraphServiceMe request builder.
        /// </summary>
        IUserRequestBuilder Me { get; }
    
        /// <summary>
        /// Gets the GraphServicePolicies request builder.
        /// </summary>
        IPolicyRootRequestBuilder Policies { get; }
    
        /// <summary>
        /// Gets the GraphServiceRoleManagement request builder.
        /// </summary>
        IRoleManagementRequestBuilder RoleManagement { get; }
    
        /// <summary>
        /// Gets the GraphServiceEducation request builder.
        /// </summary>
        IEducationRootRequestBuilder Education { get; }
    
        /// <summary>
        /// Gets the GraphServiceDrive request builder.
        /// </summary>
        IDriveRequestBuilder Drive { get; }
    
        /// <summary>
        /// Gets the GraphServiceTermStore request builder.
        /// </summary>
        Microsoft.Graph.TermStore.IStoreRequestBuilder TermStore { get; }
    
        /// <summary>
        /// Gets the GraphServiceCommunications request builder.
        /// </summary>
        ICloudCommunicationsRequestBuilder Communications { get; }
    
        /// <summary>
        /// Gets the GraphServiceIdentityProtection request builder.
        /// </summary>
        IIdentityProtectionRootRequestBuilder IdentityProtection { get; }
    
        /// <summary>
        /// Gets the GraphServiceIdentityGovernance request builder.
        /// </summary>
        IIdentityGovernanceRequestBuilder IdentityGovernance { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceManagement request builder.
        /// </summary>
        IDeviceManagementRequestBuilder DeviceManagement { get; }
    
        /// <summary>
        /// Gets the GraphServiceDeviceAppManagement request builder.
        /// </summary>
        IDeviceAppManagementRequestBuilder DeviceAppManagement { get; }
    
        /// <summary>
        /// Gets the GraphServiceOfficeConfiguration request builder.
        /// </summary>
        IOfficeConfigurationRequestBuilder OfficeConfiguration { get; }
    
        /// <summary>
        /// Gets the GraphServiceSearch request builder.
        /// </summary>
        ISearchEntityRequestBuilder Search { get; }
    
        /// <summary>
        /// Gets the GraphServiceFinancials request builder.
        /// </summary>
        IFinancialsRequestBuilder Financials { get; }
    
        /// <summary>
        /// Gets the GraphServicePlanner request builder.
        /// </summary>
        IPlannerRequestBuilder Planner { get; }
    
        /// <summary>
        /// Gets the GraphServicePrint request builder.
        /// </summary>
        IPrintRequestBuilder Print { get; }
    
        /// <summary>
        /// Gets the GraphServiceSecurity request builder.
        /// </summary>
        ISecurityRequestBuilder Security { get; }
    
        /// <summary>
        /// Gets the GraphServiceApp request builder.
        /// </summary>
        ICommsApplicationRequestBuilder App { get; }
    
        /// <summary>
        /// Gets the GraphServiceExternal request builder.
        /// </summary>
        IExternalRequestBuilder External { get; }
    
        /// <summary>
        /// Gets the GraphServiceAppCatalogs request builder.
        /// </summary>
        IAppCatalogsRequestBuilder AppCatalogs { get; }
    
        /// <summary>
        /// Gets the GraphServiceTeamwork request builder.
        /// </summary>
        ITeamworkRequestBuilder Teamwork { get; }
    
    }
}
