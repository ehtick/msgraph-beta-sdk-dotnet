using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ThumbnailSet : Entity, IParsable {
        /// <summary>A 1920x1920 scaled thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Thumbnail? Large {
            get { return BackingStore?.Get<Thumbnail?>("large"); }
            set { BackingStore?.Set("large", value); }
        }
#else
        public Thumbnail Large {
            get { return BackingStore?.Get<Thumbnail>("large"); }
            set { BackingStore?.Set("large", value); }
        }
#endif
        /// <summary>A 176x176 scaled thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Thumbnail? Medium {
            get { return BackingStore?.Get<Thumbnail?>("medium"); }
            set { BackingStore?.Set("medium", value); }
        }
#else
        public Thumbnail Medium {
            get { return BackingStore?.Get<Thumbnail>("medium"); }
            set { BackingStore?.Set("medium", value); }
        }
#endif
        /// <summary>A 48x48 cropped thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Thumbnail? Small {
            get { return BackingStore?.Get<Thumbnail?>("small"); }
            set { BackingStore?.Set("small", value); }
        }
#else
        public Thumbnail Small {
            get { return BackingStore?.Get<Thumbnail>("small"); }
            set { BackingStore?.Set("small", value); }
        }
#endif
        /// <summary>A custom thumbnail image or the original image used to generate other thumbnails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Thumbnail? Source {
            get { return BackingStore?.Get<Thumbnail?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#else
        public Thumbnail Source {
            get { return BackingStore?.Get<Thumbnail>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ThumbnailSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThumbnailSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"large", n => { Large = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"medium", n => { Medium = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"small", n => { Small = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
                {"source", n => { Source = n.GetObjectValue<Thumbnail>(Thumbnail.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Thumbnail>("large", Large);
            writer.WriteObjectValue<Thumbnail>("medium", Medium);
            writer.WriteObjectValue<Thumbnail>("small", Small);
            writer.WriteObjectValue<Thumbnail>("source", Source);
        }
    }
}
