// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Users.Item.FindRoomsWithRoomList {
    [Obsolete("This class is obsolete. Use findRoomsWithRoomListGetResponse instead.")]
    public class FindRoomsWithRoomListResponse : FindRoomsWithRoomListGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FindRoomsWithRoomListResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FindRoomsWithRoomListResponse();
        }
    }
}
