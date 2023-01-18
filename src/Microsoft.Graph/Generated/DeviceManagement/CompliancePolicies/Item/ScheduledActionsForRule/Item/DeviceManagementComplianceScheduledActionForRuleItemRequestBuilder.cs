using Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.Item.ScheduledActionConfigurations;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.Item {
    /// <summary>
    /// Provides operations to manage the scheduledActionsForRule property of the microsoft.graph.deviceManagementCompliancePolicy entity.
    /// </summary>
    public class DeviceManagementComplianceScheduledActionForRuleItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the scheduledActionConfigurations property of the microsoft.graph.deviceManagementComplianceScheduledActionForRule entity.</summary>
        public ScheduledActionConfigurationsRequestBuilder ScheduledActionConfigurations { get =>
            new ScheduledActionConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementComplianceScheduledActionForRuleItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy%2Did}/scheduledActionsForRule/{deviceManagementComplianceScheduledActionForRule%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementComplianceScheduledActionForRuleItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy%2Did}/scheduledActionsForRule/{deviceManagementComplianceScheduledActionForRule%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property scheduledActionsForRule for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public async Task DeleteAsync(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#else
        public async Task DeleteAsync(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The list of scheduled action for this rule
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public async Task<DeviceManagementComplianceScheduledActionForRule?> GetAsync(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#else
        public async Task<DeviceManagementComplianceScheduledActionForRule> GetAsync(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceManagementComplianceScheduledActionForRule>(requestInfo, DeviceManagementComplianceScheduledActionForRule.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property scheduledActionsForRule in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public async Task<DeviceManagementComplianceScheduledActionForRule?> PatchAsync(DeviceManagementComplianceScheduledActionForRule body, Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#else
        public async Task<DeviceManagementComplianceScheduledActionForRule> PatchAsync(DeviceManagementComplianceScheduledActionForRule body, Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceManagementComplianceScheduledActionForRule>(requestInfo, DeviceManagementComplianceScheduledActionForRule.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property scheduledActionsForRule for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public RequestInformation ToDeleteRequestInformation(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#else
        public RequestInformation ToDeleteRequestInformation(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The list of scheduled action for this rule
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public RequestInformation ToGetRequestInformation(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#else
        public RequestInformation ToGetRequestInformation(Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property scheduledActionsForRule in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public RequestInformation ToPatchRequestInformation(DeviceManagementComplianceScheduledActionForRule body, Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#else
        public RequestInformation ToPatchRequestInformation(DeviceManagementComplianceScheduledActionForRule body, Action<DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The list of scheduled action for this rule
        /// </summary>
        public class DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementComplianceScheduledActionForRuleItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
