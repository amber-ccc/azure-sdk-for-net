// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterApiServerAccessProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterApiServerAccessProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterApiServerAccessProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterApiServerAccessProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AuthorizedIPRanges))
            {
                writer.WritePropertyName("authorizedIPRanges"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnablePrivateCluster))
            {
                writer.WritePropertyName("enablePrivateCluster"u8);
                writer.WriteBooleanValue(EnablePrivateCluster.Value);
            }
            if (Optional.IsDefined(PrivateDnsZone))
            {
                writer.WritePropertyName("privateDNSZone"u8);
                writer.WriteStringValue(PrivateDnsZone);
            }
            if (Optional.IsDefined(EnablePrivateClusterPublicFqdn))
            {
                writer.WritePropertyName("enablePrivateClusterPublicFQDN"u8);
                writer.WriteBooleanValue(EnablePrivateClusterPublicFqdn.Value);
            }
            if (Optional.IsDefined(DisableRunCommand))
            {
                writer.WritePropertyName("disableRunCommand"u8);
                writer.WriteBooleanValue(DisableRunCommand.Value);
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

        ManagedClusterApiServerAccessProfile IJsonModel<ManagedClusterApiServerAccessProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterApiServerAccessProfile(document.RootElement, options);
        }

        internal static ManagedClusterApiServerAccessProfile DeserializeManagedClusterApiServerAccessProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> authorizedIPRanges = default;
            bool? enablePrivateCluster = default;
            string privateDnsZone = default;
            bool? enablePrivateClusterPublicFQDN = default;
            bool? disableRunCommand = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizedIPRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    authorizedIPRanges = array;
                    continue;
                }
                if (property.NameEquals("enablePrivateCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePrivateCluster = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateDNSZone"u8))
                {
                    privateDnsZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enablePrivateClusterPublicFQDN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePrivateClusterPublicFQDN = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableRunCommand"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableRunCommand = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterApiServerAccessProfile(
                authorizedIPRanges ?? new ChangeTrackingList<string>(),
                enablePrivateCluster,
                privateDnsZone,
                enablePrivateClusterPublicFQDN,
                disableRunCommand,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthorizedIPRanges), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authorizedIPRanges: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AuthorizedIPRanges))
                {
                    if (AuthorizedIPRanges.Any())
                    {
                        builder.Append("  authorizedIPRanges: ");
                        builder.AppendLine("[");
                        foreach (var item in AuthorizedIPRanges)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnablePrivateCluster), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enablePrivateCluster: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnablePrivateCluster))
                {
                    builder.Append("  enablePrivateCluster: ");
                    var boolValue = EnablePrivateCluster.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateDnsZone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  privateDNSZone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateDnsZone))
                {
                    builder.Append("  privateDNSZone: ");
                    if (PrivateDnsZone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrivateDnsZone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrivateDnsZone}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnablePrivateClusterPublicFqdn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enablePrivateClusterPublicFQDN: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnablePrivateClusterPublicFqdn))
                {
                    builder.Append("  enablePrivateClusterPublicFQDN: ");
                    var boolValue = EnablePrivateClusterPublicFqdn.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisableRunCommand), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  disableRunCommand: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisableRunCommand))
                {
                    builder.Append("  disableRunCommand: ");
                    var boolValue = DisableRunCommand.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedClusterApiServerAccessProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterApiServerAccessProfile IPersistableModel<ManagedClusterApiServerAccessProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterApiServerAccessProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedClusterApiServerAccessProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterApiServerAccessProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterApiServerAccessProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
