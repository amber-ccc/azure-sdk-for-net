// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents a supported prebuilt entity. </summary>
    public partial class ConversationAuthoringPrebuiltEntity
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

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringPrebuiltEntity"/>. </summary>
        /// <param name="description"> The description. </param>
        /// <param name="examples"> English examples for the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> or <paramref name="examples"/> is null. </exception>
        internal ConversationAuthoringPrebuiltEntity(string description, string examples)
        {
            Argument.AssertNotNull(description, nameof(description));
            Argument.AssertNotNull(examples, nameof(examples));

            Description = description;
            Examples = examples;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringPrebuiltEntity"/>. </summary>
        /// <param name="category"> The prebuilt entity category. </param>
        /// <param name="description"> The description. </param>
        /// <param name="examples"> English examples for the entity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationAuthoringPrebuiltEntity(string category, string description, string examples, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            Description = description;
            Examples = examples;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringPrebuiltEntity"/> for deserialization. </summary>
        internal ConversationAuthoringPrebuiltEntity()
        {
        }

        /// <summary> The prebuilt entity category. </summary>
        public string Category { get; }
        /// <summary> The description. </summary>
        public string Description { get; }
        /// <summary> English examples for the entity. </summary>
        public string Examples { get; }
    }
}
