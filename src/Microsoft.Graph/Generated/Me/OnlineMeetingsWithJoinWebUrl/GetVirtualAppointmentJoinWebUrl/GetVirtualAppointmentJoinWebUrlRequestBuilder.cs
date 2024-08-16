// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl
{
    /// <summary>
    /// Provides operations to call the getVirtualAppointmentJoinWebUrl method.
    /// </summary>
    public class GetVirtualAppointmentJoinWebUrlRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetVirtualAppointmentJoinWebUrlRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/onlineMeetings(joinWebUrl='{joinWebUrl}')/getVirtualAppointmentJoinWebUrl()", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetVirtualAppointmentJoinWebUrlRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/onlineMeetings(joinWebUrl='{joinWebUrl}')/getVirtualAppointmentJoinWebUrl()", rawUrl)
        {
        }
        /// <summary>
        /// Get a join web URL for a Teams Virtual Appointment. This web URL includes enhanced business-to-customer experiences such as mobile browser join and virtual lobby rooms. With Teams Premium, you can configure a custom lobby room experience for attendees by adding your company logo and access the Virtual Appointments usage report for organizational analytics.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/virtualappointment-getvirtualappointmentjoinweburl?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlGetResponse?> GetAsGetVirtualAppointmentJoinWebUrlGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlGetResponse> GetAsGetVirtualAppointmentJoinWebUrlGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlGetResponse>(requestInfo, Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a join web URL for a Teams Virtual Appointment. This web URL includes enhanced business-to-customer experiences such as mobile browser join and virtual lobby rooms. With Teams Premium, you can configure a custom lobby room experience for attendees by adding your company logo and access the Virtual Appointments usage report for organizational analytics.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/virtualappointment-getvirtualappointmentjoinweburl?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetVirtualAppointmentJoinWebUrlGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlResponse>(requestInfo, Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a join web URL for a Teams Virtual Appointment. This web URL includes enhanced business-to-customer experiences such as mobile browser join and virtual lobby rooms. With Teams Premium, you can configure a custom lobby room experience for attendees by adding your company logo and access the Virtual Appointments usage report for organizational analytics.
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Me.OnlineMeetingsWithJoinWebUrl.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetVirtualAppointmentJoinWebUrlRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
