// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    public partial class SqlAssessmentV2SummaryDetails : IUtf8JsonSerializable, IJsonModel<SqlAssessmentV2SummaryDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlAssessmentV2SummaryDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlAssessmentV2SummaryDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2SummaryDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentV2SummaryDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(SuitabilitySummary))
            {
                writer.WritePropertyName("suitabilitySummary"u8);
                writer.WriteStartObject();
                foreach (var item in SuitabilitySummary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(MonthlyComputeCost))
            {
                writer.WritePropertyName("monthlyComputeCost"u8);
                writer.WriteNumberValue(MonthlyComputeCost.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MonthlyStorageCost))
            {
                writer.WritePropertyName("monthlyStorageCost"u8);
                writer.WriteNumberValue(MonthlyStorageCost.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MonthlyLicenseCost))
            {
                writer.WritePropertyName("monthlyLicenseCost"u8);
                writer.WriteNumberValue(MonthlyLicenseCost.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfidenceScore))
            {
                writer.WritePropertyName("confidenceScore"u8);
                writer.WriteNumberValue(ConfidenceScore.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MonthlySecurityCost))
            {
                writer.WritePropertyName("monthlySecurityCost"u8);
                writer.WriteNumberValue(MonthlySecurityCost.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        SqlAssessmentV2SummaryDetails IJsonModel<SqlAssessmentV2SummaryDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2SummaryDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentV2SummaryDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAssessmentV2SummaryDetails(document.RootElement, options);
        }

        internal static SqlAssessmentV2SummaryDetails DeserializeSqlAssessmentV2SummaryDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, int> suitabilitySummary = default;
            double? monthlyComputeCost = default;
            double? monthlyStorageCost = default;
            double? monthlyLicenseCost = default;
            double? confidenceScore = default;
            double? monthlySecurityCost = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("suitabilitySummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    suitabilitySummary = dictionary;
                    continue;
                }
                if (property.NameEquals("monthlyComputeCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyComputeCost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("monthlyStorageCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyStorageCost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("monthlyLicenseCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyLicenseCost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("monthlySecurityCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlySecurityCost = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlAssessmentV2SummaryDetails(
                suitabilitySummary ?? new ChangeTrackingDictionary<string, int>(),
                monthlyComputeCost,
                monthlyStorageCost,
                monthlyLicenseCost,
                confidenceScore,
                monthlySecurityCost,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlAssessmentV2SummaryDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2SummaryDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMigrationAssessmentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentV2SummaryDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SqlAssessmentV2SummaryDetails IPersistableModel<SqlAssessmentV2SummaryDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2SummaryDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSqlAssessmentV2SummaryDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentV2SummaryDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlAssessmentV2SummaryDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
