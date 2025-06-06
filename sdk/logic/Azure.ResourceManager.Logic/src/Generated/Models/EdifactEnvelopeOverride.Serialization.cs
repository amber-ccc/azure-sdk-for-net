// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactEnvelopeOverride : IUtf8JsonSerializable, IJsonModel<EdifactEnvelopeOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdifactEnvelopeOverride>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdifactEnvelopeOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactEnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactEnvelopeOverride)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            if (Optional.IsDefined(MessageVersion))
            {
                writer.WritePropertyName("messageVersion"u8);
                writer.WriteStringValue(MessageVersion);
            }
            if (Optional.IsDefined(MessageRelease))
            {
                writer.WritePropertyName("messageRelease"u8);
                writer.WriteStringValue(MessageRelease);
            }
            if (Optional.IsDefined(MessageAssociationAssignedCode))
            {
                writer.WritePropertyName("messageAssociationAssignedCode"u8);
                writer.WriteStringValue(MessageAssociationAssignedCode);
            }
            if (Optional.IsDefined(TargetNamespace))
            {
                writer.WritePropertyName("targetNamespace"u8);
                writer.WriteStringValue(TargetNamespace);
            }
            if (Optional.IsDefined(FunctionalGroupId))
            {
                writer.WritePropertyName("functionalGroupId"u8);
                writer.WriteStringValue(FunctionalGroupId);
            }
            if (Optional.IsDefined(SenderApplicationQualifier))
            {
                writer.WritePropertyName("senderApplicationQualifier"u8);
                writer.WriteStringValue(SenderApplicationQualifier);
            }
            if (Optional.IsDefined(SenderApplicationId))
            {
                writer.WritePropertyName("senderApplicationId"u8);
                writer.WriteStringValue(SenderApplicationId);
            }
            if (Optional.IsDefined(ReceiverApplicationQualifier))
            {
                writer.WritePropertyName("receiverApplicationQualifier"u8);
                writer.WriteStringValue(ReceiverApplicationQualifier);
            }
            if (Optional.IsDefined(ReceiverApplicationId))
            {
                writer.WritePropertyName("receiverApplicationId"u8);
                writer.WriteStringValue(ReceiverApplicationId);
            }
            if (Optional.IsDefined(ControllingAgencyCode))
            {
                writer.WritePropertyName("controllingAgencyCode"u8);
                writer.WriteStringValue(ControllingAgencyCode);
            }
            if (Optional.IsDefined(GroupHeaderMessageVersion))
            {
                writer.WritePropertyName("groupHeaderMessageVersion"u8);
                writer.WriteStringValue(GroupHeaderMessageVersion);
            }
            if (Optional.IsDefined(GroupHeaderMessageRelease))
            {
                writer.WritePropertyName("groupHeaderMessageRelease"u8);
                writer.WriteStringValue(GroupHeaderMessageRelease);
            }
            if (Optional.IsDefined(AssociationAssignedCode))
            {
                writer.WritePropertyName("associationAssignedCode"u8);
                writer.WriteStringValue(AssociationAssignedCode);
            }
            if (Optional.IsDefined(ApplicationPassword))
            {
                writer.WritePropertyName("applicationPassword"u8);
                writer.WriteStringValue(ApplicationPassword);
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

        EdifactEnvelopeOverride IJsonModel<EdifactEnvelopeOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactEnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactEnvelopeOverride)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactEnvelopeOverride(document.RootElement, options);
        }

        internal static EdifactEnvelopeOverride DeserializeEdifactEnvelopeOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageId = default;
            string messageVersion = default;
            string messageRelease = default;
            string messageAssociationAssignedCode = default;
            string targetNamespace = default;
            string functionalGroupId = default;
            string senderApplicationQualifier = default;
            string senderApplicationId = default;
            string receiverApplicationQualifier = default;
            string receiverApplicationId = default;
            string controllingAgencyCode = default;
            string groupHeaderMessageVersion = default;
            string groupHeaderMessageRelease = default;
            string associationAssignedCode = default;
            string applicationPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageVersion"u8))
                {
                    messageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageRelease"u8))
                {
                    messageRelease = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageAssociationAssignedCode"u8))
                {
                    messageAssociationAssignedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetNamespace"u8))
                {
                    targetNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionalGroupId"u8))
                {
                    functionalGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderApplicationQualifier"u8))
                {
                    senderApplicationQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderApplicationId"u8))
                {
                    senderApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverApplicationQualifier"u8))
                {
                    receiverApplicationQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverApplicationId"u8))
                {
                    receiverApplicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controllingAgencyCode"u8))
                {
                    controllingAgencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupHeaderMessageVersion"u8))
                {
                    groupHeaderMessageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupHeaderMessageRelease"u8))
                {
                    groupHeaderMessageRelease = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("associationAssignedCode"u8))
                {
                    associationAssignedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationPassword"u8))
                {
                    applicationPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdifactEnvelopeOverride(
                messageId,
                messageVersion,
                messageRelease,
                messageAssociationAssignedCode,
                targetNamespace,
                functionalGroupId,
                senderApplicationQualifier,
                senderApplicationId,
                receiverApplicationQualifier,
                receiverApplicationId,
                controllingAgencyCode,
                groupHeaderMessageVersion,
                groupHeaderMessageRelease,
                associationAssignedCode,
                applicationPassword,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdifactEnvelopeOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactEnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLogicContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdifactEnvelopeOverride)} does not support writing '{options.Format}' format.");
            }
        }

        EdifactEnvelopeOverride IPersistableModel<EdifactEnvelopeOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactEnvelopeOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdifactEnvelopeOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdifactEnvelopeOverride)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdifactEnvelopeOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
