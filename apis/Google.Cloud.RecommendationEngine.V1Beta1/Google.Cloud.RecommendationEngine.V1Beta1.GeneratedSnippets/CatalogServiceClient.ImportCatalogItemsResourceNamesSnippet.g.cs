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

namespace Google.Cloud.RecommendationEngine.V1Beta1.Snippets
{
    // [START recommendationengine_v1beta1_generated_CatalogService_ImportCatalogItems_sync_flattened_resourceNames]
    using Google.Cloud.RecommendationEngine.V1Beta1;
    using Google.LongRunning;

    public sealed partial class GeneratedCatalogServiceClientSnippets
    {
        /// <summary>Snippet for ImportCatalogItems</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ImportCatalogItemsResourceNames()
        {
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportCatalogItemsResponse, ImportMetadata> response = catalogServiceClient.ImportCatalogItems(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportCatalogItemsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportCatalogItemsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCatalogItemsResponse, ImportMetadata> retrievedResponse = catalogServiceClient.PollOnceImportCatalogItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCatalogItemsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END recommendationengine_v1beta1_generated_CatalogService_ImportCatalogItems_sync_flattened_resourceNames]
}