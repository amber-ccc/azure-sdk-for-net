// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class HubPublicIPAddresses : IUtf8JsonSerializable, IJsonModel<HubPublicIPAddresses>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HubPublicIPAddresses>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HubPublicIPAddresses>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubPublicIPAddresses>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubPublicIPAddresses)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Addresses))
            {
                writer.WritePropertyName("addresses"u8);
                writer.WriteStartArray();
                foreach (var item in Addresses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
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

        HubPublicIPAddresses IJsonModel<HubPublicIPAddresses>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubPublicIPAddresses>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubPublicIPAddresses)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHubPublicIPAddresses(document.RootElement, options);
        }

        internal static HubPublicIPAddresses DeserializeHubPublicIPAddresses(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AzureFirewallPublicIPAddress> addresses = default;
            int? count = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureFirewallPublicIPAddress> array = new List<AzureFirewallPublicIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureFirewallPublicIPAddress.DeserializeAzureFirewallPublicIPAddress(item, options));
                    }
                    addresses = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HubPublicIPAddresses(addresses ?? new ChangeTrackingList<AzureFirewallPublicIPAddress>(), count, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HubPublicIPAddresses>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubPublicIPAddresses>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(HubPublicIPAddresses)} does not support writing '{options.Format}' format.");
            }
        }

        HubPublicIPAddresses IPersistableModel<HubPublicIPAddresses>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubPublicIPAddresses>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHubPublicIPAddresses(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HubPublicIPAddresses)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HubPublicIPAddresses>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
