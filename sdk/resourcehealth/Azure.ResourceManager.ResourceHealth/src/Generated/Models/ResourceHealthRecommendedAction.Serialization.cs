// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthRecommendedAction : IUtf8JsonSerializable, IJsonModel<ResourceHealthRecommendedAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthRecommendedAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceHealthRecommendedAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action);
            }
            if (Optional.IsDefined(ActionUri))
            {
                writer.WritePropertyName("actionUrl"u8);
                writer.WriteStringValue(ActionUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ActionUriComment))
            {
                writer.WritePropertyName("_ActionUrl.Comment"u8);
                writer.WriteStringValue(ActionUriComment);
            }
            if (Optional.IsDefined(ActionUriText))
            {
                writer.WritePropertyName("actionUrlText"u8);
                writer.WriteStringValue(ActionUriText);
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

        ResourceHealthRecommendedAction IJsonModel<ResourceHealthRecommendedAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthRecommendedAction(document.RootElement, options);
        }

        internal static ResourceHealthRecommendedAction DeserializeResourceHealthRecommendedAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string action = default;
            Uri actionUri = default;
            string actionUriComment = default;
            string actionUriText = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("_ActionUrl.Comment"u8))
                {
                    actionUriComment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionUrlText"u8))
                {
                    actionUriText = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceHealthRecommendedAction(action, actionUri, actionUriComment, actionUriText, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHealthRecommendedAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourceHealthContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceHealthRecommendedAction IPersistableModel<ResourceHealthRecommendedAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthRecommendedAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceHealthRecommendedAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthRecommendedAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthRecommendedAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
