// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Deployment.Admin;
using Microsoft.AzureStack.Management.Deployment.Admin.Models;
using System;
using Xunit;

namespace Deployment.Tests.src
{
    public class ActionPlanTests : DeploymentTestBase
    {
        [Fact]
        public void TestUpdateEncruption() {
            RunTest((client) =>
            {
                client.ActionPlans.Get("yes");
            });
        }
    }
}
