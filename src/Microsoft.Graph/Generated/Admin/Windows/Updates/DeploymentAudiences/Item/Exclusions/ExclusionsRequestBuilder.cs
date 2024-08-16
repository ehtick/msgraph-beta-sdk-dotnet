// <auto-generated/>
using Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.Count;
using Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.Item;
using Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesEnrollAssets;
using Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesEnrollAssetsById;
using Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesUnenrollAssets;
using Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesUnenrollAssetsById;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions
{
    /// <summary>
    /// Provides operations to manage the exclusions property of the microsoft.graph.windowsUpdates.deploymentAudience entity.
    /// </summary>
    public class ExclusionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enrollAssets method.</summary>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesEnrollAssets.MicrosoftGraphWindowsUpdatesEnrollAssetsRequestBuilder MicrosoftGraphWindowsUpdatesEnrollAssets
        {
            get => new Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesEnrollAssets.MicrosoftGraphWindowsUpdatesEnrollAssetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enrollAssetsById method.</summary>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesEnrollAssetsById.MicrosoftGraphWindowsUpdatesEnrollAssetsByIdRequestBuilder MicrosoftGraphWindowsUpdatesEnrollAssetsById
        {
            get => new Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesEnrollAssetsById.MicrosoftGraphWindowsUpdatesEnrollAssetsByIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unenrollAssets method.</summary>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesUnenrollAssets.MicrosoftGraphWindowsUpdatesUnenrollAssetsRequestBuilder MicrosoftGraphWindowsUpdatesUnenrollAssets
        {
            get => new Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesUnenrollAssets.MicrosoftGraphWindowsUpdatesUnenrollAssetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unenrollAssetsById method.</summary>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesUnenrollAssetsById.MicrosoftGraphWindowsUpdatesUnenrollAssetsByIdRequestBuilder MicrosoftGraphWindowsUpdatesUnenrollAssetsById
        {
            get => new Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.MicrosoftGraphWindowsUpdatesUnenrollAssetsById.MicrosoftGraphWindowsUpdatesUnenrollAssetsByIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exclusions property of the microsoft.graph.windowsUpdates.deploymentAudience entity.</summary>
        /// <param name="position">The unique identifier of updatableAsset</param>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.Item.UpdatableAssetItemRequestBuilder"/></returns>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.Item.UpdatableAssetItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("updatableAsset%2Did", position);
                return new Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.Item.UpdatableAssetItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExclusionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/deploymentAudiences/{deploymentAudience%2Did}/exclusions{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExclusionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/deploymentAudiences/{deploymentAudience%2Did}/exclusions{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List the updatableAsset resources that are excluded from a deploymentAudience.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/windowsupdates-deploymentaudience-list-exclusions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder.ExclusionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder.ExclusionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetCollectionResponse>(requestInfo, Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to exclusions for admin
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset?> PostAsync(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset> PostAsync(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>(requestInfo, Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the updatableAsset resources that are excluded from a deploymentAudience.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder.ExclusionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder.ExclusionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to exclusions for admin
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List the updatableAsset resources that are excluded from a deploymentAudience.
        /// </summary>
        public class ExclusionsRequestBuilderGetQueryParameters 
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
        public class ExclusionsRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Admin.Windows.Updates.DeploymentAudiences.Item.Exclusions.ExclusionsRequestBuilder.ExclusionsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ExclusionsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
