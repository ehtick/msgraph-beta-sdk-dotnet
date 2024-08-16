// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ClearFilters;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ConvertToRange;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.DataBodyRange;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.HeaderRowRange;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.RangeNamespace;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ReapplyFilters;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Sort;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.TotalRowRange;
using Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Worksheet;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item
{
    /// <summary>
    /// Provides operations to manage the tables property of the microsoft.graph.workbookWorksheet entity.
    /// </summary>
    public class WorkbookTableItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clearFilters method.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ClearFilters.ClearFiltersRequestBuilder ClearFilters
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ClearFilters.ClearFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the columns property of the microsoft.graph.workbookTable entity.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.ColumnsRequestBuilder Columns
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the convertToRange method.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ConvertToRange.ConvertToRangeRequestBuilder ConvertToRange
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ConvertToRange.ConvertToRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the dataBodyRange method.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.DataBodyRange.DataBodyRangeRequestBuilder DataBodyRange
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.DataBodyRange.DataBodyRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the headerRowRange method.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.HeaderRowRange.HeaderRowRangeRequestBuilder HeaderRowRange
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.HeaderRowRange.HeaderRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the range method.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.RangeNamespace.RangeRequestBuilder Range
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.RangeNamespace.RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reapplyFilters method.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ReapplyFilters.ReapplyFiltersRequestBuilder ReapplyFilters
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.ReapplyFilters.ReapplyFiltersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the rows property of the microsoft.graph.workbookTable entity.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.RowsRequestBuilder Rows
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Rows.RowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sort property of the microsoft.graph.workbookTable entity.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Sort.SortRequestBuilder Sort
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Sort.SortRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the totalRowRange method.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.TotalRowRange.TotalRowRangeRequestBuilder TotalRowRange
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.TotalRowRange.TotalRowRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookTable entity.</summary>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Worksheet.WorksheetRequestBuilder Worksheet
        {
            get => new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.Worksheet.WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookTableItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookTableItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/fileStorage/containers/{fileStorageContainer%2Did}/drive/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/tables/{workbookTable%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property tables for storage
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
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WorkbookTable"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WorkbookTable?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder.WorkbookTableItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WorkbookTable> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder.WorkbookTableItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WorkbookTable>(requestInfo, Microsoft.Graph.Beta.Models.WorkbookTable.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property tables in storage
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WorkbookTable"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WorkbookTable?> PatchAsync(Microsoft.Graph.Beta.Models.WorkbookTable body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WorkbookTable> PatchAsync(Microsoft.Graph.Beta.Models.WorkbookTable body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WorkbookTable>(requestInfo, Microsoft.Graph.Beta.Models.WorkbookTable.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property tables for storage
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
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder.WorkbookTableItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder.WorkbookTableItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property tables in storage
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.WorkbookTable body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.WorkbookTable body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkbookTableItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// </summary>
        public class WorkbookTableItemRequestBuilderGetQueryParameters 
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
        public class WorkbookTableItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Worksheets.Item.Tables.Item.WorkbookTableItemRequestBuilder.WorkbookTableItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkbookTableItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
