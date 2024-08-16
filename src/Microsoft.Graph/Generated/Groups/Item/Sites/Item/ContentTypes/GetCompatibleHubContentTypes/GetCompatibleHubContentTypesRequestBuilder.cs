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
namespace Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes
{
    /// <summary>
    /// Provides operations to call the getCompatibleHubContentTypes method.
    /// </summary>
    public class GetCompatibleHubContentTypesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetCompatibleHubContentTypesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/contentTypes/getCompatibleHubContentTypes(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetCompatibleHubContentTypesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/contentTypes/getCompatibleHubContentTypes(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get compatible content types in the content type hub that can be added to a target site or a list. This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a &apos;push everywhere&apos; to &apos;pull as needed&apos; approach. The method allows users to pull content types directly from the content type hub to a site or list. For more information, see addCopyFromContentTypeHub and the blog post Syntex Product Updates – August 2021.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contenttype-getcompatiblehubcontenttypes?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesGetResponse?> GetAsGetCompatibleHubContentTypesGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder.GetCompatibleHubContentTypesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesGetResponse> GetAsGetCompatibleHubContentTypesGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder.GetCompatibleHubContentTypesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesGetResponse>(requestInfo, Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get compatible content types in the content type hub that can be added to a target site or a list. This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a &apos;push everywhere&apos; to &apos;pull as needed&apos; approach. The method allows users to pull content types directly from the content type hub to a site or list. For more information, see addCopyFromContentTypeHub and the blog post Syntex Product Updates – August 2021.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/contenttype-getcompatiblehubcontenttypes?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetCompatibleHubContentTypesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder.GetCompatibleHubContentTypesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder.GetCompatibleHubContentTypesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse>(requestInfo, Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get compatible content types in the content type hub that can be added to a target site or a list. This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a &apos;push everywhere&apos; to &apos;pull as needed&apos; approach. The method allows users to pull content types directly from the content type hub to a site or list. For more information, see addCopyFromContentTypeHub and the blog post Syntex Product Updates – August 2021.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder.GetCompatibleHubContentTypesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder.GetCompatibleHubContentTypesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get compatible content types in the content type hub that can be added to a target site or a list. This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a &apos;push everywhere&apos; to &apos;pull as needed&apos; approach. The method allows users to pull content types directly from the content type hub to a site or list. For more information, see addCopyFromContentTypeHub and the blog post Syntex Product Updates – August 2021.
        /// </summary>
        public class GetCompatibleHubContentTypesRequestBuilderGetQueryParameters 
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
        public class GetCompatibleHubContentTypesRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Groups.Item.Sites.Item.ContentTypes.GetCompatibleHubContentTypes.GetCompatibleHubContentTypesRequestBuilder.GetCompatibleHubContentTypesRequestBuilderGetQueryParameters>
        {
        }
    }
}
