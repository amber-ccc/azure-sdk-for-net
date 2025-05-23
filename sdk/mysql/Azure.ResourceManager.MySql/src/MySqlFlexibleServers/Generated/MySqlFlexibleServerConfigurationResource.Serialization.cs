// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerConfigurationResource : IJsonModel<MySqlFlexibleServerConfigurationData>
    {
        void IJsonModel<MySqlFlexibleServerConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MySqlFlexibleServerConfigurationData>)Data).Write(writer, options);

        MySqlFlexibleServerConfigurationData IJsonModel<MySqlFlexibleServerConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MySqlFlexibleServerConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MySqlFlexibleServerConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MySqlFlexibleServerConfigurationData>(Data, options, AzureResourceManagerMySqlContext.Default);

        MySqlFlexibleServerConfigurationData IPersistableModel<MySqlFlexibleServerConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MySqlFlexibleServerConfigurationData>(data, options, AzureResourceManagerMySqlContext.Default);

        string IPersistableModel<MySqlFlexibleServerConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MySqlFlexibleServerConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
