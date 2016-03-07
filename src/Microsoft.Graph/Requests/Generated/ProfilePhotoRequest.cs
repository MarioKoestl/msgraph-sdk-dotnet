// ------------------------------------------------------------------------------
//  Copyright (c) 2016 Microsoft Corporation
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type ProfilePhotoRequest.
    /// </summary>
    public partial class ProfilePhotoRequest : BaseRequest, IProfilePhotoRequest
    {
        /// <summary>
        /// Constructs a new ProfilePhotoRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ProfilePhotoRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ProfilePhoto using PUT.
        /// </summary>
        /// <param name="profilePhotoToCreate">The ProfilePhoto to create.</param>
        /// <returns>The created ProfilePhoto.</returns>
        public Task<ProfilePhoto> CreateAsync(ProfilePhoto profilePhotoToCreate)
        {
            return this.CreateAsync(profilePhotoToCreate, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ProfilePhoto using PUT.
        /// </summary>
        /// <param name="profilePhotoToCreate">The ProfilePhoto to create.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ProfilePhoto.</returns>
        public async Task<ProfilePhoto> CreateAsync(ProfilePhoto profilePhotoToCreate, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<ProfilePhoto>(profilePhotoToCreate, completionOption, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ProfilePhoto.
        /// </summary>
        /// <returns>The task to await.</returns>
        public Task DeleteAsync()
        {
            return this.DeleteAsync(HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ProfilePhoto.
        /// </summary>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync(HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ProfilePhoto>(null, completionOption, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ProfilePhoto.
        /// </summary>
        /// <returns>The ProfilePhoto.</returns>
        public Task<ProfilePhoto> GetAsync()
        {
            return this.GetAsync(HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ProfilePhoto.
        /// </summary>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ProfilePhoto.</returns>
        public async Task<ProfilePhoto> GetAsync(HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ProfilePhoto>(null, completionOption, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ProfilePhoto using PATCH.
        /// </summary>
        /// <param name="profilePhotoToUpdate">The ProfilePhoto to update.</param>
        /// <returns>The updated ProfilePhoto.</returns>
        public Task<ProfilePhoto> UpdateAsync(ProfilePhoto profilePhotoToUpdate)
        {
            return this.UpdateAsync(profilePhotoToUpdate, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ProfilePhoto using PATCH.
        /// </summary>
        /// <param name="profilePhotoToUpdate">The ProfilePhoto to update.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ProfilePhoto.</returns>
        public async Task<ProfilePhoto> UpdateAsync(ProfilePhoto profilePhotoToUpdate, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ProfilePhoto>(profilePhotoToUpdate, completionOption, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IProfilePhotoRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IProfilePhotoRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="profilePhotoToInitialize">The <see cref="ProfilePhoto"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ProfilePhoto profilePhotoToInitialize)
        {
        
        }
    }
}
