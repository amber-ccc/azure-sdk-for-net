// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterServerCertificateCommonName : IUtf8JsonSerializable, IJsonModel<ClusterServerCertificateCommonName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterServerCertificateCommonName>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterServerCertificateCommonName>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterServerCertificateCommonName)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("certificateCommonName"u8);
            writer.WriteStringValue(CertificateCommonName);
            writer.WritePropertyName("certificateIssuerThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CertificateIssuerThumbprint);
#else
            using (JsonDocument document = JsonDocument.Parse(CertificateIssuerThumbprint, ModelSerializationExtensions.JsonDocumentOptions))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
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

        ClusterServerCertificateCommonName IJsonModel<ClusterServerCertificateCommonName>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterServerCertificateCommonName)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterServerCertificateCommonName(document.RootElement, options);
        }

        internal static ClusterServerCertificateCommonName DeserializeClusterServerCertificateCommonName(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string certificateCommonName = default;
            BinaryData certificateIssuerThumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateCommonName"u8))
                {
                    certificateCommonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateIssuerThumbprint"u8))
                {
                    certificateIssuerThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterServerCertificateCommonName(certificateCommonName, certificateIssuerThumbprint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterServerCertificateCommonName>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerServiceFabricContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ClusterServerCertificateCommonName)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterServerCertificateCommonName IPersistableModel<ClusterServerCertificateCommonName>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServerCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClusterServerCertificateCommonName(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterServerCertificateCommonName)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterServerCertificateCommonName>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
