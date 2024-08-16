// <auto-generated/>
using Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Assign;
using Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Assignments;
using Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule;
using Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.SetScheduledActions;
using Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Settings;
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
namespace Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item
{
    /// <summary>
    /// Provides operations to manage the compliancePolicies property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class DeviceManagementCompliancePolicyItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the assign method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Assign.AssignRequestBuilder Assign
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Assign.AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.deviceManagementCompliancePolicy entity.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Assignments.AssignmentsRequestBuilder Assignments
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Assignments.AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the scheduledActionsForRule property of the microsoft.graph.deviceManagementCompliancePolicy entity.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.ScheduledActionsForRuleRequestBuilder ScheduledActionsForRule
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.ScheduledActionsForRule.ScheduledActionsForRuleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setScheduledActions method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.SetScheduledActions.SetScheduledActionsRequestBuilder SetScheduledActions
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.SetScheduledActions.SetScheduledActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.deviceManagementCompliancePolicy entity.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementCompliancePolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementCompliancePolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property compliancePolicies for deviceManagement
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
        /// List of all compliance policies
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder.DeviceManagementCompliancePolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder.DeviceManagementCompliancePolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy>(requestInfo, Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property compliancePolicies in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy?> PatchAsync(Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy> PatchAsync(Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy>(requestInfo, Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property compliancePolicies for deviceManagement
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
        /// List of all compliance policies
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder.DeviceManagementCompliancePolicyItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder.DeviceManagementCompliancePolicyItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property compliancePolicies in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.DeviceManagementCompliancePolicy body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DeviceManagementCompliancePolicyItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// List of all compliance policies
        /// </summary>
        public class DeviceManagementCompliancePolicyItemRequestBuilderGetQueryParameters 
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
        public class DeviceManagementCompliancePolicyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.CompliancePolicies.Item.DeviceManagementCompliancePolicyItemRequestBuilder.DeviceManagementCompliancePolicyItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DeviceManagementCompliancePolicyItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
