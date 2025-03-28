// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkConnectionComputeConverter))]
    public partial class LinkConnectionCompute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CoreCount))
            {
                writer.WritePropertyName("coreCount"u8);
                writer.WriteNumberValue(CoreCount.Value);
            }
            if (Optional.IsDefined(ComputeType))
            {
                writer.WritePropertyName("computeType"u8);
                writer.WriteStringValue(ComputeType);
            }
            if (Optional.IsDefined(DataProcessIntervalMinutes))
            {
                writer.WritePropertyName("dataProcessIntervalMinutes"u8);
                writer.WriteNumberValue(DataProcessIntervalMinutes.Value);
            }
            writer.WriteEndObject();
        }

        internal static LinkConnectionCompute DeserializeLinkConnectionCompute(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? coreCount = default;
            string computeType = default;
            int? dataProcessIntervalMinutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("computeType"u8))
                {
                    computeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataProcessIntervalMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataProcessIntervalMinutes = property.Value.GetInt32();
                    continue;
                }
            }
            return new LinkConnectionCompute(coreCount, computeType, dataProcessIntervalMinutes);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LinkConnectionCompute FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLinkConnectionCompute(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class LinkConnectionComputeConverter : JsonConverter<LinkConnectionCompute>
        {
            public override void Write(Utf8JsonWriter writer, LinkConnectionCompute model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override LinkConnectionCompute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkConnectionCompute(document.RootElement);
            }
        }
    }
}
