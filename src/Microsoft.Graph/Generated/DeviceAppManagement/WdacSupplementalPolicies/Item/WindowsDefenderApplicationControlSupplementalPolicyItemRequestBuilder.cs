// <auto-generated/>
using Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.Assign;
using Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.Assignments;
using Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.DeploySummary;
using Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.DeviceStatuses;
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
namespace Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item
{
    /// <summary>
    /// Provides operations to manage the wdacSupplementalPolicies property of the microsoft.graph.deviceAppManagement entity.
    /// </summary>
    public class WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the assign method.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.Assign.AssignRequestBuilder Assign
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.Assign.AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.windowsDefenderApplicationControlSupplementalPolicy entity.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.Assignments.AssignmentsRequestBuilder Assignments
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.Assignments.AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deploySummary property of the microsoft.graph.windowsDefenderApplicationControlSupplementalPolicy entity.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.DeploySummary.DeploySummaryRequestBuilder DeploySummary
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.DeploySummary.DeploySummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceStatuses property of the microsoft.graph.windowsDefenderApplicationControlSupplementalPolicy entity.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.DeviceStatuses.DeviceStatusesRequestBuilder DeviceStatuses
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.DeviceStatuses.DeviceStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/wdacSupplementalPolicies/{windowsDefenderApplicationControlSupplementalPolicy%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/wdacSupplementalPolicies/{windowsDefenderApplicationControlSupplementalPolicy%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property wdacSupplementalPolicies for deviceAppManagement
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
        /// The collection of Windows Defender Application Control Supplemental Policies.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy>(requestInfo, Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property wdacSupplementalPolicies in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy?> PatchAsync(Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy> PatchAsync(Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy>(requestInfo, Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property wdacSupplementalPolicies for deviceAppManagement
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
        /// The collection of Windows Defender Application Control Supplemental Policies.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property wdacSupplementalPolicies in deviceAppManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The collection of Windows Defender Application Control Supplemental Policies.
        /// </summary>
        public class WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderGetQueryParameters 
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
        public class WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.WdacSupplementalPolicies.Item.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilder.WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WindowsDefenderApplicationControlSupplementalPolicyItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
