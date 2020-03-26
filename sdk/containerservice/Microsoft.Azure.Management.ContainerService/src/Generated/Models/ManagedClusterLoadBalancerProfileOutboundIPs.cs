// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Desired outbound IP resources for the cluster load balancer.
    /// </summary>
    public partial class ManagedClusterLoadBalancerProfileOutboundIPs
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterLoadBalancerProfileOutboundIPs class.
        /// </summary>
        public ManagedClusterLoadBalancerProfileOutboundIPs()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterLoadBalancerProfileOutboundIPs class.
        /// </summary>
        /// <param name="publicIPs">A list of public IP resources.</param>
        public ManagedClusterLoadBalancerProfileOutboundIPs(IList<ResourceReference> publicIPs = default(IList<ResourceReference>))
        {
            PublicIPs = publicIPs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of public IP resources.
        /// </summary>
        [JsonProperty(PropertyName = "publicIPs")]
        public IList<ResourceReference> PublicIPs { get; set; }

    }
}