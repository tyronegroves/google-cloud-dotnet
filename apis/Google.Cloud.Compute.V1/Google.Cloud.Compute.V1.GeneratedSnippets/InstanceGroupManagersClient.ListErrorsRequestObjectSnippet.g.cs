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

namespace Google.Cloud.Compute.V1.Snippets
{
    // [START compute_v1_generated_InstanceGroupManagers_ListErrors_sync]
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;

    public sealed partial class GeneratedInstanceGroupManagersClientSnippets
    {
        /// <summary>Snippet for ListErrors</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ListErrorsRequestObject()
        {
            // Create client
            InstanceGroupManagersClient instanceGroupManagersClient = InstanceGroupManagersClient.Create();
            // Initialize request argument(s)
            ListErrorsInstanceGroupManagersRequest request = new ListErrorsInstanceGroupManagersRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupManagersListErrorsResponse, InstanceManagedByIgmError> response = instanceGroupManagersClient.ListErrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceManagedByIgmError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupManagersListErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceManagedByIgmError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceManagedByIgmError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceManagedByIgmError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END compute_v1_generated_InstanceGroupManagers_ListErrors_sync]
}