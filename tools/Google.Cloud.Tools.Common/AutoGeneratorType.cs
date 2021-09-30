﻿// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Cloud.Tools.Common
{
    /// <summary>
    /// The infrastructure responsible for automatically regenerating a package
    /// when the generator or source protos change.
    /// </summary>
    public enum AutoGeneratorType
    {
        /// <summary>
        /// No automated maintenance.
        /// </summary>
        None = 0,

        /// <summary>
        /// Maintenance via Synthtool/Autosynth. See https://github.com/googleapis/synthtool
        /// </summary>
        Synthtool = 1,

        /// <summary>
        /// Maintenance via OwlBot.
        /// </summary>
        OwlBot = 2
    }
}