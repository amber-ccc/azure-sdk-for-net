// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// OperationalInsightsLinkedService.
/// </summary>
public partial class OperationalInsightsLinkedService : ProvisionableResource
{
    /// <summary>
    /// Name of the linkedServices resource.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The provisioning state of the linked service.
    /// </summary>
    public BicepValue<OperationalInsightsLinkedServiceEntityStatus> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
        set { Initialize(); _provisioningState!.Assign(value); }
    }
    private BicepValue<OperationalInsightsLinkedServiceEntityStatus>? _provisioningState;

    /// <summary>
    /// The resource id of the resource that will be linked to the workspace.
    /// This should be used for linking resources which require read access.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId 
    {
        get { Initialize(); return _resourceId!; }
        set { Initialize(); _resourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _resourceId;

    /// <summary>
    /// Resource tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// The resource id of the resource that will be linked to the workspace.
    /// This should be used for linking resources which require write access.
    /// </summary>
    public BicepValue<ResourceIdentifier> WriteAccessResourceId 
    {
        get { Initialize(); return _writeAccessResourceId!; }
        set { Initialize(); _writeAccessResourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _writeAccessResourceId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent OperationalInsightsWorkspace.
    /// </summary>
    public OperationalInsightsWorkspace? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<OperationalInsightsWorkspace>? _parent;

    /// <summary>
    /// Creates a new OperationalInsightsLinkedService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the OperationalInsightsLinkedService
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the OperationalInsightsLinkedService.</param>
    public OperationalInsightsLinkedService(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.OperationalInsights/workspaces/linkedServices", resourceVersion ?? "2023-09-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// OperationalInsightsLinkedService.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _provisioningState = DefineProperty<OperationalInsightsLinkedServiceEntityStatus>("ProvisioningState", ["properties", "provisioningState"]);
        _resourceId = DefineProperty<ResourceIdentifier>("ResourceId", ["properties", "resourceId"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _writeAccessResourceId = DefineProperty<ResourceIdentifier>("WriteAccessResourceId", ["properties", "writeAccessResourceId"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<OperationalInsightsWorkspace>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported OperationalInsightsLinkedService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing OperationalInsightsLinkedService.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the OperationalInsightsLinkedService
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the OperationalInsightsLinkedService.</param>
    /// <returns>The existing OperationalInsightsLinkedService resource.</returns>
    public static OperationalInsightsLinkedService FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
