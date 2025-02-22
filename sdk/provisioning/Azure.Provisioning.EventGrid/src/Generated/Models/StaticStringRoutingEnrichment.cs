// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// The StaticStringRoutingEnrichment.
/// </summary>
public partial class StaticStringRoutingEnrichment : StaticRoutingEnrichment
{
    /// <summary>
    /// String type routing enrichment value.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// Creates a new StaticStringRoutingEnrichment.
    /// </summary>
    public StaticStringRoutingEnrichment() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// StaticStringRoutingEnrichment.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("valueType", ["valueType"], defaultValue: "String");
        _value = DefineProperty<string>("Value", ["value"]);
    }
}
