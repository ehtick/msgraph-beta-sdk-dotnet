// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type InformationProtectionSensitivityLabelsCollectionRequestBuilder.
    /// </summary>
    public partial class InformationProtectionSensitivityLabelsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IInformationProtectionSensitivityLabelsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new InformationProtectionSensitivityLabelsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public InformationProtectionSensitivityLabelsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IInformationProtectionSensitivityLabelsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IInformationProtectionSensitivityLabelsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new InformationProtectionSensitivityLabelsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISensitivityLabelRequestBuilder"/> for the specified InformationProtectionSensitivityLabel.
        /// </summary>
        /// <param name="id">The ID for the InformationProtectionSensitivityLabel.</param>
        /// <returns>The <see cref="ISensitivityLabelRequestBuilder"/>.</returns>
        public ISensitivityLabelRequestBuilder this[string id]
        {
            get
            {
                return new SensitivityLabelRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SensitivityLabelEvaluateApplication.
        /// </summary>
        /// <returns>The <see cref="ISensitivityLabelEvaluateApplicationRequestBuilder"/>.</returns>
        public ISensitivityLabelEvaluateApplicationRequestBuilder EvaluateApplication(
            ContentInfo contentInfo,
            LabelingOptions labelingOptions)
        {
            return new SensitivityLabelEvaluateApplicationRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.evaluateApplication"),
                this.Client,
                contentInfo,
                labelingOptions);
        }

        /// <summary>
        /// Gets the request builder for SensitivityLabelEvaluateClassificationResults.
        /// </summary>
        /// <returns>The <see cref="ISensitivityLabelEvaluateClassificationResultsRequestBuilder"/>.</returns>
        public ISensitivityLabelEvaluateClassificationResultsRequestBuilder EvaluateClassificationResults(
            ContentInfo contentInfo,
            IEnumerable<ClassificationResult> classificationResults)
        {
            return new SensitivityLabelEvaluateClassificationResultsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.evaluateClassificationResults"),
                this.Client,
                contentInfo,
                classificationResults);
        }

        /// <summary>
        /// Gets the request builder for SensitivityLabelEvaluateRemoval.
        /// </summary>
        /// <returns>The <see cref="ISensitivityLabelEvaluateRemovalRequestBuilder"/>.</returns>
        public ISensitivityLabelEvaluateRemovalRequestBuilder EvaluateRemoval(
            ContentInfo contentInfo,
            DowngradeJustification downgradeJustification = null)
        {
            return new SensitivityLabelEvaluateRemovalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.evaluateRemoval"),
                this.Client,
                contentInfo,
                downgradeJustification);
        }

        /// <summary>
        /// Gets the request builder for SensitivityLabelExtractContentLabel.
        /// </summary>
        /// <returns>The <see cref="ISensitivityLabelExtractContentLabelRequestBuilder"/>.</returns>
        public ISensitivityLabelExtractContentLabelRequestBuilder ExtractContentLabel(
            ContentInfo contentInfo = null)
        {
            return new SensitivityLabelExtractContentLabelRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.extractContentLabel"),
                this.Client,
                contentInfo);
        }
    }
}
