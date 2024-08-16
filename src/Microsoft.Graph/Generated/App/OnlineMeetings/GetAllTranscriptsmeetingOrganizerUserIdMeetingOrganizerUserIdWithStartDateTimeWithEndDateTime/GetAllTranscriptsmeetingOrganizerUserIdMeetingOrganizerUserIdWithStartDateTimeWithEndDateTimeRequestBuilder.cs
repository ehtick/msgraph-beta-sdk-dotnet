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
namespace Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime
{
    /// <summary>
    /// Provides operations to call the getAllTranscripts method.
    /// </summary>
    public class GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/onlineMeetings/getAllTranscripts(meetingOrganizerUserId='@meetingOrganizerUserId',startDateTime=@startDateTime,endDateTime=@endDateTime){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top,endDateTime*,meetingOrganizerUserId*,startDateTime*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/onlineMeetings/getAllTranscripts(meetingOrganizerUserId='@meetingOrganizerUserId',startDateTime=@startDateTime,endDateTime=@endDateTime){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top,endDateTime*,meetingOrganizerUserId*,startDateTime*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all transcripts from scheduled onlineMeeting instances for which the specified user is the organizer. This API currently doesn&apos;t support getting call transcripts from channel meetings. You can apply the delta function on getAllTranscripts to synchronize and get callTranscript resources as they&apos;re added for onlineMeeting instances organized by the specified user. Delta query supports both full synchronization and incremental synchronization. Full synchronization gets all the transcripts for online meetings organized by the user. Incremental synchronization gets transcripts that are added since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that recording view periodically. For more information, see delta query. For more examples, see callTranscript: delta. To learn more about using the Microsoft Teams export APIs to export content, see Export content with the Microsoft Teams export APIs.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/onlinemeeting-getalltranscripts?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponse?> GetAsGetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponse> GetAsGetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponseAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponse>(requestInfo, Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all transcripts from scheduled onlineMeeting instances for which the specified user is the organizer. This API currently doesn&apos;t support getting call transcripts from channel meetings. You can apply the delta function on getAllTranscripts to synchronize and get callTranscript resources as they&apos;re added for onlineMeeting instances organized by the specified user. Delta query supports both full synchronization and incremental synchronization. Full synchronization gets all the transcripts for online meetings organized by the user. Incremental synchronization gets transcripts that are added since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that recording view periodically. For more information, see delta query. For more examples, see callTranscript: delta. To learn more about using the Microsoft Teams export APIs to export content, see Export content with the Microsoft Teams export APIs.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/onlinemeeting-getalltranscripts?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeResponse>(requestInfo, Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all transcripts from scheduled onlineMeeting instances for which the specified user is the organizer. This API currently doesn&apos;t support getting call transcripts from channel meetings. You can apply the delta function on getAllTranscripts to synchronize and get callTranscript resources as they&apos;re added for onlineMeeting instances organized by the specified user. Delta query supports both full synchronization and incremental synchronization. Full synchronization gets all the transcripts for online meetings organized by the user. Incremental synchronization gets transcripts that are added since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that recording view periodically. For more information, see delta query. For more examples, see callTranscript: delta. To learn more about using the Microsoft Teams export APIs to export content, see Export content with the Microsoft Teams export APIs.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all transcripts from scheduled onlineMeeting instances for which the specified user is the organizer. This API currently doesn&apos;t support getting call transcripts from channel meetings. You can apply the delta function on getAllTranscripts to synchronize and get callTranscript resources as they&apos;re added for onlineMeeting instances organized by the specified user. Delta query supports both full synchronization and incremental synchronization. Full synchronization gets all the transcripts for online meetings organized by the user. Incremental synchronization gets transcripts that are added since the last synchronization. Typically, you would do an initial full synchronization, and then get incremental changes to that recording view periodically. For more information, see delta query. For more examples, see callTranscript: delta. To learn more about using the Microsoft Teams export APIs to export content, see Export content with the Microsoft Teams export APIs.
        /// </summary>
        public class GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Usage: endDateTime=@endDateTime</summary>
            [QueryParameter("endDateTime")]
            public DateTimeOffset? EndDateTime { get; set; }
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
            /// <summary>Usage: meetingOrganizerUserId=&apos;@meetingOrganizerUserId&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("meetingOrganizerUserId")]
            public string? MeetingOrganizerUserId { get; set; }
#nullable restore
#else
            [QueryParameter("meetingOrganizerUserId")]
            public string MeetingOrganizerUserId { get; set; }
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
            /// <summary>Usage: startDateTime=@startDateTime</summary>
            [QueryParameter("startDateTime")]
            public DateTimeOffset? StartDateTime { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.App.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>
        {
        }
    }
}
