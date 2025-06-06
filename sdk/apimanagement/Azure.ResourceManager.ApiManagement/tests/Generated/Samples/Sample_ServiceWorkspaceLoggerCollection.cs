// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceLoggerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceAILogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceAILogger.json
            // this example is just showing the usage of "WorkspaceLogger_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceLoggerResource
            ServiceWorkspaceLoggerCollection collection = workspaceContract.GetServiceWorkspaceLoggers();

            // invoke the operation
            string loggerId = "loggerId";
            ApiManagementLoggerData data = new ApiManagementLoggerData
            {
                LoggerType = LoggerType.ApplicationInsights,
                Description = "adding a new logger",
                Credentials =
{
["instrumentationKey"] = "11................a1"
},
            };
            ArmOperation<ServiceWorkspaceLoggerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, loggerId, data);
            ServiceWorkspaceLoggerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementLoggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceEHLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceEHLogger.json
            // this example is just showing the usage of "WorkspaceLogger_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceLoggerResource
            ServiceWorkspaceLoggerCollection collection = workspaceContract.GetServiceWorkspaceLoggers();

            // invoke the operation
            string loggerId = "eh1";
            ApiManagementLoggerData data = new ApiManagementLoggerData
            {
                LoggerType = LoggerType.AzureEventHub,
                Description = "adding a new logger",
                Credentials =
{
["name"] = "hydraeventhub",
["connectionString"] = "Endpoint=sb://hydraeventhub-ns.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=********="
},
            };
            ArmOperation<ServiceWorkspaceLoggerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, loggerId, data);
            ServiceWorkspaceLoggerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementLoggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceLogger.json
            // this example is just showing the usage of "WorkspaceLogger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceLoggerResource
            ServiceWorkspaceLoggerCollection collection = workspaceContract.GetServiceWorkspaceLoggers();

            // invoke the operation
            string loggerId = "templateLogger";
            ServiceWorkspaceLoggerResource result = await collection.GetAsync(loggerId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementLoggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListWorkspaceLoggers()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListWorkspaceLoggers.json
            // this example is just showing the usage of "WorkspaceLogger_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceLoggerResource
            ServiceWorkspaceLoggerCollection collection = workspaceContract.GetServiceWorkspaceLoggers();

            // invoke the operation and iterate over the result
            await foreach (ServiceWorkspaceLoggerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementLoggerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetWorkspaceLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceLogger.json
            // this example is just showing the usage of "WorkspaceLogger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceLoggerResource
            ServiceWorkspaceLoggerCollection collection = workspaceContract.GetServiceWorkspaceLoggers();

            // invoke the operation
            string loggerId = "templateLogger";
            bool result = await collection.ExistsAsync(loggerId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetWorkspaceLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceLogger.json
            // this example is just showing the usage of "WorkspaceLogger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceLoggerResource
            ServiceWorkspaceLoggerCollection collection = workspaceContract.GetServiceWorkspaceLoggers();

            // invoke the operation
            string loggerId = "templateLogger";
            NullableResponse<ServiceWorkspaceLoggerResource> response = await collection.GetIfExistsAsync(loggerId);
            ServiceWorkspaceLoggerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementLoggerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
