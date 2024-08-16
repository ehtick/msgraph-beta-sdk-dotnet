// <auto-generated/>
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Analytics;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Columns;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.ContentTypes;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.CreatedByUser;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Drive;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Drives;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.ExternalColumns;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.InformationProtection;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Items;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.LastModifiedByUser;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Lists;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Onenote;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Operations;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Pages;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Permissions;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.RecycleBin;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Sites;
using Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.TermStore;
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
namespace Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1
{
    /// <summary>
    /// Provides operations to call the getByPath method.
    /// </summary>
    public class GetByPathWithPath1RequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Analytics.AnalyticsRequestBuilder Analytics
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Analytics.AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Columns.ColumnsRequestBuilder Columns
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentTypes property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.ContentTypes.ContentTypesRequestBuilder ContentTypes
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.ContentTypes.ContentTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.CreatedByUser.CreatedByUserRequestBuilder CreatedByUser
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.CreatedByUser.CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drive property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Drive.DriveRequestBuilder Drive
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Drive.DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the drives property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Drives.DrivesRequestBuilder Drives
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Drives.DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the externalColumns property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.ExternalColumns.ExternalColumnsRequestBuilder ExternalColumns
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.ExternalColumns.ExternalColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the informationProtection property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.InformationProtection.InformationProtectionRequestBuilder InformationProtection
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.InformationProtection.InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the items property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Items.ItemsRequestBuilder Items
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Items.ItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.LastModifiedByUser.LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lists property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Lists.ListsRequestBuilder Lists
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Lists.ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onenote property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Onenote.OnenoteRequestBuilder Onenote
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Onenote.OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Operations.OperationsRequestBuilder Operations
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pages property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Pages.PagesRequestBuilder Pages
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Pages.PagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Permissions.PermissionsRequestBuilder Permissions
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Permissions.PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recycleBin property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.RecycleBin.RecycleBinRequestBuilder RecycleBin
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.RecycleBin.RecycleBinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sites property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Sites.SitesRequestBuilder Sites
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.Sites.SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termStore property of the microsoft.graph.site entity.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.TermStore.TermStoreRequestBuilder TermStore
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.TermStore.TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.GetByPathWithPath1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="path1">Usage: path=&apos;{path1}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetByPathWithPath1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string path1 = "") : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')/getByPath(path='{path1}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(path1)) PathParameters.Add("path1", path1);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.GetByPathWithPath1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetByPathWithPath1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/sites/{site%2Did}/getByPath(path='{path}')/getByPath(path='{path1}')", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function getByPath
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Site"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Site?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Site> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Site>(requestInfo, Microsoft.Graph.Beta.Models.Site.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getByPath
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.GetByPathWithPath1RequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.GetByPathWithPath1RequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Groups.Item.Sites.Item.GetByPathWithPath.GetByPathWithPath1.GetByPathWithPath1RequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetByPathWithPath1RequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
