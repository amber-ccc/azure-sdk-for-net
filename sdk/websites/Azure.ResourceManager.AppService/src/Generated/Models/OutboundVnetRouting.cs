// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Outbound traffic options over virtual network. </summary>
    public partial class OutboundVnetRouting
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

        /// <summary> Initializes a new instance of <see cref="OutboundVnetRouting"/>. </summary>
        public OutboundVnetRouting()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OutboundVnetRouting"/>. </summary>
        /// <param name="isAllTrafficEnabled"> Enables all other routing options defined in OutboundVnetRouting if this setting is set to true. </param>
        /// <param name="isApplicationTrafficEnabled"> This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. Previously called VnetRouteAllEnabled. </param>
        /// <param name="isContentShareTrafficEnabled"> Enables accessing content over virtual network. Previously called VnetContentShareEnabled. </param>
        /// <param name="isImagePullTrafficEnabled"> Enables pulling image over Virtual Network. Previously called VnetImagePullEnabled. </param>
        /// <param name="isBackupRestoreTrafficEnabled"> Enables Backup and Restore operations over virtual network. Previously called VnetBackupRestoreEnabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundVnetRouting(bool? isAllTrafficEnabled, bool? isApplicationTrafficEnabled, bool? isContentShareTrafficEnabled, bool? isImagePullTrafficEnabled, bool? isBackupRestoreTrafficEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsAllTrafficEnabled = isAllTrafficEnabled;
            IsApplicationTrafficEnabled = isApplicationTrafficEnabled;
            IsContentShareTrafficEnabled = isContentShareTrafficEnabled;
            IsImagePullTrafficEnabled = isImagePullTrafficEnabled;
            IsBackupRestoreTrafficEnabled = isBackupRestoreTrafficEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enables all other routing options defined in OutboundVnetRouting if this setting is set to true. </summary>
        [WirePath("allTraffic")]
        public bool? IsAllTrafficEnabled { get; set; }
        /// <summary> This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. Previously called VnetRouteAllEnabled. </summary>
        [WirePath("applicationTraffic")]
        public bool? IsApplicationTrafficEnabled { get; set; }
        /// <summary> Enables accessing content over virtual network. Previously called VnetContentShareEnabled. </summary>
        [WirePath("contentShareTraffic")]
        public bool? IsContentShareTrafficEnabled { get; set; }
        /// <summary> Enables pulling image over Virtual Network. Previously called VnetImagePullEnabled. </summary>
        [WirePath("imagePullTraffic")]
        public bool? IsImagePullTrafficEnabled { get; set; }
        /// <summary> Enables Backup and Restore operations over virtual network. Previously called VnetBackupRestoreEnabled. </summary>
        [WirePath("backupRestoreTraffic")]
        public bool? IsBackupRestoreTrafficEnabled { get; set; }
    }
}
