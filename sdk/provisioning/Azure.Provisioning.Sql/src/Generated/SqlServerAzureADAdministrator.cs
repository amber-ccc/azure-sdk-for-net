// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerAzureADAdministrator.
/// </summary>
public partial class SqlServerAzureADAdministrator : ProvisionableResource
{
    private BicepValue<string>? _name;

    /// <summary>
    /// Type of the sever administrator.
    /// </summary>
    public BicepValue<SqlAdministratorType> AdministratorType 
    {
        get { Initialize(); return _administratorType!; }
        set { Initialize(); _administratorType!.Assign(value); }
    }
    private BicepValue<SqlAdministratorType>? _administratorType;

    /// <summary>
    /// Login name of the server administrator.
    /// </summary>
    public BicepValue<string> Login 
    {
        get { Initialize(); return _login!; }
        set { Initialize(); _login!.Assign(value); }
    }
    private BicepValue<string>? _login;

    /// <summary>
    /// SID (object ID) of the server administrator.
    /// </summary>
    public BicepValue<Guid> Sid 
    {
        get { Initialize(); return _sid!; }
        set { Initialize(); _sid!.Assign(value); }
    }
    private BicepValue<Guid>? _sid;

    /// <summary>
    /// Tenant ID of the administrator.
    /// </summary>
    public BicepValue<Guid> TenantId 
    {
        get { Initialize(); return _tenantId!; }
        set { Initialize(); _tenantId!.Assign(value); }
    }
    private BicepValue<Guid>? _tenantId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Azure Active Directory only Authentication enabled.
    /// </summary>
    public BicepValue<bool> IsAzureADOnlyAuthenticationEnabled 
    {
        get { Initialize(); return _isAzureADOnlyAuthenticationEnabled!; }
    }
    private BicepValue<bool>? _isAzureADOnlyAuthenticationEnabled;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServer.
    /// </summary>
    public SqlServer? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlServer>? _parent;

    /// <summary>
    /// Get the default value for the Name property.
    /// </summary>
    private partial BicepValue<string> GetNameDefaultValue();

    /// <summary>
    /// Creates a new SqlServerAzureADAdministrator.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerAzureADAdministrator
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerAzureADAdministrator.</param>
    public SqlServerAzureADAdministrator(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/administrators", resourceVersion ?? "2021-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SqlServerAzureADAdministrator.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true, defaultValue: GetNameDefaultValue());
        _administratorType = DefineProperty<SqlAdministratorType>("AdministratorType", ["properties", "administratorType"]);
        _login = DefineProperty<string>("Login", ["properties", "login"]);
        _sid = DefineProperty<Guid>("Sid", ["properties", "sid"]);
        _tenantId = DefineProperty<Guid>("TenantId", ["properties", "tenantId"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _isAzureADOnlyAuthenticationEnabled = DefineProperty<bool>("IsAzureADOnlyAuthenticationEnabled", ["properties", "azureADOnlyAuthentication"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlServer>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerAzureADAdministrator resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlServerAzureADAdministrator.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlServerAzureADAdministrator
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlServerAzureADAdministrator.</param>
    /// <returns>The existing SqlServerAzureADAdministrator resource.</returns>
    public static SqlServerAzureADAdministrator FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
