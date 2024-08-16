// <auto-generated/>
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Assignments;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Categories;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.ContentVersions;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Relationships;
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
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp
{
    /// <summary>
    /// Casts the previous resource to androidLobApp.
    /// </summary>
    public class GraphAndroidLobAppRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the assignments property of the microsoft.graph.mobileApp entity.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Assignments.AssignmentsRequestBuilder Assignments
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Assignments.AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the categories property of the microsoft.graph.mobileApp entity.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Categories.CategoriesRequestBuilder Categories
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Categories.CategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentVersions property of the microsoft.graph.mobileLobApp entity.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.ContentVersions.ContentVersionsRequestBuilder ContentVersions
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.ContentVersions.ContentVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the relationships property of the microsoft.graph.mobileApp entity.</summary>
        public Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Relationships.RelationshipsRequestBuilder Relationships
        {
            get => new Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.Relationships.RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphAndroidLobAppRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.androidLobApp{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphAndroidLobAppRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/graph.androidLobApp{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.androidLobApp
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AndroidLobApp"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.AndroidLobApp?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder.GraphAndroidLobAppRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.AndroidLobApp> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder.GraphAndroidLobAppRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.AndroidLobApp>(requestInfo, Microsoft.Graph.Beta.Models.AndroidLobApp.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.androidLobApp
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder.GraphAndroidLobAppRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder.GraphAndroidLobAppRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.mobileApp as microsoft.graph.androidLobApp
        /// </summary>
        public class GraphAndroidLobAppRequestBuilderGetQueryParameters 
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
        public class GraphAndroidLobAppRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GraphAndroidLobApp.GraphAndroidLobAppRequestBuilder.GraphAndroidLobAppRequestBuilderGetQueryParameters>
        {
        }
    }
}
