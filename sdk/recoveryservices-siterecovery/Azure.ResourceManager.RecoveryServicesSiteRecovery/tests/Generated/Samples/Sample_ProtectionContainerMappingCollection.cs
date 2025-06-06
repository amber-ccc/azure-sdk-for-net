// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_ProtectionContainerMappingCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAProtectionContainerMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2025-01-01/examples/ReplicationProtectionContainerMappings_Get.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryProtectionContainerResource created on azure
            // for more information of creating SiteRecoveryProtectionContainerResource, please refer to the document of SiteRecoveryProtectionContainerResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            ResourceIdentifier siteRecoveryProtectionContainerResourceId = SiteRecoveryProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName);
            SiteRecoveryProtectionContainerResource siteRecoveryProtectionContainer = client.GetSiteRecoveryProtectionContainerResource(siteRecoveryProtectionContainerResourceId);

            // get the collection of this ProtectionContainerMappingResource
            ProtectionContainerMappingCollection collection = siteRecoveryProtectionContainer.GetProtectionContainerMappings();

            // invoke the operation
            string mappingName = "cloud1protectionprofile1";
            ProtectionContainerMappingResource result = await collection.GetAsync(mappingName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProtectionContainerMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsTheListOfProtectionContainerMappingsForAProtectionContainer()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2025-01-01/examples/ReplicationProtectionContainerMappings_ListByReplicationProtectionContainers.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_ListByReplicationProtectionContainers" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryProtectionContainerResource created on azure
            // for more information of creating SiteRecoveryProtectionContainerResource, please refer to the document of SiteRecoveryProtectionContainerResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            ResourceIdentifier siteRecoveryProtectionContainerResourceId = SiteRecoveryProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName);
            SiteRecoveryProtectionContainerResource siteRecoveryProtectionContainer = client.GetSiteRecoveryProtectionContainerResource(siteRecoveryProtectionContainerResourceId);

            // get the collection of this ProtectionContainerMappingResource
            ProtectionContainerMappingCollection collection = siteRecoveryProtectionContainer.GetProtectionContainerMappings();

            // invoke the operation and iterate over the result
            await foreach (ProtectionContainerMappingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProtectionContainerMappingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsAProtectionContainerMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2025-01-01/examples/ReplicationProtectionContainerMappings_Get.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryProtectionContainerResource created on azure
            // for more information of creating SiteRecoveryProtectionContainerResource, please refer to the document of SiteRecoveryProtectionContainerResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            ResourceIdentifier siteRecoveryProtectionContainerResourceId = SiteRecoveryProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName);
            SiteRecoveryProtectionContainerResource siteRecoveryProtectionContainer = client.GetSiteRecoveryProtectionContainerResource(siteRecoveryProtectionContainerResourceId);

            // get the collection of this ProtectionContainerMappingResource
            ProtectionContainerMappingCollection collection = siteRecoveryProtectionContainer.GetProtectionContainerMappings();

            // invoke the operation
            string mappingName = "cloud1protectionprofile1";
            bool result = await collection.ExistsAsync(mappingName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsAProtectionContainerMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2025-01-01/examples/ReplicationProtectionContainerMappings_Get.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryProtectionContainerResource created on azure
            // for more information of creating SiteRecoveryProtectionContainerResource, please refer to the document of SiteRecoveryProtectionContainerResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            ResourceIdentifier siteRecoveryProtectionContainerResourceId = SiteRecoveryProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName);
            SiteRecoveryProtectionContainerResource siteRecoveryProtectionContainer = client.GetSiteRecoveryProtectionContainerResource(siteRecoveryProtectionContainerResourceId);

            // get the collection of this ProtectionContainerMappingResource
            ProtectionContainerMappingCollection collection = siteRecoveryProtectionContainer.GetProtectionContainerMappings();

            // invoke the operation
            string mappingName = "cloud1protectionprofile1";
            NullableResponse<ProtectionContainerMappingResource> response = await collection.GetIfExistsAsync(mappingName);
            ProtectionContainerMappingResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProtectionContainerMappingData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
