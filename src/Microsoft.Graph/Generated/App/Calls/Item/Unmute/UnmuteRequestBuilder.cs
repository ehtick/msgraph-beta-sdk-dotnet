// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.App.Calls.Item.Unmute
{
    /// <summary>
    /// Provides operations to call the unmute method.
    /// </summary>
    public class UnmuteRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmuteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnmuteRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/calls/{call%2Did}/unmute", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmuteRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UnmuteRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/calls/{call%2Did}/unmute", rawUrl)
        {
        }
        /// <summary>
        /// Allow the application to unmute itself. This is a server unmute, meaning that the server will start sending audio packets for this participant to other participants again. For more information about how to handle unmute operations, see unmuteParticipantOperation.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/call-unmute?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnmuteParticipantOperation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.UnmuteParticipantOperation?> PostAsync(Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmutePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.UnmuteParticipantOperation> PostAsync(Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmutePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.UnmuteParticipantOperation>(requestInfo, Microsoft.Graph.Beta.Models.UnmuteParticipantOperation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Allow the application to unmute itself. This is a server unmute, meaning that the server will start sending audio packets for this participant to other participants again. For more information about how to handle unmute operations, see unmuteParticipantOperation.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmutePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmutePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmuteRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmuteRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmuteRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UnmuteRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
