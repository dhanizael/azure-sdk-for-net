// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace OpenTelemetry.Exporter.AzureMonitor.Models
{
    /// <summary> Instances of AvailabilityData represent the result of executing an availability test. </summary>
    public partial class AvailabilityData : MonitorDomain
    {
        /// <summary> Initializes a new instance of AvailabilityData. </summary>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a test run. Use it to correlate steps of test run and telemetry generated by the service. </param>
        /// <param name="name"> Name of the test that these availability results represent. </param>
        /// <param name="duration"> Duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Success flag. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="name"/> is null. </exception>
        public AvailabilityData(int ver, string id, string name, TimeSpan duration, bool success)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Ver = ver;
            Id = id;
            Name = name;
            Duration = duration;
            Success = success;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of AvailabilityData. </summary>
        /// <param name="test"> Ignored value. </param>
        /// <param name="ver"> Schema version. </param>
        /// <param name="id"> Identifier of a test run. Use it to correlate steps of test run and telemetry generated by the service. </param>
        /// <param name="name"> Name of the test that these availability results represent. </param>
        /// <param name="duration"> Duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </param>
        /// <param name="success"> Success flag. </param>
        /// <param name="runLocation"> Name of the location where the test was run from. </param>
        /// <param name="message"> Diagnostic message for the result. </param>
        /// <param name="properties"> Collection of custom properties. TODO: max key length validate. </param>
        /// <param name="measurements"> Collection of custom measurements. TODO: max key length validate. </param>
        internal AvailabilityData(string test, int ver, string id, string name, TimeSpan duration, bool success, string runLocation, string message, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(test)
        {
            Ver = ver;
            Id = id;
            Name = name;
            Duration = duration;
            Success = success;
            RunLocation = runLocation;
            Message = message;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Schema version. </summary>
        public int Ver { get; set; }
        /// <summary> Identifier of a test run. Use it to correlate steps of test run and telemetry generated by the service. </summary>
        public string Id { get; set; }
        /// <summary> Name of the test that these availability results represent. </summary>
        public string Name { get; set; }
        /// <summary> Duration in format: DD.HH:MM:SS.MMMMMM. Must be less than 1000 days. </summary>
        public TimeSpan Duration { get; set; }
        /// <summary> Success flag. </summary>
        public bool Success { get; set; }
        /// <summary> Name of the location where the test was run from. </summary>
        public string RunLocation { get; set; }
        /// <summary> Diagnostic message for the result. </summary>
        public string Message { get; set; }
        /// <summary> Collection of custom properties. TODO: max key length validate. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. TODO: max key length validate. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}