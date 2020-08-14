// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The location of SFTP dataset. </summary>
    public partial class SftpLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of SftpLocation. </summary>
        public SftpLocation()
        {
            Type = "SftpLocation";
        }

        /// <summary> Initializes a new instance of SftpLocation. </summary>
        /// <param name="type"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> . </param>
        internal SftpLocation(string type, object folderPath, object fileName, IDictionary<string, object> additionalProperties) : base(type, folderPath, fileName, additionalProperties)
        {
            Type = type ?? "SftpLocation";
        }
    }
}