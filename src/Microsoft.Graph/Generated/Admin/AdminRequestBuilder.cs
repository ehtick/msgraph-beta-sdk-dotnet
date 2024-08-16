// <auto-generated/>
using Microsoft.Graph.Beta.Admin.AppsAndServices;
using Microsoft.Graph.Beta.Admin.Dynamics;
using Microsoft.Graph.Beta.Admin.Edge;
using Microsoft.Graph.Beta.Admin.Forms;
using Microsoft.Graph.Beta.Admin.Microsoft365Apps;
using Microsoft.Graph.Beta.Admin.People;
using Microsoft.Graph.Beta.Admin.ReportSettings;
using Microsoft.Graph.Beta.Admin.ServiceAnnouncement;
using Microsoft.Graph.Beta.Admin.Sharepoint;
using Microsoft.Graph.Beta.Admin.Todo;
using Microsoft.Graph.Beta.Admin.Windows;
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
namespace Microsoft.Graph.Beta.Admin
{
    /// <summary>
    /// Provides operations to manage the admin singleton.
    /// </summary>
    public class AdminRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the appsAndServices property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.AppsAndServices.AppsAndServicesRequestBuilder AppsAndServices
        {
            get => new Microsoft.Graph.Beta.Admin.AppsAndServices.AppsAndServicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dynamics property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.Dynamics.DynamicsRequestBuilder Dynamics
        {
            get => new Microsoft.Graph.Beta.Admin.Dynamics.DynamicsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the edge property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.Edge.EdgeRequestBuilder Edge
        {
            get => new Microsoft.Graph.Beta.Admin.Edge.EdgeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the forms property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.Forms.FormsRequestBuilder Forms
        {
            get => new Microsoft.Graph.Beta.Admin.Forms.FormsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the microsoft365Apps property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.Microsoft365Apps.Microsoft365AppsRequestBuilder Microsoft365Apps
        {
            get => new Microsoft.Graph.Beta.Admin.Microsoft365Apps.Microsoft365AppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the people property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.People.PeopleRequestBuilder People
        {
            get => new Microsoft.Graph.Beta.Admin.People.PeopleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reportSettings property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.ReportSettings.ReportSettingsRequestBuilder ReportSettings
        {
            get => new Microsoft.Graph.Beta.Admin.ReportSettings.ReportSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the serviceAnnouncement property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.ServiceAnnouncement.ServiceAnnouncementRequestBuilder ServiceAnnouncement
        {
            get => new Microsoft.Graph.Beta.Admin.ServiceAnnouncement.ServiceAnnouncementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharepoint property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.Sharepoint.SharepointRequestBuilder Sharepoint
        {
            get => new Microsoft.Graph.Beta.Admin.Sharepoint.SharepointRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the todo property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.Todo.TodoRequestBuilder Todo
        {
            get => new Microsoft.Graph.Beta.Admin.Todo.TodoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windows property of the microsoft.graph.admin entity.</summary>
        public Microsoft.Graph.Beta.Admin.Windows.WindowsRequestBuilder Windows
        {
            get => new Microsoft.Graph.Beta.Admin.Windows.WindowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Admin.AdminRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdminRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Admin.AdminRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdminRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get admin
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Admin"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Admin?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.AdminRequestBuilder.AdminRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Admin> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.AdminRequestBuilder.AdminRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Admin>(requestInfo, Microsoft.Graph.Beta.Models.Admin.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update admin
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Admin"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Admin?> PatchAsync(Microsoft.Graph.Beta.Models.Admin body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Admin> PatchAsync(Microsoft.Graph.Beta.Models.Admin body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Admin>(requestInfo, Microsoft.Graph.Beta.Models.Admin.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get admin
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.AdminRequestBuilder.AdminRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Admin.AdminRequestBuilder.AdminRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update admin
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Admin body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Admin body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Admin.AdminRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Admin.AdminRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Admin.AdminRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get admin
        /// </summary>
        public class AdminRequestBuilderGetQueryParameters 
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
        public class AdminRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Admin.AdminRequestBuilder.AdminRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AdminRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
