// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.Count;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.FilterByCurrentUserWithOn;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests
{
    /// <summary>
    /// Provides operations to manage the roleEligibilityScheduleRequests property of the microsoft.graph.rbacApplication entity.
    /// </summary>
    public class RoleEligibilityScheduleRequestsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        /// <param name="position">The unique identifier of unifiedRoleEligibilityScheduleRequest</param>
        /// <returns>A <see cref="Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.Item.UnifiedRoleEligibilityScheduleRequestItemRequestBuilder"/></returns>
        public Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.Item.UnifiedRoleEligibilityScheduleRequestItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("unifiedRoleEligibilityScheduleRequest%2Did", position);
                return new Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.Item.UnifiedRoleEligibilityScheduleRequestItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoleEligibilityScheduleRequestsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/directory/roleEligibilityScheduleRequests{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoleEligibilityScheduleRequestsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/directory/roleEligibilityScheduleRequests{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the filterByCurrentUser method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder"/></returns>
        /// <param name="on">Usage: on=&apos;{on}&apos;</param>
        public Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder FilterByCurrentUserWithOn(string on)
        {
            if(string.IsNullOrEmpty(on)) throw new ArgumentNullException(nameof(on));
            return new Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.FilterByCurrentUserWithOn.FilterByCurrentUserWithOnRequestBuilder(PathParameters, RequestAdapter, on);
        }
        /// <summary>
        /// Get a list of the unifiedRoleEligibilityScheduleRequest objects and their properties.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/rbacapplication-list-roleeligibilityschedulerequests?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequestCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequestCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder.RoleEligibilityScheduleRequestsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequestCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder.RoleEligibilityScheduleRequestsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequestCollectionResponse>(requestInfo, Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequestCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new unifiedRoleEligibilityScheduleRequest object. This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/rbacapplication-post-roleeligibilityschedulerequests?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest?> PostAsync(Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest> PostAsync(Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest>(requestInfo, Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of the unifiedRoleEligibilityScheduleRequest objects and their properties.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder.RoleEligibilityScheduleRequestsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder.RoleEligibilityScheduleRequestsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new unifiedRoleEligibilityScheduleRequest object. This operation allows both admins and eligible users to add, revoke, or extend eligible assignments.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.UnifiedRoleEligibilityScheduleRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a list of the unifiedRoleEligibilityScheduleRequest objects and their properties.
        /// </summary>
        public class RoleEligibilityScheduleRequestsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RoleEligibilityScheduleRequestsRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder.RoleEligibilityScheduleRequestsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RoleEligibilityScheduleRequestsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
