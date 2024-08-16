// <auto-generated/>
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
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc
{
    /// <summary>
    /// Provides operations to call the bulkRestoreCloudPc method.
    /// </summary>
    public class BulkRestoreCloudPcRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRestoreCloudPcRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices/bulkRestoreCloudPc", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRestoreCloudPcRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices/bulkRestoreCloudPc", rawUrl)
        {
        }
        /// <summary>
        /// Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/manageddevice-bulkrestorecloudpc?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The bulkRestoreCloudPc action is deprecated and will stop supporting on September 24, 2023. Please use bulk action entity api. as of 2023-05/bulkRestoreCloudPc")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult?> PostAsync(Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult> PostAsync(Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult>(requestInfo, Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The bulkRestoreCloudPc action is deprecated and will stop supporting on September 24, 2023. Please use bulk action entity api. as of 2023-05/bulkRestoreCloudPc")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("The bulkRestoreCloudPc action is deprecated and will stop supporting on September 24, 2023. Please use bulk action entity api. as of 2023-05/bulkRestoreCloudPc")]
        public Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc.BulkRestoreCloudPcRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class BulkRestoreCloudPcRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
