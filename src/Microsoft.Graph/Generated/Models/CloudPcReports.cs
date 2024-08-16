// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CloudPcReports : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The export jobs created for downloading reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CloudPcExportJob>? ExportJobs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CloudPcExportJob>?>("exportJobs"); }
            set { BackingStore?.Set("exportJobs", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CloudPcExportJob> ExportJobs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CloudPcExportJob>>("exportJobs"); }
            set { BackingStore?.Set("exportJobs", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPcReports"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.CloudPcReports CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CloudPcReports();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "exportJobs", n => { ExportJobs = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CloudPcExportJob>(Microsoft.Graph.Beta.Models.CloudPcExportJob.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CloudPcExportJob>("exportJobs", ExportJobs);
        }
    }
}
