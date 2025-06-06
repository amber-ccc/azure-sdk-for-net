// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ApiManagement.GatewayTokenExpired event. </summary>
    public partial class ApiManagementGatewayTokenExpiredEventData
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementGatewayTokenExpiredEventData"/>. </summary>
        /// <param name="gateway"> Information related to a given self-hosted gateway deployment. </param>
        /// <param name="token"> Information related to a an expired gateway token for a self-hosted gateway deployment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gateway"/> or <paramref name="token"/> is null. </exception>
        internal ApiManagementGatewayTokenExpiredEventData(ApiManagementGatewayProperties gateway, ApiManagementExpiredGatewayTokenProperties token)
        {
            Argument.AssertNotNull(gateway, nameof(gateway));
            Argument.AssertNotNull(token, nameof(token));

            Gateway = gateway;
            Token = token;
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementGatewayTokenExpiredEventData"/>. </summary>
        /// <param name="gateway"> Information related to a given self-hosted gateway deployment. </param>
        /// <param name="token"> Information related to a an expired gateway token for a self-hosted gateway deployment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementGatewayTokenExpiredEventData(ApiManagementGatewayProperties gateway, ApiManagementExpiredGatewayTokenProperties token, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Gateway = gateway;
            Token = token;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementGatewayTokenExpiredEventData"/> for deserialization. </summary>
        internal ApiManagementGatewayTokenExpiredEventData()
        {
        }

        /// <summary> Information related to a given self-hosted gateway deployment. </summary>
        public ApiManagementGatewayProperties Gateway { get; }
        /// <summary> Information related to a an expired gateway token for a self-hosted gateway deployment. </summary>
        public ApiManagementExpiredGatewayTokenProperties Token { get; }
    }
}
