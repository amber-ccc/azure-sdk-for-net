// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class InsightQueryItemPropertiesDefaultTimeRange : IUtf8JsonSerializable, IJsonModel<InsightQueryItemPropertiesDefaultTimeRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InsightQueryItemPropertiesDefaultTimeRange>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InsightQueryItemPropertiesDefaultTimeRange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightQueryItemPropertiesDefaultTimeRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InsightQueryItemPropertiesDefaultTimeRange)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BeforeRange))
            {
                writer.WritePropertyName("beforeRange"u8);
                writer.WriteStringValue(BeforeRange);
            }
            if (Optional.IsDefined(AfterRange))
            {
                writer.WritePropertyName("afterRange"u8);
                writer.WriteStringValue(AfterRange);
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

        InsightQueryItemPropertiesDefaultTimeRange IJsonModel<InsightQueryItemPropertiesDefaultTimeRange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightQueryItemPropertiesDefaultTimeRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InsightQueryItemPropertiesDefaultTimeRange)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInsightQueryItemPropertiesDefaultTimeRange(document.RootElement, options);
        }

        internal static InsightQueryItemPropertiesDefaultTimeRange DeserializeInsightQueryItemPropertiesDefaultTimeRange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string beforeRange = default;
            string afterRange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("beforeRange"u8))
                {
                    beforeRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("afterRange"u8))
                {
                    afterRange = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InsightQueryItemPropertiesDefaultTimeRange(beforeRange, afterRange, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BeforeRange), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  beforeRange: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BeforeRange))
                {
                    builder.Append("  beforeRange: ");
                    if (BeforeRange.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BeforeRange}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BeforeRange}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AfterRange), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  afterRange: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AfterRange))
                {
                    builder.Append("  afterRange: ");
                    if (AfterRange.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AfterRange}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AfterRange}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<InsightQueryItemPropertiesDefaultTimeRange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightQueryItemPropertiesDefaultTimeRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InsightQueryItemPropertiesDefaultTimeRange)} does not support writing '{options.Format}' format.");
            }
        }

        InsightQueryItemPropertiesDefaultTimeRange IPersistableModel<InsightQueryItemPropertiesDefaultTimeRange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightQueryItemPropertiesDefaultTimeRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInsightQueryItemPropertiesDefaultTimeRange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InsightQueryItemPropertiesDefaultTimeRange)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InsightQueryItemPropertiesDefaultTimeRange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
