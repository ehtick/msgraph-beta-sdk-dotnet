// <auto-generated/>
using Microsoft.Graph.Beta.App.Calls.Item.AddLargeGalleryView;
using Microsoft.Graph.Beta.App.Calls.Item.Answer;
using Microsoft.Graph.Beta.App.Calls.Item.AudioRoutingGroups;
using Microsoft.Graph.Beta.App.Calls.Item.CancelMediaProcessing;
using Microsoft.Graph.Beta.App.Calls.Item.ChangeScreenSharingRole;
using Microsoft.Graph.Beta.App.Calls.Item.ContentSharingSessions;
using Microsoft.Graph.Beta.App.Calls.Item.KeepAlive;
using Microsoft.Graph.Beta.App.Calls.Item.Mute;
using Microsoft.Graph.Beta.App.Calls.Item.Operations;
using Microsoft.Graph.Beta.App.Calls.Item.Participants;
using Microsoft.Graph.Beta.App.Calls.Item.PlayPrompt;
using Microsoft.Graph.Beta.App.Calls.Item.Record;
using Microsoft.Graph.Beta.App.Calls.Item.RecordResponse;
using Microsoft.Graph.Beta.App.Calls.Item.Redirect;
using Microsoft.Graph.Beta.App.Calls.Item.Reject;
using Microsoft.Graph.Beta.App.Calls.Item.SendDtmfTones;
using Microsoft.Graph.Beta.App.Calls.Item.SubscribeToTone;
using Microsoft.Graph.Beta.App.Calls.Item.Transfer;
using Microsoft.Graph.Beta.App.Calls.Item.Unmute;
using Microsoft.Graph.Beta.App.Calls.Item.UpdateRecordingStatus;
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
namespace Microsoft.Graph.Beta.App.Calls.Item
{
    /// <summary>
    /// Provides operations to manage the calls property of the microsoft.graph.commsApplication entity.
    /// </summary>
    public class CallItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the addLargeGalleryView method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.AddLargeGalleryView.AddLargeGalleryViewRequestBuilder AddLargeGalleryView
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.AddLargeGalleryView.AddLargeGalleryViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the answer method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Answer.AnswerRequestBuilder Answer
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Answer.AnswerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the audioRoutingGroups property of the microsoft.graph.call entity.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.AudioRoutingGroups.AudioRoutingGroupsRequestBuilder AudioRoutingGroups
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.AudioRoutingGroups.AudioRoutingGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancelMediaProcessing method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.CancelMediaProcessing.CancelMediaProcessingRequestBuilder CancelMediaProcessing
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.CancelMediaProcessing.CancelMediaProcessingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the changeScreenSharingRole method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.ChangeScreenSharingRole.ChangeScreenSharingRoleRequestBuilder ChangeScreenSharingRole
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.ChangeScreenSharingRole.ChangeScreenSharingRoleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentSharingSessions property of the microsoft.graph.call entity.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.ContentSharingSessions.ContentSharingSessionsRequestBuilder ContentSharingSessions
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.ContentSharingSessions.ContentSharingSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the keepAlive method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.KeepAlive.KeepAliveRequestBuilder KeepAlive
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.KeepAlive.KeepAliveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the mute method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Mute.MuteRequestBuilder Mute
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Mute.MuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.call entity.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Operations.OperationsRequestBuilder Operations
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the participants property of the microsoft.graph.call entity.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Participants.ParticipantsRequestBuilder Participants
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Participants.ParticipantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the playPrompt method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.PlayPrompt.PlayPromptRequestBuilder PlayPrompt
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.PlayPrompt.PlayPromptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the record method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Record.RecordRequestBuilder Record
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Record.RecordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recordResponse method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.RecordResponse.RecordResponseRequestBuilder RecordResponse
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.RecordResponse.RecordResponseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the redirect method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Redirect.RedirectRequestBuilder Redirect
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Redirect.RedirectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reject method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Reject.RejectRequestBuilder Reject
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Reject.RejectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendDtmfTones method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.SendDtmfTones.SendDtmfTonesRequestBuilder SendDtmfTones
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.SendDtmfTones.SendDtmfTonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the subscribeToTone method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.SubscribeToTone.SubscribeToToneRequestBuilder SubscribeToTone
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.SubscribeToTone.SubscribeToToneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the transfer method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Transfer.TransferRequestBuilder Transfer
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Transfer.TransferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmute method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmuteRequestBuilder Unmute
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.Unmute.UnmuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateRecordingStatus method.</summary>
        public Microsoft.Graph.Beta.App.Calls.Item.UpdateRecordingStatus.UpdateRecordingStatusRequestBuilder UpdateRecordingStatus
        {
            get => new Microsoft.Graph.Beta.App.Calls.Item.UpdateRecordingStatus.UpdateRecordingStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CallItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/calls/{call%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CallItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/calls/{call%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property calls for app
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
        /// Get calls from app
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Call"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Call?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Call> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Call>(requestInfo, Microsoft.Graph.Beta.Models.Call.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property calls in app
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Call"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Call?> PatchAsync(Microsoft.Graph.Beta.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Call> PatchAsync(Microsoft.Graph.Beta.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Call>(requestInfo, Microsoft.Graph.Beta.Models.Call.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property calls for app
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
        /// Get calls from app
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property calls in app
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CallItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get calls from app
        /// </summary>
        public class CallItemRequestBuilderGetQueryParameters 
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
        public class CallItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.App.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CallItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
