// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceServerTrustCertificateResource : IJsonModel<ServerTrustCertificateData>
    {
        void IJsonModel<ServerTrustCertificateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServerTrustCertificateData>)Data).Write(writer, options);

        ServerTrustCertificateData IJsonModel<ServerTrustCertificateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServerTrustCertificateData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServerTrustCertificateData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ServerTrustCertificateData>(Data, options, AzureResourceManagerSqlContext.Default);

        ServerTrustCertificateData IPersistableModel<ServerTrustCertificateData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServerTrustCertificateData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<ServerTrustCertificateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServerTrustCertificateData>)Data).GetFormatFromOptions(options);
    }
}
