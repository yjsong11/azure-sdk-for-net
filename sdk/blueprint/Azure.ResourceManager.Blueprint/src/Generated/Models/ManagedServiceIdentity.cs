// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Managed identity generic object. </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="identityType"> Type of the managed identity. </param>
        public ManagedServiceIdentity(ManagedServiceIdentityType identityType)
        {
            IdentityType = identityType;
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of ManagedServiceIdentity. </summary>
        /// <param name="identityType"> Type of the managed identity. </param>
        /// <param name="principalId"> Azure Active Directory principal ID associated with this Identity. </param>
        /// <param name="tenantId"> ID of the Azure Active Directory. </param>
        /// <param name="userAssignedIdentities"> The list of user-assigned managed identities associated with the resource. Key is the Azure resource Id of the managed identity. </param>
        internal ManagedServiceIdentity(ManagedServiceIdentityType identityType, string principalId, Guid? tenantId, IDictionary<string, UserAssignedIdentity> userAssignedIdentities)
        {
            IdentityType = identityType;
            PrincipalId = principalId;
            TenantId = tenantId;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> Type of the managed identity. </summary>
        public ManagedServiceIdentityType IdentityType { get; set; }
        /// <summary> Azure Active Directory principal ID associated with this Identity. </summary>
        public string PrincipalId { get; set; }
        /// <summary> ID of the Azure Active Directory. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> The list of user-assigned managed identities associated with the resource. Key is the Azure resource Id of the managed identity. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
