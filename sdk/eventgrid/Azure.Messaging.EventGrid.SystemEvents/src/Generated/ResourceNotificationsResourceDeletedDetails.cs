// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary>
    /// Describes the schema of the properties under resource info which are common
    /// across all ARN system topic delete events
    /// </summary>
    public partial class ResourceNotificationsResourceDeletedDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceDeletedDetails"/>. </summary>
        /// <param name="resource"> id of the resource for which the event is being emitted. </param>
        /// <param name="name"> name of the resource for which the event is being emitted. </param>
        /// <param name="type"> the type of the resource for which the event is being emitted. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/>, <paramref name="name"/> or <paramref name="type"/> is null. </exception>
        internal ResourceNotificationsResourceDeletedDetails(ResourceIdentifier resource, string name, string type)
        {
            Argument.AssertNotNull(resource, nameof(resource));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(type, nameof(type));

            Resource = resource;
            Name = name;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceDeletedDetails"/>. </summary>
        /// <param name="resource"> id of the resource for which the event is being emitted. </param>
        /// <param name="name"> name of the resource for which the event is being emitted. </param>
        /// <param name="type"> the type of the resource for which the event is being emitted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceNotificationsResourceDeletedDetails(ResourceIdentifier resource, string name, string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Resource = resource;
            Name = name;
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceDeletedDetails"/> for deserialization. </summary>
        internal ResourceNotificationsResourceDeletedDetails()
        {
        }
    }
}
