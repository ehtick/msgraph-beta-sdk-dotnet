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
namespace Microsoft.Graph.Beta.Me.CloudPCs.Item.GetShiftWorkCloudPcAccessState
{
    /// <summary>
    /// Provides operations to call the getShiftWorkCloudPcAccessState method.
    /// </summary>
    public class GetShiftWorkCloudPcAccessStateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.CloudPCs.Item.GetShiftWorkCloudPcAccessState.GetShiftWorkCloudPcAccessStateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetShiftWorkCloudPcAccessStateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/cloudPCs/{cloudPC%2Did}/getShiftWorkCloudPcAccessState()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.CloudPCs.Item.GetShiftWorkCloudPcAccessState.GetShiftWorkCloudPcAccessStateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetShiftWorkCloudPcAccessStateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/cloudPCs/{cloudPC%2Did}/getShiftWorkCloudPcAccessState()", rawUrl)
        {
        }
        /// <summary>
        /// Get the shiftWorkCloudPcAccessState of a shift work Cloud PC.  This API only supports shared-use licenses. For more information, see cloudPcProvisioningPolicy. Shared-use licenses allow three users per license, with one user signed in at a time. Callers can get the latest shift work Cloud PC accessState and determine whether the shift work Cloud PC is accessible to the user.  If a web client needs to connect to a shift work Cloud PC, the sharedCloudPcAccessState validates the bookmark scenario. If sharedCloudPcAccessState is not active/activating/standbyMode, the web client shows a &apos;bad bookmark&apos;.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-getshiftworkcloudpcaccessstate?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ShiftWorkCloudPcAccessState"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The getShiftWorkCloudPcAccessState API is deprecated and will stop returning data on Dec 31, 2023. Please use the new getFrontlineCloudPcAccessState API as of 2023-08/getShiftWorkCloudPcAccessState")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ShiftWorkCloudPcAccessState?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ShiftWorkCloudPcAccessState?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Microsoft.Graph.Beta.Models.ShiftWorkCloudPcAccessState?>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the shiftWorkCloudPcAccessState of a shift work Cloud PC.  This API only supports shared-use licenses. For more information, see cloudPcProvisioningPolicy. Shared-use licenses allow three users per license, with one user signed in at a time. Callers can get the latest shift work Cloud PC accessState and determine whether the shift work Cloud PC is accessible to the user.  If a web client needs to connect to a shift work Cloud PC, the sharedCloudPcAccessState validates the bookmark scenario. If sharedCloudPcAccessState is not active/activating/standbyMode, the web client shows a &apos;bad bookmark&apos;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The getShiftWorkCloudPcAccessState API is deprecated and will stop returning data on Dec 31, 2023. Please use the new getFrontlineCloudPcAccessState API as of 2023-08/getShiftWorkCloudPcAccessState")]
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.CloudPCs.Item.GetShiftWorkCloudPcAccessState.GetShiftWorkCloudPcAccessStateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("The getShiftWorkCloudPcAccessState API is deprecated and will stop returning data on Dec 31, 2023. Please use the new getFrontlineCloudPcAccessState API as of 2023-08/getShiftWorkCloudPcAccessState")]
        public Microsoft.Graph.Beta.Me.CloudPCs.Item.GetShiftWorkCloudPcAccessState.GetShiftWorkCloudPcAccessStateRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Me.CloudPCs.Item.GetShiftWorkCloudPcAccessState.GetShiftWorkCloudPcAccessStateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetShiftWorkCloudPcAccessStateRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
