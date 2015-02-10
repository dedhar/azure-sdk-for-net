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

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the varible properties
    /// </summary>
    public partial class VariableProperties
    {
        private DateTimeOffset _creationTime;
        
        /// <summary>
        /// Optional. Gets or sets the creation time of the variable.
        /// </summary>
        public DateTimeOffset CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the variable.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private bool _isEncrypted;
        
        /// <summary>
        /// Optional. Gets or sets the encrypted flag of the variable.
        /// </summary>
        public bool IsEncrypted
        {
            get { return this._isEncrypted; }
            set { this._isEncrypted = value; }
        }
        
        private DateTimeOffset _lastModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the last modified time of the variable.
        /// </summary>
        public DateTimeOffset LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. Gets or sets the value of the variable.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VariableProperties class.
        /// </summary>
        public VariableProperties()
        {
        }
    }
}
