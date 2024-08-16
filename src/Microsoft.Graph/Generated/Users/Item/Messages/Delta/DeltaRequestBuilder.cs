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
namespace Microsoft.Graph.Beta.Users.Item.Messages.Delta
{
    /// <summary>
    /// Provides operations to call the delta method.
    /// </summary>
    public class DeltaRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeltaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/messages/delta(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top,changeType*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeltaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/messages/delta(){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top,changeType*}", rawUrl)
        {
        }
        /// <summary>
        /// Get a set of messages that have been added, deleted, or updated in a specified folder. A delta function call for messages in a folder is similar to a GET request, except that by appropriatelyapplying state tokens in one or more of these calls, you can [query for incremental changes in the messages inthat folder](/graph/delta-query-messages). This allows you to maintain and synchronize a local store of a user&apos;s messages withouthaving to fetch the entire set of messages from the server every time.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/message-delta?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaGetResponse?> GetAsDeltaGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaGetResponse> GetAsDeltaGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaGetResponse>(requestInfo, Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a set of messages that have been added, deleted, or updated in a specified folder. A delta function call for messages in a folder is similar to a GET request, except that by appropriatelyapplying state tokens in one or more of these calls, you can [query for incremental changes in the messages inthat folder](/graph/delta-query-messages). This allows you to maintain and synchronize a local store of a user&apos;s messages withouthaving to fetch the entire set of messages from the server every time.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/message-delta?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDeltaGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaResponse>(requestInfo, Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a set of messages that have been added, deleted, or updated in a specified folder. A delta function call for messages in a folder is similar to a GET request, except that by appropriatelyapplying state tokens in one or more of these calls, you can [query for incremental changes in the messages inthat folder](/graph/delta-query-messages). This allows you to maintain and synchronize a local store of a user&apos;s messages withouthaving to fetch the entire set of messages from the server every time.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a set of messages that have been added, deleted, or updated in a specified folder. A delta function call for messages in a folder is similar to a GET request, except that by appropriatelyapplying state tokens in one or more of these calls, you can [query for incremental changes in the messages inthat folder](/graph/delta-query-messages). This allows you to maintain and synchronize a local store of a user&apos;s messages withouthaving to fetch the entire set of messages from the server every time.
        /// </summary>
        public class DeltaRequestBuilderGetQueryParameters 
        {
            /// <summary>A custom query option to filter the delta response based on the type of change. Supported values are created, updated or deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("changeType")]
            public string? ChangeType { get; set; }
#nullable restore
#else
            [QueryParameter("changeType")]
            public string ChangeType { get; set; }
#endif
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
        public class DeltaRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Users.Item.Messages.Delta.DeltaRequestBuilder.DeltaRequestBuilderGetQueryParameters>
        {
        }
    }
}
