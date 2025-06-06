// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the document evaluation result for a custom single-label classification project. </summary>
    public partial class CustomSingleLabelClassificationDocumentEvalResult : TextAuthoringDocumentEvalResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomSingleLabelClassificationDocumentEvalResult"/>. </summary>
        /// <param name="location"> Represents the document path. </param>
        /// <param name="language"> Represents the document language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="customSingleLabelClassificationResult"> Represents the evaluation prediction for single label classification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="language"/> or <paramref name="customSingleLabelClassificationResult"/> is null. </exception>
        internal CustomSingleLabelClassificationDocumentEvalResult(string location, string language, DocumentSingleLabelClassificationEvalResult customSingleLabelClassificationResult) : base(location, language)
        {
            Argument.AssertNotNull(location, nameof(location));
            Argument.AssertNotNull(language, nameof(language));
            Argument.AssertNotNull(customSingleLabelClassificationResult, nameof(customSingleLabelClassificationResult));

            ProjectKind = TextAuthoringProjectKind.CustomSingleLabelClassification;
            CustomSingleLabelClassificationResult = customSingleLabelClassificationResult;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSingleLabelClassificationDocumentEvalResult"/>. </summary>
        /// <param name="projectKind"> Represents the project kind. </param>
        /// <param name="location"> Represents the document path. </param>
        /// <param name="language"> Represents the document language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="customSingleLabelClassificationResult"> Represents the evaluation prediction for single label classification. </param>
        internal CustomSingleLabelClassificationDocumentEvalResult(TextAuthoringProjectKind projectKind, string location, string language, IDictionary<string, BinaryData> serializedAdditionalRawData, DocumentSingleLabelClassificationEvalResult customSingleLabelClassificationResult) : base(projectKind, location, language, serializedAdditionalRawData)
        {
            CustomSingleLabelClassificationResult = customSingleLabelClassificationResult;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSingleLabelClassificationDocumentEvalResult"/> for deserialization. </summary>
        internal CustomSingleLabelClassificationDocumentEvalResult()
        {
        }

        /// <summary> Represents the evaluation prediction for single label classification. </summary>
        public DocumentSingleLabelClassificationEvalResult CustomSingleLabelClassificationResult { get; }
    }
}
