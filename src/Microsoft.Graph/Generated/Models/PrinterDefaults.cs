// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PrinterDefaults : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default color mode to use when printing the document. Valid values are described in the following table.</summary>
        public Microsoft.Graph.Beta.Models.PrintColorMode? ColorMode
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintColorMode?>("colorMode"); }
            set { BackingStore?.Set("colorMode", value); }
        }
        /// <summary>The default content (MIME) type to use when processing documents.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType
        {
            get { return BackingStore?.Get<string?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public string ContentType
        {
            get { return BackingStore?.Get<string>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>The default number of copies printed per job.</summary>
        public int? CopiesPerJob
        {
            get { return BackingStore?.Get<int?>("copiesPerJob"); }
            set { BackingStore?.Set("copiesPerJob", value); }
        }
        /// <summary>The documentMimeType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentMimeType
        {
            get { return BackingStore?.Get<string?>("documentMimeType"); }
            set { BackingStore?.Set("documentMimeType", value); }
        }
#nullable restore
#else
        public string DocumentMimeType
        {
            get { return BackingStore?.Get<string>("documentMimeType"); }
            set { BackingStore?.Set("documentMimeType", value); }
        }
#endif
        /// <summary>The default resolution in DPI to use when printing the job.</summary>
        public int? Dpi
        {
            get { return BackingStore?.Get<int?>("dpi"); }
            set { BackingStore?.Set("dpi", value); }
        }
        /// <summary>The duplexConfiguration property</summary>
        public Microsoft.Graph.Beta.Models.PrintDuplexConfiguration? DuplexConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintDuplexConfiguration?>("duplexConfiguration"); }
            set { BackingStore?.Set("duplexConfiguration", value); }
        }
        /// <summary>The default duplex (double-sided) configuration to use when printing a document. Valid values are described in the following table.</summary>
        public Microsoft.Graph.Beta.Models.PrintDuplexMode? DuplexMode
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintDuplexMode?>("duplexMode"); }
            set { BackingStore?.Set("duplexMode", value); }
        }
        /// <summary>The default set of finishings to apply to print jobs. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PrintFinishing?>? Finishings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PrintFinishing?>?>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PrintFinishing?> Finishings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PrintFinishing?>>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#endif
        /// <summary>The default fitPdfToPage setting. True to fit each page of a PDF document to a physical sheet of media; false to let the printer decide how to lay out impressions.</summary>
        public bool? FitPdfToPage
        {
            get { return BackingStore?.Get<bool?>("fitPdfToPage"); }
            set { BackingStore?.Set("fitPdfToPage", value); }
        }
        /// <summary>The default input bin that serves as the paper source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputBin
        {
            get { return BackingStore?.Get<string?>("inputBin"); }
            set { BackingStore?.Set("inputBin", value); }
        }
#nullable restore
#else
        public string InputBin
        {
            get { return BackingStore?.Get<string>("inputBin"); }
            set { BackingStore?.Set("inputBin", value); }
        }
#endif
        /// <summary>The default media (such as paper) color to print the document on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaColor
        {
            get { return BackingStore?.Get<string?>("mediaColor"); }
            set { BackingStore?.Set("mediaColor", value); }
        }
#nullable restore
#else
        public string MediaColor
        {
            get { return BackingStore?.Get<string>("mediaColor"); }
            set { BackingStore?.Set("mediaColor", value); }
        }
#endif
        /// <summary>The default media size to use. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaSize
        {
            get { return BackingStore?.Get<string?>("mediaSize"); }
            set { BackingStore?.Set("mediaSize", value); }
        }
#nullable restore
#else
        public string MediaSize
        {
            get { return BackingStore?.Get<string>("mediaSize"); }
            set { BackingStore?.Set("mediaSize", value); }
        }
#endif
        /// <summary>The default media (such as paper) type to print the document on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType
        {
            get { return BackingStore?.Get<string?>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#nullable restore
#else
        public string MediaType
        {
            get { return BackingStore?.Get<string>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#endif
        /// <summary>The default direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.</summary>
        public Microsoft.Graph.Beta.Models.PrintMultipageLayout? MultipageLayout
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintMultipageLayout?>("multipageLayout"); }
            set { BackingStore?.Set("multipageLayout", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The default orientation to use when printing the document. Valid values are described in the following table.</summary>
        public Microsoft.Graph.Beta.Models.PrintOrientation? Orientation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintOrientation?>("orientation"); }
            set { BackingStore?.Set("orientation", value); }
        }
        /// <summary>The default output bin to place completed prints into. See the printer&apos;s capabilities for a list of supported output bins.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputBin
        {
            get { return BackingStore?.Get<string?>("outputBin"); }
            set { BackingStore?.Set("outputBin", value); }
        }
#nullable restore
#else
        public string OutputBin
        {
            get { return BackingStore?.Get<string>("outputBin"); }
            set { BackingStore?.Set("outputBin", value); }
        }
#endif
        /// <summary>The default number of document pages to print on each sheet.</summary>
        public int? PagesPerSheet
        {
            get { return BackingStore?.Get<int?>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
        /// <summary>The pdfFitToPage property</summary>
        public bool? PdfFitToPage
        {
            get { return BackingStore?.Get<bool?>("pdfFitToPage"); }
            set { BackingStore?.Set("pdfFitToPage", value); }
        }
        /// <summary>The presentationDirection property</summary>
        public Microsoft.Graph.Beta.Models.PrintPresentationDirection? PresentationDirection
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintPresentationDirection?>("presentationDirection"); }
            set { BackingStore?.Set("presentationDirection", value); }
        }
        /// <summary>The printColorConfiguration property</summary>
        public Microsoft.Graph.Beta.Models.PrintColorConfiguration? PrintColorConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintColorConfiguration?>("printColorConfiguration"); }
            set { BackingStore?.Set("printColorConfiguration", value); }
        }
        /// <summary>The printQuality property</summary>
        public Microsoft.Graph.Beta.Models.PrintQuality? PrintQuality
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintQuality?>("printQuality"); }
            set { BackingStore?.Set("printQuality", value); }
        }
        /// <summary>The default quality to use when printing the document. Valid values are described in the following table.</summary>
        public Microsoft.Graph.Beta.Models.PrintQuality? Quality
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintQuality?>("quality"); }
            set { BackingStore?.Set("quality", value); }
        }
        /// <summary>Specifies how the printer scales the document data to fit the requested media. Valid values are described in the following table.</summary>
        public Microsoft.Graph.Beta.Models.PrintScaling? Scaling
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrintScaling?>("scaling"); }
            set { BackingStore?.Set("scaling", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.PrinterDefaults"/> and sets the default values.
        /// </summary>
        public PrinterDefaults()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PrinterDefaults"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.PrinterDefaults CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.PrinterDefaults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "colorMode", n => { ColorMode = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintColorMode>(); } },
                { "contentType", n => { ContentType = n.GetStringValue(); } },
                { "copiesPerJob", n => { CopiesPerJob = n.GetIntValue(); } },
                { "documentMimeType", n => { DocumentMimeType = n.GetStringValue(); } },
                { "dpi", n => { Dpi = n.GetIntValue(); } },
                { "duplexConfiguration", n => { DuplexConfiguration = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintDuplexConfiguration>(); } },
                { "duplexMode", n => { DuplexMode = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintDuplexMode>(); } },
                { "finishings", n => { Finishings = n.GetCollectionOfEnumValues<Microsoft.Graph.Beta.Models.PrintFinishing>()?.ToList(); } },
                { "fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                { "inputBin", n => { InputBin = n.GetStringValue(); } },
                { "mediaColor", n => { MediaColor = n.GetStringValue(); } },
                { "mediaSize", n => { MediaSize = n.GetStringValue(); } },
                { "mediaType", n => { MediaType = n.GetStringValue(); } },
                { "multipageLayout", n => { MultipageLayout = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintMultipageLayout>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "orientation", n => { Orientation = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintOrientation>(); } },
                { "outputBin", n => { OutputBin = n.GetStringValue(); } },
                { "pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
                { "pdfFitToPage", n => { PdfFitToPage = n.GetBoolValue(); } },
                { "presentationDirection", n => { PresentationDirection = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintPresentationDirection>(); } },
                { "printColorConfiguration", n => { PrintColorConfiguration = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintColorConfiguration>(); } },
                { "printQuality", n => { PrintQuality = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintQuality>(); } },
                { "quality", n => { Quality = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintQuality>(); } },
                { "scaling", n => { Scaling = n.GetEnumValue<Microsoft.Graph.Beta.Models.PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintColorMode>("colorMode", ColorMode);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteIntValue("copiesPerJob", CopiesPerJob);
            writer.WriteStringValue("documentMimeType", DocumentMimeType);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintDuplexConfiguration>("duplexConfiguration", DuplexConfiguration);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteCollectionOfEnumValues<Microsoft.Graph.Beta.Models.PrintFinishing>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteStringValue("mediaColor", MediaColor);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteBoolValue("pdfFitToPage", PdfFitToPage);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintPresentationDirection>("presentationDirection", PresentationDirection);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintColorConfiguration>("printColorConfiguration", PrintColorConfiguration);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintQuality>("printQuality", PrintQuality);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintQuality>("quality", Quality);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
