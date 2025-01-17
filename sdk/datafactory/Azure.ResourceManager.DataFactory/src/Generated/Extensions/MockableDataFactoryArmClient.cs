// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableDataFactoryArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDataFactoryArmClient"/> class for mocking. </summary>
        protected MockableDataFactoryArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDataFactoryArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDataFactoryArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableDataFactoryArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryResource" /> object. </returns>
        public virtual DataFactoryResource GetDataFactoryResource(ResourceIdentifier id)
        {
            DataFactoryResource.ValidateResourceId(id);
            return new DataFactoryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryIntegrationRuntimeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryIntegrationRuntimeResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryIntegrationRuntimeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryIntegrationRuntimeResource" /> object. </returns>
        public virtual DataFactoryIntegrationRuntimeResource GetDataFactoryIntegrationRuntimeResource(ResourceIdentifier id)
        {
            DataFactoryIntegrationRuntimeResource.ValidateResourceId(id);
            return new DataFactoryIntegrationRuntimeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryLinkedServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryLinkedServiceResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryLinkedServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryLinkedServiceResource" /> object. </returns>
        public virtual DataFactoryLinkedServiceResource GetDataFactoryLinkedServiceResource(ResourceIdentifier id)
        {
            DataFactoryLinkedServiceResource.ValidateResourceId(id);
            return new DataFactoryLinkedServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryDatasetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryDatasetResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryDatasetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryDatasetResource" /> object. </returns>
        public virtual DataFactoryDatasetResource GetDataFactoryDatasetResource(ResourceIdentifier id)
        {
            DataFactoryDatasetResource.ValidateResourceId(id);
            return new DataFactoryDatasetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryPipelineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryPipelineResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryPipelineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryPipelineResource" /> object. </returns>
        public virtual DataFactoryPipelineResource GetDataFactoryPipelineResource(ResourceIdentifier id)
        {
            DataFactoryPipelineResource.ValidateResourceId(id);
            return new DataFactoryPipelineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryTriggerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryTriggerResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryTriggerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryTriggerResource" /> object. </returns>
        public virtual DataFactoryTriggerResource GetDataFactoryTriggerResource(ResourceIdentifier id)
        {
            DataFactoryTriggerResource.ValidateResourceId(id);
            return new DataFactoryTriggerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryDataFlowResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryDataFlowResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryDataFlowResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryDataFlowResource" /> object. </returns>
        public virtual DataFactoryDataFlowResource GetDataFactoryDataFlowResource(ResourceIdentifier id)
        {
            DataFactoryDataFlowResource.ValidateResourceId(id);
            return new DataFactoryDataFlowResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryManagedVirtualNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryManagedVirtualNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryManagedVirtualNetworkResource" /> object. </returns>
        public virtual DataFactoryManagedVirtualNetworkResource GetDataFactoryManagedVirtualNetworkResource(ResourceIdentifier id)
        {
            DataFactoryManagedVirtualNetworkResource.ValidateResourceId(id);
            return new DataFactoryManagedVirtualNetworkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryPrivateEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryPrivateEndpointResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryPrivateEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryPrivateEndpointResource" /> object. </returns>
        public virtual DataFactoryPrivateEndpointResource GetDataFactoryPrivateEndpointResource(ResourceIdentifier id)
        {
            DataFactoryPrivateEndpointResource.ValidateResourceId(id);
            return new DataFactoryPrivateEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryManagedIdentityCredentialResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryManagedIdentityCredentialResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryManagedIdentityCredentialResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryManagedIdentityCredentialResource" /> object. </returns>
        public virtual DataFactoryManagedIdentityCredentialResource GetDataFactoryManagedIdentityCredentialResource(ResourceIdentifier id)
        {
            DataFactoryManagedIdentityCredentialResource.ValidateResourceId(id);
            return new DataFactoryManagedIdentityCredentialResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryPrivateEndpointConnectionResource" /> object. </returns>
        public virtual DataFactoryPrivateEndpointConnectionResource GetDataFactoryPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            DataFactoryPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new DataFactoryPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryGlobalParameterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryGlobalParameterResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryGlobalParameterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryGlobalParameterResource" /> object. </returns>
        public virtual DataFactoryGlobalParameterResource GetDataFactoryGlobalParameterResource(ResourceIdentifier id)
        {
            DataFactoryGlobalParameterResource.ValidateResourceId(id);
            return new DataFactoryGlobalParameterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataFactoryChangeDataCaptureResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataFactoryChangeDataCaptureResource.CreateResourceIdentifier" /> to create a <see cref="DataFactoryChangeDataCaptureResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataFactoryChangeDataCaptureResource" /> object. </returns>
        public virtual DataFactoryChangeDataCaptureResource GetDataFactoryChangeDataCaptureResource(ResourceIdentifier id)
        {
            DataFactoryChangeDataCaptureResource.ValidateResourceId(id);
            return new DataFactoryChangeDataCaptureResource(Client, id);
        }
    }
}
