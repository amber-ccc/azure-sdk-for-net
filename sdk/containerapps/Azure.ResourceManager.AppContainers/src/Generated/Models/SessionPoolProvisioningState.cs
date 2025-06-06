// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Provisioning state of the session pool. </summary>
    public readonly partial struct SessionPoolProvisioningState : IEquatable<SessionPoolProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SessionPoolProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SessionPoolProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";

        /// <summary> InProgress. </summary>
        public static SessionPoolProvisioningState InProgress { get; } = new SessionPoolProvisioningState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static SessionPoolProvisioningState Succeeded { get; } = new SessionPoolProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static SessionPoolProvisioningState Failed { get; } = new SessionPoolProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static SessionPoolProvisioningState Canceled { get; } = new SessionPoolProvisioningState(CanceledValue);
        /// <summary> Deleting. </summary>
        public static SessionPoolProvisioningState Deleting { get; } = new SessionPoolProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="SessionPoolProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SessionPoolProvisioningState left, SessionPoolProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SessionPoolProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SessionPoolProvisioningState left, SessionPoolProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SessionPoolProvisioningState"/>. </summary>
        public static implicit operator SessionPoolProvisioningState(string value) => new SessionPoolProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SessionPoolProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SessionPoolProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
