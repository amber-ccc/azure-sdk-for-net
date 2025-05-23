// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DnsResolver
{
    public partial class DnsResolverPolicyVirtualNetworkLinkResource : IJsonModel<DnsResolverPolicyVirtualNetworkLinkData>
    {
        void IJsonModel<DnsResolverPolicyVirtualNetworkLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DnsResolverPolicyVirtualNetworkLinkData>)Data).Write(writer, options);

        DnsResolverPolicyVirtualNetworkLinkData IJsonModel<DnsResolverPolicyVirtualNetworkLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DnsResolverPolicyVirtualNetworkLinkData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DnsResolverPolicyVirtualNetworkLinkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DnsResolverPolicyVirtualNetworkLinkData>(Data, options, AzureResourceManagerDnsResolverContext.Default);

        DnsResolverPolicyVirtualNetworkLinkData IPersistableModel<DnsResolverPolicyVirtualNetworkLinkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DnsResolverPolicyVirtualNetworkLinkData>(data, options, AzureResourceManagerDnsResolverContext.Default);

        string IPersistableModel<DnsResolverPolicyVirtualNetworkLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DnsResolverPolicyVirtualNetworkLinkData>)Data).GetFormatFromOptions(options);
    }
}
