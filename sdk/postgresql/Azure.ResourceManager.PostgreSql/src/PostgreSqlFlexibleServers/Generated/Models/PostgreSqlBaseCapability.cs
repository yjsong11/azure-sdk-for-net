// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Base object for representing capability. </summary>
    public partial class PostgreSqlBaseCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlBaseCapability. </summary>
        internal PostgreSqlBaseCapability()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlBaseCapability. </summary>
        /// <param name="capabilityStatus"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal PostgreSqlBaseCapability(PostgreSqlFlexbileServerCapabilityStatus? capabilityStatus, string reason)
        {
            CapabilityStatus = capabilityStatus;
            Reason = reason;
        }

        /// <summary> The status of the capability. </summary>
        public PostgreSqlFlexbileServerCapabilityStatus? CapabilityStatus { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
