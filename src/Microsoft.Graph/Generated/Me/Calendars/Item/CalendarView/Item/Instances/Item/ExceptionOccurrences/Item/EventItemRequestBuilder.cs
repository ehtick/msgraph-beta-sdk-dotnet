// <auto-generated/>
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Accept;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Attachments;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Calendar;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Cancel;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Decline;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.DismissReminder;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Extensions;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Forward;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.SnoozeReminder;
using Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.TentativelyAccept;
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
namespace Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item
{
    /// <summary>
    /// Provides operations to manage the exceptionOccurrences property of the microsoft.graph.event entity.
    /// </summary>
    public class EventItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the accept method.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Accept.AcceptRequestBuilder Accept
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Accept.AcceptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attachments property of the microsoft.graph.event entity.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Attachments.AttachmentsRequestBuilder Attachments
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Attachments.AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the calendar property of the microsoft.graph.event entity.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Calendar.CalendarRequestBuilder Calendar
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Calendar.CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancel method.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Cancel.CancelRequestBuilder Cancel
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Cancel.CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the decline method.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Decline.DeclineRequestBuilder Decline
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Decline.DeclineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the dismissReminder method.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.DismissReminder.DismissReminderRequestBuilder DismissReminder
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.DismissReminder.DismissReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.event entity.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Extensions.ExtensionsRequestBuilder Extensions
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the forward method.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Forward.ForwardRequestBuilder Forward
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.Forward.ForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the snoozeReminder method.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.SnoozeReminder.SnoozeReminderRequestBuilder SnoozeReminder
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.SnoozeReminder.SnoozeReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the tentativelyAccept method.</summary>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.TentativelyAccept.TentativelyAcceptRequestBuilder TentativelyAccept
        {
            get => new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.TentativelyAccept.TentativelyAcceptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/calendars/{calendar%2Did}/calendarView/{event%2Did}/instances/{event%2Did1}/exceptionOccurrences/{event%2Did2}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/calendars/{calendar%2Did}/calendarView/{event%2Did}/instances/{event%2Did1}/exceptionOccurrences/{event%2Did2}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get exceptionOccurrences from me
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Event"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Event?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Event> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Event>(requestInfo, Microsoft.Graph.Beta.Models.Event.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get exceptionOccurrences from me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get exceptionOccurrences from me
        /// </summary>
        public class EventItemRequestBuilderGetQueryParameters 
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
        public class EventItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Me.Calendars.Item.CalendarView.Item.Instances.Item.ExceptionOccurrences.Item.EventItemRequestBuilder.EventItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
