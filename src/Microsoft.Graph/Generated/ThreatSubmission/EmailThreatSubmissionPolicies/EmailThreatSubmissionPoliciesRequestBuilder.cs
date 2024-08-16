// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.Count;
using Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies
{
    /// <summary>
    /// Provides operations to manage the emailThreatSubmissionPolicies property of the microsoft.graph.security.threatSubmissionRoot entity.
    /// </summary>
    public class EmailThreatSubmissionPoliciesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the emailThreatSubmissionPolicies property of the microsoft.graph.security.threatSubmissionRoot entity.</summary>
        /// <param name="position">The unique identifier of emailThreatSubmissionPolicy</param>
        /// <returns>A <see cref="Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.Item.EmailThreatSubmissionPolicyItemRequestBuilder"/></returns>
        public Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.Item.EmailThreatSubmissionPolicyItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("emailThreatSubmissionPolicy%2Did", position);
                return new Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.Item.EmailThreatSubmissionPolicyItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailThreatSubmissionPoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/threatSubmission/emailThreatSubmissionPolicies{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmailThreatSubmissionPoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/threatSubmission/emailThreatSubmissionPolicies{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get emailThreatSubmissionPolicies from threatSubmission
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicyCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicyCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder.EmailThreatSubmissionPoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicyCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder.EmailThreatSubmissionPoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicyCollectionResponse>(requestInfo, Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicyCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to emailThreatSubmissionPolicies for threatSubmission
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy?> PostAsync(Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy> PostAsync(Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy>(requestInfo, Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get emailThreatSubmissionPolicies from threatSubmission
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder.EmailThreatSubmissionPoliciesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder.EmailThreatSubmissionPoliciesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to emailThreatSubmissionPolicies for threatSubmission
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.Security.EmailThreatSubmissionPolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get emailThreatSubmissionPolicies from threatSubmission
        /// </summary>
        public class EmailThreatSubmissionPoliciesRequestBuilderGetQueryParameters 
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
        public class EmailThreatSubmissionPoliciesRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.ThreatSubmission.EmailThreatSubmissionPolicies.EmailThreatSubmissionPoliciesRequestBuilder.EmailThreatSubmissionPoliciesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EmailThreatSubmissionPoliciesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
