// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ContainerServiceFleet.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    /// <summary>
    /// A Class representing an AutoUpgradeProfile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AutoUpgradeProfileResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAutoUpgradeProfileResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerServiceFleetResource"/> using the GetAutoUpgradeProfile method.
    /// </summary>
    public partial class AutoUpgradeProfileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutoUpgradeProfileResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="fleetName"> The fleetName. </param>
        /// <param name="autoUpgradeProfileName"> The autoUpgradeProfileName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName, string autoUpgradeProfileName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _autoUpgradeProfileClientDiagnostics;
        private readonly AutoUpgradeProfilesRestOperations _autoUpgradeProfileRestClient;
        private readonly ClientDiagnostics _autoUpgradeProfileOperationsClientDiagnostics;
        private readonly AutoUpgradeProfileRestOperations _autoUpgradeProfileOperationsRestClient;
        private readonly AutoUpgradeProfileData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/fleets/autoUpgradeProfiles";

        /// <summary> Initializes a new instance of the <see cref="AutoUpgradeProfileResource"/> class for mocking. </summary>
        protected AutoUpgradeProfileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutoUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutoUpgradeProfileResource(ArmClient client, AutoUpgradeProfileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutoUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutoUpgradeProfileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _autoUpgradeProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerServiceFleet", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string autoUpgradeProfileApiVersion);
            _autoUpgradeProfileRestClient = new AutoUpgradeProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autoUpgradeProfileApiVersion);
            _autoUpgradeProfileOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerServiceFleet", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _autoUpgradeProfileOperationsRestClient = new AutoUpgradeProfileRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutoUpgradeProfileData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a AutoUpgradeProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutoUpgradeProfileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _autoUpgradeProfileClientDiagnostics.CreateScope("AutoUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = await _autoUpgradeProfileRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a AutoUpgradeProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutoUpgradeProfileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _autoUpgradeProfileClientDiagnostics.CreateScope("AutoUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = _autoUpgradeProfileRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a AutoUpgradeProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfiles_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _autoUpgradeProfileClientDiagnostics.CreateScope("AutoUpgradeProfileResource.Delete");
            scope.Start();
            try
            {
                var response = await _autoUpgradeProfileRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation(_autoUpgradeProfileClientDiagnostics, Pipeline, _autoUpgradeProfileRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a AutoUpgradeProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfiles_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _autoUpgradeProfileClientDiagnostics.CreateScope("AutoUpgradeProfileResource.Delete");
            scope.Start();
            try
            {
                var response = _autoUpgradeProfileRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation(_autoUpgradeProfileClientDiagnostics, Pipeline, _autoUpgradeProfileRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a AutoUpgradeProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutoUpgradeProfileResource>> UpdateAsync(WaitUntil waitUntil, AutoUpgradeProfileData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoUpgradeProfileClientDiagnostics.CreateScope("AutoUpgradeProfileResource.Update");
            scope.Start();
            try
            {
                var response = await _autoUpgradeProfileRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation<AutoUpgradeProfileResource>(new AutoUpgradeProfileOperationSource(Client), _autoUpgradeProfileClientDiagnostics, Pipeline, _autoUpgradeProfileRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a AutoUpgradeProfile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AutoUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutoUpgradeProfileResource> Update(WaitUntil waitUntil, AutoUpgradeProfileData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoUpgradeProfileClientDiagnostics.CreateScope("AutoUpgradeProfileResource.Update");
            scope.Start();
            try
            {
                var response = _autoUpgradeProfileRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation<AutoUpgradeProfileResource>(new AutoUpgradeProfileOperationSource(Client), _autoUpgradeProfileClientDiagnostics, Pipeline, _autoUpgradeProfileRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// A long-running resource action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}/generateUpdateRun</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfileOperations_GenerateUpdateRun</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<AutoUpgradeProfileGenerateResult>> GenerateUpdateRunAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _autoUpgradeProfileOperationsClientDiagnostics.CreateScope("AutoUpgradeProfileResource.GenerateUpdateRun");
            scope.Start();
            try
            {
                var response = await _autoUpgradeProfileOperationsRestClient.GenerateUpdateRunAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceFleetArmOperation<AutoUpgradeProfileGenerateResult>(new AutoUpgradeProfileGenerateResultOperationSource(), _autoUpgradeProfileOperationsClientDiagnostics, Pipeline, _autoUpgradeProfileOperationsRestClient.CreateGenerateUpdateRunRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// A long-running resource action.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}/generateUpdateRun</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoUpgradeProfileOperations_GenerateUpdateRun</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<AutoUpgradeProfileGenerateResult> GenerateUpdateRun(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _autoUpgradeProfileOperationsClientDiagnostics.CreateScope("AutoUpgradeProfileResource.GenerateUpdateRun");
            scope.Start();
            try
            {
                var response = _autoUpgradeProfileOperationsRestClient.GenerateUpdateRun(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ContainerServiceFleetArmOperation<AutoUpgradeProfileGenerateResult>(new AutoUpgradeProfileGenerateResultOperationSource(), _autoUpgradeProfileOperationsClientDiagnostics, Pipeline, _autoUpgradeProfileOperationsRestClient.CreateGenerateUpdateRunRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
