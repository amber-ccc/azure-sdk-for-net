// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OnlineExperimentation.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.OnlineExperimentation.Samples
{
    public partial class Sample_OnlineExperimentationWorkspaceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAnOnlineExperimentationWorkspaceWithFreeSku()
        {
            // Generated from example definition: 2025-05-31-preview/OnlineExperimentationWorkspaces_CreateOrUpdate.json
            // this example is just showing the usage of "OnlineExperimentationWorkspace_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa5fc227-a624-475e-b696-cdd604c735bc";
            string resourceGroupName = "res9871";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OnlineExperimentationWorkspaceResource
            OnlineExperimentationWorkspaceCollection collection = resourceGroupResource.GetOnlineExperimentationWorkspaces();

            // invoke the operation
            string workspaceName = "expworkspace7";
            OnlineExperimentationWorkspaceData data = new OnlineExperimentationWorkspaceData(new AzureLocation("eastus2"))
            {
                Properties = new OnlineExperimentationWorkspaceProperties(new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/res9871/providers/Microsoft.OperationalInsights/workspaces/log9871"), new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/res9871/providers/Microsoft.Storage/storageAccounts/sto9871"), new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/res9871/providers/Microsoft.AppConfiguration/configurationStores/appconfig9871")),
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/eu2cgroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1")] = new UserAssignedIdentity(),
[new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/eu2cgroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id2")] = new UserAssignedIdentity()
},
                },
                Sku = new OnlineExperimentationWorkspaceSku(OnlineExperimentationWorkspaceSkuName.F0),
                Tags =
{
["newKey"] = "newVal"
},
            };
            ArmOperation<OnlineExperimentationWorkspaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceName, data);
            OnlineExperimentationWorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OnlineExperimentationWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAnOnlineExperimentationWorkspaceWithFreeSkuAndCustomerManagedKey()
        {
            // Generated from example definition: 2025-05-31-preview/OnlineExperimentationWorkspaces_CreateOrUpdateWithEncryption.json
            // this example is just showing the usage of "OnlineExperimentationWorkspace_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa5fc227-a624-475e-b696-cdd604c735bc";
            string resourceGroupName = "res9871";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OnlineExperimentationWorkspaceResource
            OnlineExperimentationWorkspaceCollection collection = resourceGroupResource.GetOnlineExperimentationWorkspaces();

            // invoke the operation
            string workspaceName = "expworkspace7";
            OnlineExperimentationWorkspaceData data = new OnlineExperimentationWorkspaceData(new AzureLocation("eastus2"))
            {
                Properties = new OnlineExperimentationWorkspaceProperties(new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/res9871/providers/Microsoft.OperationalInsights/workspaces/log9871"), new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/res9871/providers/Microsoft.Storage/storageAccounts/sto9871"), new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/res9871/providers/Microsoft.AppConfiguration/configurationStores/appconfig9871"))
                {
                    CustomerManagedKeyEncryption = new CustomerManagedKeyEncryption
                    {
                        KeyEncryptionKeyIdentity = new KeyEncryptionKeyIdentity
                        {
                            IdentityType = KeyEncryptionKeyIdentityType.UserAssignedIdentity,
                            UserAssignedIdentityResourceId = new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/eu2cgroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1"),
                        },
                        KeyEncryptionKeyUri = new Uri("https://contosovault.vault.azure.net/keys/contosokek"),
                    },
                },
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/eu2cgroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1")] = new UserAssignedIdentity(),
[new ResourceIdentifier("/subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/eu2cgroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id2")] = new UserAssignedIdentity()
},
                },
                Sku = new OnlineExperimentationWorkspaceSku(OnlineExperimentationWorkspaceSkuName.F0),
                Tags =
{
["newKey"] = "newVal"
},
            };
            ArmOperation<OnlineExperimentationWorkspaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceName, data);
            OnlineExperimentationWorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OnlineExperimentationWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetASingleOnlineExperimentationWorkspace()
        {
            // Generated from example definition: 2025-05-31-preview/OnlineExperimentationWorkspaces_Get.json
            // this example is just showing the usage of "OnlineExperimentationWorkspace_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa5fc227-a624-475e-b696-cdd604c735bc";
            string resourceGroupName = "res9871";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OnlineExperimentationWorkspaceResource
            OnlineExperimentationWorkspaceCollection collection = resourceGroupResource.GetOnlineExperimentationWorkspaces();

            // invoke the operation
            string workspaceName = "expworkspace3";
            OnlineExperimentationWorkspaceResource result = await collection.GetAsync(workspaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OnlineExperimentationWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListOnlineExperimentationWorkspacesInAResourceGroup()
        {
            // Generated from example definition: 2025-05-31-preview/OnlineExperimentationWorkspaces_ListByResourceGroup.json
            // this example is just showing the usage of "OnlineExperimentationWorkspace_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa5fc227-a624-475e-b696-cdd604c735bc";
            string resourceGroupName = "res9871";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OnlineExperimentationWorkspaceResource
            OnlineExperimentationWorkspaceCollection collection = resourceGroupResource.GetOnlineExperimentationWorkspaces();

            // invoke the operation and iterate over the result
            await foreach (OnlineExperimentationWorkspaceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OnlineExperimentationWorkspaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetASingleOnlineExperimentationWorkspace()
        {
            // Generated from example definition: 2025-05-31-preview/OnlineExperimentationWorkspaces_Get.json
            // this example is just showing the usage of "OnlineExperimentationWorkspace_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa5fc227-a624-475e-b696-cdd604c735bc";
            string resourceGroupName = "res9871";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OnlineExperimentationWorkspaceResource
            OnlineExperimentationWorkspaceCollection collection = resourceGroupResource.GetOnlineExperimentationWorkspaces();

            // invoke the operation
            string workspaceName = "expworkspace3";
            bool result = await collection.ExistsAsync(workspaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetASingleOnlineExperimentationWorkspace()
        {
            // Generated from example definition: 2025-05-31-preview/OnlineExperimentationWorkspaces_Get.json
            // this example is just showing the usage of "OnlineExperimentationWorkspace_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa5fc227-a624-475e-b696-cdd604c735bc";
            string resourceGroupName = "res9871";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OnlineExperimentationWorkspaceResource
            OnlineExperimentationWorkspaceCollection collection = resourceGroupResource.GetOnlineExperimentationWorkspaces();

            // invoke the operation
            string workspaceName = "expworkspace3";
            NullableResponse<OnlineExperimentationWorkspaceResource> response = await collection.GetIfExistsAsync(workspaceName);
            OnlineExperimentationWorkspaceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OnlineExperimentationWorkspaceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
