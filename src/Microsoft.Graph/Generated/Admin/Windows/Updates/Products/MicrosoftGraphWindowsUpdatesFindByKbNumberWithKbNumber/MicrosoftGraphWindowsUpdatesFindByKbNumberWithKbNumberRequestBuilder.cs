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
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber
{
    /// <summary>
    /// Provides operations to call the findByKbNumber method.
    /// </summary>
    public class MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="kbNumber">Usage: kbNumber={kbNumber}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, int? kbNumber = default) : base(requestAdapter, "{+baseurl}/admin/windows/updates/products/microsoft.graph.windowsUpdates.findByKbNumber(kbNumber={kbNumber}){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
            if (kbNumber != null) PathParameters.Add("kbNumber", kbNumber);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/products/microsoft.graph.windowsUpdates.findByKbNumber(kbNumber={kbNumber}){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function findByKbNumber
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberGetResponse?> GetAsFindByKbNumberWithKbNumberGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberGetResponse> GetAsFindByKbNumberWithKbNumberGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberGetResponse>(requestInfo, Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function findByKbNumber
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsFindByKbNumberWithKbNumberGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberResponse>(requestInfo, Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.FindByKbNumberWithKbNumberResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function findByKbNumber
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Invoke function findByKbNumber
        /// </summary>
        public class MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters 
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
        public class MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.Products.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumber.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilder.MicrosoftGraphWindowsUpdatesFindByKbNumberWithKbNumberRequestBuilderGetQueryParameters>
        {
        }
    }
}
