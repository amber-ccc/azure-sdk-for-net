// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Migration.Assessment.Samples
{
    public partial class Sample_MigrationAssessmentProjectSummaryResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AssessmentProjectSummaryOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/AssessmentProjectSummaryOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "AssessmentProjectSummaryOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentProjectSummaryResource created on azure
            // for more information of creating MigrationAssessmentProjectSummaryResource, please refer to the document of MigrationAssessmentProjectSummaryResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "piyushapp1";
            string projectName = "PiyushApp15328project";
            string projectSummaryName = "default";
            ResourceIdentifier migrationAssessmentProjectSummaryResourceId = MigrationAssessmentProjectSummaryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, projectSummaryName);
            MigrationAssessmentProjectSummaryResource migrationAssessmentProjectSummary = client.GetMigrationAssessmentProjectSummaryResource(migrationAssessmentProjectSummaryResourceId);

            // invoke the operation
            MigrationAssessmentProjectSummaryResource result = await migrationAssessmentProjectSummary.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationAssessmentProjectSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
