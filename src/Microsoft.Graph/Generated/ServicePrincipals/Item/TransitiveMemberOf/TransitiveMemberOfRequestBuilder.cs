// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.Count;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphAdministrativeUnit;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphDirectoryRole;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphGroup;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf
{
    /// <summary>
    /// Provides operations to manage the transitiveMemberOf property of the microsoft.graph.servicePrincipal entity.
    /// </summary>
    public class TransitiveMemberOfRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to administrativeUnit.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphAdministrativeUnit.GraphAdministrativeUnitRequestBuilder GraphAdministrativeUnit
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphAdministrativeUnit.GraphAdministrativeUnitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to directoryRole.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphDirectoryRole.GraphDirectoryRoleRequestBuilder GraphDirectoryRole
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphDirectoryRole.GraphDirectoryRoleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphGroup.GraphGroupRequestBuilder GraphGroup
        {
            get => new Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.GraphGroup.GraphGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.servicePrincipal entity.</summary>
        /// <param name="position">The unique identifier of directoryObject</param>
        /// <returns>A <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder"/></returns>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("directoryObject%2Did", position);
                return new Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitiveMemberOfRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/transitiveMemberOf{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitiveMemberOfRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/transitiveMemberOf{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get the groups and directory roles that this servicePrincipal is a member of. This operation is transitive and will include all groups that this service principal is a nested member of.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/serviceprincipal-list-transitivememberof?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder.TransitiveMemberOfRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder.TransitiveMemberOfRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse>(requestInfo, Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the groups and directory roles that this servicePrincipal is a member of. This operation is transitive and will include all groups that this service principal is a nested member of.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder.TransitiveMemberOfRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder.TransitiveMemberOfRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the groups and directory roles that this servicePrincipal is a member of. This operation is transitive and will include all groups that this service principal is a nested member of.
        /// </summary>
        public class TransitiveMemberOfRequestBuilderGetQueryParameters 
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
        public class TransitiveMemberOfRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf.TransitiveMemberOfRequestBuilder.TransitiveMemberOfRequestBuilderGetQueryParameters>
        {
        }
    }
}
