// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum FileProcessingStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FileProcessingStatus
    {
    
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// Internal Error
        /// </summary>
        InternalError = 1,
	
        /// <summary>
        /// Unknown Error
        /// </summary>
        UnknownError = 2,
	
        /// <summary>
        /// Processing Timeout
        /// </summary>
        ProcessingTimeout = 3,
	
        /// <summary>
        /// Invalid File Id
        /// </summary>
        InvalidFileId = 4,
	
        /// <summary>
        /// File Size Is Zero
        /// </summary>
        FileSizeIsZero = 5,
	
        /// <summary>
        /// File Size Is Too Large
        /// </summary>
        FileSizeIsTooLarge = 6,
	
        /// <summary>
        /// File Depth Limit Exceeded
        /// </summary>
        FileDepthLimitExceeded = 7,
	
        /// <summary>
        /// File Body Is Too Long
        /// </summary>
        FileBodyIsTooLong = 8,
	
        /// <summary>
        /// File Type Is Unknown
        /// </summary>
        FileTypeIsUnknown = 9,
	
        /// <summary>
        /// File Type Is Not Supported
        /// </summary>
        FileTypeIsNotSupported = 10,
	
        /// <summary>
        /// Malformed File
        /// </summary>
        MalformedFile = 11,
	
        /// <summary>
        /// Protected File
        /// </summary>
        ProtectedFile = 12,
	
        /// <summary>
        /// Poison File
        /// </summary>
        PoisonFile = 13,
	
        /// <summary>
        /// No Review Set Summary Generated
        /// </summary>
        NoReviewSetSummaryGenerated = 14,
	
        /// <summary>
        /// Extraction Exception
        /// </summary>
        ExtractionException = 15,
	
        /// <summary>
        /// Ocr Processing Timeout
        /// </summary>
        OcrProcessingTimeout = 16,
	
        /// <summary>
        /// Ocr File Size Exceeds Limit
        /// </summary>
        OcrFileSizeExceedsLimit = 17,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 18,
	
    }
}
