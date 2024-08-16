// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppManagementPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignedTo;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignments;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsMappingPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsPolicy;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CreatePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CreatedObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.DelegatedPermissionClassifications;
using Microsoft.Graph.Beta.ServicePrincipals.Item.DeletePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Endpoints;
using Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentialsWithName;
using Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.GetPasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.HomeRealmDiscoveryPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.LicenseDetails;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Oauth2PermissionGrants;
using Microsoft.Graph.Beta.ServicePrincipals.Item.OwnedObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Owners;
using Microsoft.Graph.Beta.ServicePrincipals.Item.PermissionGrantPreApprovalPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Restore;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TokenIssuancePolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TokenLifetimePolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf;
using Microsoft.Graph.Beta.ServicePrincipals.Item.UpdatePasswordSingleSignOnCredentials;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item
{
    /// <summary>
    /// Provides operations to manage the collection of servicePrincipal entities.
    /// </summary>
    public class ServicePrincipalItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the addTokenSigningCertificate method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificateRequestBuilder AddTokenSigningCertificate
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.AddTokenSigningCertificate.AddTokenSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appManagementPolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.AppManagementPolicies.AppManagementPoliciesRequestBuilder AppManagementPolicies
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.AppManagementPolicies.AppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignedTo property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignedTo.AppRoleAssignedToRequestBuilder AppRoleAssignedTo
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignedTo.AppRoleAssignedToRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignments property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignments.AppRoleAssignmentsRequestBuilder AppRoleAssignments
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignments.AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder CheckMemberGroups
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberGroups.CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder CheckMemberObjects
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.CheckMemberObjects.CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the claimsMappingPolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsMappingPolicies.ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsMappingPolicies.ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the claimsPolicy property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsPolicy.ClaimsPolicyRequestBuilder ClaimsPolicy
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsPolicy.ClaimsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdObjects property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.CreatedObjects.CreatedObjectsRequestBuilder CreatedObjects
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.CreatedObjects.CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createPasswordSingleSignOnCredentials method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.CreatePasswordSingleSignOnCredentials.CreatePasswordSingleSignOnCredentialsRequestBuilder CreatePasswordSingleSignOnCredentials
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.CreatePasswordSingleSignOnCredentials.CreatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the delegatedPermissionClassifications property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.DelegatedPermissionClassifications.DelegatedPermissionClassificationsRequestBuilder DelegatedPermissionClassifications
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.DelegatedPermissionClassifications.DelegatedPermissionClassificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deletePasswordSingleSignOnCredentials method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.DeletePasswordSingleSignOnCredentials.DeletePasswordSingleSignOnCredentialsRequestBuilder DeletePasswordSingleSignOnCredentials
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.DeletePasswordSingleSignOnCredentials.DeletePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the endpoints property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.Endpoints.EndpointsRequestBuilder Endpoints
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.Endpoints.EndpointsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the federatedIdentityCredentials property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentials.FederatedIdentityCredentialsRequestBuilder FederatedIdentityCredentials
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentials.FederatedIdentityCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberGroups.GetMemberGroupsRequestBuilder GetMemberGroups
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberGroups.GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberObjects.GetMemberObjectsRequestBuilder GetMemberObjects
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.GetMemberObjects.GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPasswordSingleSignOnCredentials method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.GetPasswordSingleSignOnCredentials.GetPasswordSingleSignOnCredentialsRequestBuilder GetPasswordSingleSignOnCredentials
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.GetPasswordSingleSignOnCredentials.GetPasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the homeRealmDiscoveryPolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.HomeRealmDiscoveryPolicies.HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the licenseDetails property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.LicenseDetails.LicenseDetailsRequestBuilder LicenseDetails
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.LicenseDetails.LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.MemberOfRequestBuilder MemberOf
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.Oauth2PermissionGrants.Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.Oauth2PermissionGrants.Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ownedObjects property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.OwnedObjects.OwnedObjectsRequestBuilder OwnedObjects
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.OwnedObjects.OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the owners property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.Owners.OwnersRequestBuilder Owners
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.Owners.OwnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissionGrantPreApprovalPolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.PermissionGrantPreApprovalPolicies.PermissionGrantPreApprovalPoliciesRequestBuilder PermissionGrantPreApprovalPolicies
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.PermissionGrantPreApprovalPolicies.PermissionGrantPreApprovalPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the remoteDesktopSecurityConfiguration property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.RemoteDesktopSecurityConfigurationRequestBuilder RemoteDesktopSecurityConfiguration
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.RemoteDesktopSecurityConfiguration.RemoteDesktopSecurityConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.Restore.RestoreRequestBuilder Restore
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the synchronization property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.SynchronizationRequestBuilder Synchronization
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.SynchronizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenIssuancePolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.TokenIssuancePolicies.TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenLifetimePolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TokenLifetimePolicies.TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.TokenLifetimePolicies.TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.servicePrincipal entity.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder TransitiveMemberOf
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updatePasswordSingleSignOnCredentials method.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.UpdatePasswordSingleSignOnCredentials.UpdatePasswordSingleSignOnCredentialsRequestBuilder UpdatePasswordSingleSignOnCredentials
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.UpdatePasswordSingleSignOnCredentials.UpdatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServicePrincipalItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServicePrincipalItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a servicePrincipal object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-delete?view=graph-rest-beta" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to manage the federatedIdentityCredentials property of the microsoft.graph.servicePrincipal entity.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentialsWithName.FederatedIdentityCredentialsWithNameRequestBuilder"/></returns>
        /// <param name="name">Alternate key of federatedIdentityCredential</param>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentialsWithName.FederatedIdentityCredentialsWithNameRequestBuilder FederatedIdentityCredentialsWithName(string name)
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            return new Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentialsWithName.FederatedIdentityCredentialsWithNameRequestBuilder(PathParameters, RequestAdapter, name);
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ServicePrincipal"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ServicePrincipal?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder.ServicePrincipalItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ServicePrincipal> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder.ServicePrincipalItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ServicePrincipal>(requestInfo, Microsoft.Graph.Beta.Models.ServicePrincipal.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new servicePrincipal object if it doesn&apos;t exist, or update the properties of an existing servicePrincipal object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-upsert?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ServicePrincipal"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ServicePrincipal?> PatchAsync(Microsoft.Graph.Beta.Models.ServicePrincipal body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ServicePrincipal> PatchAsync(Microsoft.Graph.Beta.Models.ServicePrincipal body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ServicePrincipal>(requestInfo, Microsoft.Graph.Beta.Models.ServicePrincipal.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a servicePrincipal object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder.ServicePrincipalItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder.ServicePrincipalItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new servicePrincipal object if it doesn&apos;t exist, or update the properties of an existing servicePrincipal object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.ServicePrincipal body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.ServicePrincipal body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ServicePrincipalItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ServicePrincipalItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.ServicePrincipalItemRequestBuilder.ServicePrincipalItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ServicePrincipalItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
