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

namespace Google.Cloud.Retail.V2.Snippets
{
    // [START retail_v2_generated_ProductService_CreateProduct_async]
    using Google.Cloud.Retail.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedProductServiceClientSnippets
    {
        /// <summary>Snippet for CreateProductAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateProductRequestObjectAsync()
        {
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "",
            };
            // Make the request
            Product response = await productServiceClient.CreateProductAsync(request);
        }
    }
    // [END retail_v2_generated_ProductService_CreateProduct_async]
}