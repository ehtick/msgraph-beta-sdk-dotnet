// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityGroupCountsWithPeriod {
    [Obsolete("This class is obsolete. Use getOffice365GroupsActivityGroupCountsWithPeriodGetResponse instead.")]
    public class GetOffice365GroupsActivityGroupCountsWithPeriodResponse : GetOffice365GroupsActivityGroupCountsWithPeriodGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetOffice365GroupsActivityGroupCountsWithPeriodResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetOffice365GroupsActivityGroupCountsWithPeriodResponse();
        }
    }
}
