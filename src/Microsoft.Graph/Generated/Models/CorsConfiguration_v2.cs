using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CorsConfiguration_v2 : Entity, IParsable {
        /// <summary>The request headers that the origin domain may specify on the CORS request. The wildcard character * indicates that any header beginning with the specified prefix is allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedHeaders {
            get { return BackingStore?.Get<List<string>?>("allowedHeaders"); }
            set { BackingStore?.Set("allowedHeaders", value); }
        }
#nullable restore
#else
        public List<string> AllowedHeaders {
            get { return BackingStore?.Get<List<string>>("allowedHeaders"); }
            set { BackingStore?.Set("allowedHeaders", value); }
        }
#endif
        /// <summary>The HTTP request methods that the origin domain may use for a CORS request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedMethods {
            get { return BackingStore?.Get<List<string>?>("allowedMethods"); }
            set { BackingStore?.Set("allowedMethods", value); }
        }
#nullable restore
#else
        public List<string> AllowedMethods {
            get { return BackingStore?.Get<List<string>>("allowedMethods"); }
            set { BackingStore?.Set("allowedMethods", value); }
        }
#endif
        /// <summary>The origin domains that are permitted to make a request against the service via CORS. The origin domain is the domain from which the request originates. The origin must be an exact case-sensitive match with the origin that the user agent sends to the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedOrigins {
            get { return BackingStore?.Get<List<string>?>("allowedOrigins"); }
            set { BackingStore?.Set("allowedOrigins", value); }
        }
#nullable restore
#else
        public List<string> AllowedOrigins {
            get { return BackingStore?.Get<List<string>>("allowedOrigins"); }
            set { BackingStore?.Set("allowedOrigins", value); }
        }
#endif
        /// <summary>The maximum amount of time that a browser should cache the response to the preflight OPTIONS request.</summary>
        public int? MaxAgeInSeconds {
            get { return BackingStore?.Get<int?>("maxAgeInSeconds"); }
            set { BackingStore?.Set("maxAgeInSeconds", value); }
        }
        /// <summary>Resource within the application segment for which CORS permissions are granted. / grants permission for the whole app segment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Resource {
            get { return BackingStore?.Get<string?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public string Resource {
            get { return BackingStore?.Get<string>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CorsConfiguration_v2 CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CorsConfiguration_v2();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedHeaders", n => { AllowedHeaders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"allowedMethods", n => { AllowedMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"allowedOrigins", n => { AllowedOrigins = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"maxAgeInSeconds", n => { MaxAgeInSeconds = n.GetIntValue(); } },
                {"resource", n => { Resource = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedHeaders", AllowedHeaders);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedMethods", AllowedMethods);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedOrigins", AllowedOrigins);
            writer.WriteIntValue("maxAgeInSeconds", MaxAgeInSeconds);
            writer.WriteStringValue("resource", Resource);
        }
    }
}
