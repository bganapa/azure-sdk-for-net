// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Deployment.Admin;
using Xunit;

namespace Deployment.Tests
{

    public class DeploymentTestBase : AzureStackTestBase<DeploymentAdminClient>
    {
        public DeploymentTestBase()
        {
            // Empty
        }

        protected override void ValidateClient(DeploymentAdminClient client)
        {
            // validate creation
            Assert.NotNull(client);

            // validate objects
            //Assert.NotNull(client.SubscriberUsageAggregates);
            Assert.NotNull(client.SubscriptionId);
        }
    }
}
