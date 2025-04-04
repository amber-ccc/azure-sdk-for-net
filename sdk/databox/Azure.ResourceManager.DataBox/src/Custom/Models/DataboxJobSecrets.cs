// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The secrets related to a databox job. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This class is obsolete and will be removed in a future release.Please use DataBoxJobSecrets instead.", false)]
    public partial class DataboxJobSecrets : JobSecrets
    {
        /// <summary> Initializes a new instance of <see cref="DataboxJobSecrets"/>. </summary>
        internal DataboxJobSecrets()
        {
            PodSecrets = new ChangeTrackingList<DataBoxSecret>();
            JobSecretsType = DataBoxOrderType.DataBox;
        }

        /// <summary> Initializes a new instance of <see cref="DataboxJobSecrets"/>. </summary>
        /// <param name="jobSecretsType"> Used to indicate what type of job secrets object. </param>
        /// <param name="dataCenterAccessSecurityCode"> Dc Access Security Code for Customer Managed Shipping. </param>
        /// <param name="error"> Error while fetching the secrets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="podSecrets"> Contains the list of secret objects for a job. </param>
        internal DataboxJobSecrets(DataBoxOrderType jobSecretsType, DataCenterAccessSecurityCode dataCenterAccessSecurityCode, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<DataBoxSecret> podSecrets) : base(jobSecretsType, dataCenterAccessSecurityCode, error, serializedAdditionalRawData)
        {
            PodSecrets = podSecrets;
            JobSecretsType = jobSecretsType;
        }

        /// <summary> Contains the list of secret objects for a job. </summary>
        public IReadOnlyList<DataBoxSecret> PodSecrets { get; }
    }
}
