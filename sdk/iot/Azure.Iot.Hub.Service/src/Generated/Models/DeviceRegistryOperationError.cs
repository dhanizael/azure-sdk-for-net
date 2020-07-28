// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The device registry operation error details. </summary>
    public partial class DeviceRegistryOperationError
    {
        /// <summary> Initializes a new instance of DeviceRegistryOperationError. </summary>
        internal DeviceRegistryOperationError()
        {
        }

        /// <summary> Initializes a new instance of DeviceRegistryOperationError. </summary>
        /// <param name="deviceId"> The unique identifier of the device. </param>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorStatus"> The details of the error. </param>
        /// <param name="moduleId"> The unique identifier of the module, if applicable. </param>
        /// <param name="operation"> The type of the operation that failed. </param>
        internal DeviceRegistryOperationError(string deviceId, DeviceRegistryOperationErrorCode? errorCode, string errorStatus, string moduleId, string operation)
        {
            DeviceId = deviceId;
            ErrorCode = errorCode;
            ErrorStatus = errorStatus;
            ModuleId = moduleId;
            Operation = operation;
        }

        /// <summary> The unique identifier of the device. </summary>
        public string DeviceId { get; }
        /// <summary> The error code. </summary>
        public DeviceRegistryOperationErrorCode? ErrorCode { get; }
        /// <summary> The details of the error. </summary>
        public string ErrorStatus { get; }
        /// <summary> The unique identifier of the module, if applicable. </summary>
        public string ModuleId { get; }
        /// <summary> The type of the operation that failed. </summary>
        public string Operation { get; }
    }
}