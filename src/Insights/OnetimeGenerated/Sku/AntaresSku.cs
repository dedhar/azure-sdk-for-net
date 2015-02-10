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

namespace Microsoft.Azure.Management.Insights.Models
{
    internal partial class AntaresSku
    {
        private int _currentNumberOfWorkers;

        /// <summary>
        /// Optional.
        /// </summary>
        public int CurrentNumberOfWorkers
        {
            get { return this._currentNumberOfWorkers; }
            set { this._currentNumberOfWorkers = value; }
        }

        private int _currentWorkerSize;

        /// <summary>
        /// Optional.
        /// </summary>
        public int CurrentWorkerSize
        {
            get { return this._currentWorkerSize; }
            set { this._currentWorkerSize = value; }
        }

        private string _sku;

        /// <summary>
        /// Optional.
        /// </summary>
        public string Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }

        /// <summary>
        /// Initializes a new instance of the AntaresSku class.
        /// </summary>
        public AntaresSku()
        {
        }
    }
}
