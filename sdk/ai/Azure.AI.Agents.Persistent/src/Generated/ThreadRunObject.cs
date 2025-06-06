// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The ThreadRunObject. </summary>
    internal readonly partial struct ThreadRunObject : IEquatable<ThreadRunObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ThreadRunObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ThreadRunObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadRunValue = "thread.run";

        /// <summary> thread.run. </summary>
        public static ThreadRunObject ThreadRun { get; } = new ThreadRunObject(ThreadRunValue);
        /// <summary> Determines if two <see cref="ThreadRunObject"/> values are the same. </summary>
        public static bool operator ==(ThreadRunObject left, ThreadRunObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ThreadRunObject"/> values are not the same. </summary>
        public static bool operator !=(ThreadRunObject left, ThreadRunObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ThreadRunObject"/>. </summary>
        public static implicit operator ThreadRunObject(string value) => new ThreadRunObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThreadRunObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ThreadRunObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
