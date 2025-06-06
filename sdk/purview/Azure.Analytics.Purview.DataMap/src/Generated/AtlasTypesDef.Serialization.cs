// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasTypesDef : IUtf8JsonSerializable, IJsonModel<AtlasTypesDef>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasTypesDef>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtlasTypesDef>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypesDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasTypesDef)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(BusinessMetadataDefs))
            {
                writer.WritePropertyName("businessMetadataDefs"u8);
                writer.WriteStartArray();
                foreach (var item in BusinessMetadataDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClassificationDefs))
            {
                writer.WritePropertyName("classificationDefs"u8);
                writer.WriteStartArray();
                foreach (var item in ClassificationDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EntityDefs))
            {
                writer.WritePropertyName("entityDefs"u8);
                writer.WriteStartArray();
                foreach (var item in EntityDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnumDefs))
            {
                writer.WritePropertyName("enumDefs"u8);
                writer.WriteStartArray();
                foreach (var item in EnumDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RelationshipDefs))
            {
                writer.WritePropertyName("relationshipDefs"u8);
                writer.WriteStartArray();
                foreach (var item in RelationshipDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StructDefs))
            {
                writer.WritePropertyName("structDefs"u8);
                writer.WriteStartArray();
                foreach (var item in StructDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TermTemplateDefs))
            {
                writer.WritePropertyName("termTemplateDefs"u8);
                writer.WriteStartArray();
                foreach (var item in TermTemplateDefs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        AtlasTypesDef IJsonModel<AtlasTypesDef>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypesDef>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasTypesDef)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasTypesDef(document.RootElement, options);
        }

        internal static AtlasTypesDef DeserializeAtlasTypesDef(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AtlasBusinessMetadataDef> businessMetadataDefs = default;
            IList<AtlasClassificationDef> classificationDefs = default;
            IList<AtlasEntityDef> entityDefs = default;
            IList<AtlasEnumDef> enumDefs = default;
            IList<AtlasRelationshipDef> relationshipDefs = default;
            IList<AtlasStructDef> structDefs = default;
            IList<TermTemplateDef> termTemplateDefs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("businessMetadataDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasBusinessMetadataDef> array = new List<AtlasBusinessMetadataDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasBusinessMetadataDef.DeserializeAtlasBusinessMetadataDef(item, options));
                    }
                    businessMetadataDefs = array;
                    continue;
                }
                if (property.NameEquals("classificationDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasClassificationDef> array = new List<AtlasClassificationDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasClassificationDef.DeserializeAtlasClassificationDef(item, options));
                    }
                    classificationDefs = array;
                    continue;
                }
                if (property.NameEquals("entityDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasEntityDef> array = new List<AtlasEntityDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasEntityDef.DeserializeAtlasEntityDef(item, options));
                    }
                    entityDefs = array;
                    continue;
                }
                if (property.NameEquals("enumDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasEnumDef> array = new List<AtlasEnumDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasEnumDef.DeserializeAtlasEnumDef(item, options));
                    }
                    enumDefs = array;
                    continue;
                }
                if (property.NameEquals("relationshipDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasRelationshipDef> array = new List<AtlasRelationshipDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasRelationshipDef.DeserializeAtlasRelationshipDef(item, options));
                    }
                    relationshipDefs = array;
                    continue;
                }
                if (property.NameEquals("structDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AtlasStructDef> array = new List<AtlasStructDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasStructDef.DeserializeAtlasStructDef(item, options));
                    }
                    structDefs = array;
                    continue;
                }
                if (property.NameEquals("termTemplateDefs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TermTemplateDef> array = new List<TermTemplateDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TermTemplateDef.DeserializeTermTemplateDef(item, options));
                    }
                    termTemplateDefs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AtlasTypesDef(
                businessMetadataDefs ?? new ChangeTrackingList<AtlasBusinessMetadataDef>(),
                classificationDefs ?? new ChangeTrackingList<AtlasClassificationDef>(),
                entityDefs ?? new ChangeTrackingList<AtlasEntityDef>(),
                enumDefs ?? new ChangeTrackingList<AtlasEnumDef>(),
                relationshipDefs ?? new ChangeTrackingList<AtlasRelationshipDef>(),
                structDefs ?? new ChangeTrackingList<AtlasStructDef>(),
                termTemplateDefs ?? new ChangeTrackingList<TermTemplateDef>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasTypesDef>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypesDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAnalyticsPurviewDataMapContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AtlasTypesDef)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasTypesDef IPersistableModel<AtlasTypesDef>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTypesDef>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAtlasTypesDef(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasTypesDef)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasTypesDef>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasTypesDef FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAtlasTypesDef(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
