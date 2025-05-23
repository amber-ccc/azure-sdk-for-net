// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class MabContainer : IUtf8JsonSerializable, IJsonModel<MabContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MabContainer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MabContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MabContainer)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(CanReRegister))
            {
                writer.WritePropertyName("canReRegister"u8);
                writer.WriteBooleanValue(CanReRegister.Value);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteNumberValue(ContainerId.Value);
            }
            if (Optional.IsDefined(ProtectedItemCount))
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo, options);
            }
            if (Optional.IsCollectionDefined(MabContainerHealthDetails))
            {
                writer.WritePropertyName("mabContainerHealthDetails"u8);
                writer.WriteStartArray();
                foreach (var item in MabContainerHealthDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContainerHealthState))
            {
                writer.WritePropertyName("containerHealthState"u8);
                writer.WriteStringValue(ContainerHealthState);
            }
        }

        MabContainer IJsonModel<MabContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MabContainer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMabContainer(document.RootElement, options);
        }

        internal static MabContainer DeserializeMabContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? canReRegister = default;
            long? containerId = default;
            long? protectedItemCount = default;
            string agentVersion = default;
            MabContainerExtendedInfo extendedInfo = default;
            IList<MabContainerHealthDetails> mabContainerHealthDetails = default;
            string containerHealthState = default;
            string friendlyName = default;
            BackupManagementType? backupManagementType = default;
            string registrationStatus = default;
            string healthStatus = default;
            ProtectableContainerType containerType = default;
            string protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canReRegister"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = MabContainerExtendedInfo.DeserializeMabContainerExtendedInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mabContainerHealthDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MabContainerHealthDetails> array = new List<MabContainerHealthDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.MabContainerHealthDetails.DeserializeMabContainerHealthDetails(item, options));
                    }
                    mabContainerHealthDetails = array;
                    continue;
                }
                if (property.NameEquals("containerHealthState"u8))
                {
                    containerHealthState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MabContainer(
                friendlyName,
                backupManagementType,
                registrationStatus,
                healthStatus,
                containerType,
                protectableObjectType,
                serializedAdditionalRawData,
                canReRegister,
                containerId,
                protectedItemCount,
                agentVersion,
                extendedInfo,
                mabContainerHealthDetails ?? new ChangeTrackingList<MabContainerHealthDetails>(),
                containerHealthState);
        }

        BinaryData IPersistableModel<MabContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MabContainer)} does not support writing '{options.Format}' format.");
            }
        }

        MabContainer IPersistableModel<MabContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMabContainer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MabContainer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MabContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
