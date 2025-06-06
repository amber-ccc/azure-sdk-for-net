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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstancePairInfo : IUtf8JsonSerializable, IJsonModel<ManagedInstancePairInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstancePairInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedInstancePairInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstancePairInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstancePairInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PrimaryManagedInstanceId))
            {
                writer.WritePropertyName("primaryManagedInstanceId"u8);
                writer.WriteStringValue(PrimaryManagedInstanceId);
            }
            if (Optional.IsDefined(PartnerManagedInstanceId))
            {
                writer.WritePropertyName("partnerManagedInstanceId"u8);
                writer.WriteStringValue(PartnerManagedInstanceId);
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

        ManagedInstancePairInfo IJsonModel<ManagedInstancePairInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstancePairInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstancePairInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstancePairInfo(document.RootElement, options);
        }

        internal static ManagedInstancePairInfo DeserializeManagedInstancePairInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier primaryManagedInstanceId = default;
            ResourceIdentifier partnerManagedInstanceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryManagedInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryManagedInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("partnerManagedInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerManagedInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedInstancePairInfo(primaryManagedInstanceId, partnerManagedInstanceId, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryManagedInstanceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryManagedInstanceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryManagedInstanceId))
                {
                    builder.Append("  primaryManagedInstanceId: ");
                    builder.AppendLine($"'{PrimaryManagedInstanceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartnerManagedInstanceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partnerManagedInstanceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartnerManagedInstanceId))
                {
                    builder.Append("  partnerManagedInstanceId: ");
                    builder.AppendLine($"'{PartnerManagedInstanceId.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedInstancePairInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstancePairInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSqlContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstancePairInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedInstancePairInfo IPersistableModel<ManagedInstancePairInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstancePairInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedInstancePairInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstancePairInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstancePairInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
