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

namespace Google.Cloud.Iam.Credentials.V1.Snippets
{
    // [START iamcredentials_v1_generated_IAMCredentials_GenerateIdToken_sync_flattened_resourceNames]
    using Google.Cloud.Iam.Credentials.V1;
    using System.Collections.Generic;

    public sealed partial class GeneratedIAMCredentialsClientSnippets
    {
        /// <summary>Snippet for GenerateIdToken</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GenerateIdTokenResourceNames()
        {
            // Create client
            IAMCredentialsClient iAMCredentialsClient = IAMCredentialsClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<string> delegates = new string[] { "", };
            string audience = "";
            bool includeEmail = false;
            // Make the request
            GenerateIdTokenResponse response = iAMCredentialsClient.GenerateIdToken(name, delegates, audience, includeEmail);
        }
    }
    // [END iamcredentials_v1_generated_IAMCredentials_GenerateIdToken_sync_flattened_resourceNames]
}