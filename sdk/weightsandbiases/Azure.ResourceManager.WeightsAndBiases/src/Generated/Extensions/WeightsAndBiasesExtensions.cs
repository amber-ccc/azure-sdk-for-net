// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WeightsAndBiases.Mocking;

namespace Azure.ResourceManager.WeightsAndBiases
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.WeightsAndBiases. </summary>
    public static partial class WeightsAndBiasesExtensions
    {
        private static MockableWeightsAndBiasesArmClient GetMockableWeightsAndBiasesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableWeightsAndBiasesArmClient(client0));
        }

        private static MockableWeightsAndBiasesResourceGroupResource GetMockableWeightsAndBiasesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableWeightsAndBiasesResourceGroupResource(client, resource.Id));
        }

        private static MockableWeightsAndBiasesSubscriptionResource GetMockableWeightsAndBiasesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableWeightsAndBiasesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="WeightsAndBiasesInstanceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WeightsAndBiasesInstanceResource.CreateResourceIdentifier" /> to create a <see cref="WeightsAndBiasesInstanceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWeightsAndBiasesArmClient.GetWeightsAndBiasesInstanceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="WeightsAndBiasesInstanceResource"/> object. </returns>
        public static WeightsAndBiasesInstanceResource GetWeightsAndBiasesInstanceResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableWeightsAndBiasesArmClient(client).GetWeightsAndBiasesInstanceResource(id);
        }

        /// <summary>
        /// Gets a collection of WeightsAndBiasesInstanceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWeightsAndBiasesResourceGroupResource.GetWeightsAndBiasesInstances()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of WeightsAndBiasesInstanceResources and their operations over a WeightsAndBiasesInstanceResource. </returns>
        public static WeightsAndBiasesInstanceCollection GetWeightsAndBiasesInstances(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableWeightsAndBiasesResourceGroupResource(resourceGroupResource).GetWeightsAndBiasesInstances();
        }

        /// <summary>
        /// Get a InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.WeightsAndBiases/instances/{instancename}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WeightsAndBiasesInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWeightsAndBiasesResourceGroupResource.GetWeightsAndBiasesInstanceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="instancename"> Name of the Instance resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="instancename"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="instancename"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<WeightsAndBiasesInstanceResource>> GetWeightsAndBiasesInstanceAsync(this ResourceGroupResource resourceGroupResource, string instancename, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableWeightsAndBiasesResourceGroupResource(resourceGroupResource).GetWeightsAndBiasesInstanceAsync(instancename, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.WeightsAndBiases/instances/{instancename}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WeightsAndBiasesInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWeightsAndBiasesResourceGroupResource.GetWeightsAndBiasesInstance(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="instancename"> Name of the Instance resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="instancename"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="instancename"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<WeightsAndBiasesInstanceResource> GetWeightsAndBiasesInstance(this ResourceGroupResource resourceGroupResource, string instancename, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableWeightsAndBiasesResourceGroupResource(resourceGroupResource).GetWeightsAndBiasesInstance(instancename, cancellationToken);
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.WeightsAndBiases/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WeightsAndBiasesInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWeightsAndBiasesSubscriptionResource.GetWeightsAndBiasesInstances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="WeightsAndBiasesInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<WeightsAndBiasesInstanceResource> GetWeightsAndBiasesInstancesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableWeightsAndBiasesSubscriptionResource(subscriptionResource).GetWeightsAndBiasesInstancesAsync(cancellationToken);
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.WeightsAndBiases/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-18-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WeightsAndBiasesInstanceResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWeightsAndBiasesSubscriptionResource.GetWeightsAndBiasesInstances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="WeightsAndBiasesInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<WeightsAndBiasesInstanceResource> GetWeightsAndBiasesInstances(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableWeightsAndBiasesSubscriptionResource(subscriptionResource).GetWeightsAndBiasesInstances(cancellationToken);
        }
    }
}
