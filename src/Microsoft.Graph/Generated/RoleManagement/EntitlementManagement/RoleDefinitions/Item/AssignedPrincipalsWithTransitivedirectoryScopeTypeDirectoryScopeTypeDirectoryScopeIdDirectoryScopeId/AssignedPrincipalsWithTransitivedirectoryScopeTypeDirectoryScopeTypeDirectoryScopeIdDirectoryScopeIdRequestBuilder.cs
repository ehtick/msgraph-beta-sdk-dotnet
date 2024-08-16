// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId
{
    /// <summary>
    /// Provides operations to call the assignedPrincipals method.
    /// </summary>
    public class AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/entitlementManagement/roleDefinitions/{unifiedRoleDefinition%2Did}/assignedPrincipals(transitive=@transitive,directoryScopeType='@directoryScopeType',directoryScopeId='@directoryScopeId'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top,directoryScopeId*,directoryScopeType*,transitive*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/entitlementManagement/roleDefinitions/{unifiedRoleDefinition%2Did}/assignedPrincipals(transitive=@transitive,directoryScopeType='@directoryScopeType',directoryScopeId='@directoryScopeId'){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top,directoryScopeId*,directoryScopeType*,transitive*}", rawUrl)
        {
        }
        /// <summary>
        /// Get the list of security principals (users, groups, and service principals) that are assigned to a specific role for different scopes either directly or transitively. You can use the $count query parameter to also get the count. This API is supported for the directory (Microsoft Entra ID) provider only. To list the direct and transitive role assignments for a specific principal, use the List transitiveRoleAssignments API.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/unifiedroledefinition-assignedprincipals?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponse?> GetAsAssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponse> GetAsAssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponse>(requestInfo, Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the list of security principals (users, groups, and service principals) that are assigned to a specific role for different scopes either directly or transitively. You can use the $count query parameter to also get the count. This API is supported for the directory (Microsoft Entra ID) provider only. To list the direct and transitive role assignments for a specific principal, use the List transitiveRoleAssignments API.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/unifiedroledefinition-assignedprincipals?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsAssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdResponse>(requestInfo, Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the list of security principals (users, groups, and service principals) that are assigned to a specific role for different scopes either directly or transitively. You can use the $count query parameter to also get the count. This API is supported for the directory (Microsoft Entra ID) provider only. To list the direct and transitive role assignments for a specific principal, use the List transitiveRoleAssignments API.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the list of security principals (users, groups, and service principals) that are assigned to a specific role for different scopes either directly or transitively. You can use the $count query parameter to also get the count. This API is supported for the directory (Microsoft Entra ID) provider only. To list the direct and transitive role assignments for a specific principal, use the List transitiveRoleAssignments API.
        /// </summary>
        public class AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Usage: directoryScopeId=&apos;@directoryScopeId&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("directoryScopeId")]
            public string? DirectoryScopeId { get; set; }
#nullable restore
#else
            [QueryParameter("directoryScopeId")]
            public string DirectoryScopeId { get; set; }
#endif
            /// <summary>Usage: directoryScopeType=&apos;@directoryScopeType&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("directoryScopeType")]
            public string? DirectoryScopeType { get; set; }
#nullable restore
#else
            [QueryParameter("directoryScopeType")]
            public string DirectoryScopeType { get; set; }
#endif
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
            /// <summary>Usage: transitive=@transitive</summary>
            [QueryParameter("transitive")]
            public bool? Transitive { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions.Item.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeId.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilder.AssignedPrincipalsWithTransitivedirectoryScopeTypeDirectoryScopeTypeDirectoryScopeIdDirectoryScopeIdRequestBuilderGetQueryParameters>
        {
        }
    }
}
