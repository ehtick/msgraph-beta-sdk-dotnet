// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes;
using Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes;
using Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes;
using Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes;
using Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Reports.ServiceActivity
{
    /// <summary>
    /// Provides operations to manage the serviceActivity property of the microsoft.graph.reportRoot entity.
    /// </summary>
    public class ServiceActivityRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServiceActivityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/serviceActivity{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServiceActivityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/serviceActivity{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property serviceActivity for reports
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Reports that relate to tenant-level authentication activities in Microsoft Entra.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ServiceActivity"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ServiceActivity?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder.ServiceActivityRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ServiceActivity> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder.ServiceActivityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ServiceActivity>(requestInfo, Microsoft.Graph.Beta.Models.ServiceActivity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the getMetricsForConditionalAccessCompliantDevicesSignInSuccess method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder"/></returns>
        /// <param name="exclusiveIntervalEndDateTime">Usage: exclusiveIntervalEndDateTime={exclusiveIntervalEndDateTime}</param>
        /// <param name="inclusiveIntervalStartDateTime">Usage: inclusiveIntervalStartDateTime={inclusiveIntervalStartDateTime}</param>
        public Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes(DateTimeOffset? exclusiveIntervalEndDateTime, DateTimeOffset? inclusiveIntervalStartDateTime)
        {
            _ = exclusiveIntervalEndDateTime ?? throw new ArgumentNullException(nameof(exclusiveIntervalEndDateTime));
            _ = inclusiveIntervalStartDateTime ?? throw new ArgumentNullException(nameof(inclusiveIntervalStartDateTime));
            return new Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForConditionalAccessCompliantDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder(PathParameters, RequestAdapter, exclusiveIntervalEndDateTime, inclusiveIntervalStartDateTime);
        }
        /// <summary>
        /// Provides operations to call the getMetricsForConditionalAccessManagedDevicesSignInSuccess method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder"/></returns>
        /// <param name="exclusiveIntervalEndDateTime">Usage: exclusiveIntervalEndDateTime={exclusiveIntervalEndDateTime}</param>
        /// <param name="inclusiveIntervalStartDateTime">Usage: inclusiveIntervalStartDateTime={inclusiveIntervalStartDateTime}</param>
        public Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes(DateTimeOffset? exclusiveIntervalEndDateTime, DateTimeOffset? inclusiveIntervalStartDateTime)
        {
            _ = exclusiveIntervalEndDateTime ?? throw new ArgumentNullException(nameof(exclusiveIntervalEndDateTime));
            _ = inclusiveIntervalStartDateTime ?? throw new ArgumentNullException(nameof(inclusiveIntervalStartDateTime));
            return new Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForConditionalAccessManagedDevicesSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder(PathParameters, RequestAdapter, exclusiveIntervalEndDateTime, inclusiveIntervalStartDateTime);
        }
        /// <summary>
        /// Provides operations to call the getMetricsForMfaSignInFailure method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder"/></returns>
        /// <param name="exclusiveIntervalEndDateTime">Usage: exclusiveIntervalEndDateTime={exclusiveIntervalEndDateTime}</param>
        /// <param name="inclusiveIntervalStartDateTime">Usage: inclusiveIntervalStartDateTime={inclusiveIntervalStartDateTime}</param>
        public Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes(DateTimeOffset? exclusiveIntervalEndDateTime, DateTimeOffset? inclusiveIntervalStartDateTime)
        {
            _ = exclusiveIntervalEndDateTime ?? throw new ArgumentNullException(nameof(exclusiveIntervalEndDateTime));
            _ = inclusiveIntervalStartDateTime ?? throw new ArgumentNullException(nameof(inclusiveIntervalStartDateTime));
            return new Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForMfaSignInFailureWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder(PathParameters, RequestAdapter, exclusiveIntervalEndDateTime, inclusiveIntervalStartDateTime);
        }
        /// <summary>
        /// Provides operations to call the getMetricsForMfaSignInSuccess method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder"/></returns>
        /// <param name="exclusiveIntervalEndDateTime">Usage: exclusiveIntervalEndDateTime={exclusiveIntervalEndDateTime}</param>
        /// <param name="inclusiveIntervalStartDateTime">Usage: inclusiveIntervalStartDateTime={inclusiveIntervalStartDateTime}</param>
        public Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes(DateTimeOffset? exclusiveIntervalEndDateTime, DateTimeOffset? inclusiveIntervalStartDateTime)
        {
            _ = exclusiveIntervalEndDateTime ?? throw new ArgumentNullException(nameof(exclusiveIntervalEndDateTime));
            _ = inclusiveIntervalStartDateTime ?? throw new ArgumentNullException(nameof(inclusiveIntervalStartDateTime));
            return new Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForMfaSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder(PathParameters, RequestAdapter, exclusiveIntervalEndDateTime, inclusiveIntervalStartDateTime);
        }
        /// <summary>
        /// Provides operations to call the getMetricsForSamlSignInSuccess method.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder"/></returns>
        /// <param name="exclusiveIntervalEndDateTime">Usage: exclusiveIntervalEndDateTime={exclusiveIntervalEndDateTime}</param>
        /// <param name="inclusiveIntervalStartDateTime">Usage: inclusiveIntervalStartDateTime={inclusiveIntervalStartDateTime}</param>
        public Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes(DateTimeOffset? exclusiveIntervalEndDateTime, DateTimeOffset? inclusiveIntervalStartDateTime)
        {
            _ = exclusiveIntervalEndDateTime ?? throw new ArgumentNullException(nameof(exclusiveIntervalEndDateTime));
            _ = inclusiveIntervalStartDateTime ?? throw new ArgumentNullException(nameof(inclusiveIntervalStartDateTime));
            return new Microsoft.Graph.Beta.Reports.ServiceActivity.GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutes.GetMetricsForSamlSignInSuccessWithInclusiveIntervalStartDateTimeWithExclusiveIntervalEndDateTimeWithAggregationIntervalInMinutesRequestBuilder(PathParameters, RequestAdapter, exclusiveIntervalEndDateTime, inclusiveIntervalStartDateTime);
        }
        /// <summary>
        /// Update the navigation property serviceActivity in reports
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ServiceActivity"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ServiceActivity?> PatchAsync(Microsoft.Graph.Beta.Models.ServiceActivity body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ServiceActivity> PatchAsync(Microsoft.Graph.Beta.Models.ServiceActivity body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ServiceActivity>(requestInfo, Microsoft.Graph.Beta.Models.ServiceActivity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property serviceActivity for reports
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Reports that relate to tenant-level authentication activities in Microsoft Entra.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder.ServiceActivityRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder.ServiceActivityRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property serviceActivity in reports
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.ServiceActivity body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.ServiceActivity body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ServiceActivityRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Reports that relate to tenant-level authentication activities in Microsoft Entra.
        /// </summary>
        public class ServiceActivityRequestBuilderGetQueryParameters 
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
        public class ServiceActivityRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Reports.ServiceActivity.ServiceActivityRequestBuilder.ServiceActivityRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ServiceActivityRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
