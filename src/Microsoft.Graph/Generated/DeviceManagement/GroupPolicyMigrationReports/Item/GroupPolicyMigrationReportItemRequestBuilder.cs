// <auto-generated/>
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicySettingMappings;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.UnsupportedGroupPolicyExtensions;
using Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.UpdateScopeTags;
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
namespace Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item
{
    /// <summary>
    /// Provides operations to manage the groupPolicyMigrationReports property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class GroupPolicyMigrationReportItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the groupPolicySettingMappings property of the microsoft.graph.groupPolicyMigrationReport entity.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicySettingMappings.GroupPolicySettingMappingsRequestBuilder GroupPolicySettingMappings
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicySettingMappings.GroupPolicySettingMappingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the unsupportedGroupPolicyExtensions property of the microsoft.graph.groupPolicyMigrationReport entity.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.UnsupportedGroupPolicyExtensions.UnsupportedGroupPolicyExtensionsRequestBuilder UnsupportedGroupPolicyExtensions
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.UnsupportedGroupPolicyExtensions.UnsupportedGroupPolicyExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateScopeTags method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.UpdateScopeTags.UpdateScopeTagsRequestBuilder UpdateScopeTags
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.UpdateScopeTags.UpdateScopeTagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupPolicyMigrationReportItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/groupPolicyMigrationReports/{groupPolicyMigrationReport%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupPolicyMigrationReportItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/groupPolicyMigrationReports/{groupPolicyMigrationReport%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property groupPolicyMigrationReports for deviceManagement
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
        /// A list of Group Policy migration reports.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder.GroupPolicyMigrationReportItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder.GroupPolicyMigrationReportItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport>(requestInfo, Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property groupPolicyMigrationReports in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport?> PatchAsync(Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport> PatchAsync(Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport>(requestInfo, Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property groupPolicyMigrationReports for deviceManagement
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
        /// A list of Group Policy migration reports.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder.GroupPolicyMigrationReportItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder.GroupPolicyMigrationReportItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property groupPolicyMigrationReports in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.GroupPolicyMigrationReport body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GroupPolicyMigrationReportItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// A list of Group Policy migration reports.
        /// </summary>
        public class GroupPolicyMigrationReportItemRequestBuilderGetQueryParameters 
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
        public class GroupPolicyMigrationReportItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.GroupPolicyMigrationReports.Item.GroupPolicyMigrationReportItemRequestBuilder.GroupPolicyMigrationReportItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GroupPolicyMigrationReportItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
