// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class AvailabilitySetResource : IJsonModel<AvailabilitySetData>
    {
        void IJsonModel<AvailabilitySetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AvailabilitySetData>)Data).Write(writer, options);

        AvailabilitySetData IJsonModel<AvailabilitySetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AvailabilitySetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AvailabilitySetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AvailabilitySetData>(Data, options, AzureResourceManagerComputeContext.Default);

        AvailabilitySetData IPersistableModel<AvailabilitySetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AvailabilitySetData>(data, options, AzureResourceManagerComputeContext.Default);

        string IPersistableModel<AvailabilitySetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AvailabilitySetData>)Data).GetFormatFromOptions(options);
    }
}
