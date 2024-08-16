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
namespace Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item
{
    /// <summary>
    /// Provides operations to manage the inactiveUsersByApplication property of the microsoft.graph.monthlyUserInsightMetricsRoot entity.
    /// </summary>
    public class MonthlyInactiveUsersByApplicationMetricItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MonthlyInactiveUsersByApplicationMetricItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/userInsights/monthly/inactiveUsersByApplication/{monthlyInactiveUsersByApplicationMetric%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MonthlyInactiveUsersByApplicationMetricItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/userInsights/monthly/inactiveUsersByApplication/{monthlyInactiveUsersByApplicationMetric%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get inactiveUsersByApplication from reports
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The Inactive Users By Application Metric is deprecated and will stop returning data on February 16, 2024. Please use the existing Inactive Users API. as of 2024-02/Remove_Breakdown_APIs")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder.MonthlyInactiveUsersByApplicationMetricItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder.MonthlyInactiveUsersByApplicationMetricItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric>(requestInfo, Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get inactiveUsersByApplication from reports
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Inactive Users By Application Metric is deprecated and will stop returning data on February 16, 2024. Please use the existing Inactive Users API. as of 2024-02/Remove_Breakdown_APIs")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder.MonthlyInactiveUsersByApplicationMetricItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder.MonthlyInactiveUsersByApplicationMetricItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("The Inactive Users By Application Metric is deprecated and will stop returning data on February 16, 2024. Please use the existing Inactive Users API. as of 2024-02/Remove_Breakdown_APIs")]
        public Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get inactiveUsersByApplication from reports
        /// </summary>
        public class MonthlyInactiveUsersByApplicationMetricItemRequestBuilderGetQueryParameters 
        {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MonthlyInactiveUsersByApplicationMetricItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Reports.UserInsights.Monthly.InactiveUsersByApplication.Item.MonthlyInactiveUsersByApplicationMetricItemRequestBuilder.MonthlyInactiveUsersByApplicationMetricItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
