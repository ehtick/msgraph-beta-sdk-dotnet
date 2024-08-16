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
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks
{
    /// <summary>
    /// Provides operations to call the hasPayloadLinks method.
    /// </summary>
    public class HasPayloadLinksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HasPayloadLinksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/deviceConfigurations/hasPayloadLinks", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HasPayloadLinksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/deviceConfigurations/hasPayloadLinks", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action hasPayloadLinks
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostResponse?> PostAsHasPayloadLinksPostResponseAsync(Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostResponse> PostAsHasPayloadLinksPostResponseAsync(Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostResponse>(requestInfo, Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke action hasPayloadLinks
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsHasPayloadLinksPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksResponse?> PostAsync(Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksResponse> PostAsync(Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksResponse>(requestInfo, Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke action hasPayloadLinks
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.HasPayloadLinks.HasPayloadLinksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class HasPayloadLinksRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
