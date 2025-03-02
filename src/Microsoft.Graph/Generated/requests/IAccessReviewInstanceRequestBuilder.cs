// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IAccessReviewInstanceRequestBuilder.
    /// </summary>
    public partial interface IAccessReviewInstanceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAccessReviewInstanceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAccessReviewInstanceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ContactedReviewers.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceContactedReviewersCollectionRequestBuilder"/>.</returns>
        IAccessReviewInstanceContactedReviewersCollectionRequestBuilder ContactedReviewers { get; }

        /// <summary>
        /// Gets the request builder for Decisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceDecisionsCollectionRequestBuilder"/>.</returns>
        IAccessReviewInstanceDecisionsCollectionRequestBuilder Decisions { get; }

        /// <summary>
        /// Gets the request builder for Definition.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewScheduleDefinitionWithReferenceRequestBuilder"/>.</returns>
        IAccessReviewScheduleDefinitionWithReferenceRequestBuilder Definition { get; }

        /// <summary>
        /// Gets the request builder for Stages.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceStagesCollectionRequestBuilder"/>.</returns>
        IAccessReviewInstanceStagesCollectionRequestBuilder Stages { get; }
    
        /// <summary>
        /// Gets the request builder for AccessReviewInstanceStop.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceStopRequestBuilder"/>.</returns>
        IAccessReviewInstanceStopRequestBuilder Stop();

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceAcceptRecommendations.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceAcceptRecommendationsRequestBuilder"/>.</returns>
        IAccessReviewInstanceAcceptRecommendationsRequestBuilder AcceptRecommendations();

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceApplyDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceApplyDecisionsRequestBuilder"/>.</returns>
        IAccessReviewInstanceApplyDecisionsRequestBuilder ApplyDecisions();

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceBatchRecordDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceBatchRecordDecisionsRequestBuilder"/>.</returns>
        IAccessReviewInstanceBatchRecordDecisionsRequestBuilder BatchRecordDecisions(
            string decision = null,
            string justification = null,
            string principalId = null,
            string resourceId = null);

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceResetDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceResetDecisionsRequestBuilder"/>.</returns>
        IAccessReviewInstanceResetDecisionsRequestBuilder ResetDecisions();

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceSendReminder.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceSendReminderRequestBuilder"/>.</returns>
        IAccessReviewInstanceSendReminderRequestBuilder SendReminder();
    
    }
}
