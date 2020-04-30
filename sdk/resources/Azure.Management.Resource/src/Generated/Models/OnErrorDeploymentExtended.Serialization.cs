// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class OnErrorDeploymentExtended
    {
        internal static OnErrorDeploymentExtended DeserializeOnErrorDeploymentExtended(JsonElement element)
        {
            string provisioningState = default;
            OnErrorDeploymentType? type = default;
            string deploymentName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToOnErrorDeploymentType();
                    continue;
                }
                if (property.NameEquals("deploymentName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentName = property.Value.GetString();
                    continue;
                }
            }
            return new OnErrorDeploymentExtended(provisioningState, type, deploymentName);
        }
    }
}