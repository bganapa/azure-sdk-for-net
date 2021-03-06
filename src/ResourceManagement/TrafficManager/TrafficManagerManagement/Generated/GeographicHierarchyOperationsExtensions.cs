// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.TrafficManager;
using Microsoft.Azure.Management.TrafficManager.Models;

namespace Microsoft.Azure.Management.TrafficManager
{
    /// <summary>
    /// Client for creating, updating, listing and deleting Azure Traffic
    /// Manager profiles  (see
    /// http://azure.microsoft.com/en-gb/documentation/articles/traffic-manager-overview/
    /// for more information)
    /// </summary>
    public static partial class GeographicHierarchyOperationsExtensions
    {
        /// <summary>
        /// Gets a hierarchy of regions for use with the Geographic Traffic
        /// Routing Method.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IGeographicHierarchyOperations.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'CreateOrUpdate'
        /// operation.
        /// </returns>
        public static GeographicHierarchyGetResponse GetDefault(this IGeographicHierarchyOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IGeographicHierarchyOperations)s).GetDefaultAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a hierarchy of regions for use with the Geographic Traffic
        /// Routing Method.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.TrafficManager.IGeographicHierarchyOperations.
        /// </param>
        /// <returns>
        /// The response to a Traffic Manager profile 'CreateOrUpdate'
        /// operation.
        /// </returns>
        public static Task<GeographicHierarchyGetResponse> GetDefaultAsync(this IGeographicHierarchyOperations operations)
        {
            return operations.GetDefaultAsync(CancellationToken.None);
        }
    }
}
