// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Billing
{
    internal class BillingRoleAssignmentOperationSource : IOperationSource<BillingRoleAssignmentResource>
    {
        private readonly ArmClient _client;

        internal BillingRoleAssignmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        BillingRoleAssignmentResource IOperationSource<BillingRoleAssignmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingRoleAssignmentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerBillingContext.Default);
            return new BillingRoleAssignmentResource(_client, data);
        }

        async ValueTask<BillingRoleAssignmentResource> IOperationSource<BillingRoleAssignmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingRoleAssignmentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerBillingContext.Default);
            return await Task.FromResult(new BillingRoleAssignmentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
