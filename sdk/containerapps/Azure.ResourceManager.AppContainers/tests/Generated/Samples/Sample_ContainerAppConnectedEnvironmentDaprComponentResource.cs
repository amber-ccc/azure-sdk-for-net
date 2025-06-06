// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppContainers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppConnectedEnvironmentDaprComponentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDaprComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ConnectedEnvironmentsDaprComponents_Get.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentDaprComponentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentDaprComponentResource, please refer to the document of ContainerAppConnectedEnvironmentDaprComponentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            string componentName = "reddog";
            ResourceIdentifier containerAppConnectedEnvironmentDaprComponentResourceId = ContainerAppConnectedEnvironmentDaprComponentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, componentName);
            ContainerAppConnectedEnvironmentDaprComponentResource containerAppConnectedEnvironmentDaprComponent = client.GetContainerAppConnectedEnvironmentDaprComponentResource(containerAppConnectedEnvironmentDaprComponentResourceId);

            // invoke the operation
            ContainerAppConnectedEnvironmentDaprComponentResource result = await containerAppConnectedEnvironmentDaprComponent.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppDaprComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteDaprComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ConnectedEnvironmentsDaprComponents_Delete.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentDaprComponentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentDaprComponentResource, please refer to the document of ContainerAppConnectedEnvironmentDaprComponentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            string componentName = "reddog";
            ResourceIdentifier containerAppConnectedEnvironmentDaprComponentResourceId = ContainerAppConnectedEnvironmentDaprComponentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, componentName);
            ContainerAppConnectedEnvironmentDaprComponentResource containerAppConnectedEnvironmentDaprComponent = client.GetContainerAppConnectedEnvironmentDaprComponentResource(containerAppConnectedEnvironmentDaprComponentResourceId);

            // invoke the operation
            await containerAppConnectedEnvironmentDaprComponent.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateDaprComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ConnectedEnvironmentsDaprComponents_CreateOrUpdate.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentDaprComponentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentDaprComponentResource, please refer to the document of ContainerAppConnectedEnvironmentDaprComponentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            string componentName = "reddog";
            ResourceIdentifier containerAppConnectedEnvironmentDaprComponentResourceId = ContainerAppConnectedEnvironmentDaprComponentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, componentName);
            ContainerAppConnectedEnvironmentDaprComponentResource containerAppConnectedEnvironmentDaprComponent = client.GetContainerAppConnectedEnvironmentDaprComponentResource(containerAppConnectedEnvironmentDaprComponentResourceId);

            // invoke the operation
            ContainerAppDaprComponentData data = new ContainerAppDaprComponentData
            {
                ComponentType = "state.azure.cosmosdb",
                Version = "v1",
                IgnoreErrors = false,
                InitTimeout = "50s",
                Secrets = {new ContainerAppWritableSecret
{
Name = "masterkey",
Value = "keyvalue",
}},
                Metadata = {new ContainerAppDaprMetadata
{
Name = "url",
Value = "<COSMOS-URL>",
}, new ContainerAppDaprMetadata
{
Name = "database",
Value = "itemsDB",
}, new ContainerAppDaprMetadata
{
Name = "collection",
Value = "items",
}, new ContainerAppDaprMetadata
{
Name = "masterkey",
SecretRef = "masterkey",
}},
                Scopes = { "container-app-1", "container-app-2" },
            };
            ArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource> lro = await containerAppConnectedEnvironmentDaprComponent.UpdateAsync(WaitUntil.Completed, data);
            ContainerAppConnectedEnvironmentDaprComponentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppDaprComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSecrets_ListContainerAppsSecrets()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2025-01-01/examples/ConnectedEnvironmentsDaprComponents_ListSecrets.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentDaprComponentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentDaprComponentResource, please refer to the document of ContainerAppConnectedEnvironmentDaprComponentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            string componentName = "reddog";
            ResourceIdentifier containerAppConnectedEnvironmentDaprComponentResourceId = ContainerAppConnectedEnvironmentDaprComponentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName, componentName);
            ContainerAppConnectedEnvironmentDaprComponentResource containerAppConnectedEnvironmentDaprComponent = client.GetContainerAppConnectedEnvironmentDaprComponentResource(containerAppConnectedEnvironmentDaprComponentResourceId);

            // invoke the operation and iterate over the result
            await foreach (ContainerAppDaprSecret item in containerAppConnectedEnvironmentDaprComponent.GetSecretsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
