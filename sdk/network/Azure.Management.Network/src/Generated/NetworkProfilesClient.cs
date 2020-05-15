// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The NetworkProfiles service client. </summary>
    public partial class NetworkProfilesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NetworkProfilesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of NetworkProfilesClient for mocking. </summary>
        protected NetworkProfilesClient()
        {
        }

        /// <summary> Initializes a new instance of NetworkProfilesClient. </summary>
        public NetworkProfilesClient(string subscriptionId, TokenCredential tokenCredential, NetworkManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }

        /// <summary> Initializes a new instance of NetworkProfilesClient. </summary>
        public NetworkProfilesClient(string subscriptionId, string host, TokenCredential tokenCredential, NetworkManagementClientOptions options = null)
        {
            options ??= new NetworkManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, host, options);
            RestClient = new NetworkProfilesRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId, host: host);
        }

        /// <summary> Gets the specified network profile in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkProfile>> GetAsync(string resourceGroupName, string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkProfileName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified network profile in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the public IP prefix. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkProfile> Get(string resourceGroupName, string networkProfileName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkProfileName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the network profile. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network profile operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkProfile>> CreateOrUpdateAsync(string resourceGroupName, string networkProfileName, NetworkProfile parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, networkProfileName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the network profile. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network profile operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkProfile> CreateOrUpdate(string resourceGroupName, string networkProfileName, NetworkProfile parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, networkProfileName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates network profile tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the network profile. </param>
        /// <param name="parameters"> Parameters supplied to update network profile tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkProfile>> UpdateTagsAsync(string resourceGroupName, string networkProfileName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, networkProfileName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates network profile tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the network profile. </param>
        /// <param name="parameters"> Parameters supplied to update network profile tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkProfile> UpdateTags(string resourceGroupName, string networkProfileName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, networkProfileName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the network profiles in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkProfile> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkProfile>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkProfile>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the network profiles in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkProfile> ListAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkProfile> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAll(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkProfile> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network profiles in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkProfile> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<NetworkProfile>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkProfile>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network profiles in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkProfile> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<NetworkProfile> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkProfile> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<NetworkProfilesDeleteOperation> StartDeleteAsync(string resourceGroupName, string networkProfileName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkProfileName == null)
            {
                throw new ArgumentNullException(nameof(networkProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkProfileName, cancellationToken).ConfigureAwait(false);
                return new NetworkProfilesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkProfileName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NetworkProfilesDeleteOperation StartDelete(string resourceGroupName, string networkProfileName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkProfileName == null)
            {
                throw new ArgumentNullException(nameof(networkProfileName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkProfilesClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, networkProfileName, cancellationToken);
                return new NetworkProfilesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, networkProfileName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}