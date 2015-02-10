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
using Microsoft.Azure.Management.Authorization;
using Microsoft.Azure.Management.Authorization.Models;

namespace Microsoft.Azure.Management.Authorization
{
    public static partial class RoleDefinitionOperationsExtensions
    {
        /// <summary>
        /// Get role definition by name (GUID).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IRoleDefinitionOperations.
        /// </param>
        /// <param name='roleDefinitionName'>
        /// Required. Role definition name (GUID).
        /// </param>
        /// <returns>
        /// Role definition get operation result.
        /// </returns>
        public static RoleDefinitionGetResult Get(this IRoleDefinitionOperations operations, Guid roleDefinitionName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRoleDefinitionOperations)s).GetAsync(roleDefinitionName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get role definition by name (GUID).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IRoleDefinitionOperations.
        /// </param>
        /// <param name='roleDefinitionName'>
        /// Required. Role definition name (GUID).
        /// </param>
        /// <returns>
        /// Role definition get operation result.
        /// </returns>
        public static Task<RoleDefinitionGetResult> GetAsync(this IRoleDefinitionOperations operations, Guid roleDefinitionName)
        {
            return operations.GetAsync(roleDefinitionName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get role definition by name (GUID).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IRoleDefinitionOperations.
        /// </param>
        /// <param name='roleDefinitionId'>
        /// Required. Role definition Id
        /// </param>
        /// <returns>
        /// Role definition get operation result.
        /// </returns>
        public static RoleDefinitionGetResult GetById(this IRoleDefinitionOperations operations, string roleDefinitionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRoleDefinitionOperations)s).GetByIdAsync(roleDefinitionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get role definition by name (GUID).
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IRoleDefinitionOperations.
        /// </param>
        /// <param name='roleDefinitionId'>
        /// Required. Role definition Id
        /// </param>
        /// <returns>
        /// Role definition get operation result.
        /// </returns>
        public static Task<RoleDefinitionGetResult> GetByIdAsync(this IRoleDefinitionOperations operations, string roleDefinitionId)
        {
            return operations.GetByIdAsync(roleDefinitionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Get all role definitions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IRoleDefinitionOperations.
        /// </param>
        /// <returns>
        /// Role definition list operation result.
        /// </returns>
        public static RoleDefinitionListResult List(this IRoleDefinitionOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRoleDefinitionOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get all role definitions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IRoleDefinitionOperations.
        /// </param>
        /// <returns>
        /// Role definition list operation result.
        /// </returns>
        public static Task<RoleDefinitionListResult> ListAsync(this IRoleDefinitionOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
