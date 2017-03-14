// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TierType.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TierType
    {
        [EnumMember(Value = "Consumption")]
        Consumption,
        [EnumMember(Value = "Commitment_100AUHours")]
        Commitment100AUHours,
        [EnumMember(Value = "Commitment_500AUHours")]
        Commitment500AUHours,
        [EnumMember(Value = "Commitment_1000AUHours")]
        Commitment1000AUHours,
        [EnumMember(Value = "Commitment_5000AUHours")]
        Commitment5000AUHours,
        [EnumMember(Value = "Commitment_10000AUHours")]
        Commitment10000AUHours,
        [EnumMember(Value = "Commitment_50000AUHours")]
        Commitment50000AUHours,
        [EnumMember(Value = "Commitment_100000AUHours")]
        Commitment100000AUHours,
        [EnumMember(Value = "Commitment_500000AUHours")]
        Commitment500000AUHours
    }
}


