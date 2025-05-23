// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The provisioning state of the cluster replication. </summary>
    public readonly partial struct OperationalInsightsClusterReplicationState : IEquatable<OperationalInsightsClusterReplicationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsClusterReplicationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsClusterReplicationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string EnableRequestedValue = "EnableRequested";
        private const string EnablingValue = "Enabling";
        private const string DisableRequestedValue = "DisableRequested";
        private const string DisablingValue = "Disabling";
        private const string RollbackRequestedValue = "RollbackRequested";
        private const string RollingBackValue = "RollingBack";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static OperationalInsightsClusterReplicationState Succeeded { get; } = new OperationalInsightsClusterReplicationState(SucceededValue);
        /// <summary> EnableRequested. </summary>
        public static OperationalInsightsClusterReplicationState EnableRequested { get; } = new OperationalInsightsClusterReplicationState(EnableRequestedValue);
        /// <summary> Enabling. </summary>
        public static OperationalInsightsClusterReplicationState Enabling { get; } = new OperationalInsightsClusterReplicationState(EnablingValue);
        /// <summary> DisableRequested. </summary>
        public static OperationalInsightsClusterReplicationState DisableRequested { get; } = new OperationalInsightsClusterReplicationState(DisableRequestedValue);
        /// <summary> Disabling. </summary>
        public static OperationalInsightsClusterReplicationState Disabling { get; } = new OperationalInsightsClusterReplicationState(DisablingValue);
        /// <summary> RollbackRequested. </summary>
        public static OperationalInsightsClusterReplicationState RollbackRequested { get; } = new OperationalInsightsClusterReplicationState(RollbackRequestedValue);
        /// <summary> RollingBack. </summary>
        public static OperationalInsightsClusterReplicationState RollingBack { get; } = new OperationalInsightsClusterReplicationState(RollingBackValue);
        /// <summary> Failed. </summary>
        public static OperationalInsightsClusterReplicationState Failed { get; } = new OperationalInsightsClusterReplicationState(FailedValue);
        /// <summary> Canceled. </summary>
        public static OperationalInsightsClusterReplicationState Canceled { get; } = new OperationalInsightsClusterReplicationState(CanceledValue);
        /// <summary> Determines if two <see cref="OperationalInsightsClusterReplicationState"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsClusterReplicationState left, OperationalInsightsClusterReplicationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsClusterReplicationState"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsClusterReplicationState left, OperationalInsightsClusterReplicationState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperationalInsightsClusterReplicationState"/>. </summary>
        public static implicit operator OperationalInsightsClusterReplicationState(string value) => new OperationalInsightsClusterReplicationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsClusterReplicationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsClusterReplicationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
