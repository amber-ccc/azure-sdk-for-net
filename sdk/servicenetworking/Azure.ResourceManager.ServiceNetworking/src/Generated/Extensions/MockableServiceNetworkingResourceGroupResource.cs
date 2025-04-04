// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ServiceNetworking.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableServiceNetworkingResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableServiceNetworkingResourceGroupResource"/> class for mocking. </summary>
        protected MockableServiceNetworkingResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceNetworkingResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceNetworkingResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of TrafficControllerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of TrafficControllerResources and their operations over a TrafficControllerResource. </returns>
        public virtual TrafficControllerCollection GetTrafficControllers()
        {
            return GetCachedClient(client => new TrafficControllerCollection(client, Id));
        }

        /// <summary>
        /// Get a TrafficController
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficController_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trafficControllerName"> traffic controller name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trafficControllerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trafficControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TrafficControllerResource>> GetTrafficControllerAsync(string trafficControllerName, CancellationToken cancellationToken = default)
        {
            return await GetTrafficControllers().GetAsync(trafficControllerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a TrafficController
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceNetworking/trafficControllers/{trafficControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrafficController_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficControllerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trafficControllerName"> traffic controller name for path. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trafficControllerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trafficControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TrafficControllerResource> GetTrafficController(string trafficControllerName, CancellationToken cancellationToken = default)
        {
            return GetTrafficControllers().Get(trafficControllerName, cancellationToken);
        }
    }
}
