// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    public partial class CosmosDBForPostgreSqlPrivateLinkResource : IJsonModel<CosmosDBForPostgreSqlPrivateLinkResourceData>
    {
        void IJsonModel<CosmosDBForPostgreSqlPrivateLinkResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBForPostgreSqlPrivateLinkResourceData>)Data).Write(writer, options);

        CosmosDBForPostgreSqlPrivateLinkResourceData IJsonModel<CosmosDBForPostgreSqlPrivateLinkResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBForPostgreSqlPrivateLinkResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBForPostgreSqlPrivateLinkResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<CosmosDBForPostgreSqlPrivateLinkResourceData>(Data, options, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);

        CosmosDBForPostgreSqlPrivateLinkResourceData IPersistableModel<CosmosDBForPostgreSqlPrivateLinkResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBForPostgreSqlPrivateLinkResourceData>(data, options, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);

        string IPersistableModel<CosmosDBForPostgreSqlPrivateLinkResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBForPostgreSqlPrivateLinkResourceData>)Data).GetFormatFromOptions(options);
    }
}
