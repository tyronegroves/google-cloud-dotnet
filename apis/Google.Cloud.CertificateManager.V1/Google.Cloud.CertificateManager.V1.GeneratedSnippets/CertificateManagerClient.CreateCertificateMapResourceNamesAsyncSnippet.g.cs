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

namespace Google.Cloud.CertificateManager.V1.Snippets
{
    // [START certificatemanager_v1_generated_CertificateManager_CreateCertificateMap_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.CertificateManager.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCertificateManagerClientSnippets
    {
        /// <summary>Snippet for CreateCertificateMapAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateCertificateMapResourceNamesAsync()
        {
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CertificateMap certificateMap = new CertificateMap();
            string certificateMapId = "";
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = await certificateManagerClient.CreateCertificateMapAsync(parent, certificateMap, certificateMapId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END certificatemanager_v1_generated_CertificateManager_CreateCertificateMap_async_flattened_resourceNames]
}