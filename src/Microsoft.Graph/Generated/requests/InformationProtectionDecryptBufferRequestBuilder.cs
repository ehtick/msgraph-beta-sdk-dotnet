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
    /// The type InformationProtectionDecryptBufferRequestBuilder.
    /// </summary>
    public partial class InformationProtectionDecryptBufferRequestBuilder : BaseActionMethodRequestBuilder<IInformationProtectionDecryptBufferRequest>, IInformationProtectionDecryptBufferRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="InformationProtectionDecryptBufferRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="encryptedBuffer">A encryptedBuffer parameter for the OData method call.</param>
        /// <param name="publishingLicense">A publishingLicense parameter for the OData method call.</param>
        public InformationProtectionDecryptBufferRequestBuilder(
            string requestUrl,
            IBaseClient client,
            byte[] encryptedBuffer,
            byte[] publishingLicense)
            : base(requestUrl, client)
        {
            this.SetParameter("encryptedBuffer", encryptedBuffer, false);
            this.SetParameter("publishingLicense", publishingLicense, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IInformationProtectionDecryptBufferRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new InformationProtectionDecryptBufferRequest(functionUrl, this.Client, options);

            if (this.HasParameter("encryptedBuffer"))
            {
                request.RequestBody.EncryptedBuffer = this.GetParameter<byte[]>("encryptedBuffer");
            }

            if (this.HasParameter("publishingLicense"))
            {
                request.RequestBody.PublishingLicense = this.GetParameter<byte[]>("publishingLicense");
            }

            return request;
        }
    }
}
