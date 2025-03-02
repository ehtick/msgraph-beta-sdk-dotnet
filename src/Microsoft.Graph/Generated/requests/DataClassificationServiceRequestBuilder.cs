// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DataClassificationServiceRequestBuilder.
    /// </summary>
    public partial class DataClassificationServiceRequestBuilder : EntityRequestBuilder, IDataClassificationServiceRequestBuilder
    {

        /// <summary>
        /// Constructs a new DataClassificationServiceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DataClassificationServiceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDataClassificationServiceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDataClassificationServiceRequest Request(IEnumerable<Option> options)
        {
            return new DataClassificationServiceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ExactMatchDataStores.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceExactMatchDataStoresCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceExactMatchDataStoresCollectionRequestBuilder ExactMatchDataStores
        {
            get
            {
                return new DataClassificationServiceExactMatchDataStoresCollectionRequestBuilder(this.AppendSegmentToRequestUrl("exactMatchDataStores"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ClassifyFileJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyFileJobsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceClassifyFileJobsCollectionRequestBuilder ClassifyFileJobs
        {
            get
            {
                return new DataClassificationServiceClassifyFileJobsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("classifyFileJobs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ClassifyTextJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyTextJobsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceClassifyTextJobsCollectionRequestBuilder ClassifyTextJobs
        {
            get
            {
                return new DataClassificationServiceClassifyTextJobsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("classifyTextJobs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for EvaluateDlpPoliciesJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceEvaluateDlpPoliciesJobsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceEvaluateDlpPoliciesJobsCollectionRequestBuilder EvaluateDlpPoliciesJobs
        {
            get
            {
                return new DataClassificationServiceEvaluateDlpPoliciesJobsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("evaluateDlpPoliciesJobs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for EvaluateLabelJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceEvaluateLabelJobsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceEvaluateLabelJobsCollectionRequestBuilder EvaluateLabelJobs
        {
            get
            {
                return new DataClassificationServiceEvaluateLabelJobsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("evaluateLabelJobs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Jobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceJobsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceJobsCollectionRequestBuilder Jobs
        {
            get
            {
                return new DataClassificationServiceJobsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("jobs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SensitiveTypes.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceSensitiveTypesCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceSensitiveTypesCollectionRequestBuilder SensitiveTypes
        {
            get
            {
                return new DataClassificationServiceSensitiveTypesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sensitiveTypes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SensitivityLabels.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceSensitivityLabelsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceSensitivityLabelsCollectionRequestBuilder SensitivityLabels
        {
            get
            {
                return new DataClassificationServiceSensitivityLabelsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sensitivityLabels"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ExactMatchUploadAgents.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceExactMatchUploadAgentsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceExactMatchUploadAgentsCollectionRequestBuilder ExactMatchUploadAgents
        {
            get
            {
                return new DataClassificationServiceExactMatchUploadAgentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("exactMatchUploadAgents"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DataClassificationServiceClassifyFile.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyFileRequestBuilder"/>.</returns>
        public IDataClassificationServiceClassifyFileRequestBuilder ClassifyFile(
            Stream file = null,
            IEnumerable<string> sensitiveTypeIds = null)
        {
            return new DataClassificationServiceClassifyFileRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.classifyFile"),
                this.Client,
                file,
                sensitiveTypeIds);
        }

        /// <summary>
        /// Gets the request builder for DataClassificationServiceClassifyExactMatches.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyExactMatchesRequestBuilder"/>.</returns>
        public IDataClassificationServiceClassifyExactMatchesRequestBuilder ClassifyExactMatches(
            IEnumerable<ContentClassification> contentClassifications,
            string text = null,
            string timeoutInMs = null,
            IEnumerable<string> sensitiveTypeIds = null)
        {
            return new DataClassificationServiceClassifyExactMatchesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.classifyExactMatches"),
                this.Client,
                contentClassifications,
                text,
                timeoutInMs,
                sensitiveTypeIds);
        }
    
    }
}
