// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Data source used when creating the volume. </summary>
    public partial class ElasticSanVolumeDataSourceInfo
    {
        /// <summary> Initializes a new instance of ElasticSanVolumeDataSourceInfo. </summary>
        public ElasticSanVolumeDataSourceInfo()
        {
        }

        /// <summary> Initializes a new instance of ElasticSanVolumeDataSourceInfo. </summary>
        /// <param name="createSource"> This enumerates the possible sources of a volume creation. </param>
        /// <param name="sourceId"> Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}". </param>
        internal ElasticSanVolumeDataSourceInfo(ElasticSanVolumeCreateOption? createSource, ResourceIdentifier sourceId)
        {
            CreateSource = createSource;
            SourceId = sourceId;
        }

        /// <summary> This enumerates the possible sources of a volume creation. </summary>
        public ElasticSanVolumeCreateOption? CreateSource { get; set; }
        /// <summary> Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}". </summary>
        public ResourceIdentifier SourceId { get; set; }
    }
}
