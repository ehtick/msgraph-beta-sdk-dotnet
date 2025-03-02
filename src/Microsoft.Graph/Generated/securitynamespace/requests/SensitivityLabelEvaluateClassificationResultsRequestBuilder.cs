// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SensitivityLabelEvaluateClassificationResultsRequestBuilder.
    /// </summary>
    public partial class SensitivityLabelEvaluateClassificationResultsRequestBuilder : Microsoft.Graph.BaseActionMethodRequestBuilder<ISensitivityLabelEvaluateClassificationResultsRequest>, ISensitivityLabelEvaluateClassificationResultsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="SensitivityLabelEvaluateClassificationResultsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="contentInfo">A contentInfo parameter for the OData method call.</param>
        /// <param name="classificationResults">A classificationResults parameter for the OData method call.</param>
        public SensitivityLabelEvaluateClassificationResultsRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            ContentInfo contentInfo,
            IEnumerable<ClassificationResult> classificationResults)
            : base(requestUrl, client)
        {
            this.SetParameter("contentInfo", contentInfo, false);
            this.SetParameter("classificationResults", classificationResults, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ISensitivityLabelEvaluateClassificationResultsRequest CreateRequest(string functionUrl, IEnumerable<Microsoft.Graph.Option> options)
        {
            var request = new SensitivityLabelEvaluateClassificationResultsRequest(functionUrl, this.Client, options);

            if (this.HasParameter("contentInfo"))
            {
                request.RequestBody.ContentInfo = this.GetParameter<ContentInfo>("contentInfo");
            }

            if (this.HasParameter("classificationResults"))
            {
                request.RequestBody.ClassificationResults = this.GetParameter<IEnumerable<ClassificationResult>>("classificationResults");
            }

            return request;
        }
    }
}
