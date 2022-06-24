// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.BareMetalSolution.V2.Snippets
{
    // [START baremetalsolution_v2_generated_BareMetalSolution_ResizeVolume_async_flattened]
    using Google.Cloud.BareMetalSolution.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBareMetalSolutionClientSnippets
    {
        /// <summary>Snippet for ResizeVolumeAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ResizeVolumeAsync()
        {
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string volume = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            long sizeGib = 0L;
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.ResizeVolumeAsync(volume, sizeGib);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResizeVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END baremetalsolution_v2_generated_BareMetalSolution_ResizeVolume_async_flattened]
}