﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Update.Admin;
using Microsoft.AzureStack.Management.Update.Admin.Models;
using System.Linq;
using Xunit;

namespace Update.Tests
{
    public class UpdateRuns : UpdateTestBase
    {

        void ValidateUpdateRun(UpdateRun runs) {
            Assert.True(ValidResource(runs));
            Assert.NotNull(runs.Duration);
            Assert.NotNull(runs.Progress);
            Assert.NotNull(runs.State);
            Assert.NotNull(runs.TimeStarted);
        }

        public void AssertProgressAreSame(Step expected, Step found) {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.NotNull(found);
                Assert.Equal(expected.Description, found.Description);
                Assert.Equal(expected.EndTimeUtc, found.EndTimeUtc);
                Assert.Equal(expected.ErrorMessage, found.ErrorMessage);
                Assert.Equal(expected.Name, found.Name);
                Assert.Equal(expected.StartTimeUtc, found.StartTimeUtc);
                Assert.Equal(expected.Status, found.Status);
                if (expected.StepProperty == null)
                {
                    Assert.Null(found.StepProperty);
                }
                else
                {
                    Assert.NotNull(found.StepProperty);
                    Assert.Equal(expected.StepProperty.Count, found.StepProperty.Count);
                }
            }
        }

        public void AssertAreSame(UpdateRun expected, UpdateRun found) {
            Assert.True(ResourceAreSame(expected, found));

            if (expected != null)
            {
                Assert.Equal(expected.Duration, found.Duration);
                AssertProgressAreSame(expected.Progress, found.Progress);
                Assert.Equal(expected.State, found.State);
                Assert.Equal(expected.TimeStarted, found.TimeStarted);
            }
        }

        [Fact]
        public void TestListUpdateRuns() {
            RunTest((client) => {
                var updateLocations = client.UpdateLocations.List("System.local");
                updateLocations.ForEach((updateLocation) => {
                    var updates = client.Updates.List("System.local", updateLocation.Name);
                    updates.ForEach((update) => {
                        var runs= client.UpdateRuns.List("System.local", updateLocation.Name, update.Name);
                        Common.WriteIEnumerableToFile(runs, "TestListUpdateRuns");
                        runs.ForEach(ValidateUpdateRun);
                    });
                });
            });
        }

        [Fact]
        public void TestGetUpdateRun() {
            RunTest((client) => {
                var updateLocation = client.UpdateLocations.List("System.local").FirstOrDefault();
                Assert.NotNull(updateLocation);
                var update = client.Updates.List("System.local", updateLocation.Name).FirstOrDefault();
                if (update != null)
                {
                    var run = client.UpdateRuns.List("System.local", updateLocation.Name, update.Name).FirstOrDefault();
                    if (run != null)
                    {
                        var returned = client.UpdateRuns.Get("System.local", updateLocation.Name, update.Name, run.Name);
                        AssertAreSame(run, returned);
                    }
                }
            });
        }

        [Fact]
        public void TestGetAllUpdateRuns() {
            RunTest((client) => {
                var updateLocations = client.UpdateLocations.List("System.local");
                updateLocations.ForEach((updateLocation) => {
                    var updates = client.Updates.List("System.local", updateLocation.Name);
                    updates.ForEach((update) => {
                        var runs = client.UpdateRuns.List("System.local", updateLocation.Name, update.Name);
                        runs.ForEach((run) => {
                            var returned = client.UpdateRuns.Get("System.local", updateLocation.Name, update.Name, run.Name);
                        AssertAreSame(run, returned);
                        });
                    });
                });
            });
        }
    }
}
