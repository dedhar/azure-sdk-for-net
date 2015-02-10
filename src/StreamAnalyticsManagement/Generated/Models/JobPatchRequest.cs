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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The response returned by the job patch operation.
    /// </summary>
    public partial class JobPatchRequest
    {
        private JobProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets the job properties for patch request.
        /// </summary>
        public JobProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Gets or sets the tags of the stream analytics job.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobPatchRequest class.
        /// </summary>
        public JobPatchRequest()
        {
            this.Tags = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the JobPatchRequest class with
        /// required arguments.
        /// </summary>
        public JobPatchRequest(JobProperties properties)
            : this()
        {
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.Properties = properties;
        }
    }
}
