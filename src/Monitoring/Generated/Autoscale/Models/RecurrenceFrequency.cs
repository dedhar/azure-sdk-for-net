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

namespace Microsoft.WindowsAzure.Management.Monitoring.Autoscale.Models
{
    public enum RecurrenceFrequency
    {
        /// <summary>
        /// No recurrence.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// A recurrence value measured in seconds.
        /// </summary>
        Second = 1,
        
        /// <summary>
        /// A recurrence value measured in minutes.
        /// </summary>
        Minute = 2,
        
        /// <summary>
        /// A recurrence value measured in hours.
        /// </summary>
        Hour = 3,
        
        /// <summary>
        /// A recurrence value measured in days.
        /// </summary>
        Day = 4,
        
        /// <summary>
        /// A recurrence value measured in weeks.
        /// </summary>
        Week = 5,
        
        /// <summary>
        /// A recurrence value measured in months.
        /// </summary>
        Month = 6,
        
        /// <summary>
        /// A recurrence value measured in years.
        /// </summary>
        Year = 7,
    }
}
