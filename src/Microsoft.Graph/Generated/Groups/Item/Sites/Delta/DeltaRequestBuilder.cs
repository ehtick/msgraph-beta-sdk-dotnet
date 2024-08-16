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
namespace Microsoft.Graph.Beta.Groups.Item.Sites.Delta
{
    /// <summary>
    /// Provides operations to call the delta method.
    /// </summary>
    public class DeltaRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeltaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/delta(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeltaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/delta(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get a set of newly created, updated, or deleted sites without having to perform a full read of the entire sites collection. A delta function call for sites is similar to a GET request, except that by appropriately applying state tokens in one or more of these calls, you can query for incremental changes in the sites. It allows you to maintain and synchronize a local store of a user&apos;s sites without having to fetch all the sites from the server every time.The application calls the API without specifying any parameters.The service begins enumerating sites and returns pages of changes to these sites, accompanied by either an @odata.nextLink or an @odata.deltaLink.Your application should continue making calls using the @odata.nextLink until there&apos;s an @odata.deltaLink  in the response. After you receive all the changes, you can apply them to your local state.To monitor future changes, call the delta API by using the @odata.deltaLink in the previous response. Any resources marked as deleted should be removed from your local state.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-delta?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaGetResponse?> GetAsDeltaGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaGetResponse> GetAsDeltaGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaGetResponse>(requestInfo, Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a set of newly created, updated, or deleted sites without having to perform a full read of the entire sites collection. A delta function call for sites is similar to a GET request, except that by appropriately applying state tokens in one or more of these calls, you can query for incremental changes in the sites. It allows you to maintain and synchronize a local store of a user&apos;s sites without having to fetch all the sites from the server every time.The application calls the API without specifying any parameters.The service begins enumerating sites and returns pages of changes to these sites, accompanied by either an @odata.nextLink or an @odata.deltaLink.Your application should continue making calls using the @odata.nextLink until there&apos;s an @odata.deltaLink  in the response. After you receive all the changes, you can apply them to your local state.To monitor future changes, call the delta API by using the @odata.deltaLink in the previous response. Any resources marked as deleted should be removed from your local state.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/site-delta?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDeltaGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaResponse>(requestInfo, Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a set of newly created, updated, or deleted sites without having to perform a full read of the entire sites collection. A delta function call for sites is similar to a GET request, except that by appropriately applying state tokens in one or more of these calls, you can query for incremental changes in the sites. It allows you to maintain and synchronize a local store of a user&apos;s sites without having to fetch all the sites from the server every time.The application calls the API without specifying any parameters.The service begins enumerating sites and returns pages of changes to these sites, accompanied by either an @odata.nextLink or an @odata.deltaLink.Your application should continue making calls using the @odata.nextLink until there&apos;s an @odata.deltaLink  in the response. After you receive all the changes, you can apply them to your local state.To monitor future changes, call the delta API by using the @odata.deltaLink in the previous response. Any resources marked as deleted should be removed from your local state.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a set of newly created, updated, or deleted sites without having to perform a full read of the entire sites collection. A delta function call for sites is similar to a GET request, except that by appropriately applying state tokens in one or more of these calls, you can query for incremental changes in the sites. It allows you to maintain and synchronize a local store of a user&apos;s sites without having to fetch all the sites from the server every time.The application calls the API without specifying any parameters.The service begins enumerating sites and returns pages of changes to these sites, accompanied by either an @odata.nextLink or an @odata.deltaLink.Your application should continue making calls using the @odata.nextLink until there&apos;s an @odata.deltaLink  in the response. After you receive all the changes, you can apply them to your local state.To monitor future changes, call the delta API by using the @odata.deltaLink in the previous response. Any resources marked as deleted should be removed from your local state.
        /// </summary>
        public class DeltaRequestBuilderGetQueryParameters 
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
        public class DeltaRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>
        {
        }
    }
}
