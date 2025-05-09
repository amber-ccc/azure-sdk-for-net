// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsTableResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TablesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/TablesGet.json
            // this example is just showing the usage of "Tables_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsTableResource created on azure
            // for more information of creating OperationalInsightsTableResource, please refer to the document of OperationalInsightsTableResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            string tableName = "table1_SRCH";
            ResourceIdentifier operationalInsightsTableResourceId = OperationalInsightsTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, tableName);
            OperationalInsightsTableResource operationalInsightsTable = client.GetOperationalInsightsTableResource(operationalInsightsTableResourceId);

            // invoke the operation
            OperationalInsightsTableResource result = await operationalInsightsTable.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_TablesDelete()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/TablesDelete.json
            // this example is just showing the usage of "Tables_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsTableResource created on azure
            // for more information of creating OperationalInsightsTableResource, please refer to the document of OperationalInsightsTableResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            string tableName = "table1_CL";
            ResourceIdentifier operationalInsightsTableResourceId = OperationalInsightsTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, tableName);
            OperationalInsightsTableResource operationalInsightsTable = client.GetOperationalInsightsTableResource(operationalInsightsTableResourceId);

            // invoke the operation
            await operationalInsightsTable.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_TablesUpsert()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/TablesUpsert.json
            // this example is just showing the usage of "Tables_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsTableResource created on azure
            // for more information of creating OperationalInsightsTableResource, please refer to the document of OperationalInsightsTableResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            string tableName = "AzureNetworkFlow";
            ResourceIdentifier operationalInsightsTableResourceId = OperationalInsightsTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, tableName);
            OperationalInsightsTableResource operationalInsightsTable = client.GetOperationalInsightsTableResource(operationalInsightsTableResourceId);

            // invoke the operation
            OperationalInsightsTableData data = new OperationalInsightsTableData
            {
                RetentionInDays = 45,
                TotalRetentionInDays = 70,
                Schema = new OperationalInsightsSchema
                {
                    Name = "AzureNetworkFlow",
                    Columns = {new OperationalInsightsColumn
{
Name = "MyNewColumn",
ColumnType = OperationalInsightsColumnType.Guid,
}},
                },
            };
            ArmOperation<OperationalInsightsTableResource> lro = await operationalInsightsTable.UpdateAsync(WaitUntil.Completed, data);
            OperationalInsightsTableResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsTableData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Migrate_TablesMigrate()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/TablesMigrate.json
            // this example is just showing the usage of "Tables_Migrate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsTableResource created on azure
            // for more information of creating OperationalInsightsTableResource, please refer to the document of OperationalInsightsTableResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            string tableName = "table1_CL";
            ResourceIdentifier operationalInsightsTableResourceId = OperationalInsightsTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, tableName);
            OperationalInsightsTableResource operationalInsightsTable = client.GetOperationalInsightsTableResource(operationalInsightsTableResourceId);

            // invoke the operation
            await operationalInsightsTable.MigrateAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CancelSearch_TablesSearchCancel()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2025-02-01/examples/TablesSearchCancel.json
            // this example is just showing the usage of "Tables_CancelSearch" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsTableResource created on azure
            // for more information of creating OperationalInsightsTableResource, please refer to the document of OperationalInsightsTableResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            string workspaceName = "oiautorest6685";
            string tableName = "table1_SRCH";
            ResourceIdentifier operationalInsightsTableResourceId = OperationalInsightsTableResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, tableName);
            OperationalInsightsTableResource operationalInsightsTable = client.GetOperationalInsightsTableResource(operationalInsightsTableResourceId);

            // invoke the operation
            await operationalInsightsTable.CancelSearchAsync();

            Console.WriteLine("Succeeded");
        }
    }
}
