// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableStreamAnalyticsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStreamAnalyticsArmClient"/> class for mocking. </summary>
        protected MockableStreamAnalyticsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStreamAnalyticsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStreamAnalyticsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableStreamAnalyticsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="StreamingJobFunctionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingJobFunctionResource.CreateResourceIdentifier" /> to create a <see cref="StreamingJobFunctionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingJobFunctionResource" /> object. </returns>
        public virtual StreamingJobFunctionResource GetStreamingJobFunctionResource(ResourceIdentifier id)
        {
            StreamingJobFunctionResource.ValidateResourceId(id);
            return new StreamingJobFunctionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StreamingJobInputResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingJobInputResource.CreateResourceIdentifier" /> to create a <see cref="StreamingJobInputResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingJobInputResource" /> object. </returns>
        public virtual StreamingJobInputResource GetStreamingJobInputResource(ResourceIdentifier id)
        {
            StreamingJobInputResource.ValidateResourceId(id);
            return new StreamingJobInputResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StreamingJobOutputResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingJobOutputResource.CreateResourceIdentifier" /> to create a <see cref="StreamingJobOutputResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingJobOutputResource" /> object. </returns>
        public virtual StreamingJobOutputResource GetStreamingJobOutputResource(ResourceIdentifier id)
        {
            StreamingJobOutputResource.ValidateResourceId(id);
            return new StreamingJobOutputResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StreamingJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingJobResource.CreateResourceIdentifier" /> to create a <see cref="StreamingJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingJobResource" /> object. </returns>
        public virtual StreamingJobResource GetStreamingJobResource(ResourceIdentifier id)
        {
            StreamingJobResource.ValidateResourceId(id);
            return new StreamingJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StreamingJobTransformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamingJobTransformationResource.CreateResourceIdentifier" /> to create a <see cref="StreamingJobTransformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamingJobTransformationResource" /> object. </returns>
        public virtual StreamingJobTransformationResource GetStreamingJobTransformationResource(ResourceIdentifier id)
        {
            StreamingJobTransformationResource.ValidateResourceId(id);
            return new StreamingJobTransformationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StreamAnalyticsClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamAnalyticsClusterResource.CreateResourceIdentifier" /> to create a <see cref="StreamAnalyticsClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamAnalyticsClusterResource" /> object. </returns>
        public virtual StreamAnalyticsClusterResource GetStreamAnalyticsClusterResource(ResourceIdentifier id)
        {
            StreamAnalyticsClusterResource.ValidateResourceId(id);
            return new StreamAnalyticsClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StreamAnalyticsPrivateEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StreamAnalyticsPrivateEndpointResource.CreateResourceIdentifier" /> to create a <see cref="StreamAnalyticsPrivateEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StreamAnalyticsPrivateEndpointResource" /> object. </returns>
        public virtual StreamAnalyticsPrivateEndpointResource GetStreamAnalyticsPrivateEndpointResource(ResourceIdentifier id)
        {
            StreamAnalyticsPrivateEndpointResource.ValidateResourceId(id);
            return new StreamAnalyticsPrivateEndpointResource(Client, id);
        }
    }
}
