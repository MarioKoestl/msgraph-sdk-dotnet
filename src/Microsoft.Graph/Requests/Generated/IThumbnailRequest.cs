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
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IThumbnailRequest.
    /// </summary>
    public partial interface IThumbnailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Thumbnail using PUT.
        /// </summary>
        /// <param name="thumbnailToCreate">The Thumbnail to create.</param>
        /// <returns>The created Thumbnail.</returns>
        Task<Thumbnail> CreateAsync(Thumbnail thumbnailToCreate);

        /// <summary>
        /// Deletes the specified Thumbnail.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Gets the specified Thumbnail.
        /// </summary>
        /// <returns>The Thumbnail.</returns>
        Task<Thumbnail> GetAsync();

        /// <summary>
        /// Updates the specified Thumbnail using PATCH.
        /// </summary>
        /// <param name="thumbnailToUpdate">The Thumbnail to update.</param>
        /// <returns>The updated Thumbnail.</returns>
        Task<Thumbnail> UpdateAsync(Thumbnail thumbnailToUpdate);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailRequest Select(string value);
    }
}
