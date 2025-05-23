// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Elastic
{
    public partial class ElasticTagRuleResource : IJsonModel<ElasticTagRuleData>
    {
        void IJsonModel<ElasticTagRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ElasticTagRuleData>)Data).Write(writer, options);

        ElasticTagRuleData IJsonModel<ElasticTagRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ElasticTagRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ElasticTagRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ElasticTagRuleData>(Data, options, AzureResourceManagerElasticContext.Default);

        ElasticTagRuleData IPersistableModel<ElasticTagRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ElasticTagRuleData>(data, options, AzureResourceManagerElasticContext.Default);

        string IPersistableModel<ElasticTagRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ElasticTagRuleData>)Data).GetFormatFromOptions(options);
    }
}
