// <auto-generated/>
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Excuse;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Outcomes;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Reassign;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Resources;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Return;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.SetUpResourcesFolder;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Submit;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.SubmittedResources;
using Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Unsubmit;
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
namespace Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item
{
    /// <summary>
    /// Provides operations to manage the submissions property of the microsoft.graph.educationAssignment entity.
    /// </summary>
    public class EducationSubmissionItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the excuse method.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Excuse.ExcuseRequestBuilder Excuse
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Excuse.ExcuseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the outcomes property of the microsoft.graph.educationSubmission entity.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Outcomes.OutcomesRequestBuilder Outcomes
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Outcomes.OutcomesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reassign method.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Reassign.ReassignRequestBuilder Reassign
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Reassign.ReassignRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resources property of the microsoft.graph.educationSubmission entity.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Resources.ResourcesRequestBuilder Resources
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Resources.ResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the return method.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Return.ReturnRequestBuilder Return
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Return.ReturnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setUpResourcesFolder method.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.SetUpResourcesFolder.SetUpResourcesFolderRequestBuilder SetUpResourcesFolder
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.SetUpResourcesFolder.SetUpResourcesFolderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the submit method.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Submit.SubmitRequestBuilder Submit
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Submit.SubmitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the submittedResources property of the microsoft.graph.educationSubmission entity.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.SubmittedResources.SubmittedResourcesRequestBuilder SubmittedResources
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.SubmittedResources.SubmittedResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unsubmit method.</summary>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Unsubmit.UnsubmitRequestBuilder Unsubmit
        {
            get => new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.Unsubmit.UnsubmitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationSubmissionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/classes/{educationClass%2Did}/assignments/{educationAssignment%2Did}/submissions/{educationSubmission%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationSubmissionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/classes/{educationClass%2Did}/assignments/{educationAssignment%2Did}/submissions/{educationSubmission%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property submissions for education
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
        /// Retrieve a particular submission. Only teachers, students, and applications with application permissions can perform this operation. A submission object represents a student&apos;s work for an assignment. Resources associated with the submission represent this work. Only the assignedTo student can see and modify the submission. A teacher or application with application permissions has full access to all submissions. The grade and feedback from a teacher are part of the educationOutcome associated with this object. Only teachers or applications with application permissions can add or change grades and feedback. Students will not see the grade or feedback until the assignment has been released. Provide the header Prefer: include-unknown-enum-members to properly list submissions with the reassigned status. For details, see the examples section.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/educationsubmission-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EducationSubmission"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.EducationSubmission?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder.EducationSubmissionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.EducationSubmission> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder.EducationSubmissionItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.EducationSubmission>(requestInfo, Microsoft.Graph.Beta.Models.EducationSubmission.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property submissions in education
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EducationSubmission"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.EducationSubmission?> PatchAsync(Microsoft.Graph.Beta.Models.EducationSubmission body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.EducationSubmission> PatchAsync(Microsoft.Graph.Beta.Models.EducationSubmission body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.EducationSubmission>(requestInfo, Microsoft.Graph.Beta.Models.EducationSubmission.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property submissions for education
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
        /// Retrieve a particular submission. Only teachers, students, and applications with application permissions can perform this operation. A submission object represents a student&apos;s work for an assignment. Resources associated with the submission represent this work. Only the assignedTo student can see and modify the submission. A teacher or application with application permissions has full access to all submissions. The grade and feedback from a teacher are part of the educationOutcome associated with this object. Only teachers or applications with application permissions can add or change grades and feedback. Students will not see the grade or feedback until the assignment has been released. Provide the header Prefer: include-unknown-enum-members to properly list submissions with the reassigned status. For details, see the examples section.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder.EducationSubmissionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder.EducationSubmissionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property submissions in education
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.EducationSubmission body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.EducationSubmission body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EducationSubmissionItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve a particular submission. Only teachers, students, and applications with application permissions can perform this operation. A submission object represents a student&apos;s work for an assignment. Resources associated with the submission represent this work. Only the assignedTo student can see and modify the submission. A teacher or application with application permissions has full access to all submissions. The grade and feedback from a teacher are part of the educationOutcome associated with this object. Only teachers or applications with application permissions can add or change grades and feedback. Students will not see the grade or feedback until the assignment has been released. Provide the header Prefer: include-unknown-enum-members to properly list submissions with the reassigned status. For details, see the examples section.
        /// </summary>
        public class EducationSubmissionItemRequestBuilderGetQueryParameters 
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
        public class EducationSubmissionItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.Education.Classes.Item.Assignments.Item.Submissions.Item.EducationSubmissionItemRequestBuilder.EducationSubmissionItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EducationSubmissionItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
