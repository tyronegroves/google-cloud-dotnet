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

namespace Google.Cloud.AppEngine.V1.Snippets
{
    // [START appengine_v1_generated_Versions_UpdateVersion_sync]
    using Google.Cloud.AppEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedVersionsClientSnippets
    {
        /// <summary>Snippet for UpdateVersion</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateVersionRequestObject()
        {
            // Create client
            VersionsClient versionsClient = VersionsClient.Create();
            // Initialize request argument(s)
            UpdateVersionRequest request = new UpdateVersionRequest
            {
                Name = "",
                Version = new Version(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Version, OperationMetadataV1> response = versionsClient.UpdateVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Version, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Version result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Version, OperationMetadataV1> retrievedResponse = versionsClient.PollOnceUpdateVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Version retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END appengine_v1_generated_Versions_UpdateVersion_sync]
}