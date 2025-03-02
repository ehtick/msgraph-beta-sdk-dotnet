// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsHlookupRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsHlookupRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsHlookupRequest>, IWorkbookFunctionsHlookupRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsHlookupRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="lookupValue">A lookupValue parameter for the OData method call.</param>
        /// <param name="tableArray">A tableArray parameter for the OData method call.</param>
        /// <param name="rowIndexNum">A rowIndexNum parameter for the OData method call.</param>
        /// <param name="rangeLookup">A rangeLookup parameter for the OData method call.</param>
        public WorkbookFunctionsHlookupRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument lookupValue,
            System.Text.Json.JsonDocument tableArray,
            System.Text.Json.JsonDocument rowIndexNum,
            System.Text.Json.JsonDocument rangeLookup)
            : base(requestUrl, client)
        {
            this.SetParameter("lookupValue", lookupValue, true);
            this.SetParameter("tableArray", tableArray, true);
            this.SetParameter("rowIndexNum", rowIndexNum, true);
            this.SetParameter("rangeLookup", rangeLookup, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsHlookupRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsHlookupRequest(functionUrl, this.Client, options);

            if (this.HasParameter("lookupValue"))
            {
                request.RequestBody.LookupValue = this.GetParameter<System.Text.Json.JsonDocument>("lookupValue");
            }

            if (this.HasParameter("tableArray"))
            {
                request.RequestBody.TableArray = this.GetParameter<System.Text.Json.JsonDocument>("tableArray");
            }

            if (this.HasParameter("rowIndexNum"))
            {
                request.RequestBody.RowIndexNum = this.GetParameter<System.Text.Json.JsonDocument>("rowIndexNum");
            }

            if (this.HasParameter("rangeLookup"))
            {
                request.RequestBody.RangeLookup = this.GetParameter<System.Text.Json.JsonDocument>("rangeLookup");
            }

            return request;
        }
    }
}
